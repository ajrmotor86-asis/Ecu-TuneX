using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace System.Windows.Forms
{
	// Token: 0x02000009 RID: 9
	[ToolboxBitmap(typeof(AGauge), "AGauge.AGauge.bmp")]
	[DefaultEvent("ValueInRangeChanged")]
	[Description("Displays a value on an analog gauge. Raises an event if the value enters one of the definable ranges.")]
	public class AGauge : Control
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600005C RID: 92 RVA: 0x00005648 File Offset: 0x00003848
		// (remove) Token: 0x0600005D RID: 93 RVA: 0x00005680 File Offset: 0x00003880
		[Description("This event is raised when gauge value changed.")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler ValueChanged;

		// Token: 0x0600005E RID: 94 RVA: 0x000056B8 File Offset: 0x000038B8
		private void OnValueChanged()
		{
			EventHandler valueChanged = this.ValueChanged;
			bool flag = valueChanged != null;
			if (flag)
			{
				valueChanged(this, null);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600005F RID: 95 RVA: 0x000056E0 File Offset: 0x000038E0
		// (remove) Token: 0x06000060 RID: 96 RVA: 0x00005718 File Offset: 0x00003918
		[Description("This event is raised if the value is entering or leaving defined range.")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler<ValueInRangeChangedEventArgs> ValueInRangeChanged;

		// Token: 0x06000061 RID: 97 RVA: 0x00005750 File Offset: 0x00003950
		private void OnValueInRangeChanged(AGaugeRange range, float value)
		{
			EventHandler<ValueInRangeChangedEventArgs> valueInRangeChanged = this.ValueInRangeChanged;
			bool flag = valueInRangeChanged != null;
			if (flag)
			{
				valueInRangeChanged(this, new ValueInRangeChangedEventArgs(range, value, range.InRange));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00005784 File Offset: 0x00003984
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00003C6B File Offset: 0x00001E6B
		public new bool AllowDrop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005798 File Offset: 0x00003998
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00003C6B File Offset: 0x00001E6B
		public new bool AutoSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000057AC File Offset: 0x000039AC
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00003C6B File Offset: 0x00001E6B
		public new bool ForeColor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000057C0 File Offset: 0x000039C0
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00003C6B File Offset: 0x00001E6B
		public new bool ImeMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000057D4 File Offset: 0x000039D4
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000057EC File Offset: 0x000039EC
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
				this.drawGaugeBackground = true;
				this.Refresh();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00005808 File Offset: 0x00003A08
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00005820 File Offset: 0x00003A20
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font = value;
				this.drawGaugeBackground = true;
				this.Refresh();
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000583C File Offset: 0x00003A3C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00005854 File Offset: 0x00003A54
		public override ImageLayout BackgroundImageLayout
		{
			get
			{
				return base.BackgroundImageLayout;
			}
			set
			{
				base.BackgroundImageLayout = value;
				this.drawGaugeBackground = true;
				this.Refresh();
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005870 File Offset: 0x00003A70
		public AGauge()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this._GaugeRanges = new AGaugeRangeCollection(this);
			this._GaugeLabels = new AGaugeLabelCollection(this);
			base.Size = new Size(205, 180);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000059E0 File Offset: 0x00003BE0
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000059F8 File Offset: 0x00003BF8
		[Browsable(true)]
		[Category("AGauge")]
		[Description("Gauge value.")]
		public float Value
		{
			get
			{
				return this.m_value;
			}
			set
			{
				value = Math.Min(Math.Max(value, this.m_MinValue), this.m_MaxValue);
				bool flag = this.m_value != value;
				if (flag)
				{
					this.m_value = value;
					this.OnValueChanged();
					bool designMode = base.DesignMode;
					if (designMode)
					{
						this.drawGaugeBackground = true;
					}
					foreach (object obj in this._GaugeRanges)
					{
						AGaugeRange agaugeRange = (AGaugeRange)obj;
						bool flag2 = this.m_value >= agaugeRange.StartValue && this.m_value <= agaugeRange.EndValue;
						if (flag2)
						{
							bool flag3 = !agaugeRange.InRange;
							if (flag3)
							{
								agaugeRange.InRange = true;
								this.OnValueInRangeChanged(agaugeRange, this.m_value);
							}
						}
						else
						{
							bool inRange = agaugeRange.InRange;
							if (inRange)
							{
								agaugeRange.InRange = false;
								this.OnValueInRangeChanged(agaugeRange, this.m_value);
							}
						}
					}
					this.Refresh();
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00005B28 File Offset: 0x00003D28
		[Browsable(true)]
		[Category("AGauge")]
		[Description("Gauge Ranges.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public AGaugeRangeCollection GaugeRanges
		{
			get
			{
				return this._GaugeRanges;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005B40 File Offset: 0x00003D40
		[Browsable(true)]
		[Category("AGauge")]
		[Description("Gauge Labels.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public AGaugeLabelCollection GaugeLabels
		{
			get
			{
				return this._GaugeLabels;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00005B58 File Offset: 0x00003D58
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00005B70 File Offset: 0x00003D70
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The center of the gauge (in the control's client area).")]
		public Point Center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				bool flag = this.m_Center != value;
				if (flag)
				{
					this.m_Center = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00005BA8 File Offset: 0x00003DA8
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00005BC0 File Offset: 0x00003DC0
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The color of the base arc.")]
		public Color BaseArcColor
		{
			get
			{
				return this.m_BaseArcColor;
			}
			set
			{
				bool flag = this.m_BaseArcColor != value;
				if (flag)
				{
					this.m_BaseArcColor = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00005BF8 File Offset: 0x00003DF8
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00005C10 File Offset: 0x00003E10
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The radius of the base arc.")]
		public int BaseArcRadius
		{
			get
			{
				return this.m_BaseArcRadius;
			}
			set
			{
				bool flag = this.m_BaseArcRadius != value;
				if (flag)
				{
					this.m_BaseArcRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00005C48 File Offset: 0x00003E48
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00005C60 File Offset: 0x00003E60
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The start angle of the base arc.")]
		public int BaseArcStart
		{
			get
			{
				return this.m_BaseArcStart;
			}
			set
			{
				bool flag = this.m_BaseArcStart != value;
				if (flag)
				{
					this.m_BaseArcStart = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005C98 File Offset: 0x00003E98
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00005CB0 File Offset: 0x00003EB0
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The sweep angle of the base arc.")]
		public int BaseArcSweep
		{
			get
			{
				return this.m_BaseArcSweep;
			}
			set
			{
				bool flag = this.m_BaseArcSweep != value;
				if (flag)
				{
					this.m_BaseArcSweep = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00005CE8 File Offset: 0x00003EE8
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00005D00 File Offset: 0x00003F00
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The width of the base arc.")]
		public int BaseArcWidth
		{
			get
			{
				return this.m_BaseArcWidth;
			}
			set
			{
				bool flag = this.m_BaseArcWidth != value;
				if (flag)
				{
					this.m_BaseArcWidth = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00005D38 File Offset: 0x00003F38
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00005D50 File Offset: 0x00003F50
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The minimum value to show on the scale.")]
		public float MinValue
		{
			get
			{
				return this.m_MinValue;
			}
			set
			{
				bool flag = this.m_MinValue != value && value < this.m_MaxValue;
				if (flag)
				{
					this.m_MinValue = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00005D90 File Offset: 0x00003F90
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The maximum value to show on the scale.")]
		public float MaxValue
		{
			get
			{
				return this.m_MaxValue;
			}
			set
			{
				bool flag = this.m_MaxValue != value && value > this.m_MinValue;
				if (flag)
				{
					this.m_MaxValue = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00005DE8 File Offset: 0x00003FE8
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00005E00 File Offset: 0x00004000
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The color of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")]
		public Color ScaleLinesInterColor
		{
			get
			{
				return this.m_ScaleLinesInterColor;
			}
			set
			{
				bool flag = this.m_ScaleLinesInterColor != value;
				if (flag)
				{
					this.m_ScaleLinesInterColor = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00005E38 File Offset: 0x00004038
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00005E50 File Offset: 0x00004050
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The inner radius of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")]
		public int ScaleLinesInterInnerRadius
		{
			get
			{
				return this.m_ScaleLinesInterInnerRadius;
			}
			set
			{
				bool flag = this.m_ScaleLinesInterInnerRadius != value;
				if (flag)
				{
					this.m_ScaleLinesInterInnerRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00005E88 File Offset: 0x00004088
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00005EA0 File Offset: 0x000040A0
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The outer radius of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")]
		public int ScaleLinesInterOuterRadius
		{
			get
			{
				return this.m_ScaleLinesInterOuterRadius;
			}
			set
			{
				bool flag = this.m_ScaleLinesInterOuterRadius != value;
				if (flag)
				{
					this.m_ScaleLinesInterOuterRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00005ED8 File Offset: 0x000040D8
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00005EF0 File Offset: 0x000040F0
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The width of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")]
		public int ScaleLinesInterWidth
		{
			get
			{
				return this.m_ScaleLinesInterWidth;
			}
			set
			{
				bool flag = this.m_ScaleLinesInterWidth != value;
				if (flag)
				{
					this.m_ScaleLinesInterWidth = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00005F28 File Offset: 0x00004128
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00005F40 File Offset: 0x00004140
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The number of minor scale lines.")]
		public int ScaleLinesMinorTicks
		{
			get
			{
				return this.m_ScaleLinesMinorTicks;
			}
			set
			{
				bool flag = this.m_ScaleLinesMinorTicks != value;
				if (flag)
				{
					this.m_ScaleLinesMinorTicks = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00005F78 File Offset: 0x00004178
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00005F90 File Offset: 0x00004190
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The color of the minor scale lines.")]
		public Color ScaleLinesMinorColor
		{
			get
			{
				return this.m_ScaleLinesMinorColor;
			}
			set
			{
				bool flag = this.m_ScaleLinesMinorColor != value;
				if (flag)
				{
					this.m_ScaleLinesMinorColor = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00005FC8 File Offset: 0x000041C8
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00005FE0 File Offset: 0x000041E0
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The inner radius of the minor scale lines.")]
		public int ScaleLinesMinorInnerRadius
		{
			get
			{
				return this.m_ScaleLinesMinorInnerRadius;
			}
			set
			{
				bool flag = this.m_ScaleLinesMinorInnerRadius != value;
				if (flag)
				{
					this.m_ScaleLinesMinorInnerRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006018 File Offset: 0x00004218
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00006030 File Offset: 0x00004230
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The outer radius of the minor scale lines.")]
		public int ScaleLinesMinorOuterRadius
		{
			get
			{
				return this.m_ScaleLinesMinorOuterRadius;
			}
			set
			{
				bool flag = this.m_ScaleLinesMinorOuterRadius != value;
				if (flag)
				{
					this.m_ScaleLinesMinorOuterRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00006068 File Offset: 0x00004268
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00006080 File Offset: 0x00004280
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The width of the minor scale lines.")]
		public int ScaleLinesMinorWidth
		{
			get
			{
				return this.m_ScaleLinesMinorWidth;
			}
			set
			{
				bool flag = this.m_ScaleLinesMinorWidth != value;
				if (flag)
				{
					this.m_ScaleLinesMinorWidth = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000060B8 File Offset: 0x000042B8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000060D0 File Offset: 0x000042D0
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The step value of the major scale lines.")]
		public float ScaleLinesMajorStepValue
		{
			get
			{
				return this.m_ScaleLinesMajorStepValue;
			}
			set
			{
				bool flag = this.m_ScaleLinesMajorStepValue != value && value > 0f;
				if (flag)
				{
					this.m_ScaleLinesMajorStepValue = Math.Max(Math.Min(value, this.m_MaxValue), this.m_MinValue);
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006124 File Offset: 0x00004324
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000613C File Offset: 0x0000433C
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The color of the major scale lines.")]
		public Color ScaleLinesMajorColor
		{
			get
			{
				return this.m_ScaleLinesMajorColor;
			}
			set
			{
				bool flag = this.m_ScaleLinesMajorColor != value;
				if (flag)
				{
					this.m_ScaleLinesMajorColor = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006174 File Offset: 0x00004374
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000618C File Offset: 0x0000438C
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The inner radius of the major scale lines.")]
		public int ScaleLinesMajorInnerRadius
		{
			get
			{
				return this.m_ScaleLinesMajorInnerRadius;
			}
			set
			{
				bool flag = this.m_ScaleLinesMajorInnerRadius != value;
				if (flag)
				{
					this.m_ScaleLinesMajorInnerRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000061C4 File Offset: 0x000043C4
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000061DC File Offset: 0x000043DC
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The outer radius of the major scale lines.")]
		public int ScaleLinesMajorOuterRadius
		{
			get
			{
				return this.m_ScaleLinesMajorOuterRadius;
			}
			set
			{
				bool flag = this.m_ScaleLinesMajorOuterRadius != value;
				if (flag)
				{
					this.m_ScaleLinesMajorOuterRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00006214 File Offset: 0x00004414
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000622C File Offset: 0x0000442C
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The width of the major scale lines.")]
		public int ScaleLinesMajorWidth
		{
			get
			{
				return this.m_ScaleLinesMajorWidth;
			}
			set
			{
				bool flag = this.m_ScaleLinesMajorWidth != value;
				if (flag)
				{
					this.m_ScaleLinesMajorWidth = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00006264 File Offset: 0x00004464
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000627C File Offset: 0x0000447C
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The radius of the scale numbers.")]
		public int ScaleNumbersRadius
		{
			get
			{
				return this.m_ScaleNumbersRadius;
			}
			set
			{
				bool flag = this.m_ScaleNumbersRadius != value;
				if (flag)
				{
					this.m_ScaleNumbersRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000062B4 File Offset: 0x000044B4
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000062CC File Offset: 0x000044CC
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The color of the scale numbers.")]
		public Color ScaleNumbersColor
		{
			get
			{
				return this.m_ScaleNumbersColor;
			}
			set
			{
				bool flag = this.m_ScaleNumbersColor != value;
				if (flag)
				{
					this.m_ScaleNumbersColor = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00006304 File Offset: 0x00004504
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000631C File Offset: 0x0000451C
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The format of the scale numbers.")]
		public string ScaleNumbersFormat
		{
			get
			{
				return this.m_ScaleNumbersFormat;
			}
			set
			{
				bool flag = this.m_ScaleNumbersFormat != value;
				if (flag)
				{
					this.m_ScaleNumbersFormat = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00006354 File Offset: 0x00004554
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000636C File Offset: 0x0000456C
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The number of the scale line to start writing numbers next to.")]
		public int ScaleNumbersStartScaleLine
		{
			get
			{
				return this.m_ScaleNumbersStartScaleLine;
			}
			set
			{
				bool flag = this.m_ScaleNumbersStartScaleLine != value;
				if (flag)
				{
					this.m_ScaleNumbersStartScaleLine = Math.Max(value, 1);
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000063A8 File Offset: 0x000045A8
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000063C0 File Offset: 0x000045C0
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The number of scale line steps for writing numbers.")]
		public int ScaleNumbersStepScaleLines
		{
			get
			{
				return this.m_ScaleNumbersStepScaleLines;
			}
			set
			{
				bool flag = this.m_ScaleNumbersStepScaleLines != value;
				if (flag)
				{
					this.m_ScaleNumbersStepScaleLines = Math.Max(value, 1);
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000063FC File Offset: 0x000045FC
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00006414 File Offset: 0x00004614
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The angle relative to the tangent of the base arc at a scale line that is used to rotate numbers. set to 0 for no rotation or e.g. set to 90.")]
		public int ScaleNumbersRotation
		{
			get
			{
				return this.m_ScaleNumbersRotation;
			}
			set
			{
				bool flag = this.m_ScaleNumbersRotation != value;
				if (flag)
				{
					this.m_ScaleNumbersRotation = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000644C File Offset: 0x0000464C
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00006464 File Offset: 0x00004664
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The type of the needle, currently only type 0 and 1 are supported. Type 0 looks nicers but if you experience performance problems you might consider using type 1.")]
		public NeedleType NeedleType
		{
			get
			{
				return this.m_NeedleType;
			}
			set
			{
				bool flag = this.m_NeedleType != value;
				if (flag)
				{
					this.m_NeedleType = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000649C File Offset: 0x0000469C
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000064B4 File Offset: 0x000046B4
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The radius of the needle.")]
		public int NeedleRadius
		{
			get
			{
				return this.m_NeedleRadius;
			}
			set
			{
				bool flag = this.m_NeedleRadius != value;
				if (flag)
				{
					this.m_NeedleRadius = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000064EC File Offset: 0x000046EC
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00006504 File Offset: 0x00004704
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The first color of the needle.")]
		public AGaugeNeedleColor NeedleColor1
		{
			get
			{
				return this.m_NeedleColor1;
			}
			set
			{
				bool flag = this.m_NeedleColor1 != value;
				if (flag)
				{
					this.m_NeedleColor1 = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000653C File Offset: 0x0000473C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00006554 File Offset: 0x00004754
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The second color of the needle.")]
		public Color NeedleColor2
		{
			get
			{
				return this.m_NeedleColor2;
			}
			set
			{
				bool flag = this.m_NeedleColor2 != value;
				if (flag)
				{
					this.m_NeedleColor2 = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000658C File Offset: 0x0000478C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000065A4 File Offset: 0x000047A4
		[Browsable(true)]
		[Category("AGauge")]
		[Description("The width of the needle.")]
		public int NeedleWidth
		{
			get
			{
				return this.m_NeedleWidth;
			}
			set
			{
				bool flag = this.m_NeedleWidth != value;
				if (flag)
				{
					this.m_NeedleWidth = value;
					this.drawGaugeBackground = true;
					this.Refresh();
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000065DC File Offset: 0x000047DC
		private void FindFontBounds()
		{
			SolidBrush solidBrush = new SolidBrush(Color.White);
			SolidBrush brush = new SolidBrush(Color.Black);
			Bitmap bitmap = new Bitmap(5, 5);
			Graphics graphics = Graphics.FromImage(bitmap);
			SizeF sizeF = graphics.MeasureString("0123456789", this.Font, -1, StringFormat.GenericTypographic);
			bitmap = new Bitmap((int)sizeF.Width, (int)sizeF.Height);
			graphics = Graphics.FromImage(bitmap);
			graphics.FillRectangle(solidBrush, 0f, 0f, sizeF.Width, sizeF.Height);
			graphics.DrawString("0123456789", this.Font, brush, 0f, 0f, StringFormat.GenericTypographic);
			this.fontBoundY1 = 0f;
			this.fontBoundY2 = 0f;
			int num = 0;
			bool flag = false;
			while (num < bitmap.Height && !flag)
			{
				int num2 = 0;
				while (num2 < bitmap.Width && !flag)
				{
					bool flag2 = bitmap.GetPixel(num2, num) != solidBrush.Color;
					if (flag2)
					{
						this.fontBoundY1 = (float)num;
						flag = true;
					}
					num2++;
				}
				num++;
			}
			num = bitmap.Height - 1;
			flag = false;
			while (0 < num && !flag)
			{
				int num2 = 0;
				while (num2 < bitmap.Width && !flag)
				{
					bool flag3 = bitmap.GetPixel(num2, num) != solidBrush.Color;
					if (flag3)
					{
						this.fontBoundY2 = (float)num;
						flag = true;
					}
					num2++;
				}
				num--;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006778 File Offset: 0x00004978
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public void RepaintControl()
		{
			this.drawGaugeBackground = true;
			this.Refresh();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003C6B File Offset: 0x00001E6B
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000678C File Offset: 0x0000498C
		protected override void OnPaint(PaintEventArgs e)
		{
			bool flag = base.Width < 10 || base.Height < 10;
			if (!flag)
			{
				bool flag2 = this.drawGaugeBackground;
				if (flag2)
				{
					this.drawGaugeBackground = false;
					this.FindFontBounds();
					this.gaugeBitmap = new Bitmap(base.Width, base.Height, e.Graphics);
					Graphics graphics = Graphics.FromImage(this.gaugeBitmap);
					graphics.FillRectangle(new SolidBrush(this.BackColor), base.ClientRectangle);
					bool flag3 = this.BackgroundImage != null;
					if (flag3)
					{
						switch (this.BackgroundImageLayout)
						{
						case ImageLayout.None:
							graphics.DrawImageUnscaled(this.BackgroundImage, 0, 0);
							break;
						case ImageLayout.Tile:
							for (int i = 0; i < base.Width; i += this.BackgroundImage.Width)
							{
								for (int j = 0; j < base.Height; j += this.BackgroundImage.Height)
								{
									graphics.DrawImageUnscaled(this.BackgroundImage, i, j);
								}
							}
							break;
						case ImageLayout.Center:
							graphics.DrawImageUnscaled(this.BackgroundImage, base.Width / 2 - this.BackgroundImage.Width / 2, base.Height / 2 - this.BackgroundImage.Height / 2);
							break;
						case ImageLayout.Stretch:
							graphics.DrawImage(this.BackgroundImage, 0, 0, base.Width, base.Height);
							break;
						case ImageLayout.Zoom:
						{
							bool flag4 = (float)(this.BackgroundImage.Width / base.Width) < (float)(this.BackgroundImage.Height / base.Height);
							if (flag4)
							{
								graphics.DrawImage(this.BackgroundImage, 0, 0, base.Height, base.Height);
							}
							else
							{
								graphics.DrawImage(this.BackgroundImage, 0, 0, base.Width, base.Width);
							}
							break;
						}
						}
					}
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					GraphicsPath graphicsPath = new GraphicsPath();
					foreach (object obj in this._GaugeRanges)
					{
						AGaugeRange agaugeRange = (AGaugeRange)obj;
						bool flag5 = agaugeRange.EndValue > agaugeRange.StartValue;
						if (flag5)
						{
							float startAngle = (float)this.m_BaseArcStart + (agaugeRange.StartValue - this.m_MinValue) * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue);
							float sweepAngle = (agaugeRange.EndValue - agaugeRange.StartValue) * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue);
							graphicsPath.Reset();
							graphicsPath.AddPie(new Rectangle(this.m_Center.X - agaugeRange.OuterRadius, this.m_Center.Y - agaugeRange.OuterRadius, 2 * agaugeRange.OuterRadius, 2 * agaugeRange.OuterRadius), startAngle, sweepAngle);
							graphicsPath.Reverse();
							graphicsPath.AddPie(new Rectangle(this.m_Center.X - agaugeRange.InnerRadius, this.m_Center.Y - agaugeRange.InnerRadius, 2 * agaugeRange.InnerRadius, 2 * agaugeRange.InnerRadius), startAngle, sweepAngle);
							graphicsPath.Reverse();
							graphics.SetClip(graphicsPath);
							graphics.FillPie(new SolidBrush(agaugeRange.Color), new Rectangle(this.m_Center.X - agaugeRange.OuterRadius, this.m_Center.Y - agaugeRange.OuterRadius, 2 * agaugeRange.OuterRadius, 2 * agaugeRange.OuterRadius), startAngle, sweepAngle);
						}
					}
					graphics.SetClip(base.ClientRectangle);
					bool flag6 = this.m_BaseArcRadius > 0;
					if (flag6)
					{
						graphics.DrawArc(new Pen(this.m_BaseArcColor, (float)this.m_BaseArcWidth), new Rectangle(this.m_Center.X - this.m_BaseArcRadius, this.m_Center.Y - this.m_BaseArcRadius, 2 * this.m_BaseArcRadius, 2 * this.m_BaseArcRadius), (float)this.m_BaseArcStart, (float)this.m_BaseArcSweep);
					}
					float num = 0f;
					int num2 = 0;
					while (num <= this.m_MaxValue - this.m_MinValue)
					{
						string text = (this.m_MinValue + num).ToString(this.m_ScaleNumbersFormat);
						graphics.ResetTransform();
						SizeF sizeF = graphics.MeasureString(text, this.Font, -1, StringFormat.GenericTypographic);
						graphicsPath.Reset();
						graphicsPath.AddEllipse(new Rectangle(this.m_Center.X - this.m_ScaleLinesMajorOuterRadius, this.m_Center.Y - this.m_ScaleLinesMajorOuterRadius, 2 * this.m_ScaleLinesMajorOuterRadius, 2 * this.m_ScaleLinesMajorOuterRadius));
						graphicsPath.Reverse();
						graphicsPath.AddEllipse(new Rectangle(this.m_Center.X - this.m_ScaleLinesMajorInnerRadius, this.m_Center.Y - this.m_ScaleLinesMajorInnerRadius, 2 * this.m_ScaleLinesMajorInnerRadius, 2 * this.m_ScaleLinesMajorInnerRadius));
						graphicsPath.Reverse();
						graphics.SetClip(graphicsPath);
						graphics.DrawLine(new Pen(this.m_ScaleLinesMajorColor, (float)this.m_ScaleLinesMajorWidth), (float)this.Center.X, (float)this.Center.Y, (float)((double)this.Center.X + (double)(2 * this.m_ScaleLinesMajorOuterRadius) * Math.Cos((double)((float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue)) * 3.1415926535897931 / 180.0)), (float)((double)this.Center.Y + (double)(2 * this.m_ScaleLinesMajorOuterRadius) * Math.Sin((double)((float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue)) * 3.1415926535897931 / 180.0)));
						graphicsPath.Reset();
						graphicsPath.AddEllipse(new Rectangle(this.m_Center.X - this.m_ScaleLinesMinorOuterRadius, this.m_Center.Y - this.m_ScaleLinesMinorOuterRadius, 2 * this.m_ScaleLinesMinorOuterRadius, 2 * this.m_ScaleLinesMinorOuterRadius));
						graphicsPath.Reverse();
						graphicsPath.AddEllipse(new Rectangle(this.m_Center.X - this.m_ScaleLinesMinorInnerRadius, this.m_Center.Y - this.m_ScaleLinesMinorInnerRadius, 2 * this.m_ScaleLinesMinorInnerRadius, 2 * this.m_ScaleLinesMinorInnerRadius));
						graphicsPath.Reverse();
						graphics.SetClip(graphicsPath);
						bool flag7 = num < this.m_MaxValue - this.m_MinValue;
						if (flag7)
						{
							for (int k = 1; k <= this.m_ScaleLinesMinorTicks; k++)
							{
								bool flag8 = this.m_ScaleLinesMinorTicks % 2 == 1 && this.m_ScaleLinesMinorTicks / 2 + 1 == k;
								if (flag8)
								{
									graphicsPath.Reset();
									graphicsPath.AddEllipse(new Rectangle(this.m_Center.X - this.m_ScaleLinesInterOuterRadius, this.m_Center.Y - this.m_ScaleLinesInterOuterRadius, 2 * this.m_ScaleLinesInterOuterRadius, 2 * this.m_ScaleLinesInterOuterRadius));
									graphicsPath.Reverse();
									graphicsPath.AddEllipse(new Rectangle(this.m_Center.X - this.m_ScaleLinesInterInnerRadius, this.m_Center.Y - this.m_ScaleLinesInterInnerRadius, 2 * this.m_ScaleLinesInterInnerRadius, 2 * this.m_ScaleLinesInterInnerRadius));
									graphicsPath.Reverse();
									graphics.SetClip(graphicsPath);
									graphics.DrawLine(new Pen(this.m_ScaleLinesInterColor, (float)this.m_ScaleLinesInterWidth), (float)this.Center.X, (float)this.Center.Y, (float)((double)this.Center.X + (double)(2 * this.m_ScaleLinesInterOuterRadius) * Math.Cos((double)((float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue) + (float)(k * this.m_BaseArcSweep) / ((this.m_MaxValue - this.m_MinValue) / this.m_ScaleLinesMajorStepValue * (float)(this.m_ScaleLinesMinorTicks + 1))) * 3.1415926535897931 / 180.0)), (float)((double)this.Center.Y + (double)(2 * this.m_ScaleLinesInterOuterRadius) * Math.Sin((double)((float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue) + (float)(k * this.m_BaseArcSweep) / ((this.m_MaxValue - this.m_MinValue) / this.m_ScaleLinesMajorStepValue * (float)(this.m_ScaleLinesMinorTicks + 1))) * 3.1415926535897931 / 180.0)));
									graphicsPath.Reset();
									graphicsPath.AddEllipse(new Rectangle(this.m_Center.X - this.m_ScaleLinesMinorOuterRadius, this.m_Center.Y - this.m_ScaleLinesMinorOuterRadius, 2 * this.m_ScaleLinesMinorOuterRadius, 2 * this.m_ScaleLinesMinorOuterRadius));
									graphicsPath.Reverse();
									graphicsPath.AddEllipse(new Rectangle(this.m_Center.X - this.m_ScaleLinesMinorInnerRadius, this.m_Center.Y - this.m_ScaleLinesMinorInnerRadius, 2 * this.m_ScaleLinesMinorInnerRadius, 2 * this.m_ScaleLinesMinorInnerRadius));
									graphicsPath.Reverse();
									graphics.SetClip(graphicsPath);
								}
								else
								{
									graphics.DrawLine(new Pen(this.m_ScaleLinesMinorColor, (float)this.m_ScaleLinesMinorWidth), (float)this.Center.X, (float)this.Center.Y, (float)((double)this.Center.X + (double)(2 * this.m_ScaleLinesMinorOuterRadius) * Math.Cos((double)((float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue) + (float)(k * this.m_BaseArcSweep) / ((this.m_MaxValue - this.m_MinValue) / this.m_ScaleLinesMajorStepValue * (float)(this.m_ScaleLinesMinorTicks + 1))) * 3.1415926535897931 / 180.0)), (float)((double)this.Center.Y + (double)(2 * this.m_ScaleLinesMinorOuterRadius) * Math.Sin((double)((float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue) + (float)(k * this.m_BaseArcSweep) / ((this.m_MaxValue - this.m_MinValue) / this.m_ScaleLinesMajorStepValue * (float)(this.m_ScaleLinesMinorTicks + 1))) * 3.1415926535897931 / 180.0)));
								}
							}
						}
						graphics.SetClip(base.ClientRectangle);
						bool flag9 = this.m_ScaleNumbersRotation != 0;
						if (flag9)
						{
							graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
							graphics.RotateTransform(90f + (float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue));
						}
						graphics.TranslateTransform((float)((double)this.Center.X + (double)this.m_ScaleNumbersRadius * Math.Cos((double)((float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue)) * 3.1415926535897931 / 180.0)), (float)((double)this.Center.Y + (double)this.m_ScaleNumbersRadius * Math.Sin((double)((float)this.m_BaseArcStart + num * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue)) * 3.1415926535897931 / 180.0)), MatrixOrder.Append);
						bool flag10 = num2 >= this.ScaleNumbersStartScaleLine - 1;
						if (flag10)
						{
							graphics.DrawString(text, this.Font, new SolidBrush(this.m_ScaleNumbersColor), -sizeF.Width / 2f, -this.fontBoundY1 - (this.fontBoundY2 - this.fontBoundY1 + 1f) / 2f, StringFormat.GenericTypographic);
						}
						num += this.m_ScaleLinesMajorStepValue;
						num2++;
					}
					graphics.ResetTransform();
					graphics.SetClip(base.ClientRectangle);
					bool flag11 = this.m_ScaleNumbersRotation != 0;
					if (flag11)
					{
						graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
					}
					foreach (object obj2 in this._GaugeLabels)
					{
						AGaugeLabel agaugeLabel = (AGaugeLabel)obj2;
						bool flag12 = !string.IsNullOrEmpty(agaugeLabel.Text);
						if (flag12)
						{
							graphics.DrawString(agaugeLabel.Text, agaugeLabel.Font, new SolidBrush(agaugeLabel.Color), (float)agaugeLabel.Position.X, (float)agaugeLabel.Position.Y, StringFormat.GenericTypographic);
						}
					}
				}
				e.Graphics.DrawImageUnscaled(this.gaugeBitmap, 0, 0);
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				float num3 = (float)((int)((float)this.m_BaseArcStart + (this.m_value - this.m_MinValue) * (float)this.m_BaseArcSweep / (this.m_MaxValue - this.m_MinValue)) % 360);
				double num4 = (double)num3 * 3.1415926535897931 / 180.0;
				NeedleType needleType = this.m_NeedleType;
				NeedleType needleType2 = needleType;
				if (needleType2 != NeedleType.Advance)
				{
					if (needleType2 == NeedleType.Simple)
					{
						Point point = new Point((int)((double)this.Center.X - (double)(this.m_NeedleRadius / 8) * Math.Cos(num4)), (int)((double)this.Center.Y - (double)(this.m_NeedleRadius / 8) * Math.Sin(num4)));
						Point point2 = new Point((int)((double)this.Center.X + (double)this.m_NeedleRadius * Math.Cos(num4)), (int)((double)this.Center.Y + (double)this.m_NeedleRadius * Math.Sin(num4)));
						e.Graphics.FillEllipse(new SolidBrush(this.m_NeedleColor2), this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
						switch (this.m_NeedleColor1)
						{
						case AGaugeNeedleColor.Gray:
							e.Graphics.DrawLine(new Pen(Color.DarkGray, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point2.X, point2.Y);
							e.Graphics.DrawLine(new Pen(Color.DarkGray, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point.X, point.Y);
							break;
						case AGaugeNeedleColor.Red:
							e.Graphics.DrawLine(new Pen(Color.Red, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point2.X, point2.Y);
							e.Graphics.DrawLine(new Pen(Color.Red, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point.X, point.Y);
							break;
						case AGaugeNeedleColor.Green:
							e.Graphics.DrawLine(new Pen(Color.Green, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point2.X, point2.Y);
							e.Graphics.DrawLine(new Pen(Color.Green, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point.X, point.Y);
							break;
						case AGaugeNeedleColor.Blue:
							e.Graphics.DrawLine(new Pen(Color.Blue, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point2.X, point2.Y);
							e.Graphics.DrawLine(new Pen(Color.Blue, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point.X, point.Y);
							break;
						case AGaugeNeedleColor.Yellow:
							e.Graphics.DrawLine(new Pen(Color.Yellow, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point2.X, point2.Y);
							e.Graphics.DrawLine(new Pen(Color.Yellow, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point.X, point.Y);
							break;
						case AGaugeNeedleColor.Violet:
							e.Graphics.DrawLine(new Pen(Color.Violet, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point2.X, point2.Y);
							e.Graphics.DrawLine(new Pen(Color.Violet, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point.X, point.Y);
							break;
						case AGaugeNeedleColor.Magenta:
							e.Graphics.DrawLine(new Pen(Color.Magenta, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point2.X, point2.Y);
							e.Graphics.DrawLine(new Pen(Color.Magenta, (float)this.m_NeedleWidth), this.Center.X, this.Center.Y, point.X, point.Y);
							break;
						}
					}
				}
				else
				{
					PointF[] array = new PointF[3];
					Brush brush = Brushes.White;
					Brush brush2 = Brushes.White;
					Brush brush3 = Brushes.White;
					Brush brush4 = Brushes.White;
					Brush brush5 = Brushes.White;
					int num5 = (int)((num3 + 225f) % 180f * 100f / 180f);
					int num6 = (int)((num3 + 135f) % 180f * 100f / 180f);
					e.Graphics.FillEllipse(new SolidBrush(this.m_NeedleColor2), this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
					switch (this.m_NeedleColor1)
					{
					case AGaugeNeedleColor.Gray:
						brush = new SolidBrush(Color.FromArgb(80 + num5, 80 + num5, 80 + num5));
						brush2 = new SolidBrush(Color.FromArgb(180 - num5, 180 - num5, 180 - num5));
						brush3 = new SolidBrush(Color.FromArgb(80 + num6, 80 + num6, 80 + num6));
						brush4 = new SolidBrush(Color.FromArgb(180 - num6, 180 - num6, 180 - num6));
						e.Graphics.DrawEllipse(Pens.Gray, this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
						break;
					case AGaugeNeedleColor.Red:
						brush = new SolidBrush(Color.FromArgb(145 + num5, num5, num5));
						brush2 = new SolidBrush(Color.FromArgb(245 - num5, 100 - num5, 100 - num5));
						brush3 = new SolidBrush(Color.FromArgb(145 + num6, num6, num6));
						brush4 = new SolidBrush(Color.FromArgb(245 - num6, 100 - num6, 100 - num6));
						e.Graphics.DrawEllipse(Pens.Red, this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
						break;
					case AGaugeNeedleColor.Green:
						brush = new SolidBrush(Color.FromArgb(num5, 145 + num5, num5));
						brush2 = new SolidBrush(Color.FromArgb(100 - num5, 245 - num5, 100 - num5));
						brush3 = new SolidBrush(Color.FromArgb(num6, 145 + num6, num6));
						brush4 = new SolidBrush(Color.FromArgb(100 - num6, 245 - num6, 100 - num6));
						e.Graphics.DrawEllipse(Pens.Green, this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
						break;
					case AGaugeNeedleColor.Blue:
						brush = new SolidBrush(Color.FromArgb(num5, num5, 145 + num5));
						brush2 = new SolidBrush(Color.FromArgb(100 - num5, 100 - num5, 245 - num5));
						brush3 = new SolidBrush(Color.FromArgb(num6, num6, 145 + num6));
						brush4 = new SolidBrush(Color.FromArgb(100 - num6, 100 - num6, 245 - num6));
						e.Graphics.DrawEllipse(Pens.Blue, this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
						break;
					case AGaugeNeedleColor.Yellow:
						brush = new SolidBrush(Color.FromArgb(145 + num5, 145 + num5, num5));
						brush2 = new SolidBrush(Color.FromArgb(245 - num5, 245 - num5, 100 - num5));
						brush3 = new SolidBrush(Color.FromArgb(145 + num6, 145 + num6, num6));
						brush4 = new SolidBrush(Color.FromArgb(245 - num6, 245 - num6, 100 - num6));
						e.Graphics.DrawEllipse(Pens.Violet, this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
						break;
					case AGaugeNeedleColor.Violet:
						brush = new SolidBrush(Color.FromArgb(145 + num5, num5, 145 + num5));
						brush2 = new SolidBrush(Color.FromArgb(245 - num5, 100 - num5, 245 - num5));
						brush3 = new SolidBrush(Color.FromArgb(145 + num6, num6, 145 + num6));
						brush4 = new SolidBrush(Color.FromArgb(245 - num6, 100 - num6, 245 - num6));
						e.Graphics.DrawEllipse(Pens.Violet, this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
						break;
					case AGaugeNeedleColor.Magenta:
						brush = new SolidBrush(Color.FromArgb(num5, 145 + num5, 145 + num5));
						brush2 = new SolidBrush(Color.FromArgb(100 - num5, 245 - num5, 245 - num5));
						brush3 = new SolidBrush(Color.FromArgb(num6, 145 + num6, 145 + num6));
						brush4 = new SolidBrush(Color.FromArgb(100 - num6, 245 - num6, 245 - num6));
						e.Graphics.DrawEllipse(Pens.Magenta, this.Center.X - this.m_NeedleWidth * 3, this.Center.Y - this.m_NeedleWidth * 3, this.m_NeedleWidth * 6, this.m_NeedleWidth * 6);
						break;
					}
					bool flag13 = Math.Floor((double)((float)((double)((num3 + 225f) % 360f) / 180.0))) == 0.0;
					if (flag13)
					{
						brush5 = brush;
						brush = brush2;
						brush2 = brush5;
					}
					bool flag14 = Math.Floor((double)((float)((double)((num3 + 135f) % 360f) / 180.0))) == 0.0;
					if (flag14)
					{
						brush4 = brush3;
					}
					array[0].X = (float)((double)this.Center.X + (double)this.m_NeedleRadius * Math.Cos(num4));
					array[0].Y = (float)((double)this.Center.Y + (double)this.m_NeedleRadius * Math.Sin(num4));
					array[1].X = (float)((double)this.Center.X - (double)(this.m_NeedleRadius / 20) * Math.Cos(num4));
					array[1].Y = (float)((double)this.Center.Y - (double)(this.m_NeedleRadius / 20) * Math.Sin(num4));
					array[2].X = (float)((double)this.Center.X - (double)(this.m_NeedleRadius / 5) * Math.Cos(num4) + (double)(this.m_NeedleWidth * 2) * Math.Cos(num4 + 1.5707963267948966));
					array[2].Y = (float)((double)this.Center.Y - (double)(this.m_NeedleRadius / 5) * Math.Sin(num4) + (double)(this.m_NeedleWidth * 2) * Math.Sin(num4 + 1.5707963267948966));
					e.Graphics.FillPolygon(brush, array);
					array[2].X = (float)((double)this.Center.X - (double)(this.m_NeedleRadius / 5) * Math.Cos(num4) + (double)(this.m_NeedleWidth * 2) * Math.Cos(num4 - 1.5707963267948966));
					array[2].Y = (float)((double)this.Center.Y - (double)(this.m_NeedleRadius / 5) * Math.Sin(num4) + (double)(this.m_NeedleWidth * 2) * Math.Sin(num4 - 1.5707963267948966));
					e.Graphics.FillPolygon(brush2, array);
					array[0].X = (float)((double)this.Center.X - (double)(this.m_NeedleRadius / 20 - 1) * Math.Cos(num4));
					array[0].Y = (float)((double)this.Center.Y - (double)(this.m_NeedleRadius / 20 - 1) * Math.Sin(num4));
					array[1].X = (float)((double)this.Center.X - (double)(this.m_NeedleRadius / 5) * Math.Cos(num4) + (double)(this.m_NeedleWidth * 2) * Math.Cos(num4 + 1.5707963267948966));
					array[1].Y = (float)((double)this.Center.Y - (double)(this.m_NeedleRadius / 5) * Math.Sin(num4) + (double)(this.m_NeedleWidth * 2) * Math.Sin(num4 + 1.5707963267948966));
					array[2].X = (float)((double)this.Center.X - (double)(this.m_NeedleRadius / 5) * Math.Cos(num4) + (double)(this.m_NeedleWidth * 2) * Math.Cos(num4 - 1.5707963267948966));
					array[2].Y = (float)((double)this.Center.Y - (double)(this.m_NeedleRadius / 5) * Math.Sin(num4) + (double)(this.m_NeedleWidth * 2) * Math.Sin(num4 - 1.5707963267948966));
					e.Graphics.FillPolygon(brush4, array);
					array[0].X = (float)((double)this.Center.X - (double)(this.m_NeedleRadius / 20) * Math.Cos(num4));
					array[0].Y = (float)((double)this.Center.Y - (double)(this.m_NeedleRadius / 20) * Math.Sin(num4));
					array[1].X = (float)((double)this.Center.X + (double)this.m_NeedleRadius * Math.Cos(num4));
					array[1].Y = (float)((double)this.Center.Y + (double)this.m_NeedleRadius * Math.Sin(num4));
					e.Graphics.DrawLine(new Pen(this.m_NeedleColor2), (float)this.Center.X, (float)this.Center.Y, array[0].X, array[0].Y);
					e.Graphics.DrawLine(new Pen(this.m_NeedleColor2), (float)this.Center.X, (float)this.Center.Y, array[1].X, array[1].Y);
				}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006778 File Offset: 0x00004978
		protected override void OnResize(EventArgs e)
		{
			this.drawGaugeBackground = true;
			this.Refresh();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00008724 File Offset: 0x00006924
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.gaugeBitmap.Dispose();
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00008767 File Offset: 0x00006967
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x0400002A RID: 42
		private float fontBoundY1;

		// Token: 0x0400002B RID: 43
		private float fontBoundY2;

		// Token: 0x0400002C RID: 44
		private Bitmap gaugeBitmap;

		// Token: 0x0400002D RID: 45
		private bool drawGaugeBackground = true;

		// Token: 0x0400002E RID: 46
		private float m_value;

		// Token: 0x0400002F RID: 47
		private Point m_Center = new Point(100, 100);

		// Token: 0x04000030 RID: 48
		private float m_MinValue = -100f;

		// Token: 0x04000031 RID: 49
		private float m_MaxValue = 400f;

		// Token: 0x04000032 RID: 50
		private Color m_BaseArcColor = Color.Gray;

		// Token: 0x04000033 RID: 51
		private int m_BaseArcRadius = 80;

		// Token: 0x04000034 RID: 52
		private int m_BaseArcStart = 135;

		// Token: 0x04000035 RID: 53
		private int m_BaseArcSweep = 270;

		// Token: 0x04000036 RID: 54
		private int m_BaseArcWidth = 2;

		// Token: 0x04000037 RID: 55
		private Color m_ScaleLinesInterColor = Color.Black;

		// Token: 0x04000038 RID: 56
		private int m_ScaleLinesInterInnerRadius = 73;

		// Token: 0x04000039 RID: 57
		private int m_ScaleLinesInterOuterRadius = 80;

		// Token: 0x0400003A RID: 58
		private int m_ScaleLinesInterWidth = 1;

		// Token: 0x0400003B RID: 59
		private int m_ScaleLinesMinorTicks = 9;

		// Token: 0x0400003C RID: 60
		private Color m_ScaleLinesMinorColor = Color.Gray;

		// Token: 0x0400003D RID: 61
		private int m_ScaleLinesMinorInnerRadius = 75;

		// Token: 0x0400003E RID: 62
		private int m_ScaleLinesMinorOuterRadius = 80;

		// Token: 0x0400003F RID: 63
		private int m_ScaleLinesMinorWidth = 1;

		// Token: 0x04000040 RID: 64
		private float m_ScaleLinesMajorStepValue = 50f;

		// Token: 0x04000041 RID: 65
		private Color m_ScaleLinesMajorColor = Color.Black;

		// Token: 0x04000042 RID: 66
		private int m_ScaleLinesMajorInnerRadius = 70;

		// Token: 0x04000043 RID: 67
		private int m_ScaleLinesMajorOuterRadius = 80;

		// Token: 0x04000044 RID: 68
		private int m_ScaleLinesMajorWidth = 2;

		// Token: 0x04000045 RID: 69
		private int m_ScaleNumbersRadius = 95;

		// Token: 0x04000046 RID: 70
		private Color m_ScaleNumbersColor = Color.Black;

		// Token: 0x04000047 RID: 71
		private string m_ScaleNumbersFormat;

		// Token: 0x04000048 RID: 72
		private int m_ScaleNumbersStartScaleLine;

		// Token: 0x04000049 RID: 73
		private int m_ScaleNumbersStepScaleLines = 1;

		// Token: 0x0400004A RID: 74
		private int m_ScaleNumbersRotation;

		// Token: 0x0400004B RID: 75
		private NeedleType m_NeedleType;

		// Token: 0x0400004C RID: 76
		private int m_NeedleRadius = 80;

		// Token: 0x0400004D RID: 77
		private AGaugeNeedleColor m_NeedleColor1 = AGaugeNeedleColor.Gray;

		// Token: 0x0400004E RID: 78
		private Color m_NeedleColor2 = Color.DimGray;

		// Token: 0x0400004F RID: 79
		private int m_NeedleWidth = 2;

		// Token: 0x04000052 RID: 82
		private AGaugeRangeCollection _GaugeRanges;

		// Token: 0x04000053 RID: 83
		private AGaugeLabelCollection _GaugeLabels;

		// Token: 0x04000054 RID: 84
		private IContainer components = null;
	}
}
