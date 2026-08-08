namespace _3D_Chart_Graph
{
	// Token: 0x0200001F RID: 31
	public partial class SplashScreen : global::System.Windows.Forms.Form
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00048D18 File Offset: 0x00046F18
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00048D50 File Offset: 0x00046F50
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph.SplashScreen));
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(414, 221);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "SplashScreen";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new global::System.EventHandler(this.SplashScreen_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400021A RID: 538
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}
