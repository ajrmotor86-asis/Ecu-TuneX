using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x02000012 RID: 18
	public partial class _2d : Form
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000100 RID: 256 RVA: 0x0000905C File Offset: 0x0000725C
		// (remove) Token: 0x06000101 RID: 257 RVA: 0x00009094 File Offset: 0x00007294
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<int, double> DataPointValueChanged;

		// Token: 0x06000102 RID: 258 RVA: 0x000090CC File Offset: 0x000072CC
		public _2d()
		{
			this.InitializeComponent();
			this.dataPoints = new List<DataPoint>();
			this.toolTip = new CustomToolTip();
			this.panel1.Paint += this.Panel1_Paint;
			this.panel1.MouseDown += this.Panel1_MouseDown;
			this.panel1.MouseMove += this.Panel1_MouseMove;
			this.panel1.MouseUp += this.Panel1_MouseUp;
			this.panel1.Resize += this.Panel1_Resize;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000918C File Offset: 0x0000738C
		public void ShowChart(List<double> values)
		{
			this.dataPoints.Clear();
			for (int i = 0; i < values.Count; i++)
			{
				int num = this.margin + i * (this.panel1.Width - 2 * this.margin) / (values.Count - 1);
				int num2 = this.margin + (int)((double)(this.panel1.Height - 2 * this.margin) - values[i] * (double)(this.panel1.Height - 2 * this.margin) / 100.0);
				this.dataPoints.Add(new DataPoint
				{
					X = (double)i,
					Y = values[i],
					Bounds = new Rectangle(num - this.pointSize / 2, num2 - this.pointSize / 2, this.pointSize, this.pointSize)
				});
			}
			this.panel1.Invalidate();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00009290 File Offset: 0x00007490
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			using (Pen pen = new Pen(Color.Lime, 0.1f)
			{
				DashStyle = DashStyle.Dash
			})
			{
				for (int i = 0; i <= 10; i++)
				{
					int num = this.margin + i * (this.panel1.Height - 2 * this.margin) / 10;
					graphics.DrawLine(pen, this.margin, num, this.panel1.Width - this.margin, num);
				}
				for (int j = 0; j < this.dataPoints.Count; j++)
				{
					int num2 = this.margin + j * (this.panel1.Width - 2 * this.margin) / (this.dataPoints.Count - 1);
					graphics.DrawLine(pen, num2, this.margin, num2, this.panel1.Height - this.margin);
				}
			}
			bool flag = this.dataPoints.Count > 1;
			if (flag)
			{
				using (Pen pen2 = new Pen(Color.Orange, 2.5f))
				{
					for (int k = 1; k < this.dataPoints.Count; k++)
					{
						bool flag2 = this.dataPoints[k - 1].Bounds != Rectangle.Empty && this.dataPoints[k].Bounds != Rectangle.Empty;
						if (flag2)
						{
							bool flag3 = k > 1;
							if (flag3)
							{
								graphics.DrawLine(pen2, this.dataPoints[k].Bounds.X + this.pointSize / 2, this.dataPoints[k].Bounds.Y + this.pointSize / 2, this.dataPoints[k - 1].Bounds.X + this.pointSize / 2, this.dataPoints[k - 1].Bounds.Y + this.pointSize / 2);
							}
						}
					}
				}
			}
			for (int l = 1; l < this.dataPoints.Count; l++)
			{
				DataPoint dataPoint = this.dataPoints[l];
				bool flag4 = dataPoint.Bounds != Rectangle.Empty;
				if (flag4)
				{
					graphics.FillEllipse(Brushes.Cyan, dataPoint.Bounds);
				}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00009588 File Offset: 0x00007788
		private void Panel1_MouseDown(object sender, MouseEventArgs e)
		{
			foreach (DataPoint dataPoint in this.dataPoints)
			{
				bool flag = dataPoint.Bounds.Contains(e.Location);
				if (flag)
				{
					this.isDragging = true;
					this.draggedPoint = dataPoint;
					this.offset = new Point(e.X - dataPoint.Bounds.X, e.Y - dataPoint.Bounds.Y);
					this.toolTip.Show(string.Format("Value: {0:F2}", this.draggedPoint.Y), this, e.Location.X + 10, e.Location.Y + 10);
					break;
				}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000968C File Offset: 0x0000788C
		private void Panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.isDragging && this.draggedPoint != null;
			if (flag)
			{
				int num = e.Y - this.offset.Y;
				this.draggedPoint.Y = (double)((this.panel1.Height - this.margin - num) * 100 / (this.panel1.Height - 2 * this.margin));
				this.draggedPoint.Bounds = new Rectangle(this.draggedPoint.Bounds.X, num, this.pointSize, this.pointSize);
				this.toolTip.Show(string.Format("Value: {0:F2}", this.draggedPoint.Y), this, e.Location.X + 10, e.Location.Y + 10);
				this.panel1.Invalidate();
				int arg = this.dataPoints.IndexOf(this.draggedPoint);
				Action<int, double> dataPointValueChanged = this.DataPointValueChanged;
				if (dataPointValueChanged != null)
				{
					dataPointValueChanged(arg, this.draggedPoint.Y);
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000097BC File Offset: 0x000079BC
		private void Panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isDragging = false;
			bool flag = this.draggedPoint != null;
			if (flag)
			{
				Action<int, double> dataPointValueChanged = this.DataPointValueChanged;
				if (dataPointValueChanged != null)
				{
					dataPointValueChanged((int)this.draggedPoint.X, this.draggedPoint.Y);
				}
			}
			this.draggedPoint = null;
			this.toolTip.Hide();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000981C File Offset: 0x00007A1C
		private void Panel1_Resize(object sender, EventArgs e)
		{
			for (int i = 0; i < this.dataPoints.Count; i++)
			{
				int num = this.margin + i * (this.panel1.Width - 2 * this.margin) / (this.dataPoints.Count - 1);
				int num2 = this.margin + (int)((double)(this.panel1.Height - 2 * this.margin) - this.dataPoints[i].Y * (double)(this.panel1.Height - 2 * this.margin) / 100.0);
				this.dataPoints[i].Bounds = new Rectangle(num - this.pointSize / 2, num2 - this.pointSize / 2, this.pointSize, this.pointSize);
			}
			this.panel1.Invalidate();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void _2d_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000074 RID: 116
		private List<DataPoint> dataPoints;

		// Token: 0x04000075 RID: 117
		private bool isDragging;

		// Token: 0x04000076 RID: 118
		private DataPoint draggedPoint;

		// Token: 0x04000077 RID: 119
		private Point offset;

		// Token: 0x04000078 RID: 120
		private int margin = 15;

		// Token: 0x04000079 RID: 121
		private int pointSize = 6;

		// Token: 0x0400007A RID: 122
		private CustomToolTip toolTip;
	}
}
