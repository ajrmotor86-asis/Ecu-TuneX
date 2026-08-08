namespace _3D_Chart_Graph
{
	// Token: 0x0200001E RID: 30
	public partial class SMK : global::System.Windows.Forms.Form
	{
		// Token: 0x060002A3 RID: 675 RVA: 0x00047AF8 File Offset: 0x00045CF8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00047B30 File Offset: 0x00045D30
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph.SMK));
			this.label1 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.PERSEN = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.pictureBoxBarcode = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxBarcode).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Cyan;
			this.label1.Location = new global::System.Drawing.Point(178, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(195, 32);
			this.label1.TabIndex = 11;
			this.label1.Text = "\ud83d\udd11 ID Smartkey";
			this.button2.BackColor = global::System.Drawing.Color.Black;
			this.button2.ForeColor = global::System.Drawing.Color.Cyan;
			this.button2.Location = new global::System.Drawing.Point(12, 89);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(131, 27);
			this.button2.TabIndex = 10;
			this.button2.Text = "RESET ID KEIHIN";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.progressBar1.Location = new global::System.Drawing.Point(12, 205);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(522, 10);
			this.progressBar1.TabIndex = 9;
			this.comboBox1.BackColor = global::System.Drawing.Color.Black;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBox1.ForeColor = global::System.Drawing.Color.Cyan;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(12, 221);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(522, 25);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.textBox1.BackColor = global::System.Drawing.Color.Black;
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 35.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(240, 418);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(361, 10);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "\ud83d\udd11 ---------";
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.button1.BackColor = global::System.Drawing.Color.Black;
			this.button1.ForeColor = global::System.Drawing.Color.Cyan;
			this.button1.Location = new global::System.Drawing.Point(459, 87);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 27);
			this.button1.TabIndex = 6;
			this.button1.Text = "READ ID";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox2.BackColor = global::System.Drawing.Color.Black;
			this.textBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 48f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox2.ForeColor = global::System.Drawing.Color.Cyan;
			this.textBox2.Location = new global::System.Drawing.Point(12, 122);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(522, 77);
			this.textBox2.TabIndex = 28;
			this.textBox2.Text = "\ud83d\udd11 ---------";
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox3.Location = new global::System.Drawing.Point(143, 418);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 29;
			this.textBox4.Location = new global::System.Drawing.Point(134, 392);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new global::System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 30;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(566, 378);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "label2";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(455, 392);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(35, 13);
			this.label3.TabIndex = 32;
			this.label3.Text = "label3";
			this.PERSEN.AutoSize = true;
			this.PERSEN.Location = new global::System.Drawing.Point(414, 399);
			this.PERSEN.Name = "PERSEN";
			this.PERSEN.Size = new global::System.Drawing.Size(35, 13);
			this.PERSEN.TabIndex = 33;
			this.PERSEN.Text = "label4";
			this.lblStatus.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblStatus.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.ForeColor = global::System.Drawing.Color.Cyan;
			this.lblStatus.Location = new global::System.Drawing.Point(15, 44);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(519, 36);
			this.lblStatus.TabIndex = 34;
			this.lblStatus.Text = "-";
			this.lblStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.button3.BackColor = global::System.Drawing.Color.Black;
			this.button3.ForeColor = global::System.Drawing.Color.Cyan;
			this.button3.Location = new global::System.Drawing.Point(149, 89);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(176, 27);
			this.button3.TabIndex = 35;
			this.button3.Text = "RESET ID SHINDENGEN";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.pictureBoxBarcode.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxBarcode.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxBarcode.Location = new global::System.Drawing.Point(643, 358);
			this.pictureBoxBarcode.Name = "pictureBoxBarcode";
			this.pictureBoxBarcode.Size = new global::System.Drawing.Size(10, 80);
			this.pictureBoxBarcode.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxBarcode.TabIndex = 27;
			this.pictureBoxBarcode.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(548, 260);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.PERSEN);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox4);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.pictureBoxBarcode);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "SMK";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SMK";
			base.Load += new global::System.EventHandler(this.SMK_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxBarcode).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000206 RID: 518
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000207 RID: 519
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000208 RID: 520
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000209 RID: 521
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x0400020A RID: 522
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400020B RID: 523
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400020C RID: 524
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400020D RID: 525
		private global::System.Windows.Forms.PictureBox pictureBoxBarcode;

		// Token: 0x0400020E RID: 526
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400020F RID: 527
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000210 RID: 528
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x04000211 RID: 529
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Forms.Label PERSEN;

		// Token: 0x04000214 RID: 532
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000215 RID: 533
		private global::System.Windows.Forms.Button button3;
	}
}
