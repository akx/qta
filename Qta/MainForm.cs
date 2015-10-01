/*
 * Date: 8.12.2009
 * Time: 19:05
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace Qta
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		AccumulatorBuffer buffer;
		Renderer renderer;
		Palette palette;
		Bitmap bmp;
		ParticleChamber pc;
		BitmapView bv;
		int iters;
		DateTime lastAutoRenderTime;
		DateTime startTime;
		Thread renderThread;
		Object renderLock;
		PaletteEditor pe;
		
		public MainForm()
		{
			InitializeComponent();
			palette = new Palette();
			createEnv(1024, 768);
			bv = new BitmapView();
			bv.Show();
			bv.setBitmap(bmp, true);
			GammaSpinner.Value = (decimal)(renderer.Gamma = .15f);
			ZetaSpinner.Value = (decimal)(renderer.Zeta = 1.0f);
			SigmaSpinner.Value =(decimal)(renderer.Sigma = 0.475f);
			IterIntvlSpinner.Value = (decimal)timer1.Interval;
			timer1.Enabled=true;
			lastAutoRenderTime = DateTime.Now;
			renderLock = new Object();
			renderThread = (new Thread(new ThreadStart(RunRender)));
			renderThread.Start();
			startTime = DateTime.Now;
			
			pe = new PaletteEditor();
			pe.Hide();
			//new ColourLoversBrowser(null).Show();
		}
		
		public void createEnv(int width, int height)
		{
			buffer = new AccumulatorBuffer((uint)width, (uint)height);
			bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
			renderer = new Renderer(buffer, palette);
			pc = new ParticleChamber(buffer);
			widthSpinner.Value = (decimal)width;
			heightSpinner.Value = (decimal)height;
		}
		
		void RunSimStep(int n)
		{
			float f = 1.0f + (float)FrictionSpinner.Value;
			for(int i=0;i<n;i++){
				pc.update(f);
				iters++;
			}
		}
		
		void RunRender()
		{
			while(!Visible) Thread.Sleep(50);
			while(Visible)
			{
				if(!runTSButton.Checked){
					Thread.Sleep(100);
				}
				else
				{
					lock(renderLock) RunSimStep(2);
				}
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if(!runTSButton.Checked) return;
			//RunSimStep(50);
			if(autorenderMenuItem.Checked)
			{
				if((DateTime.Now - lastAutoRenderTime).TotalMilliseconds >= 100)
				{
					renderer.Render(bmp);
					bv.setBitmap(bmp, false);
					lastAutoRenderTime = DateTime.Now;
				}
			}
			int itersPerSec = (int)(iters / (((DateTime.Now - startTime).TotalMilliseconds) / 1000.0f));
			logTextBox.AppendText(string.Format("Iters = {0} ({1}/s), nPar = {2}\n", iters, itersPerSec, pc.GetActiveParticleCount()));
			logTextBox.ScrollToCaret();
		}
		
		void RenderButtonClick(object sender, EventArgs e)
		{
			renderer.Render(bmp);
			logTextBox.AppendText(string.Format("Render G = {0}\n", renderer.lastRenderGValue));
			bv.setBitmap(bmp, false);
		}
		
		void setRenderValues()
		{
			renderer.Sigma = (float)SigmaSpinner.Value;
			renderer.Zeta = (float)ZetaSpinner.Value;
			renderer.Gamma = (float)GammaSpinner.Value;
			timer1.Interval = (int)IterIntvlSpinner.Value;
			
		}

		
		void SpinnerValueChanged(object sender, EventArgs e)
		{
			setRenderValues();
			renderer.Render(bmp);
			bv.setBitmap(bmp, false);
		}
		
		void NewButtonClick(object sender, EventArgs e)
		{
			lock(renderLock)
			{
				startTime = DateTime.Now;
				buffer.clear();
				pc.ResetChamber((int)NPointsSpinner.Value, MultiEmitCheck.Checked, (float)repellerPerc.Value / 100.0f);
				iters = 0;
				RenderButtonClick(sender, e);
			}
		}
		
		void SetResButtonClick(object sender, EventArgs e)
		{
			createEnv((int)widthSpinner.Value, (int)heightSpinner.Value);
		}
		
		void SaveBmpButtonClick(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.DefaultExt=".png";
			sfd.Filter="Portable Network Graphics (PNG)|*.png";
			sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			sfd.AddExtension = true;
			sfd.AutoUpgradeEnabled = true;
			sfd.FileName = "qta-"+String.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				bmp.Save(sfd.FileName, ImageFormat.Png);
			}
		}
		
		void OnlyClearBufferToolStripMenuItemClick(object sender, EventArgs e)
		{
			buffer.clear();
			iters = 0;
			RenderButtonClick(sender, e);
		}

		
		void PaletteToolStripMenuItemClick(object sender, EventArgs e)
		{
			pe.Pal = renderer.Palette;
			pe.Show();
		}
	}
}
