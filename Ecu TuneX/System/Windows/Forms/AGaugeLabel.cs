using System;
using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
	// Token: 0x0200000D RID: 13
	public class AGaugeLabel
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00008EB9 File Offset: 0x000070B9
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00008EC1 File Offset: 0x000070C1
		[Browsable(true)]
		[Category("Design")]
		[DisplayName("(Name)")]
		[Description("Instance Name.")]
		public string Name { get; set; }

		// Token: 0x060000EA RID: 234 RVA: 0x00008ECA File Offset: 0x000070CA
		[Browsable(false)]
		public void SetOwner(AGauge value)
		{
			this.Owner = value;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00008ED4 File Offset: 0x000070D4
		private void NotifyOwner()
		{
			bool flag = this.Owner != null;
			if (flag)
			{
				this.Owner.RepaintControl();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00008EFC File Offset: 0x000070FC
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00008F14 File Offset: 0x00007114
		[Browsable(true)]
		[Category("Appearance")]
		[Description("The color of the caption text.")]
		public Color Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				this._Color = value;
				this.NotifyOwner();
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00008F28 File Offset: 0x00007128
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00008F40 File Offset: 0x00007140
		[Browsable(true)]
		[Category("Appearance")]
		[Description("The text of the caption.")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				this._Text = value;
				this.NotifyOwner();
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00008F54 File Offset: 0x00007154
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00008F6C File Offset: 0x0000716C
		[Browsable(true)]
		[Category("Appearance")]
		[Description("The position of the caption.")]
		public Point Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				this._Position = value;
				this.NotifyOwner();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00008F80 File Offset: 0x00007180
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00008F98 File Offset: 0x00007198
		[Browsable(true)]
		[Category("Appearance")]
		[Description("Font of Text.")]
		public Font Font
		{
			get
			{
				return this._Font;
			}
			set
			{
				this._Font = value;
				this.NotifyOwner();
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00008FA9 File Offset: 0x000071A9
		public void ResetFont()
		{
			this._Font = AGaugeLabel.DefaultFont;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00008FB8 File Offset: 0x000071B8
		private bool ShouldSerializeFont()
		{
			return this._Font != AGaugeLabel.DefaultFont;
		}

		// Token: 0x04000060 RID: 96
		private AGauge Owner;

		// Token: 0x04000061 RID: 97
		private Color _Color = Color.FromKnownColor(KnownColor.WindowText);

		// Token: 0x04000062 RID: 98
		private string _Text;

		// Token: 0x04000063 RID: 99
		private Point _Position;

		// Token: 0x04000064 RID: 100
		private Font _Font = AGaugeLabel.DefaultFont;

		// Token: 0x04000065 RID: 101
		private static Font DefaultFont = Control.DefaultFont;
	}
}
