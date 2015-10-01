/*
 * Created by SharpDevelop.
 * User: X
 * Date: 8.12.2009
 * Time: 19:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Qta
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label7;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label8;
			System.Windows.Forms.Label label9;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.logTextBox = new System.Windows.Forms.RichTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.IterIntvlSpinner = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.GammaSpinner = new System.Windows.Forms.NumericUpDown();
			this.SigmaSpinner = new System.Windows.Forms.NumericUpDown();
			this.ZetaSpinner = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.repellerPerc = new System.Windows.Forms.NumericUpDown();
			this.FrictionSpinner = new System.Windows.Forms.NumericUpDown();
			this.NPointsSpinner = new System.Windows.Forms.NumericUpDown();
			this.MultiEmitCheck = new System.Windows.Forms.CheckBox();
			this.SetResButton = new System.Windows.Forms.Button();
			this.heightSpinner = new System.Windows.Forms.NumericUpDown();
			this.widthSpinner = new System.Windows.Forms.NumericUpDown();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.runTSButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.onlyClearBufferToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.renderTSButton = new System.Windows.Forms.ToolStripSplitButton();
			this.saveRenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autorenderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.paletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			label4 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.IterIntvlSpinner)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GammaSpinner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SigmaSpinner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ZetaSpinner)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.repellerPerc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FrictionSpinner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NPointsSpinner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heightSpinner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthSpinner)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			label4.Location = new System.Drawing.Point(18, 487);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(85, 20);
			label4.TabIndex = 6;
			label4.Text = "Iter Interval (ms)";
			label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			label1.Location = new System.Drawing.Point(6, 22);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(103, 20);
			label1.TabIndex = 8;
			label1.Text = "Gamma";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			label2.Location = new System.Drawing.Point(5, 48);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(103, 20);
			label2.TabIndex = 7;
			label2.Text = "Sigma";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			label3.Location = new System.Drawing.Point(5, 74);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(103, 20);
			label3.TabIndex = 6;
			label3.Text = "Zeta";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			label7.Location = new System.Drawing.Point(6, 26);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(103, 20);
			label7.TabIndex = 23;
			label7.Text = "Number of Points";
			label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			label6.Location = new System.Drawing.Point(206, 123);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(10, 20);
			label6.TabIndex = 17;
			label6.Text = "x";
			label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			label5.Location = new System.Drawing.Point(6, 127);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(103, 20);
			label5.TabIndex = 18;
			label5.Text = "Resolution";
			label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			label8.Location = new System.Drawing.Point(6, 101);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(103, 20);
			label8.TabIndex = 25;
			label8.Text = "Friction";
			label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			label9.Location = new System.Drawing.Point(6, 75);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(103, 20);
			label9.TabIndex = 25;
			label9.Text = "Repeller%";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// logTextBox
			// 
			this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logTextBox.Location = new System.Drawing.Point(0, 28);
			this.logTextBox.Name = "logTextBox";
			this.logTextBox.ReadOnly = true;
			this.logTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.logTextBox.Size = new System.Drawing.Size(323, 153);
			this.logTextBox.TabIndex = 0;
			this.logTextBox.Text = "";
			// 
			// timer1
			// 
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// IterIntvlSpinner
			// 
			this.IterIntvlSpinner.Increment = new decimal(new int[] {
									10,
									0,
									0,
									0});
			this.IterIntvlSpinner.Location = new System.Drawing.Point(127, 487);
			this.IterIntvlSpinner.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.IterIntvlSpinner.Minimum = new decimal(new int[] {
									10,
									0,
									0,
									0});
			this.IterIntvlSpinner.Name = "IterIntvlSpinner";
			this.IterIntvlSpinner.Size = new System.Drawing.Size(133, 20);
			this.IterIntvlSpinner.TabIndex = 7;
			this.IterIntvlSpinner.Value = new decimal(new int[] {
									200,
									0,
									0,
									0});
			this.IterIntvlSpinner.ValueChanged += new System.EventHandler(this.SpinnerValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.GammaSpinner);
			this.groupBox1.Controls.Add(label1);
			this.groupBox1.Controls.Add(label2);
			this.groupBox1.Controls.Add(this.SigmaSpinner);
			this.groupBox1.Controls.Add(label3);
			this.groupBox1.Controls.Add(this.ZetaSpinner);
			this.groupBox1.Location = new System.Drawing.Point(12, 187);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(299, 101);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rendering Parameters";
			// 
			// GammaSpinner
			// 
			this.GammaSpinner.DecimalPlaces = 3;
			this.GammaSpinner.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.GammaSpinner.Location = new System.Drawing.Point(147, 22);
			this.GammaSpinner.Maximum = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.GammaSpinner.Name = "GammaSpinner";
			this.GammaSpinner.Size = new System.Drawing.Size(133, 20);
			this.GammaSpinner.TabIndex = 5;
			this.GammaSpinner.Value = new decimal(new int[] {
									15,
									0,
									0,
									131072});
			this.GammaSpinner.ValueChanged += new System.EventHandler(this.SpinnerValueChanged);
			// 
			// SigmaSpinner
			// 
			this.SigmaSpinner.DecimalPlaces = 3;
			this.SigmaSpinner.Increment = new decimal(new int[] {
									5,
									0,
									0,
									131072});
			this.SigmaSpinner.Location = new System.Drawing.Point(147, 48);
			this.SigmaSpinner.Maximum = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.SigmaSpinner.Name = "SigmaSpinner";
			this.SigmaSpinner.Size = new System.Drawing.Size(133, 20);
			this.SigmaSpinner.TabIndex = 10;
			this.SigmaSpinner.Value = new decimal(new int[] {
									475,
									0,
									0,
									196608});
			this.SigmaSpinner.ValueChanged += new System.EventHandler(this.SpinnerValueChanged);
			// 
			// ZetaSpinner
			// 
			this.ZetaSpinner.DecimalPlaces = 3;
			this.ZetaSpinner.Increment = new decimal(new int[] {
									5,
									0,
									0,
									131072});
			this.ZetaSpinner.Location = new System.Drawing.Point(147, 74);
			this.ZetaSpinner.Maximum = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.ZetaSpinner.Name = "ZetaSpinner";
			this.ZetaSpinner.Size = new System.Drawing.Size(133, 20);
			this.ZetaSpinner.TabIndex = 9;
			this.ZetaSpinner.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.ZetaSpinner.ValueChanged += new System.EventHandler(this.SpinnerValueChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.repellerPerc);
			this.groupBox2.Controls.Add(label9);
			this.groupBox2.Controls.Add(this.FrictionSpinner);
			this.groupBox2.Controls.Add(label8);
			this.groupBox2.Controls.Add(this.NPointsSpinner);
			this.groupBox2.Controls.Add(label7);
			this.groupBox2.Controls.Add(this.MultiEmitCheck);
			this.groupBox2.Controls.Add(this.SetResButton);
			this.groupBox2.Controls.Add(this.heightSpinner);
			this.groupBox2.Controls.Add(this.widthSpinner);
			this.groupBox2.Controls.Add(label6);
			this.groupBox2.Controls.Add(label5);
			this.groupBox2.Location = new System.Drawing.Point(12, 295);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(299, 186);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Environment";
			// 
			// repellerPerc
			// 
			this.repellerPerc.Location = new System.Drawing.Point(147, 75);
			this.repellerPerc.Name = "repellerPerc";
			this.repellerPerc.Size = new System.Drawing.Size(133, 20);
			this.repellerPerc.TabIndex = 26;
			// 
			// FrictionSpinner
			// 
			this.FrictionSpinner.DecimalPlaces = 4;
			this.FrictionSpinner.Increment = new decimal(new int[] {
									1,
									0,
									0,
									262144});
			this.FrictionSpinner.Location = new System.Drawing.Point(147, 101);
			this.FrictionSpinner.Maximum = new decimal(new int[] {
									5,
									0,
									0,
									65536});
			this.FrictionSpinner.Name = "FrictionSpinner";
			this.FrictionSpinner.Size = new System.Drawing.Size(133, 20);
			this.FrictionSpinner.TabIndex = 26;
			this.FrictionSpinner.Value = new decimal(new int[] {
									4,
									0,
									0,
									196608});
			// 
			// NPointsSpinner
			// 
			this.NPointsSpinner.Location = new System.Drawing.Point(147, 26);
			this.NPointsSpinner.Maximum = new decimal(new int[] {
									30,
									0,
									0,
									0});
			this.NPointsSpinner.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.NPointsSpinner.Name = "NPointsSpinner";
			this.NPointsSpinner.Size = new System.Drawing.Size(133, 20);
			this.NPointsSpinner.TabIndex = 24;
			this.NPointsSpinner.Value = new decimal(new int[] {
									5,
									0,
									0,
									0});
			// 
			// MultiEmitCheck
			// 
			this.MultiEmitCheck.Location = new System.Drawing.Point(147, 48);
			this.MultiEmitCheck.Name = "MultiEmitCheck";
			this.MultiEmitCheck.Size = new System.Drawing.Size(104, 24);
			this.MultiEmitCheck.TabIndex = 22;
			this.MultiEmitCheck.Text = "Multiple Emitters";
			this.MultiEmitCheck.UseVisualStyleBackColor = true;
			// 
			// SetResButton
			// 
			this.SetResButton.Location = new System.Drawing.Point(147, 154);
			this.SetResButton.Name = "SetResButton";
			this.SetResButton.Size = new System.Drawing.Size(134, 21);
			this.SetResButton.TabIndex = 21;
			this.SetResButton.Text = "Apply Resolution";
			this.SetResButton.UseVisualStyleBackColor = true;
			this.SetResButton.Click += new System.EventHandler(this.SetResButtonClick);
			// 
			// heightSpinner
			// 
			this.heightSpinner.Location = new System.Drawing.Point(222, 127);
			this.heightSpinner.Maximum = new decimal(new int[] {
									1920,
									0,
									0,
									0});
			this.heightSpinner.Minimum = new decimal(new int[] {
									240,
									0,
									0,
									0});
			this.heightSpinner.Name = "heightSpinner";
			this.heightSpinner.Size = new System.Drawing.Size(58, 20);
			this.heightSpinner.TabIndex = 19;
			this.heightSpinner.Value = new decimal(new int[] {
									768,
									0,
									0,
									0});
			// 
			// widthSpinner
			// 
			this.widthSpinner.Location = new System.Drawing.Point(147, 127);
			this.widthSpinner.Maximum = new decimal(new int[] {
									2560,
									0,
									0,
									0});
			this.widthSpinner.Minimum = new decimal(new int[] {
									320,
									0,
									0,
									0});
			this.widthSpinner.Name = "widthSpinner";
			this.widthSpinner.Size = new System.Drawing.Size(53, 20);
			this.widthSpinner.TabIndex = 20;
			this.widthSpinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.widthSpinner.Value = new decimal(new int[] {
									1024,
									0,
									0,
									0});
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(0, 6);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(250, 250);
			this.webBrowser1.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.runTSButton,
									this.toolStripSeparator1,
									this.toolStripButton1,
									this.renderTSButton,
									this.toolStripDropDownButton1,
									this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(323, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 19;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// runTSButton
			// 
			this.runTSButton.CheckOnClick = true;
			this.runTSButton.Image = ((System.Drawing.Image)(resources.GetObject("runTSButton.Image")));
			this.runTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.runTSButton.Name = "runTSButton";
			this.runTSButton.Size = new System.Drawing.Size(48, 22);
			this.runTSButton.Text = "Run";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.onlyClearBufferToolStripMenuItem1});
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
			this.toolStripButton1.Text = "New";
			this.toolStripButton1.ButtonClick += new System.EventHandler(this.NewButtonClick);
			// 
			// onlyClearBufferToolStripMenuItem1
			// 
			this.onlyClearBufferToolStripMenuItem1.Name = "onlyClearBufferToolStripMenuItem1";
			this.onlyClearBufferToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
			this.onlyClearBufferToolStripMenuItem1.Text = "Only Clear Buffer";
			this.onlyClearBufferToolStripMenuItem1.Click += new System.EventHandler(this.OnlyClearBufferToolStripMenuItemClick);
			// 
			// renderTSButton
			// 
			this.renderTSButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saveRenderToolStripMenuItem,
									this.autorenderMenuItem});
			this.renderTSButton.Image = ((System.Drawing.Image)(resources.GetObject("renderTSButton.Image")));
			this.renderTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.renderTSButton.Name = "renderTSButton";
			this.renderTSButton.Size = new System.Drawing.Size(76, 22);
			this.renderTSButton.Text = "Render";
			this.renderTSButton.ButtonClick += new System.EventHandler(this.RenderButtonClick);
			// 
			// saveRenderToolStripMenuItem
			// 
			this.saveRenderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveRenderToolStripMenuItem.Image")));
			this.saveRenderToolStripMenuItem.Name = "saveRenderToolStripMenuItem";
			this.saveRenderToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.saveRenderToolStripMenuItem.Text = "Save Render";
			this.saveRenderToolStripMenuItem.Click += new System.EventHandler(this.SaveBmpButtonClick);
			// 
			// autorenderMenuItem
			// 
			this.autorenderMenuItem.Checked = true;
			this.autorenderMenuItem.CheckOnClick = true;
			this.autorenderMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autorenderMenuItem.Name = "autorenderMenuItem";
			this.autorenderMenuItem.Size = new System.Drawing.Size(138, 22);
			this.autorenderMenuItem.Text = "Autorender";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.paletteToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.ShowDropDownArrow = false;
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 22);
			this.toolStripDropDownButton1.Text = "Edit...";
			// 
			// paletteToolStripMenuItem
			// 
			this.paletteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paletteToolStripMenuItem.Image")));
			this.paletteToolStripMenuItem.Name = "paletteToolStripMenuItem";
			this.paletteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.paletteToolStripMenuItem.Text = "Palette";
			this.paletteToolStripMenuItem.Click += new System.EventHandler(this.PaletteToolStripMenuItemClick);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton2.Enabled = false;
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.ShowDropDownArrow = false;
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(20, 22);
			this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 541);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.IterIntvlSpinner);
			this.Controls.Add(label4);
			this.Controls.Add(this.logTextBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Qta";
			((System.ComponentModel.ISupportInitialize)(this.IterIntvlSpinner)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GammaSpinner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SigmaSpinner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ZetaSpinner)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.repellerPerc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FrictionSpinner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NPointsSpinner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heightSpinner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widthSpinner)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem paletteToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.NumericUpDown repellerPerc;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton runTSButton;
		private System.Windows.Forms.ToolStripMenuItem autorenderMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveRenderToolStripMenuItem;
		private System.Windows.Forms.ToolStripSplitButton renderTSButton;
		private System.Windows.Forms.ToolStripMenuItem onlyClearBufferToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.NumericUpDown FrictionSpinner;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown NPointsSpinner;
		private System.Windows.Forms.CheckBox MultiEmitCheck;
		private System.Windows.Forms.NumericUpDown heightSpinner;
		private System.Windows.Forms.NumericUpDown widthSpinner;
		private System.Windows.Forms.Button SetResButton;
		private System.Windows.Forms.NumericUpDown IterIntvlSpinner;
		private System.Windows.Forms.NumericUpDown ZetaSpinner;
		private System.Windows.Forms.NumericUpDown SigmaSpinner;
		private System.Windows.Forms.NumericUpDown GammaSpinner;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.RichTextBox logTextBox;
	}
}
