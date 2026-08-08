using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace Plot3D
{
	// Token: 0x02000006 RID: 6
	public class Graph3D : UserControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000026B4 File Offset: 0x000008B4
		public Graph3D.eRaster Raster
		{
			get
			{
				return this.me_Raster;
			}
			set
			{
				Debug.Assert(!base.InvokeRequired);
				bool flag = this.me_Raster != value;
				if (flag)
				{
					this.me_Raster = value;
					this.mi_DrawObjects.Clear();
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002718 File Offset: 0x00000918
		public Color PolygonLineColor
		{
			get
			{
				bool flag = this.mi_PolyLinePen != null;
				Color result;
				if (flag)
				{
					result = this.mi_PolyLinePen.Color;
				}
				else
				{
					result = Color.Empty;
				}
				return result;
			}
			set
			{
				Debug.Assert(!base.InvokeRequired);
				bool flag = value.A == 0;
				if (flag)
				{
					this.mi_PolyLinePen = null;
				}
				else
				{
					this.mi_PolyLinePen = new Pen(value);
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000027DC File Offset: 0x000009DC
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002794 File Offset: 0x00000994
		public Color BorderColor
		{
			get
			{
				bool flag = this.mi_BorderPen != null;
				Color result;
				if (flag)
				{
					result = this.mi_BorderPen.Color;
				}
				else
				{
					result = Color.Empty;
				}
				return result;
			}
			set
			{
				Debug.Assert(!base.InvokeRequired);
				bool flag = value.A == 0;
				if (flag)
				{
					this.mi_BorderPen = null;
				}
				else
				{
					this.mi_BorderPen = new Pen(value);
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002834 File Offset: 0x00000A34
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000280E File Offset: 0x00000A0E
		public Color TopLegendColor
		{
			get
			{
				bool flag = this.mi_TopLegendBrush != null;
				Color result;
				if (flag)
				{
					result = this.mi_TopLegendBrush.Color;
				}
				else
				{
					result = Color.Empty;
				}
				return result;
			}
			set
			{
				Debug.Assert(!base.InvokeRequired);
				this.mi_TopLegendBrush = new SolidBrush(value);
				base.Invalidate();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000287C File Offset: 0x00000A7C
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002866 File Offset: 0x00000A66
		public string AxisX_Legend
		{
			get
			{
				return this.ms_AxisLegends[0];
			}
			set
			{
				this.ms_AxisLegends[0] = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000028AC File Offset: 0x00000AAC
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002896 File Offset: 0x00000A96
		public string AxisY_Legend
		{
			get
			{
				return this.ms_AxisLegends[1];
			}
			set
			{
				this.ms_AxisLegends[1] = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000028DC File Offset: 0x00000ADC
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000028C6 File Offset: 0x00000AC6
		public string AxisZ_Legend
		{
			get
			{
				return this.ms_AxisLegends[2];
			}
			set
			{
				this.ms_AxisLegends[2] = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000290C File Offset: 0x00000B0C
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000028F6 File Offset: 0x00000AF6
		public Color AxisX_Color
		{
			get
			{
				return this.mi_AxisPens[0].Color;
			}
			set
			{
				this.SetAxisColor(Graph3D.eCoord.X, value);
				base.Invalidate();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000292B File Offset: 0x00000B2B
		public Color AxisY_Color
		{
			get
			{
				return this.mi_AxisPens[1].Color;
			}
			set
			{
				this.SetAxisColor(Graph3D.eCoord.Y, value);
				base.Invalidate();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002974 File Offset: 0x00000B74
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000295F File Offset: 0x00000B5F
		public Color AxisZ_Color
		{
			get
			{
				return this.mi_AxisPens[2].Color;
			}
			set
			{
				this.SetAxisColor(Graph3D.eCoord.Z, value);
				base.Invalidate();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002994 File Offset: 0x00000B94
		public void SetColorScheme(Color[] c_Colors, float f_LineWidth)
		{
			Debug.Assert(!base.InvokeRequired);
			this.mi_SchemeBrushes = new SolidBrush[c_Colors.Length];
			this.mi_SchemePens = new Pen[c_Colors.Length];
			for (int i = 0; i < this.mi_SchemeBrushes.Length; i++)
			{
				this.mi_SchemeBrushes[i] = new SolidBrush(c_Colors[i]);
				this.mi_SchemePens[i] = new Pen(this.mi_SchemeBrushes[i], f_LineWidth);
			}
			base.Invalidate();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002A18 File Offset: 0x00000C18
		[ReadOnly(true)]
		[Browsable(false)]
		public int TotalPoints
		{
			get
			{
				return this.ms32_Points;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002A30 File Offset: 0x00000C30
		public void AssignTrackBars(TrackBar i_Rho, TrackBar i_Theta, TrackBar i_Phi)
		{
			Debug.Assert(!base.InvokeRequired);
			this.mi_Mouse.AssignTrackbar(Graph3D.eMouseAction.Rho, i_Rho, new EventHandler(this.OnTrackbarScroll));
			this.mi_Mouse.AssignTrackbar(Graph3D.eMouseAction.Theta, i_Theta, new EventHandler(this.OnTrackbarScroll));
			this.mi_Mouse.AssignTrackbar(Graph3D.eMouseAction.Phi, i_Phi, new EventHandler(this.OnTrackbarScroll));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002A9C File Offset: 0x00000C9C
		public Graph3D()
		{
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.White;
			this.SetAxisColor(Graph3D.eCoord.X, Color.DarkBlue);
			this.SetAxisColor(Graph3D.eCoord.Y, Color.DarkGreen);
			this.SetAxisColor(Graph3D.eCoord.Z, Color.DarkRed);
			this.mi_PolyLinePen = new Pen(Color.Black, 1f);
			this.mi_BorderPen = new Pen(Color.FromArgb(255, 180, 180, 180), 1f);
			this.mi_TopLegendBrush = new SolidBrush(Color.FromArgb(255, 200, 200, 150));
			this.mi_Transform.SetCoeficients(this.mi_Mouse);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public void SetFunction(Graph3D.delRendererFunction f_Function, PointF k_Start, PointF k_End, double d_Density, Graph3D.eNormalize e_Normalize)
		{
			Debug.Assert(!base.InvokeRequired);
			int num = (int)((double)(k_End.X - k_Start.X) / d_Density + 1.0);
			int num2 = (int)((double)(k_End.Y - k_Start.Y) / d_Density + 1.0);
			Graph3D.cPoint3D[,] array = new Graph3D.cPoint3D[num, num2];
			for (int i = 0; i < num; i++)
			{
				double x = (double)k_Start.X + d_Density * (double)i;
				for (int j = 0; j < num2; j++)
				{
					double y = (double)k_Start.Y + d_Density * (double)j;
					double z = f_Function(x, y);
					array[i, j] = new Graph3D.cPoint3D(x, y, z);
				}
			}
			this.SetSurfacePoints(array, e_Normalize);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public void SetSurfacePoints(Graph3D.cPoint3D[,] i_Points3D, Graph3D.eNormalize e_Normalize)
		{
			Debug.Assert(!base.InvokeRequired);
			this.mi_ScatterArr = null;
			this.mi_PolyArr = i_Points3D;
			this.ms32_Points = i_Points3D.Length;
			this.mi_MinMax = new Graph3D.cMinMax3D(i_Points3D);
			bool flag = this.ms32_Points < 4;
			if (flag)
			{
				throw new Exception("Insufficient 3D points specified");
			}
			this.NormalizeRanges(e_Normalize);
			this.mi_Mouse.mk_Offset = Point.Empty;
			this.mi_DrawObjects.Clear();
			base.Invalidate();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D3C File Offset: 0x00000F3C
		public void SetScatterPoints(Graph3D.cScatter[] i_Scatter, Graph3D.eNormalize e_Normalize)
		{
			Debug.Assert(!base.InvokeRequired);
			this.mi_PolyArr = null;
			this.mi_ScatterArr = i_Scatter;
			this.ms32_Points = i_Scatter.Length;
			this.mi_MinMax = new Graph3D.cMinMax3D(i_Scatter);
			this.NormalizeRanges(e_Normalize);
			this.mi_Mouse.mk_Offset = Point.Empty;
			this.mi_DrawObjects.Clear();
			base.Invalidate();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public void SetScatterLines(Graph3D.cScatter[] i_ScatterArr, Graph3D.eNormalize e_Normalize, float f_LineWidth)
		{
			Graph3D.cScatter mi_Previous = null;
			foreach (Graph3D.cScatter cScatter in i_ScatterArr)
			{
				cScatter.mb_Combine = true;
				cScatter.mi_Previous = mi_Previous;
				bool flag = cScatter.mi_Brush != null;
				if (flag)
				{
					cScatter.mi_Pen = new Pen(cScatter.mi_Brush, f_LineWidth);
				}
				mi_Previous = cScatter;
			}
			this.SetScatterPoints(i_ScatterArr, e_Normalize);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E0C File Offset: 0x0000100C
		private void NormalizeRanges(Graph3D.eNormalize e_Normalize)
		{
			bool flag = this.mi_MinMax.md_MaxX == this.mi_MinMax.md_MinX;
			if (flag)
			{
				this.mi_MinMax.md_MinX -= 1.0;
				this.mi_MinMax.md_MaxX += 1.0;
			}
			bool flag2 = this.mi_MinMax.md_MaxY == this.mi_MinMax.md_MinY;
			if (flag2)
			{
				this.mi_MinMax.md_MinY -= 1.0;
				this.mi_MinMax.md_MaxY += 1.0;
			}
			bool flag3 = this.mi_MinMax.md_MaxZ == this.mi_MinMax.md_MinZ;
			if (flag3)
			{
				this.mi_MinMax.md_MinZ -= 1.0;
				this.mi_MinMax.md_MaxZ += 1.0;
			}
			double num = this.mi_MinMax.md_MaxX - this.mi_MinMax.md_MinX;
			double num2 = this.mi_MinMax.md_MaxY - this.mi_MinMax.md_MinY;
			bool flag4 = this.me_Raster == Graph3D.eRaster.Off;
			double num3;
			if (flag4)
			{
				num3 = this.mi_MinMax.md_MaxZ - this.mi_MinMax.md_MinZ;
			}
			else
			{
				num3 = Math.Max(0.0, this.mi_MinMax.md_MaxZ) - Math.Min(0.0, this.mi_MinMax.md_MinZ);
			}
			if (e_Normalize != Graph3D.eNormalize.MaintainXY)
			{
				if (e_Normalize == Graph3D.eNormalize.MaintainXYZ)
				{
					double num4 = (num + num2 + num3) / 3.0;
					num = num4;
					num2 = num4;
					num3 = num4;
				}
			}
			else
			{
				double num5 = (num + num2) / 2.0;
				num = num5;
				num2 = num5;
			}
			this.mi_Transform.md_NormalizeX = 250.0 / num;
			this.mi_Transform.md_NormalizeY = 250.0 / num2;
			this.mi_Transform.md_NormalizeZ = 250.0 / num3;
			this.mi_MinMax.mi_Center3D.md_X = (this.mi_MinMax.md_MaxX + this.mi_MinMax.md_MinX) / 2.0;
			this.mi_MinMax.mi_Center3D.md_Y = (this.mi_MinMax.md_MaxY + this.mi_MinMax.md_MinY) / 2.0;
			bool flag5 = this.me_Raster == Graph3D.eRaster.Off;
			if (flag5)
			{
				this.mi_MinMax.mi_Center3D.md_Z = (this.mi_MinMax.md_MaxZ + this.mi_MinMax.md_MinZ) / 2.0;
			}
			else
			{
				this.mi_MinMax.mi_Center3D.md_Z = (Math.Max(0.0, this.mi_MinMax.md_MaxZ) + Math.Min(0.0, this.mi_MinMax.md_MinZ)) / 2.0;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003124 File Offset: 0x00001324
		public void SetCoefficients(double d_Rho, double d_Theta, double d_Phi)
		{
			Debug.Assert(!base.InvokeRequired);
			this.mi_Mouse.SetRho(d_Rho);
			this.mi_Mouse.SetTheta(d_Theta);
			this.mi_Mouse.SetPhi(d_Phi);
			this.mi_Transform.SetCoeficients(this.mi_Mouse);
			this.mi_DrawObjects.Clear();
			base.Invalidate();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003190 File Offset: 0x00001390
		private void CreateCoordinateSystem(Graphics i_Graph)
		{
			this.mk_Offset2D = new Point(0, -30);
			bool flag = this.me_Raster == Graph3D.eRaster.Off;
			if (!flag)
			{
				List<Graph3D.cLine> list = new List<Graph3D.cLine>();
				for (int i = 0; i < 3; i++)
				{
					Graph3D.cLine cLine = new Graph3D.cLine();
					cLine.mi_Pen = this.mi_AxisPens[i];
					switch (i)
					{
					case 0:
						cLine.mi_Points3D[0].md_X = Math.Min(0.0, this.mi_MinMax.md_MinX * 1.1);
						cLine.mi_Points3D[0].md_Y = Math.Min(0.0, this.mi_MinMax.md_MinY * 1.1);
						cLine.mi_Points3D[1].md_Y = Math.Min(0.0, this.mi_MinMax.md_MinY * 1.1);
						cLine.me_Line = Graph3D.eCoord.X;
						cLine.me_Offset = Graph3D.eCoord.X;
						break;
					case 1:
						cLine.mi_Points3D[0].md_Y = Math.Min(0.0, this.mi_MinMax.md_MinY * 1.1);
						cLine.mi_Points3D[0].md_X = Math.Min(0.0, this.mi_MinMax.md_MinX * 1.1);
						cLine.mi_Points3D[1].md_X = Math.Min(0.0, this.mi_MinMax.md_MinX * 1.1);
						cLine.me_Line = Graph3D.eCoord.Y;
						cLine.me_Offset = Graph3D.eCoord.Z;
						break;
					}
					cLine.mi_Points2D[0] = this.mi_Transform.Project(cLine.mi_Points3D[0], this.mi_MinMax.mi_Center3D);
					cLine.mi_Points2D[1] = this.mi_Transform.Project(cLine.mi_Points3D[1], this.mi_MinMax.mi_Center3D);
					list.Add(cLine);
				}
				this.mi_Quadrant = new Graph3D.cQuadrant(this.mi_Mouse.md_Phi, list[0], list[1], list[2]);
				bool flag2 = this.me_Raster >= Graph3D.eRaster.Raster;
				if (flag2)
				{
					for (int j = 0; j < 3; j++)
					{
						Graph3D.eCoord eCoord = (Graph3D.eCoord)j;
						Graph3D.eCoord eCoord2 = (j + Graph3D.eCoord.Y) % (Graph3D.eCoord)3;
						for (int k = 0; k < 2; k++)
						{
							Graph3D.cLine cLine2 = list[(int)eCoord];
							Graph3D.cLine cLine3 = list[(int)eCoord2];
							double value = cLine3.mi_Points3D[0].GetValue(eCoord2);
							double value2 = cLine3.mi_Points3D[1].GetValue(eCoord2);
							double num = this.CalculateInterval(value2 - value);
							for (int l = -11; l < 11; l++)
							{
								double num2 = num * (double)l;
								bool flag3 = num2 < value || num2 > value2;
								if (!flag3)
								{
									Graph3D.cLine cLine4 = new Graph3D.cLine();
									cLine4.mi_Pen = this.mi_RasterPens[(int)eCoord2];
									cLine4.me_Line = eCoord;
									cLine4.me_Offset = eCoord2;
									cLine4.md_Label = num2;
									cLine4.mi_Points3D[0] = cLine2.mi_Points3D[0].Clone();
									cLine4.mi_Points3D[1] = cLine2.mi_Points3D[1].Clone();
									cLine4.mi_Points3D[0].SetValue(eCoord2, num2);
									cLine4.mi_Points3D[1].SetValue(eCoord2, num2);
									bool flag4 = cLine4.CoordEquals(list[0]) || cLine4.CoordEquals(list[1]) || cLine4.CoordEquals(list[2]);
									if (!flag4)
									{
										bool flag5 = (eCoord == Graph3D.eCoord.X && eCoord2 == Graph3D.eCoord.Z) || (eCoord == Graph3D.eCoord.Z && eCoord2 == Graph3D.eCoord.X);
										if (flag5)
										{
											cLine4.md_Sort = this.mi_Quadrant.md_SortXZ;
										}
										else
										{
											bool flag6 = (eCoord == Graph3D.eCoord.Z && eCoord2 == Graph3D.eCoord.Y) || (eCoord == Graph3D.eCoord.Y && eCoord2 == Graph3D.eCoord.Z);
											if (flag6)
											{
												cLine4.md_Sort = this.mi_Quadrant.md_SortYZ;
											}
											else
											{
												cLine4.md_Sort = this.mi_Quadrant.md_SortXY;
												Graph3D.cLine cLine5 = list[2];
												cLine4.mi_Points3D[0].md_Z = cLine5.mi_Points3D[0].md_Z;
												cLine4.mi_Points3D[1].md_Z = cLine5.mi_Points3D[0].md_Z;
											}
										}
										list.Add(cLine4);
									}
								}
							}
							Graph3D.eCoord eCoord3 = eCoord;
							eCoord = eCoord2;
							eCoord2 = eCoord3;
						}
					}
				}
				foreach (Graph3D.cLine cLine6 in list)
				{
					cLine6.mi_Points2D[0] = this.mi_Transform.Project(cLine6.mi_Points3D[0], this.mi_MinMax.mi_Center3D);
					cLine6.mi_Points2D[1] = this.mi_Transform.Project(cLine6.mi_Points3D[1], this.mi_MinMax.mi_Center3D);
					this.AddDrawObject(new Graph3D.cDrawObj(cLine6, cLine6.md_Sort));
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000036FC File Offset: 0x000018FC
		private void CreatePolygons()
		{
			Graph3D.cPoint2D[,] array = new Graph3D.cPoint2D[this.mi_PolyArr.GetLength(0), this.mi_PolyArr.GetLength(1)];
			for (int i = 0; i < this.mi_PolyArr.GetLength(0); i++)
			{
				for (int j = 0; j < this.mi_PolyArr.GetLength(1); j++)
				{
					array[i, j] = this.mi_Transform.Project(this.mi_PolyArr[i, j], this.mi_MinMax.mi_Center3D);
				}
			}
			for (int k = 0; k < this.mi_PolyArr.GetLength(0) - 1; k++)
			{
				for (int l = 0; l < this.mi_PolyArr.GetLength(1) - 1; l++)
				{
					Graph3D.cPolygon cPolygon = new Graph3D.cPolygon(new Graph3D.cPoint2D[]
					{
						array[k, l],
						array[k, l + 1],
						array[k + 1, l + 1],
						array[k + 1, l]
					});
					double md_Z = this.mi_PolyArr[k, l].md_Z;
					double md_Z2 = this.mi_PolyArr[k, l + 1].md_Z;
					double md_Z3 = this.mi_PolyArr[k + 1, l + 1].md_Z;
					double md_Z4 = this.mi_PolyArr[k + 1, l].md_Z;
					double num = (md_Z + md_Z2 + md_Z3 + md_Z4) / 4.0;
					cPolygon.md_FactorZ = (num - this.mi_MinMax.md_MinZ) / (this.mi_MinMax.md_MaxZ - this.mi_MinMax.md_MinZ);
					double d_Sort = this.mi_Transform.ProjectXY((double)(k + 1), (double)(l + 1));
					this.AddDrawObject(new Graph3D.cDrawObj(cPolygon, d_Sort));
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000038FC File Offset: 0x00001AFC
		private void CreateScatterDots()
		{
			foreach (Graph3D.cScatter cScatter in this.mi_ScatterArr)
			{
				cScatter.SetPoint2D(this.mi_Transform.Project(cScatter.mi_Point3D, this.mi_MinMax.mi_Center3D));
				bool flag = cScatter.mi_Brush == null;
				if (flag)
				{
					cScatter.md_FactorZ = (cScatter.mi_Point3D.md_Z - this.mi_MinMax.md_MinZ) / (this.mi_MinMax.md_MaxZ - this.mi_MinMax.md_MinZ);
				}
				double d_Sort = this.mi_Transform.ProjectXY(cScatter.mi_Point3D.md_X + 1.0, cScatter.mi_Point3D.md_Y + 1.0);
				this.AddDrawObject(new Graph3D.cDrawObj(cScatter, d_Sort));
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000039D8 File Offset: 0x00001BD8
		private void AddDrawObject(Graph3D.cDrawObj i_DrawObj)
		{
			int i;
			for (i = 0; i < this.mi_DrawObjects.Count; i++)
			{
				bool flag = this.mi_DrawObjects[i].md_Sort > i_DrawObj.md_Sort;
				if (flag)
				{
					break;
				}
			}
			this.mi_DrawObjects.Insert(i, i_DrawObj);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003A30 File Offset: 0x00001C30
		private Brush GetSchemeBrush(double d_FactorZ)
		{
			bool flag = this.mi_SchemeBrushes == null || double.IsNaN(d_FactorZ);
			Brush result;
			if (flag)
			{
				result = Brushes.Goldenrod;
			}
			else
			{
				d_FactorZ = Math.Min(1.0, d_FactorZ);
				d_FactorZ = Math.Max(0.0, d_FactorZ);
				int num = (int)(d_FactorZ * (double)(this.mi_SchemeBrushes.Length - 1));
				result = this.mi_SchemeBrushes[num];
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003A98 File Offset: 0x00001C98
		private Pen GetSchemePen(double d_FactorZ)
		{
			bool flag = this.mi_SchemePens == null || double.IsNaN(d_FactorZ);
			Pen result;
			if (flag)
			{
				result = Pens.Goldenrod;
			}
			else
			{
				d_FactorZ = Math.Min(1.0, d_FactorZ);
				d_FactorZ = Math.Max(0.0, d_FactorZ);
				int num = (int)(d_FactorZ * (double)(this.mi_SchemePens.Length - 1));
				result = this.mi_SchemePens[num];
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003B00 File Offset: 0x00001D00
		private void SetAxisColor(Graph3D.eCoord e_Coord, Color c_Color)
		{
			this.mi_AxisBrushes[(int)e_Coord] = new SolidBrush(c_Color);
			this.mi_AxisPens[(int)e_Coord] = new Pen(c_Color, 3f);
			this.mi_RasterPens[(int)e_Coord] = new Pen(this.BrightenColor(c_Color), 1f);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003B40 File Offset: 0x00001D40
		private Color BrightenColor(Color c_Color)
		{
			int red = (int)(c_Color.R + (byte.MaxValue - c_Color.R) / 2);
			int green = (int)(c_Color.G + (byte.MaxValue - c_Color.G) / 2);
			int blue = (int)(c_Color.B + (byte.MaxValue - c_Color.B) / 2);
			return Color.FromArgb(255, red, green, blue);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003BA8 File Offset: 0x00001DA8
		private double CalculateInterval(double d_Range)
		{
			double num = Math.Pow(10.0, Math.Floor(Math.Log10(d_Range)));
			bool flag = d_Range / num >= 5.0;
			double result;
			if (flag)
			{
				result = num;
			}
			else
			{
				bool flag2 = d_Range / (num / 2.0) >= 5.0;
				if (flag2)
				{
					result = num / 2.0;
				}
				else
				{
					result = num / 5.0;
				}
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003C28 File Offset: 0x00001E28
		private string FormatLabel(double d_Label)
		{
			return d_Label.ToString("0.000", CultureInfo.InvariantCulture).TrimEnd(new char[]
			{
				'0'
			}).TrimEnd(new char[]
			{
				'.'
			});
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003C6B File Offset: 0x00001E6B
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003C6E File Offset: 0x00001E6E
		protected override void OnPaint(PaintEventArgs e)
		{
			this.Draw(e.Graphics);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003C80 File Offset: 0x00001E80
		public Bitmap GetScreenshot()
		{
			Bitmap bitmap = new Bitmap(base.ClientSize.Width, base.ClientSize.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				this.Draw(graphics);
			}
			return bitmap;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003CE4 File Offset: 0x00001EE4
		private void Draw(Graphics i_Graph)
		{
			bool flag = this.mi_DrawObjects.Count == 0;
			if (flag)
			{
				this.CreateCoordinateSystem(i_Graph);
				bool flag2 = this.mi_PolyArr != null;
				if (flag2)
				{
					this.CreatePolygons();
				}
				bool flag3 = this.mi_ScatterArr != null;
				if (flag3)
				{
					this.CreateScatterDots();
				}
			}
			i_Graph.Clear(this.BackColor);
			int num = 4;
			int num2 = base.ClientSize.Height - this.Font.Height - 4;
			for (int i = 2; i >= 0; i--)
			{
				bool flag4 = string.IsNullOrEmpty(this.ms_AxisLegends[i]);
				if (!flag4)
				{
					string s = string.Format("{0}: {1}", (Graph3D.eCoord)i, this.ms_AxisLegends[i]);
					i_Graph.DrawString(s, this.Font, this.mi_AxisBrushes[i], (float)num, (float)num2);
					num2 -= this.Font.Height;
				}
			}
			bool flag5 = this.mi_TopLegendBrush != null;
			if (flag5)
			{
				string[] array = new string[]
				{
					"Rotation:",
					"Elevation:",
					"Distance:"
				};
				string[] array2 = new string[]
				{
					string.Format("{0:+#;-#;0}°", (int)this.mi_Mouse.md_Phi),
					string.Format("{0:+#;-#;0}°", (int)this.mi_Mouse.md_Theta),
					string.Format("{0}", (int)this.mi_Mouse.md_Rho)
				};
				SizeF sizeF = i_Graph.MeasureString(array[1], this.Font);
				num = 4;
				num2 = 3;
				for (int j = 0; j < 3; j++)
				{
					i_Graph.DrawString(array[j], this.Font, this.mi_TopLegendBrush, (float)num, (float)num2);
					i_Graph.DrawString(array2[j], this.Font, this.mi_TopLegendBrush, (float)num + sizeF.Width, (float)num2);
					num2 += this.Font.Height;
				}
			}
			i_Graph.TranslateTransform((float)(this.mi_Mouse.mk_Offset.X + this.mk_Offset2D.X), (float)(this.mi_Mouse.mk_Offset.Y + this.mk_Offset2D.Y));
			SmoothingMode smoothingMode = SmoothingMode.Invalid;
			foreach (Graph3D.cDrawObj cDrawObj in this.mi_DrawObjects)
			{
				bool flag6 = !cDrawObj.IsValid;
				if (!flag6)
				{
					bool flag7 = cDrawObj.mi_Polygon != null;
					if (flag7)
					{
						bool flag8 = smoothingMode != SmoothingMode.None;
						if (flag8)
						{
							smoothingMode = SmoothingMode.None;
							i_Graph.SmoothingMode = SmoothingMode.None;
						}
						Graph3D.cPolygon mi_Polygon = cDrawObj.mi_Polygon;
						Brush schemeBrush = this.GetSchemeBrush(mi_Polygon.md_FactorZ);
						i_Graph.FillPolygon(schemeBrush, mi_Polygon.mk_Points);
						bool flag9 = this.mi_PolyLinePen != null;
						if (flag9)
						{
							i_Graph.DrawPolygon(this.mi_PolyLinePen, mi_Polygon.mk_Points);
						}
					}
					else
					{
						bool flag10 = cDrawObj.mi_Scatter != null;
						if (flag10)
						{
							bool flag11 = smoothingMode != SmoothingMode.AntiAlias;
							if (flag11)
							{
								smoothingMode = SmoothingMode.AntiAlias;
								i_Graph.SmoothingMode = SmoothingMode.AntiAlias;
							}
							Graph3D.cScatter mi_Scatter = cDrawObj.mi_Scatter;
							bool mb_Combine = mi_Scatter.mb_Combine;
							if (mb_Combine)
							{
								bool flag12 = mi_Scatter.mi_Previous != null;
								if (flag12)
								{
									Pen pen = mi_Scatter.mi_Pen;
									bool flag13 = pen == null;
									if (flag13)
									{
										pen = this.GetSchemePen(mi_Scatter.md_FactorZ);
									}
									i_Graph.DrawLine(pen, mi_Scatter.mi_Previous.mk_Point, mi_Scatter.mk_Point);
								}
							}
							else
							{
								Brush brush = mi_Scatter.mi_Brush;
								bool flag14 = brush == null;
								if (flag14)
								{
									brush = this.GetSchemeBrush(mi_Scatter.md_FactorZ);
								}
								i_Graph.FillEllipse(brush, mi_Scatter.mk_Point.X, mi_Scatter.mk_Point.Y, 6f, 6f);
							}
						}
						else
						{
							bool flag15 = smoothingMode != SmoothingMode.AntiAlias;
							if (flag15)
							{
								smoothingMode = SmoothingMode.AntiAlias;
								i_Graph.SmoothingMode = SmoothingMode.AntiAlias;
							}
							Graph3D.cLine mi_Line = cDrawObj.mi_Line;
							i_Graph.DrawLine(mi_Line.mi_Pen, mi_Line.mi_Points2D[0].Coord, mi_Line.mi_Points2D[1].Coord);
						}
					}
				}
			}
			bool flag16 = this.mi_BorderPen != null;
			if (flag16)
			{
				i_Graph.ResetTransform();
				Rectangle clientRectangle = base.ClientRectangle;
				i_Graph.DrawRectangle(this.mi_BorderPen, clientRectangle.X, clientRectangle.Y, clientRectangle.Width - 1, clientRectangle.Height - 1);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000041A4 File Offset: 0x000023A4
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.mi_Mouse.mk_LastPos = e.Location;
			bool flag = this.mi_DrawObjects.Count == 0;
			if (!flag)
			{
				Keys modifierKeys = Control.ModifierKeys;
				Keys keys = modifierKeys;
				if (keys != Keys.None)
				{
					if (keys != Keys.Shift)
					{
						if (keys == Keys.Control)
						{
							bool flag2 = e.Button == MouseButtons.Left;
							if (flag2)
							{
								this.Cursor = Cursors.SizeNS;
								this.mi_Mouse.me_Action = Graph3D.eMouseAction.Rho;
							}
						}
					}
					else
					{
						bool flag3 = e.Button == MouseButtons.Left;
						if (flag3)
						{
							this.Cursor = Cursors.NoMove2D;
							this.mi_Mouse.me_Action = Graph3D.eMouseAction.Move;
						}
					}
				}
				else
				{
					bool flag4 = e.Button == MouseButtons.Left;
					if (flag4)
					{
						this.Cursor = Cursors.NoMoveVert;
						this.mi_Mouse.me_Action = Graph3D.eMouseAction.Theta;
					}
					bool flag5 = e.Button == MouseButtons.Right;
					if (flag5)
					{
						this.Cursor = Cursors.NoMoveHoriz;
						this.mi_Mouse.me_Action = Graph3D.eMouseAction.Phi;
					}
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000042C1 File Offset: 0x000024C1
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.mi_Mouse.me_Action = Graph3D.eMouseAction.None;
			this.Cursor = Cursors.Arrow;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000042E4 File Offset: 0x000024E4
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.mi_Mouse.me_Action = Graph3D.eMouseAction.None;
			this.Cursor = Cursors.Arrow;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004308 File Offset: 0x00002508
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			base.OnMouseWheel(e);
			bool flag = this.mi_Mouse.OnMouseWheel(e.Delta);
			if (flag)
			{
				this.mi_Transform.SetCoeficients(this.mi_Mouse);
				this.mi_DrawObjects.Clear();
				base.Invalidate();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000435C File Offset: 0x0000255C
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			int num = e.X - this.mi_Mouse.mk_LastPos.X;
			int num2 = e.Y - this.mi_Mouse.mk_LastPos.Y;
			this.mi_Mouse.mk_LastPos = e.Location;
			Graph3D.eMouseAction me_Action = this.mi_Mouse.me_Action;
			Graph3D.eMouseAction eMouseAction = me_Action;
			if (eMouseAction != Graph3D.eMouseAction.Move)
			{
				if (eMouseAction - Graph3D.eMouseAction.Rho <= 2)
				{
					this.mi_Mouse.OnMouseMove(num, num2);
					this.mi_Transform.SetCoeficients(this.mi_Mouse);
					this.mi_DrawObjects.Clear();
					base.Invalidate();
				}
			}
			else
			{
				Graph3D.cMouse cMouse = this.mi_Mouse;
				cMouse.mk_Offset.X = cMouse.mk_Offset.X + num;
				Graph3D.cMouse cMouse2 = this.mi_Mouse;
				cMouse2.mk_Offset.Y = cMouse2.mk_Offset.Y + num2;
				base.Invalidate();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000443F File Offset: 0x0000263F
		private void OnTrackbarScroll(object sender, EventArgs e)
		{
			this.mi_Mouse.OnTrackBarScroll();
			this.mi_Transform.SetCoeficients(this.mi_Mouse);
			this.mi_DrawObjects.Clear();
			base.Invalidate();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004473 File Offset: 0x00002673
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.mi_Transform.SetSize(base.ClientSize);
			this.mi_DrawObjects.Clear();
			base.Invalidate();
		}

		// Token: 0x04000002 RID: 2
		private static readonly double[] VALUES_RHO = new double[]
		{
			300.0,
			1800.0,
			1800.0,
			2.0
		};

		// Token: 0x04000003 RID: 3
		private static readonly double[] VALUES_THETA = new double[]
		{
			10.0,
			170.0,
			61.0,
			0.25
		};

		// Token: 0x04000004 RID: 4
		private static readonly double[] VALUES_PHI = new double[]
		{
			0.0,
			360.0,
			245.0,
			0.4
		};

		// Token: 0x04000005 RID: 5
		private const double AXIS_EXCESS = 1.1;

		// Token: 0x04000006 RID: 6
		private const int VERT_OFFSET = -30;

		// Token: 0x04000007 RID: 7
		private const int SCATTER_SIZE = 3;

		// Token: 0x04000008 RID: 8
		private Graph3D.eRaster me_Raster = Graph3D.eRaster.Off;

		// Token: 0x04000009 RID: 9
		private Pen[] mi_AxisPens = new Pen[3];

		// Token: 0x0400000A RID: 10
		private Pen[] mi_RasterPens = new Pen[3];

		// Token: 0x0400000B RID: 11
		private Graph3D.cTransform mi_Transform = new Graph3D.cTransform();

		// Token: 0x0400000C RID: 12
		private List<Graph3D.cDrawObj> mi_DrawObjects = new List<Graph3D.cDrawObj>();

		// Token: 0x0400000D RID: 13
		private Graph3D.cMouse mi_Mouse = new Graph3D.cMouse();

		// Token: 0x0400000E RID: 14
		private Point mk_Offset2D = default(Point);

		// Token: 0x0400000F RID: 15
		private string[] ms_AxisLegends = new string[3];

		// Token: 0x04000010 RID: 16
		private SolidBrush[] mi_AxisBrushes = new SolidBrush[3];

		// Token: 0x04000011 RID: 17
		private Pen mi_PolyLinePen;

		// Token: 0x04000012 RID: 18
		private Pen mi_BorderPen;

		// Token: 0x04000013 RID: 19
		private SolidBrush mi_TopLegendBrush;

		// Token: 0x04000014 RID: 20
		private SolidBrush[] mi_SchemeBrushes;

		// Token: 0x04000015 RID: 21
		private Pen[] mi_SchemePens;

		// Token: 0x04000016 RID: 22
		private Graph3D.cPoint3D[,] mi_PolyArr;

		// Token: 0x04000017 RID: 23
		private Graph3D.cScatter[] mi_ScatterArr;

		// Token: 0x04000018 RID: 24
		private Graph3D.cMinMax3D mi_MinMax;

		// Token: 0x04000019 RID: 25
		private Graph3D.cQuadrant mi_Quadrant;

		// Token: 0x0400001A RID: 26
		private int ms32_Points;

		// Token: 0x02000025 RID: 37
		public enum eRaster
		{
			// Token: 0x0400028E RID: 654
			Raster,
			// Token: 0x0400028F RID: 655
			Off,
			// Token: 0x04000290 RID: 656
			MainAxis
		}

		// Token: 0x02000026 RID: 38
		public enum eNormalize
		{
			// Token: 0x04000292 RID: 658
			Separate,
			// Token: 0x04000293 RID: 659
			MaintainXY,
			// Token: 0x04000294 RID: 660
			MaintainXYZ
		}

		// Token: 0x02000027 RID: 39
		public enum eCoord
		{
			// Token: 0x04000296 RID: 662
			X,
			// Token: 0x04000297 RID: 663
			Y,
			// Token: 0x04000298 RID: 664
			Z
		}

		// Token: 0x02000028 RID: 40
		private enum eMouseAction
		{
			// Token: 0x0400029A RID: 666
			None,
			// Token: 0x0400029B RID: 667
			Move,
			// Token: 0x0400029C RID: 668
			Rho,
			// Token: 0x0400029D RID: 669
			Theta,
			// Token: 0x0400029E RID: 670
			Phi
		}

		// Token: 0x02000029 RID: 41
		private class cMouse
		{
			// Token: 0x060002C3 RID: 707 RVA: 0x00048FB0 File Offset: 0x000471B0
			public void AssignTrackbar(Graph3D.eMouseAction e_Trackbar, TrackBar i_Trackbar, EventHandler i_OnScroll)
			{
				bool flag = i_Trackbar == null;
				if (!flag)
				{
					double[] array = null;
					switch (e_Trackbar)
					{
					case Graph3D.eMouseAction.Rho:
						array = Graph3D.VALUES_RHO;
						this.mi_TrackRho = i_Trackbar;
						break;
					case Graph3D.eMouseAction.Theta:
						array = Graph3D.VALUES_THETA;
						this.mi_TrackTheta = i_Trackbar;
						break;
					case Graph3D.eMouseAction.Phi:
						array = Graph3D.VALUES_PHI;
						this.mi_TrackPhi = i_Trackbar;
						break;
					}
					i_Trackbar.Minimum = (int)array[0];
					i_Trackbar.Maximum = (int)array[1];
					i_Trackbar.Value = (int)array[2];
					i_Trackbar.Scroll += i_OnScroll;
				}
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0004903C File Offset: 0x0004723C
			public void OnTrackBarScroll()
			{
				bool flag = this.mi_TrackRho != null;
				if (flag)
				{
					this.md_Rho = (double)this.mi_TrackRho.Value;
				}
				bool flag2 = this.mi_TrackTheta != null;
				if (flag2)
				{
					this.md_Theta = (double)this.mi_TrackTheta.Value;
				}
				bool flag3 = this.mi_TrackPhi != null;
				if (flag3)
				{
					this.md_Phi = (double)this.mi_TrackPhi.Value;
				}
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x000490A8 File Offset: 0x000472A8
			public bool OnMouseWheel(int s32_Delta)
			{
				bool flag = this.me_Action > Graph3D.eMouseAction.None;
				bool result;
				if (flag)
				{
					result = false;
				}
				else
				{
					this.me_Action = Graph3D.eMouseAction.Rho;
					this.OnMouseMove(0, s32_Delta / 10);
					this.me_Action = Graph3D.eMouseAction.None;
					result = true;
				}
				return result;
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x000490E8 File Offset: 0x000472E8
			public void OnMouseMove(int s32_DiffX, int s32_DiffY)
			{
				switch (this.me_Action)
				{
				case Graph3D.eMouseAction.Rho:
					this.md_Rho += (double)s32_DiffY * Graph3D.VALUES_RHO[3];
					this.SetRho(this.md_Rho);
					break;
				case Graph3D.eMouseAction.Theta:
					this.md_Theta -= (double)s32_DiffY * Graph3D.VALUES_THETA[3];
					this.SetTheta(this.md_Theta);
					break;
				case Graph3D.eMouseAction.Phi:
					this.md_Phi -= (double)s32_DiffX * Graph3D.VALUES_PHI[3];
					this.SetPhi(this.md_Phi);
					break;
				}
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x00049188 File Offset: 0x00047388
			public void SetRho(double d_Rho)
			{
				this.md_Rho = d_Rho;
				this.md_Rho = Math.Max(this.md_Rho, Graph3D.VALUES_RHO[0]);
				this.md_Rho = Math.Min(this.md_Rho, Graph3D.VALUES_RHO[1]);
				bool flag = this.mi_TrackRho != null;
				if (flag)
				{
					this.mi_TrackRho.Value = (int)this.md_Rho;
				}
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x000491F0 File Offset: 0x000473F0
			public void SetTheta(double d_Theta)
			{
				this.md_Theta = d_Theta;
				this.md_Theta = Math.Max(this.md_Theta, Graph3D.VALUES_THETA[0]);
				this.md_Theta = Math.Min(this.md_Theta, Graph3D.VALUES_THETA[1]);
				bool flag = this.mi_TrackTheta != null;
				if (flag)
				{
					this.mi_TrackTheta.Value = (int)this.md_Theta;
				}
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x00049258 File Offset: 0x00047458
			public void SetPhi(double d_Phi)
			{
				this.md_Phi = d_Phi;
				bool flag = this.md_Phi > 360.0;
				if (flag)
				{
					this.md_Phi -= 360.0;
				}
				bool flag2 = this.md_Phi < 0.0;
				if (flag2)
				{
					this.md_Phi += 360.0;
				}
				bool flag3 = this.mi_TrackPhi != null;
				if (flag3)
				{
					this.mi_TrackPhi.Value = (int)this.md_Phi;
				}
			}

			// Token: 0x0400029F RID: 671
			public Graph3D.eMouseAction me_Action;

			// Token: 0x040002A0 RID: 672
			public Point mk_LastPos;

			// Token: 0x040002A1 RID: 673
			public Point mk_Offset;

			// Token: 0x040002A2 RID: 674
			public TrackBar mi_TrackRho;

			// Token: 0x040002A3 RID: 675
			public TrackBar mi_TrackTheta;

			// Token: 0x040002A4 RID: 676
			public TrackBar mi_TrackPhi;

			// Token: 0x040002A5 RID: 677
			public double md_Rho = Graph3D.VALUES_RHO[2];

			// Token: 0x040002A6 RID: 678
			public double md_Theta = Graph3D.VALUES_THETA[2];

			// Token: 0x040002A7 RID: 679
			public double md_Phi = Graph3D.VALUES_PHI[2];
		}

		// Token: 0x0200002A RID: 42
		public class cPoint3D
		{
			// Token: 0x060002CB RID: 715 RVA: 0x00048E1A File Offset: 0x0004701A
			public cPoint3D()
			{
			}

			// Token: 0x060002CC RID: 716 RVA: 0x00049313 File Offset: 0x00047513
			public cPoint3D(double X, double Y, double Z)
			{
				this.md_X = X;
				this.md_Y = Y;
				this.md_Z = Z;
			}

			// Token: 0x060002CD RID: 717 RVA: 0x00049334 File Offset: 0x00047534
			public Graph3D.cPoint3D Clone()
			{
				return new Graph3D.cPoint3D(this.md_X, this.md_Y, this.md_Z);
			}

			// Token: 0x060002CE RID: 718 RVA: 0x00049360 File Offset: 0x00047560
			public bool Equals(Graph3D.cPoint3D i_Point)
			{
				return this.md_X == i_Point.md_X && this.md_Y == i_Point.md_Y && this.md_Z == i_Point.md_Z;
			}

			// Token: 0x060002CF RID: 719 RVA: 0x000493A0 File Offset: 0x000475A0
			public double GetValue(Graph3D.eCoord e_Coord)
			{
				double result;
				switch (e_Coord)
				{
				case Graph3D.eCoord.X:
					result = this.md_X;
					break;
				case Graph3D.eCoord.Y:
					result = this.md_Y;
					break;
				case Graph3D.eCoord.Z:
					result = this.md_Z;
					break;
				default:
					result = 0.0;
					break;
				}
				return result;
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x000493F0 File Offset: 0x000475F0
			public void SetValue(Graph3D.eCoord e_Coord, double d_Value)
			{
				switch (e_Coord)
				{
				case Graph3D.eCoord.X:
					this.md_X = d_Value;
					break;
				case Graph3D.eCoord.Y:
					this.md_Y = d_Value;
					break;
				case Graph3D.eCoord.Z:
					this.md_Z = d_Value;
					break;
				}
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x00049434 File Offset: 0x00047634
			public override string ToString()
			{
				return string.Format("{0:0.00}, {1:0.00}, {2:0.00}", this.md_X, this.md_Y, this.md_Z);
			}

			// Token: 0x040002A8 RID: 680
			public double md_X;

			// Token: 0x040002A9 RID: 681
			public double md_Y;

			// Token: 0x040002AA RID: 682
			public double md_Z;
		}

		// Token: 0x0200002B RID: 43
		public class cPoint2D
		{
			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060002D2 RID: 722 RVA: 0x00049474 File Offset: 0x00047674
			public PointF Coord
			{
				get
				{
					return new PointF((float)this.md_X, (float)this.md_Y);
				}
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0004949C File Offset: 0x0004769C
			public override string ToString()
			{
				return string.Format("{0:0.00}, {1:0.00}", this.md_X, this.md_Y);
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060002D4 RID: 724 RVA: 0x000494D0 File Offset: 0x000476D0
			public bool IsValid
			{
				get
				{
					return !double.IsNaN(this.md_X) && Math.Abs(this.md_X) < 9999.9 && !double.IsNaN(this.md_Y) && Math.Abs(this.md_Y) < 9999.9;
				}
			}

			// Token: 0x040002AB RID: 683
			public double md_X;

			// Token: 0x040002AC RID: 684
			public double md_Y;
		}

		// Token: 0x0200002C RID: 44
		private class cMinMax3D
		{
			// Token: 0x060002D6 RID: 726 RVA: 0x0004952C File Offset: 0x0004772C
			public cMinMax3D(Graph3D.cPoint3D[,] i_Points3D)
			{
				for (int i = 0; i < i_Points3D.GetLength(0); i++)
				{
					for (int j = 0; j < i_Points3D.GetLength(1); j++)
					{
						Graph3D.cPoint3D cPoint3D = i_Points3D[i, j];
						this.md_MinX = Math.Min(this.md_MinX, cPoint3D.md_X);
						this.md_MaxX = Math.Max(this.md_MaxX, cPoint3D.md_X);
						this.md_MinY = Math.Min(this.md_MinY, cPoint3D.md_Y);
						this.md_MaxY = Math.Max(this.md_MaxY, cPoint3D.md_Y);
						this.md_MinZ = Math.Min(this.md_MinZ, cPoint3D.md_Z);
						this.md_MaxZ = Math.Max(this.md_MaxZ, cPoint3D.md_Z);
					}
				}
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00049678 File Offset: 0x00047878
			public cMinMax3D(Graph3D.cScatter[] i_ScatterArr)
			{
				foreach (Graph3D.cScatter cScatter in i_ScatterArr)
				{
					Graph3D.cPoint3D mi_Point3D = cScatter.mi_Point3D;
					this.md_MinX = Math.Min(this.md_MinX, mi_Point3D.md_X);
					this.md_MaxX = Math.Max(this.md_MaxX, mi_Point3D.md_X);
					this.md_MinY = Math.Min(this.md_MinY, mi_Point3D.md_Y);
					this.md_MaxY = Math.Max(this.md_MaxY, mi_Point3D.md_Y);
					this.md_MinZ = Math.Min(this.md_MinZ, mi_Point3D.md_Z);
					this.md_MaxZ = Math.Max(this.md_MaxZ, mi_Point3D.md_Z);
				}
			}

			// Token: 0x040002AD RID: 685
			public double md_MinX = double.PositiveInfinity;

			// Token: 0x040002AE RID: 686
			public double md_MaxX = double.NegativeInfinity;

			// Token: 0x040002AF RID: 687
			public double md_MinY = double.PositiveInfinity;

			// Token: 0x040002B0 RID: 688
			public double md_MaxY = double.NegativeInfinity;

			// Token: 0x040002B1 RID: 689
			public double md_MinZ = double.PositiveInfinity;

			// Token: 0x040002B2 RID: 690
			public double md_MaxZ = double.NegativeInfinity;

			// Token: 0x040002B3 RID: 691
			public Graph3D.cPoint3D mi_Center3D = new Graph3D.cPoint3D();
		}

		// Token: 0x0200002D RID: 45
		private class cLine
		{
			// Token: 0x060002D8 RID: 728 RVA: 0x000497A0 File Offset: 0x000479A0
			public bool CoordEquals(Graph3D.cLine i_Line)
			{
				return this.mi_Points3D[0].Equals(i_Line.mi_Points3D[0]) && this.mi_Points3D[1].Equals(i_Line.mi_Points3D[1]);
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x000497E4 File Offset: 0x000479E4
			public bool IsValid
			{
				get
				{
					return this.mi_Points2D[0].IsValid && this.mi_Points2D[1].IsValid;
				}
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00049818 File Offset: 0x00047A18
			public void CalcAngle2D()
			{
				double x = this.mi_Points2D[1].md_X - this.mi_Points2D[0].md_X;
				double y = this.mi_Points2D[1].md_Y - this.mi_Points2D[0].md_Y;
				this.md_Angle = Math.Atan2(y, x) * 180.0 / 3.1415926535897931;
				bool flag = this.md_Angle < 0.0;
				if (flag)
				{
					this.md_Angle += 360.0;
				}
			}

			// Token: 0x040002B4 RID: 692
			public Graph3D.eCoord me_Line;

			// Token: 0x040002B5 RID: 693
			public Graph3D.eCoord me_Offset;

			// Token: 0x040002B6 RID: 694
			public double md_Label;

			// Token: 0x040002B7 RID: 695
			public Pen mi_Pen;

			// Token: 0x040002B8 RID: 696
			public double md_Sort;

			// Token: 0x040002B9 RID: 697
			public double md_Angle;

			// Token: 0x040002BA RID: 698
			public Graph3D.cPoint3D[] mi_Points3D = new Graph3D.cPoint3D[]
			{
				new Graph3D.cPoint3D(),
				new Graph3D.cPoint3D()
			};

			// Token: 0x040002BB RID: 699
			public Graph3D.cPoint2D[] mi_Points2D = new Graph3D.cPoint2D[]
			{
				new Graph3D.cPoint2D(),
				new Graph3D.cPoint2D()
			};
		}

		// Token: 0x0200002E RID: 46
		private class cPolygon
		{
			// Token: 0x060002DC RID: 732 RVA: 0x000498F8 File Offset: 0x00047AF8
			public cPolygon(params Graph3D.cPoint2D[] i_Points2D)
			{
				this.mb_Valid = true;
				this.mk_Points = new PointF[i_Points2D.Length];
				for (int i = 0; i < i_Points2D.Length; i++)
				{
					bool isValid = i_Points2D[i].IsValid;
					if (isValid)
					{
						this.mk_Points[i] = i_Points2D[i].Coord;
					}
					else
					{
						this.mb_Valid = false;
					}
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060002DD RID: 733 RVA: 0x00049960 File Offset: 0x00047B60
			public bool IsValid
			{
				get
				{
					return this.mb_Valid;
				}
			}

			// Token: 0x040002BC RID: 700
			public PointF[] mk_Points;

			// Token: 0x040002BD RID: 701
			public double md_FactorZ;

			// Token: 0x040002BE RID: 702
			private bool mb_Valid;
		}

		// Token: 0x0200002F RID: 47
		public class cScatter
		{
			// Token: 0x060002DE RID: 734 RVA: 0x00049978 File Offset: 0x00047B78
			public cScatter(double X, double Y, double Z, Brush i_Brush)
			{
				this.mi_Point3D = new Graph3D.cPoint3D(X, Y, Z);
				this.mi_Brush = i_Brush;
			}

			// Token: 0x060002DF RID: 735 RVA: 0x00049998 File Offset: 0x00047B98
			public void SetPoint2D(Graph3D.cPoint2D i_Point2D)
			{
				this.mk_Point = i_Point2D.Coord;
				this.mb_Valid = i_Point2D.IsValid;
				this.mk_Point.X = this.mk_Point.X - 3f;
				this.mk_Point.Y = this.mk_Point.Y - 3f;
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060002E0 RID: 736 RVA: 0x000499F0 File Offset: 0x00047BF0
			public bool IsValid
			{
				get
				{
					return this.mb_Valid;
				}
			}

			// Token: 0x040002BF RID: 703
			public Graph3D.cPoint3D mi_Point3D;

			// Token: 0x040002C0 RID: 704
			public PointF mk_Point;

			// Token: 0x040002C1 RID: 705
			public Brush mi_Brush;

			// Token: 0x040002C2 RID: 706
			public Pen mi_Pen;

			// Token: 0x040002C3 RID: 707
			public double md_FactorZ;

			// Token: 0x040002C4 RID: 708
			public Graph3D.cScatter mi_Previous;

			// Token: 0x040002C5 RID: 709
			public bool mb_Combine;

			// Token: 0x040002C6 RID: 710
			private bool mb_Valid;
		}

		// Token: 0x02000030 RID: 48
		private class cDrawObj
		{
			// Token: 0x060002E1 RID: 737 RVA: 0x00049A08 File Offset: 0x00047C08
			public cDrawObj(Graph3D.cPolygon i_Polygon, double d_Sort)
			{
				this.mi_Polygon = i_Polygon;
				this.mb_Valid = i_Polygon.IsValid;
				this.md_Sort = d_Sort;
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x00049A2C File Offset: 0x00047C2C
			public cDrawObj(Graph3D.cScatter i_Scatter, double d_Sort)
			{
				this.mi_Scatter = i_Scatter;
				this.mb_Valid = i_Scatter.IsValid;
				this.md_Sort = d_Sort;
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x00049A50 File Offset: 0x00047C50
			public cDrawObj(Graph3D.cLine i_Line, double d_Sort)
			{
				this.mi_Line = i_Line;
				this.mb_Valid = i_Line.IsValid;
				this.md_Sort = d_Sort;
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x00049A74 File Offset: 0x00047C74
			public bool IsValid
			{
				get
				{
					return this.mb_Valid;
				}
			}

			// Token: 0x040002C7 RID: 711
			public Graph3D.cPolygon mi_Polygon;

			// Token: 0x040002C8 RID: 712
			public Graph3D.cScatter mi_Scatter;

			// Token: 0x040002C9 RID: 713
			public Graph3D.cLine mi_Line;

			// Token: 0x040002CA RID: 714
			public double md_Sort;

			// Token: 0x040002CB RID: 715
			private bool mb_Valid;
		}

		// Token: 0x02000031 RID: 49
		private class cQuadrant
		{
			// Token: 0x060002E5 RID: 741 RVA: 0x00049A8C File Offset: 0x00047C8C
			public cQuadrant(double d_Phi, Graph3D.cLine i_AxisX, Graph3D.cLine i_AxisY, Graph3D.cLine i_AxisZ)
			{
				int num = (int)d_Phi + 45;
				bool flag = num > 360;
				if (flag)
				{
					num -= 360;
				}
				num = Math.Min(3, num / 90);
				switch (num)
				{
				case 0:
					this.mb_BottomView = (i_AxisX.md_Angle < 180.0);
					break;
				case 1:
					this.mb_BottomView = (i_AxisY.md_Angle < 180.0);
					break;
				case 2:
					this.mb_BottomView = (i_AxisX.md_Angle > 180.0);
					break;
				case 3:
					this.mb_BottomView = (i_AxisY.md_Angle > 180.0);
					break;
				}
				bool flag2 = this.mb_BottomView;
				if (flag2)
				{
					switch (num)
					{
					case 0:
						this.ms32_Quadrant = ((i_AxisX.md_Angle + 180.0 < i_AxisZ.md_Angle) ? 1 : 0);
						break;
					case 1:
						this.ms32_Quadrant = ((i_AxisY.md_Angle + 180.0 < i_AxisZ.md_Angle) ? 2 : 1);
						break;
					case 2:
						this.ms32_Quadrant = ((i_AxisX.md_Angle < i_AxisZ.md_Angle) ? 3 : 2);
						break;
					case 3:
						this.ms32_Quadrant = ((i_AxisY.md_Angle < i_AxisZ.md_Angle) ? 0 : 3);
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 0:
						this.ms32_Quadrant = ((i_AxisX.md_Angle > i_AxisZ.md_Angle) ? 1 : 0);
						break;
					case 1:
						this.ms32_Quadrant = ((i_AxisY.md_Angle > i_AxisZ.md_Angle) ? 2 : 1);
						break;
					case 2:
						this.ms32_Quadrant = ((i_AxisX.md_Angle + 180.0 > i_AxisZ.md_Angle) ? 3 : 2);
						break;
					case 3:
						this.ms32_Quadrant = ((i_AxisY.md_Angle + 180.0 > i_AxisZ.md_Angle) ? 0 : 3);
						break;
					}
				}
				this.md_SortXY = (this.mb_BottomView ? 99999.9 : -99999.9);
				this.md_SortXZ = ((this.ms32_Quadrant == 1 || this.ms32_Quadrant == 2) ? 99999.9 : -99999.9);
				this.md_SortYZ = ((this.ms32_Quadrant == 0 || this.ms32_Quadrant == 1) ? 99999.9 : -99999.9);
				i_AxisX.md_Sort = this.md_SortXZ;
				i_AxisY.md_Sort = this.md_SortYZ;
				i_AxisZ.md_Sort = 0.0;
			}

			// Token: 0x040002CC RID: 716
			public double md_SortXY;

			// Token: 0x040002CD RID: 717
			public double md_SortXZ;

			// Token: 0x040002CE RID: 718
			public double md_SortYZ;

			// Token: 0x040002CF RID: 719
			public int ms32_Quadrant;

			// Token: 0x040002D0 RID: 720
			public bool mb_BottomView;
		}

		// Token: 0x02000032 RID: 50
		private class cTransform
		{
			// Token: 0x060002E6 RID: 742 RVA: 0x00049D48 File Offset: 0x00047F48
			public void SetCoeficients(Graph3D.cMouse i_Mouse)
			{
				this.md_Rho = i_Mouse.md_Rho;
				double num = i_Mouse.md_Theta * 3.1415926535897931 / 180.0;
				double num2 = (i_Mouse.md_Phi - 180.0) * 3.1415926535897931 / 180.0;
				this.md_sf = Math.Sin(num2);
				this.md_cf = Math.Cos(num2);
				this.md_st = Math.Sin(num);
				this.md_ct = Math.Cos(num);
				this.md_Dist = 0.5;
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x00049DE4 File Offset: 0x00047FE4
			public void SetSize(Size k_Size)
			{
				double num = (double)k_Size.Width * 0.0254 / 96.0;
				double num2 = (double)k_Size.Height * 0.0254 / 96.0;
				this.md_FactX = (double)k_Size.Width / num;
				this.md_FactY = (double)(-(double)k_Size.Height) / num2;
				this.md_OffsX = this.md_FactX * num / 2.0;
				this.md_OffsY = -this.md_FactY * num2 / 2.0;
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x00049E80 File Offset: 0x00048080
			public Graph3D.cPoint2D Project(Graph3D.cPoint3D i_Point3D, Graph3D.cPoint3D i_Center3D)
			{
				double num = (i_Point3D.md_X - i_Center3D.md_X) * this.md_NormalizeX;
				double num2 = (i_Point3D.md_Y - i_Center3D.md_Y) * this.md_NormalizeY;
				double num3 = (i_Point3D.md_Z - i_Center3D.md_Z) * this.md_NormalizeZ;
				double num4 = -this.md_sf * num + this.md_cf * num2;
				double num5 = -this.md_cf * this.md_ct * num - this.md_sf * this.md_ct * num2 + this.md_st * num3;
				double num6 = -this.md_cf * this.md_st * num - this.md_sf * this.md_st * num2 - this.md_ct * num3 + this.md_Rho;
				bool flag = num6 <= 0.0;
				if (flag)
				{
					num6 = 0.01;
				}
				return new Graph3D.cPoint2D
				{
					md_X = this.md_FactX * num4 * this.md_Dist / num6 + this.md_OffsX,
					md_Y = this.md_FactY * num5 * this.md_Dist / num6 + this.md_OffsY
				};
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x00049FB0 File Offset: 0x000481B0
			public double ProjectXY(double X, double Y)
			{
				return X * this.md_cf + Y * this.md_sf;
			}

			// Token: 0x040002D1 RID: 721
			private double md_Dist;

			// Token: 0x040002D2 RID: 722
			private double md_sf;

			// Token: 0x040002D3 RID: 723
			private double md_st;

			// Token: 0x040002D4 RID: 724
			private double md_cf;

			// Token: 0x040002D5 RID: 725
			private double md_ct;

			// Token: 0x040002D6 RID: 726
			private double md_Rho;

			// Token: 0x040002D7 RID: 727
			private double md_FactX;

			// Token: 0x040002D8 RID: 728
			private double md_OffsX;

			// Token: 0x040002D9 RID: 729
			private double md_FactY;

			// Token: 0x040002DA RID: 730
			private double md_OffsY;

			// Token: 0x040002DB RID: 731
			public double md_NormalizeX;

			// Token: 0x040002DC RID: 732
			public double md_NormalizeY;

			// Token: 0x040002DD RID: 733
			public double md_NormalizeZ;
		}

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060002EC RID: 748
		public delegate double delRendererFunction(double X, double Y);
	}
}
