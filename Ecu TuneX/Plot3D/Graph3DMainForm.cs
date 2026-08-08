using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using _3D_Chart_Graph;

namespace Plot3D
{
	// Token: 0x02000007 RID: 7
	public partial class Graph3DMainForm : Form
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000044F4 File Offset: 0x000026F4
		public Graph3DMainForm()
		{
			this.InitializeComponent();
			this.form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault<Form1>();
			ComboBox.ObjectCollection items = this.comboRaster.Items;
			object[] items2 = new string[]
			{
				"Raster",
				"Off"
			};
			items.AddRange(items2);
			this.comboRaster.SelectedIndex = 0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004562 File Offset: 0x00002762
		public void UpdateGraphWithData(int[,] data)
		{
			this.SetSurface();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000456C File Offset: 0x0000276C
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.graph3D.AssignTrackBars(this.trackRho, this.trackTheta, this.trackPhi);
			this.comboRaster.Sorted = false;
			foreach (object obj in Enum.GetValues(typeof(Graph3D.eRaster)))
			{
				Graph3D.eRaster eRaster = (Graph3D.eRaster)obj;
				this.comboRaster.Items.Add(eRaster);
			}
			this.comboColors.Sorted = false;
			foreach (object obj2 in Enum.GetValues(typeof(ColorSchema.eSchema)))
			{
				ColorSchema.eSchema eSchema = (ColorSchema.eSchema)obj2;
				this.comboColors.Items.Add(eSchema);
			}
			this.comboColors.SelectedIndex = 10;
			this.comboDataSrc.SelectedIndex = 0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000046A8 File Offset: 0x000028A8
		private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
		{
			Color[] schema = ColorSchema.GetSchema((ColorSchema.eSchema)this.comboColors.SelectedIndex);
			this.graph3D.SetColorScheme(schema, 3f);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000046D9 File Offset: 0x000028D9
		private void comboRaster_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.graph3D.Raster = (Graph3D.eRaster)this.comboRaster.SelectedIndex;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000046F3 File Offset: 0x000028F3
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.graph3D.SetCoefficients(1350.0, 70.0, 230.0);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004720 File Offset: 0x00002920
		private void btnScreenshot_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Save as PNG image";
			saveFileDialog.Filter = "PNG Image|*.png";
			saveFileDialog.DefaultExt = ".png";
			bool flag = DialogResult.Cancel == saveFileDialog.ShowDialog(this);
			if (!flag)
			{
				Bitmap screenshot = this.graph3D.GetScreenshot();
				try
				{
					screenshot.Save(saveFileDialog.FileName, ImageFormat.Png);
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000047B4 File Offset: 0x000029B4
		private void SetCallback()
		{
			Graph3D.delRendererFunction f_Function = delegate(double X, double Y)
			{
				double num = 0.15 * Math.Sqrt(X * X + Y * Y);
				bool flag = num < 1E-10;
				double result;
				if (flag)
				{
					result = 120.0;
				}
				else
				{
					result = 120.0 * Math.Sin(num) / num;
				}
				return result;
			};
			this.graph3D.SetFunction(f_Function, new PointF(-120f, -80f), new PointF(120f, 80f), 5.0, Graph3D.eNormalize.MaintainXYZ);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004818 File Offset: 0x00002A18
		private void SetFormula()
		{
			string functionBody = "12 * sin(x) * cos(y) / (sqrt(sqrt(x * x + y * y)) + 0.2)";
			try
			{
				Graph3D.delRendererFunction f_Function = FunctionCompiler.Compile(functionBody);
				this.graph3D.SetFunction(f_Function, new PointF(-10f, -10f), new PointF(10f, 10f), 0.5, Graph3D.eNormalize.MaintainXYZ);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004898 File Offset: 0x00002A98
		private void comboDataSrc_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.graph3D.AxisX_Legend = null;
			this.graph3D.AxisY_Legend = null;
			this.graph3D.AxisZ_Legend = null;
			int selectedIndex = this.comboDataSrc.SelectedIndex;
			int num = selectedIndex;
			if (num == 0)
			{
				this.SetSurface();
			}
			this.lblInfo.Text = "Points: " + this.graph3D.TotalPoints.ToString();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004914 File Offset: 0x00002B14
		private void SetSurface()
		{
			bool flag = this.form1Instance != null;
			if (flag)
			{
				double[,] gridData = this.form1Instance.GetGridData();
				bool flag2 = gridData.GetLength(0) == 0 || gridData.GetLength(1) == 0;
				if (flag2)
				{
					MessageBox.Show("Data grid kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					Graph3D.cPoint3D[,] array = new Graph3D.cPoint3D[gridData.GetLength(0) - 1, gridData.GetLength(1) - 1];
					for (int i = gridData.GetLength(0) - 1; i >= 1; i--)
					{
						for (int j = 1; j < gridData.GetLength(1); j++)
						{
							array[gridData.GetLength(0) - i - 1, j - 1] = new Graph3D.cPoint3D((double)((gridData.GetLength(0) - i - 1) * 10), (double)((gridData.GetLength(1) - j) * 500), gridData[i, j]);
						}
					}
					this.graph3D.AxisX_Legend = "X Axis";
					this.graph3D.AxisY_Legend = "Y Axis";
					this.graph3D.AxisZ_Legend = "Z Axis";
					this.graph3D.SetSurfacePoints(array, Graph3D.eNormalize.Separate);
				}
			}
			else
			{
				MessageBox.Show("Form1 instance tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004A6C File Offset: 0x00002C6C
		private void SetScatterPlot(bool b_Lines)
		{
			List<Graph3D.cScatter> list = new List<Graph3D.cScatter>();
			for (double num = -22.0; num < 22.0; num += 0.1)
			{
				double x = Math.Sin(num) * num;
				double y = Math.Cos(num) * num;
				double num2 = num;
				bool flag = num2 > 0.0;
				if (flag)
				{
					num2 /= 3.0;
				}
				list.Add(new Graph3D.cScatter(x, y, num2, null));
			}
			if (b_Lines)
			{
				this.graph3D.SetScatterLines(list.ToArray(), Graph3D.eNormalize.Separate, 3f);
			}
			else
			{
				this.graph3D.SetScatterPoints(list.ToArray(), Graph3D.eNormalize.Separate);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004B28 File Offset: 0x00002D28
		private void SetValentine()
		{
			List<Graph3D.cScatter> list = new List<Graph3D.cScatter>();
			double num = 0.0;
			double num2 = 0.0;
			for (double num3 = 0.0; num3 <= 4.1469023027385274; num3 += 0.025)
			{
				num = Math.Cos(num3) * 1.5 - 1.5;
				num2 = Math.Sin(num3) * 3.0 + 6.0;
				list.Add(new Graph3D.cScatter(num, -num, num2, Brushes.Black));
				list.Add(new Graph3D.cScatter(-num, num, num2, Brushes.Black));
			}
			double num4 = num / 70.0;
			double num5 = num2 / 70.0;
			while (num2 >= 0.0)
			{
				list.Add(new Graph3D.cScatter(num, -num, num2, Brushes.Black));
				list.Add(new Graph3D.cScatter(-num, num, num2, Brushes.Black));
				num -= num4;
				num2 -= num5;
			}
			this.graph3D.SetScatterPoints(list.ToArray(), Graph3D.eNormalize.MaintainXYZ);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void Graph3DMainForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void graph3D_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400001B RID: 27
		private Form1 form1Instance;
	}
}
