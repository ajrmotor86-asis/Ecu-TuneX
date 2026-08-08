namespace Plot3D
{
	// Token: 0x02000007 RID: 7
	public partial class Graph3DMainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00004C60 File Offset: 0x00002E60
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004C98 File Offset: 0x00002E98
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Plot3D.Graph3DMainForm));
			this.trackRho = new global::System.Windows.Forms.TrackBar();
			this.trackTheta = new global::System.Windows.Forms.TrackBar();
			this.trackPhi = new global::System.Windows.Forms.TrackBar();
			this.lblInfo = new global::System.Windows.Forms.Label();
			this.comboColors = new global::System.Windows.Forms.ComboBox();
			this.comboDataSrc = new global::System.Windows.Forms.ComboBox();
			this.comboRaster = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.btnScreenshot = new global::System.Windows.Forms.Button();
			this.btnReset = new global::System.Windows.Forms.Button();
			this.graph3D = new global::Plot3D.Graph3D();
			((global::System.ComponentModel.ISupportInitialize)this.trackRho).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackTheta).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPhi).BeginInit();
			base.SuspendLayout();
			this.trackRho.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.trackRho.Location = new global::System.Drawing.Point(9, 211);
			this.trackRho.Name = "trackRho";
			this.trackRho.Orientation = global::System.Windows.Forms.Orientation.Vertical;
			this.trackRho.Size = new global::System.Drawing.Size(45, 203);
			this.trackRho.TabIndex = 10;
			this.trackRho.TickFrequency = 20;
			this.trackRho.TickStyle = global::System.Windows.Forms.TickStyle.None;
			this.trackTheta.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.trackTheta.Location = new global::System.Drawing.Point(53, 211);
			this.trackTheta.Name = "trackTheta";
			this.trackTheta.Orientation = global::System.Windows.Forms.Orientation.Vertical;
			this.trackTheta.Size = new global::System.Drawing.Size(45, 203);
			this.trackTheta.TabIndex = 11;
			this.trackTheta.TickFrequency = 20;
			this.trackTheta.TickStyle = global::System.Windows.Forms.TickStyle.None;
			this.trackPhi.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.trackPhi.Location = new global::System.Drawing.Point(98, 211);
			this.trackPhi.Name = "trackPhi";
			this.trackPhi.Orientation = global::System.Windows.Forms.Orientation.Vertical;
			this.trackPhi.Size = new global::System.Drawing.Size(45, 203);
			this.trackPhi.TabIndex = 12;
			this.trackPhi.TickFrequency = 20;
			this.trackPhi.TickStyle = global::System.Windows.Forms.TickStyle.None;
			this.lblInfo.AutoSize = true;
			this.lblInfo.Location = new global::System.Drawing.Point(101, 147);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new global::System.Drawing.Size(25, 13);
			this.lblInfo.TabIndex = 9;
			this.lblInfo.Text = "Info";
			this.comboColors.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboColors.FormattingEnabled = true;
			this.comboColors.Location = new global::System.Drawing.Point(102, 80);
			this.comboColors.MaxDropDownItems = 30;
			this.comboColors.Name = "comboColors";
			this.comboColors.Size = new global::System.Drawing.Size(121, 21);
			this.comboColors.TabIndex = 2;
			this.comboColors.SelectedIndexChanged += new global::System.EventHandler(this.comboColors_SelectedIndexChanged);
			this.comboDataSrc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDataSrc.FormattingEnabled = true;
			this.comboDataSrc.Items.AddRange(new object[]
			{
				"Graph"
			});
			this.comboDataSrc.Location = new global::System.Drawing.Point(102, 40);
			this.comboDataSrc.MaxDropDownItems = 30;
			this.comboDataSrc.Name = "comboDataSrc";
			this.comboDataSrc.Size = new global::System.Drawing.Size(121, 21);
			this.comboDataSrc.TabIndex = 1;
			this.comboDataSrc.SelectedIndexChanged += new global::System.EventHandler(this.comboDataSrc_SelectedIndexChanged);
			this.comboRaster.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboRaster.FormattingEnabled = true;
			this.comboRaster.Location = new global::System.Drawing.Point(102, 119);
			this.comboRaster.MaxDropDownItems = 30;
			this.comboRaster.Name = "comboRaster";
			this.comboRaster.Size = new global::System.Drawing.Size(121, 21);
			this.comboRaster.TabIndex = 3;
			this.comboRaster.SelectedIndexChanged += new global::System.EventHandler(this.comboRaster_SelectedIndexChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(100, 25);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(70, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Data Source:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(100, 64);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(76, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Color Scheme:";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(100, 104);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(98, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Coordinate System:";
			this.btnScreenshot.Location = new global::System.Drawing.Point(102, 194);
			this.btnScreenshot.Name = "btnScreenshot";
			this.btnScreenshot.Size = new global::System.Drawing.Size(121, 23);
			this.btnScreenshot.TabIndex = 5;
			this.btnScreenshot.Text = "Save Screenshot";
			this.btnScreenshot.UseVisualStyleBackColor = true;
			this.btnScreenshot.Click += new global::System.EventHandler(this.btnScreenshot_Click);
			this.btnReset.Location = new global::System.Drawing.Point(102, 165);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new global::System.Drawing.Size(121, 23);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Reset Position";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new global::System.EventHandler(this.btnReset_Click);
			this.graph3D.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.graph3D.AxisX_Color = global::System.Drawing.Color.DarkBlue;
			this.graph3D.AxisX_Legend = null;
			this.graph3D.AxisY_Color = global::System.Drawing.Color.DarkGreen;
			this.graph3D.AxisY_Legend = null;
			this.graph3D.AxisZ_Color = global::System.Drawing.Color.DarkRed;
			this.graph3D.AxisZ_Legend = null;
			this.graph3D.BackColor = global::System.Drawing.Color.Black;
			this.graph3D.BorderColor = global::System.Drawing.Color.FromArgb(180, 180, 180);
			this.graph3D.Location = new global::System.Drawing.Point(7, 6);
			this.graph3D.Name = "graph3D";
			this.graph3D.PolygonLineColor = global::System.Drawing.Color.Black;
			this.graph3D.Raster = global::Plot3D.Graph3D.eRaster.Off;
			this.graph3D.Size = new global::System.Drawing.Size(539, 425);
			this.graph3D.TabIndex = 21;
			this.graph3D.TopLegendColor = global::System.Drawing.Color.Gray;
			this.graph3D.Load += new global::System.EventHandler(this.graph3D_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(553, 437);
			base.Controls.Add(this.graph3D);
			base.Controls.Add(this.btnReset);
			base.Controls.Add(this.btnScreenshot);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.comboRaster);
			base.Controls.Add(this.comboDataSrc);
			base.Controls.Add(this.comboColors);
			base.Controls.Add(this.lblInfo);
			base.Controls.Add(this.trackPhi);
			base.Controls.Add(this.trackTheta);
			base.Controls.Add(this.trackRho);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(400, 400);
			base.Name = "Graph3DMainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Graph3D ";
			base.Load += new global::System.EventHandler(this.Graph3DMainForm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.trackRho).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackTheta).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPhi).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001C RID: 28
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.TrackBar trackRho;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.TrackBar trackTheta;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.TrackBar trackPhi;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label lblInfo;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ComboBox comboColors;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ComboBox comboDataSrc;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ComboBox comboRaster;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button btnScreenshot;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button btnReset;

		// Token: 0x04000029 RID: 41
		private global::Plot3D.Graph3D graph3D;
	}
}
