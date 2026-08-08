using System;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x0200001C RID: 28
	internal static class Program
	{
		// Token: 0x06000275 RID: 629 RVA: 0x00041250 File Offset: 0x0003F450
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			using (SplashScreen splashScreen = new SplashScreen())
			{
				splashScreen.ShowDialog();
			}
			Application.Run(new Form1());
		}
	}
}
