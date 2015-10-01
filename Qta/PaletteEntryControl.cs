/*
 * Date: 20.12.2009
 * Time: 20:59
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Qta
{
	/// <summary>
	/// Description of PaletteEntryControl.
	/// </summary>
	public partial class PaletteEntryControl : UserControl
	{
		private PaletteKeyPoint pkp;
		private PaletteEditor pe;
		
		public PaletteKeyPoint Pkp {
			set { pkp = value; UpdateValuesFromPKP(); }
		}
		
		
		public PaletteEntryControl(PaletteEditor pe, PaletteKeyPoint pkp)
		{
			InitializeComponent();
			this.pe = pe;
			if(pkp != null) this.Pkp = pkp;
			
		}
		
		private void UpdateValuesFromPKP()
		{
			positionSlider.Value = (int)(pkp.Position * 1000);
			colorButton.BackColor = pkp.Color;
			double brightness = 
				(colorButton.BackColor.R * 0.299) + 
				(colorButton.BackColor.G * 0.587) +
				(colorButton.BackColor.B * 0.114);
			
			colorButton.ForeColor = (brightness >= 127 ? Color.Black: Color.White);//Color.FromArgb((int)((uint)colorButton.BackColor.ToArgb() ^ (uint)0xFFFFFF));
			colorButton.Text = ColorTranslator.ToHtml(colorButton.BackColor);
		}
		
		void ColorButtonClick(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			cd.Color = colorButton.BackColor;
			if(cd.ShowDialog() == DialogResult.OK)
			{
				pkp.Color = cd.Color;
				pe.UpdateGradient();
				UpdateValuesFromPKP();
			}
		}
		
		void PositionSliderValueChanged(object sender, EventArgs e)
		{
			pkp.Position = positionSlider.Value / 1000.0f;
			pe.UpdateGradient();
			UpdateValuesFromPKP();
		}
		
		void DeleteButtonClick(object sender, EventArgs e)
		{
			pe.DeleteEntry(pkp);
		}
	}
}
