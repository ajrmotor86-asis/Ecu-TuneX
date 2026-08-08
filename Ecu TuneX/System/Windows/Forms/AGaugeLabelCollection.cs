using System;
using System.Collections;

namespace System.Windows.Forms
{
	// Token: 0x0200000C RID: 12
	public class AGaugeLabelCollection : CollectionBase
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00008C0E File Offset: 0x00006E0E
		public AGaugeLabelCollection(AGauge sender)
		{
			this.Owner = sender;
		}

		// Token: 0x1700003F RID: 63
		public AGaugeLabel this[int index]
		{
			get
			{
				return (AGaugeLabel)base.List[index];
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00008C44 File Offset: 0x00006E44
		public bool Contains(AGaugeLabel itemType)
		{
			return base.List.Contains(itemType);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00008C64 File Offset: 0x00006E64
		public int Add(AGaugeLabel itemType)
		{
			itemType.SetOwner(this.Owner);
			bool flag = string.IsNullOrEmpty(itemType.Name);
			if (flag)
			{
				itemType.Name = this.GetUniqueName();
			}
			return base.List.Add(itemType);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00008813 File Offset: 0x00006A13
		public void Remove(AGaugeLabel itemType)
		{
			base.List.Remove(itemType);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00008CAC File Offset: 0x00006EAC
		public void Insert(int index, AGaugeLabel itemType)
		{
			itemType.SetOwner(this.Owner);
			bool flag = string.IsNullOrEmpty(itemType.Name);
			if (flag)
			{
				itemType.Name = this.GetUniqueName();
			}
			base.List.Insert(index, itemType);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public int IndexOf(AGaugeLabel itemType)
		{
			return base.List.IndexOf(itemType);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00008D14 File Offset: 0x00006F14
		public AGaugeLabel FindByName(string name)
		{
			foreach (object obj in base.List)
			{
				AGaugeLabel agaugeLabel = (AGaugeLabel)obj;
				bool flag = agaugeLabel.Name == name;
				if (flag)
				{
					return agaugeLabel;
				}
			}
			return null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008D88 File Offset: 0x00006F88
		protected override void OnInsert(int index, object value)
		{
			bool flag = string.IsNullOrEmpty(((AGaugeLabel)value).Name);
			if (flag)
			{
				((AGaugeLabel)value).Name = this.GetUniqueName();
			}
			base.OnInsert(index, value);
			((AGaugeLabel)value).SetOwner(this.Owner);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008DD8 File Offset: 0x00006FD8
		protected override void OnRemove(int index, object value)
		{
			bool flag = this.Owner != null;
			if (flag)
			{
				this.Owner.RepaintControl();
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008E00 File Offset: 0x00007000
		protected override void OnClear()
		{
			bool flag = this.Owner != null;
			if (flag)
			{
				this.Owner.RepaintControl();
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00008E28 File Offset: 0x00007028
		private string GetUniqueName()
		{
			int num = 1;
			while (base.Count != 0)
			{
				for (int i = 0; i < base.Count; i++)
				{
					bool flag = this[i].Name == "GaugeLabel" + num.ToString();
					if (!flag)
					{
						return "GaugeLabel" + num.ToString();
					}
				}
				num++;
			}
			return "GaugeLabel" + num.ToString();
		}

		// Token: 0x0400005E RID: 94
		private AGauge Owner;
	}
}
