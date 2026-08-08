namespace _3D_Chart_Graph
{
	// Token: 0x02000015 RID: 21
	public partial class Chart : global::System.Windows.Forms.Form
	{
		// Token: 0x06000128 RID: 296 RVA: 0x0000A500 File Offset: 0x00008700
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000A538 File Offset: 0x00008738
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph.Chart));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(861, 218);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.label4.Location = new global::System.Drawing.Point(793, 62);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(58, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "AFR";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Red;
			this.label3.Location = new global::System.Drawing.Point(793, 43);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(58, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "IG";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.label2.Location = new global::System.Drawing.Point(793, 24);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(58, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "TPS";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Blue;
			this.label1.Location = new global::System.Drawing.Point(793, 5);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(58, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "RPM";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(868, 232);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Chart";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chart";
			base.Load += new global::System.EventHandler(this.Chart_Load);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400008E RID: 142
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label2;
	}
}
