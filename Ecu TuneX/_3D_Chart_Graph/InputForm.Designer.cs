namespace _3D_Chart_Graph
{
	// Token: 0x0200001A RID: 26
	public partial class InputForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600026D RID: 621 RVA: 0x00040CB0 File Offset: 0x0003EEB0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00040CE8 File Offset: 0x0003EEE8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph.InputForm));
			this.txtInput = new global::System.Windows.Forms.TextBox();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.txtInput.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtInput.Location = new global::System.Drawing.Point(78, 12);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new global::System.Drawing.Size(66, 30);
			this.txtInput.TabIndex = 0;
			this.txtInput.Text = "0";
			this.txtInput.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.btnOK.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnOK.Location = new global::System.Drawing.Point(150, 12);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(78, 30);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "Execute";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click_1);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Franklin Gothic Demi Cond", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(60, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Value :";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(240, 54);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.txtInput);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "InputForm";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Input Value";
			base.Load += new global::System.EventHandler(this.InputForm_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001DF RID: 479
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001E0 RID: 480
		private global::System.Windows.Forms.TextBox txtInput;

		// Token: 0x040001E1 RID: 481
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x040001E2 RID: 482
		private global::System.Windows.Forms.Label label1;
	}
}
