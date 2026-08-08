using System;
using System.Runtime.InteropServices;

namespace SPECIALIST_PH_TUNER
{
	// Token: 0x02000008 RID: 8
	internal class Class15
	{
		// Token: 0x06000050 RID: 80
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_Open(uint uint_0, ref IntPtr intptr_0);

		// Token: 0x06000051 RID: 81
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_Close(IntPtr intptr_0);

		// Token: 0x06000052 RID: 82
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_Read(IntPtr intptr_0, byte[] byte_0, uint uint_0, ref uint uint_1);

		// Token: 0x06000053 RID: 83
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_Write(IntPtr intptr_0, byte[] byte_0, uint uint_0, ref uint uint_1);

		// Token: 0x06000054 RID: 84
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_GetQueueStatus(IntPtr intptr_0, ref uint uint_0);

		// Token: 0x06000055 RID: 85
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_SetBaudRate(IntPtr intptr_0, uint uint_0);

		// Token: 0x06000056 RID: 86
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_SetDataCharacteristics(IntPtr intptr_0, byte byte_0, byte byte_1, byte byte_2);

		// Token: 0x06000057 RID: 87
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_Purge(IntPtr intptr_0, uint uint_0);

		// Token: 0x06000058 RID: 88
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_SetTimeouts(IntPtr intptr_0, uint uint_0, uint uint_1);

		// Token: 0x06000059 RID: 89
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_SetLatencyTimer(IntPtr intptr_0, byte byte_0);

		// Token: 0x0600005A RID: 90
		[DllImport("ftd2xx.dll")]
		public static extern Class15.Enum5 FT_SetBitMode(IntPtr intptr_0, byte byte_0, byte byte_1);

		// Token: 0x02000035 RID: 53
		public enum Enum5
		{
			// Token: 0x040002E1 RID: 737
			const_0,
			// Token: 0x040002E2 RID: 738
			const_1,
			// Token: 0x040002E3 RID: 739
			const_2,
			// Token: 0x040002E4 RID: 740
			const_3,
			// Token: 0x040002E5 RID: 741
			const_4,
			// Token: 0x040002E6 RID: 742
			const_5,
			// Token: 0x040002E7 RID: 743
			const_6,
			// Token: 0x040002E8 RID: 744
			const_7,
			// Token: 0x040002E9 RID: 745
			const_8,
			// Token: 0x040002EA RID: 746
			const_9,
			// Token: 0x040002EB RID: 747
			const_10,
			// Token: 0x040002EC RID: 748
			const_11,
			// Token: 0x040002ED RID: 749
			const_12,
			// Token: 0x040002EE RID: 750
			const_13,
			// Token: 0x040002EF RID: 751
			const_14,
			// Token: 0x040002F0 RID: 752
			const_15,
			// Token: 0x040002F1 RID: 753
			const_16,
			// Token: 0x040002F2 RID: 754
			const_17
		}
	}
}
