using System;
using System.Runtime.InteropServices;

namespace _3D_Chart_Graph
{
	// Token: 0x02000019 RID: 25
	internal class FTDI
	{
		// Token: 0x06000259 RID: 601
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_Open(uint uint_0, ref IntPtr intptr_0);

		// Token: 0x0600025A RID: 602
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_Close(IntPtr intptr_0);

		// Token: 0x0600025B RID: 603
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_Read(IntPtr intptr_0, byte[] byte_0, uint uint_0, ref uint uint_1);

		// Token: 0x0600025C RID: 604
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_Write(IntPtr intptr_0, byte[] byte_0, uint uint_0, ref uint uint_1);

		// Token: 0x0600025D RID: 605
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_GetQueueStatus(IntPtr intptr_0, ref uint uint_0);

		// Token: 0x0600025E RID: 606
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_SetBaudRate(IntPtr intptr_0, uint uint_0);

		// Token: 0x0600025F RID: 607
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_SetDataCharacteristics(IntPtr intptr_0, byte byte_0, byte byte_1, byte byte_2);

		// Token: 0x06000260 RID: 608
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_Purge(IntPtr intptr_0, uint uint_0);

		// Token: 0x06000261 RID: 609
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_SetTimeouts(IntPtr intptr_0, uint uint_0, uint uint_1);

		// Token: 0x06000262 RID: 610
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_SetLatencyTimer(IntPtr intptr_0, byte byte_0);

		// Token: 0x06000263 RID: 611
		[DllImport("ftd2xx.dll")]
		public static extern FTDI.FT_STATUS FT_SetBitMode(IntPtr intptr_0, byte byte_0, byte byte_1);

		// Token: 0x02000042 RID: 66
		public enum FT_STATUS
		{
			// Token: 0x04000343 RID: 835
			FT_OK,
			// Token: 0x04000344 RID: 836
			FT_INVALID_HANDLE,
			// Token: 0x04000345 RID: 837
			FT_DEVICE_NOT_FOUND,
			// Token: 0x04000346 RID: 838
			FT_DEVICE_NOT_OPENED,
			// Token: 0x04000347 RID: 839
			FT_IO_ERROR,
			// Token: 0x04000348 RID: 840
			FT_INSUFFICIENT_RESOURCES,
			// Token: 0x04000349 RID: 841
			FT_INVALID_PARAMETER,
			// Token: 0x0400034A RID: 842
			FT_INVALID_BAUD_RATE,
			// Token: 0x0400034B RID: 843
			FT_DEVICE_NOT_OPENED_FOR_ERASE,
			// Token: 0x0400034C RID: 844
			FT_DEVICE_NOT_OPENED_FOR_WRITE,
			// Token: 0x0400034D RID: 845
			FT_FAILED_TO_WRITE_DEVICE,
			// Token: 0x0400034E RID: 846
			FT_EEPROM_READ_FAILED,
			// Token: 0x0400034F RID: 847
			FT_EEPROM_WRITE_FAILED,
			// Token: 0x04000350 RID: 848
			FT_EEPROM_ERASE_FAILED,
			// Token: 0x04000351 RID: 849
			FT_EEPROM_NOT_PRESENT,
			// Token: 0x04000352 RID: 850
			FT_EEPROM_NOT_PROGRAMMED,
			// Token: 0x04000353 RID: 851
			FT_INVALID_ARGS,
			// Token: 0x04000354 RID: 852
			FT_OTHER_ERROR
		}
	}
}
