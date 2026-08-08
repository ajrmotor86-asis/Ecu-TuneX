namespace _3D_Chart_Graph
{
	// Token: 0x02000012 RID: 18
	public partial class _2d : global::System.Windows.Forms.Form
	{
		// Token: 0x0600010A RID: 266 RVA: 0x0000990C File Offset: 0x00007B0C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00009944 File Offset: 0x00007B44
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph._2d));
			this.panel1 = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Location = new global::System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(794, 248);
			this.panel1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(800, 253);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "_2d";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "2D";
			base.Load += new global::System.EventHandler(this._2d_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400007C RID: 124
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Panel panel1;
	}
}
