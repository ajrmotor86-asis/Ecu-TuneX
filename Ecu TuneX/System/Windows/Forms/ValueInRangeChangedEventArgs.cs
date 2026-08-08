using System;

namespace System.Windows.Forms
{
	// Token: 0x02000010 RID: 16
	public class ValueInRangeChangedEventArgs : EventArgs
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00009007 File Offset: 0x00007207
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000900F File Offset: 0x0000720F
		public AGaugeRange Range { get; private set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00009018 File Offset: 0x00007218
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00009020 File Offset: 0x00007220
		public float Value { get; private set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00009029 File Offset: 0x00007229
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00009031 File Offset: 0x00007231
		public bool InRange { get; private set; }

		// Token: 0x060000FE RID: 254 RVA: 0x0000903A File Offset: 0x0000723A
		public ValueInRangeChangedEventArgs(AGaugeRange range, float value, bool inRange)
		{
			this.Range = range;
			this.Value = value;
			this.InRange = inRange;
		}
	}
}
