namespace _3D_Chart_Graph
{
	// Token: 0x02000016 RID: 22
	public partial class Diag : global::System.Windows.Forms.Form
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph.Diag));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new global::System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1337, 670);
			this.panel1.TabIndex = 0;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(1184, 607);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(146, 56);
			this.button1.TabIndex = 1;
			this.button1.Text = "❎Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(1027, 607);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(151, 56);
			this.button2.TabIndex = 2;
			this.button2.Text = "⚡Start";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button3.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Location = new global::System.Drawing.Point(850, 607);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(171, 56);
			this.button3.TabIndex = 3;
			this.button3.Text = "\ud83d\udcc4Read DTC";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button4.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(673, 607);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(171, 56);
			this.button4.TabIndex = 4;
			this.button4.Text = "\ud83d\udd04Reset ECM";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.panel4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel4.BackColor = global::System.Drawing.Color.Gray;
			this.panel4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.listBox1);
			this.panel4.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panel4.Location = new global::System.Drawing.Point(673, 343);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(657, 258);
			this.panel4.TabIndex = 2;
			this.listBox1.BackColor = global::System.Drawing.Color.Gray;
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 21;
			this.listBox1.Location = new global::System.Drawing.Point(-2, -2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(645, 273);
			this.listBox1.TabIndex = 0;
			this.panel3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel3.BackColor = global::System.Drawing.Color.Gray;
			this.panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panel3.Location = new global::System.Drawing.Point(673, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(657, 290);
			this.panel3.TabIndex = 1;
			this.panel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.panel2.BackColor = global::System.Drawing.Color.Gray;
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panel2.Location = new global::System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(664, 660);
			this.panel2.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Franklin Gothic Demi", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(767, 296);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(497, 43);
			this.label1.TabIndex = 5;
			this.label1.Text = "\ud83d\udd0d Diagnosa Kerusakan (DTC)";
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1349, 683);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Diag";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Diag";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Diag_FormClosing);
			base.Load += new global::System.EventHandler(this.Diag_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000B4 RID: 180
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Timer timer1;
	}
}
