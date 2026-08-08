using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x02000017 RID: 23
	public partial class DYNO : Form
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000E9B7 File Offset: 0x0000CBB7
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0000E9BF File Offset: 0x0000CBBF
		public int RPMD { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		public float HP { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000E9D9 File Offset: 0x0000CBD9
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000E9E1 File Offset: 0x0000CBE1
		public float AFR { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000E9EA File Offset: 0x0000CBEA
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000E9F2 File Offset: 0x0000CBF2
		public float TQ { get; set; }

		// Token: 0x06000166 RID: 358 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		public DYNO()
		{
			this.InitializeComponent();
			this.SetDoubleBuffered(this.panel1);
			this.hScrollBar = new HScrollBar();
			this.hScrollBar.Dock = DockStyle.Bottom;
			this.hScrollBar.Scroll += this.HScrollBar_Scroll;
			base.Controls.Add(this.hScrollBar);
			this.panel1.Paint += this.panel1_Paint;
			this.panel1.MouseClick += this.Panel1_MouseClick;
			this.button1.Text = "Run";
			this.label1.Text = "0.00";
			this.label2.Text = "0";
			this.label4.Text = "0.00";
			this.label3.Text = "0.00";
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		private void Panel1_MouseClick(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Right;
			if (flag)
			{
				this.startDrawing = true;
				this.button1.Text = "Stop";
			}
			else
			{
				bool flag2 = e.Button == MouseButtons.Left;
				if (flag2)
				{
					this.startDrawing = false;
					this.button1.Text = "Run";
				}
			}
			this.panel1.Invalidate();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		private void SetDoubleBuffered(Control control)
		{
			PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			bool flag = property != null;
			if (flag)
			{
				property.SetValue(control, true, null);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000EC01 File Offset: 0x0000CE01
		private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			this.isAutoScroll = false;
			this.panel1.Invalidate();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000EC18 File Offset: 0x0000CE18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(this.panel1.BackColor);
			Graphics graphics = e.Graphics;
			Pen pen = new Pen(Color.Blue, 2f);
			Pen pen2 = new Pen(Color.Red, 2f);
			Pen pen3 = new Pen(Color.GreenYellow, 2f);
			Pen pen4 = new Pen(Color.White, 2f);
			int num = this.panel1.Height - 10;
			float num2 = 45f;
			this.yScale = (float)(this.panel1.Height - 20) / num2;
			bool flag = this.startDrawing;
			if (flag)
			{
				int x = (this.rpmPoints.Count > 0) ? (this.rpmPoints[this.rpmPoints.Count - 1].X + 10) : 0;
				this.rpmPoints.Add(new Point(x, num - (int)(this.NormalizeRPMD(this.RPMD) * this.yScale)));
				this.hpPoints.Add(new Point(x, num - (int)(this.NormalizeHP(this.HP) * this.yScale)));
				this.afrPoints.Add(new Point(x, num - (int)(this.NormalizeAFR(this.AFR) * this.yScale)));
				this.tqPoints.Add(new Point(x, num - (int)(this.NormalizeTQ(this.TQ) * this.yScale)));
			}
			this.DrawPoints(graphics, this.rpmPoints, pen);
			this.DrawPoints(graphics, this.hpPoints, pen2);
			this.DrawPoints(graphics, this.afrPoints, pen3);
			this.DrawPoints(graphics, this.tqPoints, pen4);
			this.DrawScaleLabels(graphics, num2, num);
			bool flag2 = this.isAutoScroll;
			if (flag2)
			{
				try
				{
					this.hScrollBar.Value = this.hScrollBar.Maximum;
				}
				catch (ArgumentOutOfRangeException)
				{
					this.hScrollBar.Value = this.hScrollBar.Maximum - this.hScrollBar.LargeChange + 1;
				}
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000EE50 File Offset: 0x0000D050
		private void DrawPoints(Graphics g, List<Point> points, Pen pen)
		{
			bool flag = points.Count <= 1;
			if (!flag)
			{
				bool flag2 = points[points.Count - 1].X >= this.panel1.Width;
				if (flag2)
				{
					float num = (float)this.panel1.Width / (float)points.Count;
					for (int i = 0; i < points.Count - 1; i++)
					{
						int num2 = (int)((float)i * num);
						int num3 = (int)((float)(i + 1) * num);
						bool flag3 = num3 >= 0 && num2 < this.panel1.Width;
						if (flag3)
						{
							g.DrawLine(pen, new Point(num2, points[i].Y), new Point(num3, points[i + 1].Y));
						}
					}
				}
				else
				{
					for (int j = 0; j < points.Count - 1; j++)
					{
						g.DrawLine(pen, points[j], points[j + 1]);
					}
				}
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000EF80 File Offset: 0x0000D180
		private void DrawScaleLabels(Graphics g, float maxDataValue, int yOffset)
		{
			Font font = new Font("Arial", 8f);
			Brush lightGreen = Brushes.LightGreen;
			Pen pen = new Pen(Color.Gray, 1f);
			int num = 15;
			int num2 = 0;
			while ((float)num2 <= maxDataValue)
			{
				int num3 = yOffset - (int)((float)num2 * this.yScale);
				g.DrawString(num2.ToString(), font, lightGreen, new PointF((float)num, (float)(num3 - 10)));
				g.DrawLine(pen, new Point(10, num3), new Point(this.panel1.Width, num3));
				num2 += 5;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000F024 File Offset: 0x0000D224
		private float NormalizeRPMD(int rpm)
		{
			return (float)rpm / 20000f * 45f;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000F044 File Offset: 0x0000D244
		private float NormalizeHP(float hp)
		{
			return Math.Min(hp, 45f);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000F064 File Offset: 0x0000D264
		private float NormalizeAFR(float afr)
		{
			return Math.Min(afr, 45f);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000F084 File Offset: 0x0000D284
		private float NormalizeTQ(float tq)
		{
			return Math.Min(tq, 45f);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		public void Updatedyno(int rpm, float hp, float afr, float tq)
		{
			this.RPMD = rpm;
			this.HP = hp;
			this.AFR = afr;
			this.TQ = tq;
			bool flag = this.startDrawing;
			if (flag)
			{
				bool flag2 = this.HP > this.maxHP;
				if (flag2)
				{
					this.maxHP = this.HP;
					this.rpmAtMaxHP = this.RPMD;
					this.label1.Text = string.Format("Max HP: {0:F2}", this.maxHP);
					this.label2.Text = string.Format("RPM at Max HP: {0}", this.rpmAtMaxHP);
				}
				bool flag3 = this.TQ > this.maxTQ;
				if (flag3)
				{
					this.maxTQ = this.TQ;
					this.label4.Text = string.Format("Max TQ: {0:F2}", this.maxTQ);
				}
				this.label3.Text = string.Format("AFR: {0:F2}", afr);
				Console.WriteLine(string.Format("RPM: {0}, HP: {1}, AFR: {2}, TQ: {3}", new object[]
				{
					this.RPMD,
					this.HP,
					this.AFR,
					this.TQ
				}));
				this.panel1.Invalidate();
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000F208 File Offset: 0x0000D408
		private void button1_Click(object sender, EventArgs e)
		{
			this.startDrawing = !this.startDrawing;
			this.button1.Text = (this.startDrawing ? "Stop" : "Run");
			bool flag = this.startDrawing;
			if (flag)
			{
				this.panel1.Invalidate();
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000F260 File Offset: 0x0000D460
		private void button2_Click(object sender, EventArgs e)
		{
			this.rpmPoints.Clear();
			this.hpPoints.Clear();
			this.afrPoints.Clear();
			this.tqPoints.Clear();
			this.maxHP = float.MinValue;
			this.maxTQ = float.MinValue;
			this.rpmAtMaxHP = 0;
			this.label1.Text = "0.00";
			this.label2.Text = "0";
			this.label4.Text = "0.00";
			this.label3.Text = "0.00";
			this.isAutoScroll = true;
			this.panel1.Invalidate();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void DYNO_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040000C0 RID: 192
		private List<Point> rpmPoints = new List<Point>();

		// Token: 0x040000C1 RID: 193
		private List<Point> hpPoints = new List<Point>();

		// Token: 0x040000C2 RID: 194
		private List<Point> afrPoints = new List<Point>();

		// Token: 0x040000C3 RID: 195
		private List<Point> tqPoints = new List<Point>();

		// Token: 0x040000C4 RID: 196
		private const int xScale = 10;

		// Token: 0x040000C5 RID: 197
		private float yScale;

		// Token: 0x040000C6 RID: 198
		private bool isAutoScroll = true;

		// Token: 0x040000C7 RID: 199
		private bool startDrawing = false;

		// Token: 0x040000C8 RID: 200
		private HScrollBar hScrollBar;

		// Token: 0x040000CD RID: 205
		private float maxHP = float.MinValue;

		// Token: 0x040000CE RID: 206
		private float maxTQ = float.MinValue;

		// Token: 0x040000CF RID: 207
		private int rpmAtMaxHP = 0;
	}
}
