/*
 * Date: 14.12.2009
 * Time: 19:44
 */
namespace Qta
{
	partial class PaletteEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteEditor));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.addColorButton = new System.Windows.Forms.ToolStripButton();
			this.updateButton = new System.Windows.Forms.ToolStripButton();
			this.equalDistancesButton = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.previewBox = new System.Windows.Forms.PictureBox();
			this.openButton = new System.Windows.Forms.ToolStripButton();
			this.saveButton = new System.Windows.Forms.ToolStripButton();
			this.ColourLoversButton = new System.Windows.Forms.ToolStripButton();
			this.reverseButton = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.openButton,
									this.saveButton,
									this.ColourLoversButton,
									this.toolStripSeparator1,
									this.addColorButton,
									this.updateButton,
									this.equalDistancesButton,
									this.reverseButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(544, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// addColorButton
			// 
			this.addColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addColorButton.Image = ((System.Drawing.Image)(resources.GetObject("addColorButton.Image")));
			this.addColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addColorButton.Name = "addColorButton";
			this.addColorButton.Size = new System.Drawing.Size(23, 22);
			this.addColorButton.Text = "Add";
			this.addColorButton.Click += new System.EventHandler(this.AddColorButtonClick);
			// 
			// updateButton
			// 
			this.updateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
			this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(23, 22);
			this.updateButton.Text = "Update";
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// equalDistancesButton
			// 
			this.equalDistancesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.equalDistancesButton.Image = ((System.Drawing.Image)(resources.GetObject("equalDistancesButton.Image")));
			this.equalDistancesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.equalDistancesButton.Name = "equalDistancesButton";
			this.equalDistancesButton.Size = new System.Drawing.Size(23, 22);
			this.equalDistancesButton.Text = "Equalize Distances";
			this.equalDistancesButton.Click += new System.EventHandler(this.EqualDistancesButtonClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.previewBox, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 459);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 48);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(538, 408);
			this.flowLayoutPanel1.TabIndex = 5;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// previewBox
			// 
			this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.previewBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewBox.Location = new System.Drawing.Point(3, 3);
			this.previewBox.Name = "previewBox";
			this.previewBox.Size = new System.Drawing.Size(538, 39);
			this.previewBox.TabIndex = 1;
			this.previewBox.TabStop = false;
			// 
			// openButton
			// 
			this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openButton.Enabled = false;
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(23, 22);
			this.openButton.Text = "Open...";
			// 
			// saveButton
			// 
			this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveButton.Enabled = false;
			this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
			this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(23, 22);
			this.saveButton.Text = "Save...";
			// 
			// ColourLoversButton
			// 
			this.ColourLoversButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ColourLoversButton.Image = ((System.Drawing.Image)(resources.GetObject("ColourLoversButton.Image")));
			this.ColourLoversButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ColourLoversButton.Name = "ColourLoversButton";
			this.ColourLoversButton.Size = new System.Drawing.Size(23, 22);
			this.ColourLoversButton.Text = "COLOURlovers...";
			this.ColourLoversButton.Click += new System.EventHandler(this.ColourLoversToolStripMenuItemClick);
			// 
			// reverseButton
			// 
			this.reverseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.reverseButton.Image = ((System.Drawing.Image)(resources.GetObject("reverseButton.Image")));
			this.reverseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reverseButton.Name = "reverseButton";
			this.reverseButton.Size = new System.Drawing.Size(23, 22);
			this.reverseButton.Text = "Reverse";
			this.reverseButton.Click += new System.EventHandler(this.ReverseButtonClick);
			// 
			// PaletteEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 484);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.toolStrip1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(560, 1500);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(560, 36);
			this.Name = "PaletteEditor";
			this.Text = "Palette Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaletteEditorFormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton reverseButton;
		private System.Windows.Forms.ToolStripButton ColourLoversButton;
		private System.Windows.Forms.ToolStripButton saveButton;
		private System.Windows.Forms.ToolStripButton openButton;
		private System.Windows.Forms.ToolStripButton equalDistancesButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolStripButton updateButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.PictureBox previewBox;
		private System.Windows.Forms.ToolStripButton addColorButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
