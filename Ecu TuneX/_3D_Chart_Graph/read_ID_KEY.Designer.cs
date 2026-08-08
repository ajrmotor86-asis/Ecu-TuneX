namespace _3D_Chart_Graph
{
	// Token: 0x0200001D RID: 29
	public partial class read_ID_KEY : global::System.Windows.Forms.Form
	{
		// Token: 0x06000288 RID: 648 RVA: 0x000445A0 File Offset: 0x000427A0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000445D8 File Offset: 0x000427D8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph.read_ID_KEY));
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.button2 = new global::System.Windows.Forms.Button();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(299, 56);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "READ ID";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.BackColor = global::System.Drawing.Color.Black;
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 35.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(13, 89);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(361, 72);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "\ud83d\udd11 ---------";
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.comboBox1.BackColor = global::System.Drawing.Color.Black;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBox1.ForeColor = global::System.Drawing.Color.White;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(93, 58);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(200, 25);
			this.comboBox1.TabIndex = 2;
			this.progressBar1.Location = new global::System.Drawing.Point(13, 167);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(361, 10);
			this.progressBar1.TabIndex = 3;
			this.button2.Location = new global::System.Drawing.Point(12, 56);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 27);
			this.button2.TabIndex = 4;
			this.button2.Text = "RESET ID";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(98, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(195, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "\ud83d\udd11 ID Smartkey";
			this.textBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.textBox2.BackColor = global::System.Drawing.Color.Black;
			this.textBox2.Font = new global::System.Drawing.Font("Segoe UI", 36f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox2.ForeColor = global::System.Drawing.Color.White;
			this.textBox2.Location = new global::System.Drawing.Point(12, 356);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(361, 72);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "123456789";
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(559, 337);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "read_ID_KEY";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "READ ID KEY";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.read_ID_KEY_FormClosing);
			base.Load += new global::System.EventHandler(this.read_ID_KEY_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001EE RID: 494
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001EF RID: 495
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040001F1 RID: 497
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x040001F2 RID: 498
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040001F4 RID: 500
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040001F5 RID: 501
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001F6 RID: 502
		private global::System.Windows.Forms.TextBox textBox2;
	}
}
