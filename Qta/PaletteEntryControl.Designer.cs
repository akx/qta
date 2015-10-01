/*
 * Date: 20.12.2009
 * Time: 20:59
 */
namespace Qta
{
	partial class PaletteEntryControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteEntryControl));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.colorButton = new System.Windows.Forms.Button();
			this.positionSlider = new System.Windows.Forms.TrackBar();
			this.deleteButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.positionSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.colorButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.positionSlider, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.deleteButton, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 48);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// colorButton
			// 
			this.colorButton.BackColor = System.Drawing.Color.Black;
			this.colorButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.colorButton.FlatAppearance.BorderSize = 0;
			this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colorButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorButton.ForeColor = System.Drawing.Color.White;
			this.colorButton.Location = new System.Drawing.Point(1, 1);
			this.colorButton.Margin = new System.Windows.Forms.Padding(1);
			this.colorButton.Name = "colorButton";
			this.colorButton.Size = new System.Drawing.Size(78, 46);
			this.colorButton.TabIndex = 5;
			this.colorButton.Text = "Color";
			this.colorButton.UseVisualStyleBackColor = false;
			this.colorButton.Click += new System.EventHandler(this.ColorButtonClick);
			// 
			// positionSlider
			// 
			this.positionSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.positionSlider.LargeChange = 100;
			this.positionSlider.Location = new System.Drawing.Point(81, 1);
			this.positionSlider.Margin = new System.Windows.Forms.Padding(1);
			this.positionSlider.Maximum = 1000;
			this.positionSlider.Name = "positionSlider";
			this.positionSlider.Size = new System.Drawing.Size(415, 45);
			this.positionSlider.SmallChange = 10;
			this.positionSlider.TabIndex = 9;
			this.positionSlider.TickFrequency = 50;
			this.positionSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.positionSlider.ValueChanged += new System.EventHandler(this.PositionSliderValueChanged);
			// 
			// deleteButton
			// 
			this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.deleteButton.FlatAppearance.BorderSize = 0;
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
			this.deleteButton.Location = new System.Drawing.Point(500, 3);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(23, 42);
			this.deleteButton.TabIndex = 10;
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
			// 
			// PaletteEntryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "PaletteEntryControl";
			this.Size = new System.Drawing.Size(526, 48);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.positionSlider)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button colorButton;
		private System.Windows.Forms.TrackBar positionSlider;
	}
}
