using System;
using System.Drawing;

namespace _3D_Chart_Graph
{
	// Token: 0x02000013 RID: 19
	public class DataPoint
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00009AA5 File Offset: 0x00007CA5
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00009AAD File Offset: 0x00007CAD
		public double X { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00009AB6 File Offset: 0x00007CB6
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00009ABE File Offset: 0x00007CBE
		public double Y { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00009AC7 File Offset: 0x00007CC7
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00009ACF File Offset: 0x00007CCF
		public Rectangle Bounds { get; set; }
	}
}
