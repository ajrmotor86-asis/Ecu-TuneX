using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x02000014 RID: 20
	public partial class CustomToolTip : Form
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00009AD8 File Offset: 0x00007CD8
		public CustomToolTip()
		{
			base.FormBorderStyle = FormBorderStyle.None;
			base.StartPosition = FormStartPosition.Manual;
			this.BackColor = Color.Orange;
			base.Opacity = 0.85;
			base.ShowInTaskbar = false;
			this.label = new Label
			{
				ForeColor = Color.White,
				BackColor = Color.Transparent,
				Font = new Font("Arial", 10f, FontStyle.Bold),
				AutoSize = true
			};
			base.Controls.Add(this.label);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00009B78 File Offset: 0x00007D78
		public void Show(string text, Form parent, int x, int y)
		{
			this.label.Text = text;
			base.Size = this.label.Size;
			base.Location = parent.PointToScreen(new Point(x, y));
			base.Show();
			base.BringToFront();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00009BC8 File Offset: 0x00007DC8
		public new void Hide()
		{
			base.Hide();
		}

		// Token: 0x04000081 RID: 129
		private Label label;
	}
}
