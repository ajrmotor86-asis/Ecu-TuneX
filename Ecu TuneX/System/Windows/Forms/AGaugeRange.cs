using System;
using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
	// Token: 0x0200000B RID: 11
	public class AGaugeRange
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00008A2E File Offset: 0x00006C2E
		public AGaugeRange()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00008A46 File Offset: 0x00006C46
		public AGaugeRange(Color color, float startValue, float endValue, int innerRadius, int outerRadius)
		{
			this.Color = color;
			this._StartValue = startValue;
			this._EndValue = endValue;
			this.InnerRadius = innerRadius;
			this.OuterRadius = outerRadius;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00008A86 File Offset: 0x00006C86
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00008A8E File Offset: 0x00006C8E
		[Browsable(true)]
		[Category("Design")]
		[DisplayName("(Name)")]
		[Description("Instance Name.")]
		public string Name { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00008A97 File Offset: 0x00006C97
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00008A9F File Offset: 0x00006C9F
		[Browsable(false)]
		public bool InRange { get; set; }

		// Token: 0x060000D0 RID: 208 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Browsable(false)]
		public void SetOwner(AGauge value)
		{
			this.Owner = value;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00008AB4 File Offset: 0x00006CB4
		private void NotifyOwner()
		{
			bool flag = this.Owner != null;
			if (flag)
			{
				this.Owner.RepaintControl();
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00008ADC File Offset: 0x00006CDC
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00008AF4 File Offset: 0x00006CF4
		[Browsable(true)]
		[Category("Appearance")]
		[Description("The color of the range.")]
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00008B08 File Offset: 0x00006D08
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00008B20 File Offset: 0x00006D20
		[Browsable(true)]
		[Category("Limits")]
		[Description("The start value of the range, must be less than RangeEndValue.")]
		public float StartValue
		{
			get
			{
				return this._StartValue;
			}
			set
			{
				bool flag = value < this._EndValue;
				if (flag)
				{
					this._StartValue = value;
					this.NotifyOwner();
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00008B4C File Offset: 0x00006D4C
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00008B64 File Offset: 0x00006D64
		[Browsable(true)]
		[Category("Limits")]
		[Description("The end value of the range. Must be greater than RangeStartValue.")]
		public float EndValue
		{
			get
			{
				return this._EndValue;
			}
			set
			{
				bool flag = value > this._StartValue;
				if (flag)
				{
					this._EndValue = value;
					this.NotifyOwner();
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00008B90 File Offset: 0x00006D90
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00008BA8 File Offset: 0x00006DA8
		[Browsable(true)]
		[Category("Appearance")]
		[Description("The inner radius of the range.")]
		public int InnerRadius
		{
			get
			{
				return this._InnerRadius;
			}
			set
			{
				bool flag = value > 0;
				if (flag)
				{
					this._InnerRadius = value;
					this.NotifyOwner();
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00008BD0 File Offset: 0x00006DD0
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00008BE8 File Offset: 0x00006DE8
		[Browsable(true)]
		[Category("Appearance")]
		[Description("The outer radius of the range.")]
		public int OuterRadius
		{
			get
			{
				return this._OuterRadius;
			}
			set
			{
				bool flag = value > 0;
				if (flag)
				{
					this._OuterRadius = value;
					this.NotifyOwner();
				}
			}
		}

		// Token: 0x04000058 RID: 88
		private AGauge Owner;

		// Token: 0x04000059 RID: 89
		private Color _Color;

		// Token: 0x0400005A RID: 90
		private float _StartValue;

		// Token: 0x0400005B RID: 91
		private float _EndValue;

		// Token: 0x0400005C RID: 92
		private int _InnerRadius = 1;

		// Token: 0x0400005D RID: 93
		private int _OuterRadius = 2;
	}
}
