using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x0200001A RID: 26
	public partial class InputForm : Form
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00040BAD File Offset: 0x0003EDAD
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00040BB5 File Offset: 0x0003EDB5
		public double InputValue { get; private set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00040BBE File Offset: 0x0003EDBE
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00040BC6 File Offset: 0x0003EDC6
		public bool IsConfirmed { get; private set; }

		// Token: 0x06000269 RID: 617 RVA: 0x00040BCF File Offset: 0x0003EDCF
		public InputForm(string prompt, string initialValue)
		{
			this.InitializeComponent();
			this.txtInput.Text = initialValue;
			this.IsConfirmed = false;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00040BFC File Offset: 0x0003EDFC
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00040C08 File Offset: 0x0003EE08
		private void btnOK_Click_1(object sender, EventArgs e)
		{
			double inputValue;
			bool flag = double.TryParse(this.txtInput.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out inputValue);
			if (flag)
			{
				this.InputValue = inputValue;
				this.IsConfirmed = true;
				base.Close();
			}
			else
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				bool flag2 = double.TryParse(this.txtInput.Text.Replace(',', '.'), NumberStyles.Any, invariantCulture, out inputValue);
				if (flag2)
				{
					this.InputValue = inputValue;
					this.IsConfirmed = true;
					base.Close();
				}
				else
				{
					MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void InputForm_Load(object sender, EventArgs e)
		{
		}
	}
}
