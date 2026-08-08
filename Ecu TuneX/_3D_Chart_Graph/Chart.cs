using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x02000015 RID: 21
	public partial class Chart : Form
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00009BD2 File Offset: 0x00007DD2
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00009BDA File Offset: 0x00007DDA
		public int RPMD { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00009BE3 File Offset: 0x00007DE3
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00009BEB File Offset: 0x00007DEB
		public float TPSD { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00009BF4 File Offset: 0x00007DF4
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00009BFC File Offset: 0x00007DFC
		public float AD { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00009C05 File Offset: 0x00007E05
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00009C0D File Offset: 0x00007E0D
		public float AFR { get; set; }

		// Token: 0x0600011E RID: 286 RVA: 0x00009C18 File Offset: 0x00007E18
		public Chart()
		{
			this.InitializeComponent();
			this.SetDoubleBuffered(this.panel1);
			this.hScrollBar = new HScrollBar();
			this.hScrollBar.Dock = DockStyle.Bottom;
			this.hScrollBar.Scroll += this.HScrollBar_Scroll;
			base.Controls.Add(this.hScrollBar);
			this.panel1.Paint += this.panel1_Paint;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00009CD8 File Offset: 0x00007ED8
		private void SetDoubleBuffered(Control control)
		{
			PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			bool flag = property != null;
			if (flag)
			{
				property.SetValue(control, true, null);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00009D19 File Offset: 0x00007F19
		private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			this.isAutoScroll = false;
			this.panel1.Invalidate();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00009D30 File Offset: 0x00007F30
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(this.panel1.BackColor);
			Graphics graphics = e.Graphics;
			Pen pen = new Pen(Color.Blue, 2f);
			Pen pen2 = new Pen(Color.Orange, 2f);
			Pen pen3 = new Pen(Color.Red, 2f);
			Pen pen4 = new Pen(Color.GreenYellow, 2f);
			int num = this.panel1.Height - 10;
			float num2 = 100f;
			this.yScale = (float)(this.panel1.Height - 20) / num2;
			int value = this.hScrollBar.Value;
			int x = (this.rpmPoints.Count > 0) ? (this.rpmPoints[this.rpmPoints.Count - 1].X + 10) : 0;
			this.rpmPoints.Add(new Point(x, num - (int)(this.NormalizeRPMD(this.RPMD) * this.yScale)));
			this.tpsPoints.Add(new Point(x, num - (int)(this.NormalizeTPSD(this.TPSD) * this.yScale)));
			this.adPoints.Add(new Point(x, num - (int)(this.NormalizeAD(this.AD) * this.yScale)));
			this.afrPoints.Add(new Point(x, num - (int)(this.NormalizeAFR(this.AFR) * this.yScale)));
			bool flag = this.rpmPoints.Count > 0 && this.rpmPoints[this.rpmPoints.Count - 1].X + 10 > this.panel1.Width;
			if (flag)
			{
				for (int i = 0; i < this.rpmPoints.Count; i++)
				{
					this.rpmPoints[i] = new Point(this.rpmPoints[i].X - 10, this.rpmPoints[i].Y);
					this.tpsPoints[i] = new Point(this.tpsPoints[i].X - 10, this.tpsPoints[i].Y);
					this.adPoints[i] = new Point(this.adPoints[i].X - 10, this.adPoints[i].Y);
					this.afrPoints[i] = new Point(this.afrPoints[i].X - 10, this.afrPoints[i].Y);
				}
			}
			bool flag2 = this.rpmPoints.Count > 0 && this.rpmPoints[0].X < 0;
			if (flag2)
			{
				this.rpmPoints.RemoveAt(0);
				this.tpsPoints.RemoveAt(0);
				this.adPoints.RemoveAt(0);
				this.afrPoints.RemoveAt(0);
			}
			for (int j = 0; j < this.rpmPoints.Count - 1; j++)
			{
				int num3 = this.rpmPoints[j].X - value;
				int num4 = this.rpmPoints[j + 1].X - value;
				bool flag3 = num4 >= 0 && num3 < this.panel1.Width;
				if (flag3)
				{
					graphics.DrawLine(pen, new Point(num3, this.rpmPoints[j].Y), new Point(num4, this.rpmPoints[j + 1].Y));
				}
			}
			for (int k = 0; k < this.tpsPoints.Count - 1; k++)
			{
				int num5 = this.tpsPoints[k].X - value;
				int num6 = this.tpsPoints[k + 1].X - value;
				bool flag4 = num6 >= 0 && num5 < this.panel1.Width;
				if (flag4)
				{
					graphics.DrawLine(pen2, new Point(num5, this.tpsPoints[k].Y), new Point(num6, this.tpsPoints[k + 1].Y));
				}
			}
			for (int l = 0; l < this.adPoints.Count - 1; l++)
			{
				int num7 = this.adPoints[l].X - value;
				int num8 = this.adPoints[l + 1].X - value;
				bool flag5 = num8 >= 0 && num7 < this.panel1.Width;
				if (flag5)
				{
					graphics.DrawLine(pen3, new Point(num7, this.adPoints[l].Y), new Point(num8, this.adPoints[l + 1].Y));
				}
			}
			for (int m = 0; m < this.afrPoints.Count - 1; m++)
			{
				int num9 = this.afrPoints[m].X - value;
				int num10 = this.afrPoints[m + 1].X - value;
				bool flag6 = num10 >= 0 && num9 < this.panel1.Width;
				if (flag6)
				{
					graphics.DrawLine(pen4, new Point(num9, this.afrPoints[m].Y), new Point(num10, this.afrPoints[m + 1].Y));
				}
			}
			Font font = new Font("Arial", 8f);
			Brush lightGreen = Brushes.LightGreen;
			Pen pen5 = new Pen(Color.Gray, 1f);
			int num11 = 15;
			for (int n = 0; n <= 100; n += 20)
			{
				int num12 = num - (int)((float)n * this.yScale);
				graphics.DrawString(n.ToString(), font, lightGreen, new PointF((float)num11, (float)(num12 - 10)));
				graphics.DrawLine(pen5, new Point(10, num12), new Point(this.panel1.Width, num12));
			}
			bool flag7 = this.isAutoScroll;
			if (flag7)
			{
				this.hScrollBar.Value = this.hScrollBar.Maximum;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000A474 File Offset: 0x00008674
		private float NormalizeRPMD(int rpm)
		{
			return (float)rpm / 20000f * 100f;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000A494 File Offset: 0x00008694
		private float NormalizeTPSD(float tps)
		{
			return tps;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000A4A8 File Offset: 0x000086A8
		private float NormalizeAD(float ad)
		{
			return ad;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000A4BC File Offset: 0x000086BC
		private float NormalizeAFR(float afr)
		{
			return afr;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000A4CF File Offset: 0x000086CF
		public void UpdateChart(int rpm, float tps, float ad, float afr)
		{
			this.RPMD = rpm;
			this.TPSD = tps;
			this.AD = ad;
			this.AFR = afr;
			this.panel1.Invalidate();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void Chart_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000082 RID: 130
		private List<Point> rpmPoints = new List<Point>();

		// Token: 0x04000083 RID: 131
		private List<Point> tpsPoints = new List<Point>();

		// Token: 0x04000084 RID: 132
		private List<Point> adPoints = new List<Point>();

		// Token: 0x04000085 RID: 133
		private List<Point> afrPoints = new List<Point>();

		// Token: 0x04000086 RID: 134
		private const int xScale = 10;

		// Token: 0x04000087 RID: 135
		private float yScale;

		// Token: 0x04000088 RID: 136
		private bool isAutoScroll = true;

		// Token: 0x04000089 RID: 137
		private HScrollBar hScrollBar;
	}
}
