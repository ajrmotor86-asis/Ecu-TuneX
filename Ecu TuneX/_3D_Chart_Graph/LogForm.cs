using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x0200001B RID: 27
	public partial class LogForm : Form
	{
		// Token: 0x0600026F RID: 623 RVA: 0x00040FDF File Offset: 0x0003F1DF
		public LogForm()
		{
			this.InitializeComponent();
			base.StartPosition = FormStartPosition.CenterScreen;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.ControlBox = false;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void LogForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00041020 File Offset: 0x0003F220
		public void AddLog(string message)
		{
			bool invokeRequired = this.lstLog.InvokeRequired;
			if (invokeRequired)
			{
				this.lstLog.Invoke(new Action<string>(this.AddLog), new object[]
				{
					message
				});
			}
			else
			{
				this.lstLog.Items.Add(message);
				this.lstLog.TopIndex = this.lstLog.Items.Count - 1;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00041098 File Offset: 0x0003F298
		public void ClearLog()
		{
			bool invokeRequired = this.lstLog.InvokeRequired;
			if (invokeRequired)
			{
				this.lstLog.Invoke(new Action(this.ClearLog));
			}
			else
			{
				this.lstLog.Items.Clear();
			}
		}
	}
}
