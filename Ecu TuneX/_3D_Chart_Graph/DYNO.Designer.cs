namespace _3D_Chart_Graph
{
	// Token: 0x02000017 RID: 23
	public partial class DYNO : global::System.Windows.Forms.Form
	{
		// Token: 0x06000179 RID: 377 RVA: 0x0000F314 File Offset: 0x0000D514
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000F34C File Offset: 0x0000D54C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph.DYNO));
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.Black;
			this.button1.Location = new global::System.Drawing.Point(1028, 3);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 38);
			this.button1.TabIndex = 0;
			this.button1.Text = "Run";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 128);
			this.label1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(687, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(236, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "Max HP";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label2.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 128);
			this.label2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Location = new global::System.Drawing.Point(176, 6);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(239, 38);
			this.label2.TabIndex = 2;
			this.label2.Text = "Max Rpm";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 128);
			this.label3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Black;
			this.label3.Location = new global::System.Drawing.Point(8, 6);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(162, 38);
			this.label3.TabIndex = 3;
			this.label3.Text = "Afr NR";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label4.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 128);
			this.label4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.Black;
			this.label4.Location = new global::System.Drawing.Point(421, 5);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(260, 38);
			this.label4.TabIndex = 4;
			this.label4.Text = "Max Torque";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Location = new global::System.Drawing.Point(2, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1117, 542);
			this.panel1.TabIndex = 5;
			this.panel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel2.BackColor = global::System.Drawing.Color.Black;
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new global::System.Drawing.Point(2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(1117, 48);
			this.panel2.TabIndex = 6;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.Black;
			this.button2.Location = new global::System.Drawing.Point(929, 3);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 38);
			this.button2.TabIndex = 5;
			this.button2.Text = "Refresh";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1121, 601);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "DYNO";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Run Graph";
			base.Load += new global::System.EventHandler(this.DYNO_Load);
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000D0 RID: 208
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Button button2;
	}
}
