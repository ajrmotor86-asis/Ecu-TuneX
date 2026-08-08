namespace _3D_Chart_Graph
{
	// Token: 0x0200001B RID: 27
	public partial class LogForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000273 RID: 627 RVA: 0x000410E4 File Offset: 0x0003F2E4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0004111C File Offset: 0x0003F31C
		private void InitializeComponent()
		{
			this.lstLog = new global::System.Windows.Forms.ListBox();
			base.SuspendLayout();
			this.lstLog.BackColor = global::System.Drawing.SystemColors.InfoText;
			this.lstLog.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lstLog.ForeColor = global::System.Drawing.Color.Yellow;
			this.lstLog.FormattingEnabled = true;
			this.lstLog.Location = new global::System.Drawing.Point(1, 2);
			this.lstLog.Name = "lstLog";
			this.lstLog.Size = new global::System.Drawing.Size(917, 316);
			this.lstLog.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(917, 317);
			base.Controls.Add(this.lstLog);
			base.Name = "LogForm";
			this.Text = "LogData";
			base.Load += new global::System.EventHandler(this.LogForm_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x040001E3 RID: 483
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001E4 RID: 484
		private global::System.Windows.Forms.ListBox lstLog;
	}
}
