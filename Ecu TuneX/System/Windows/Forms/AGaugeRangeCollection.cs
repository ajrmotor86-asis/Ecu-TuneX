using System;
using System.Collections;

namespace System.Windows.Forms
{
	// Token: 0x0200000A RID: 10
	public class AGaugeRangeCollection : CollectionBase
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00008775 File Offset: 0x00006975
		public AGaugeRangeCollection(AGauge sender)
		{
			this.Owner = sender;
		}

		// Token: 0x17000037 RID: 55
		public AGaugeRange this[int index]
		{
			get
			{
				return (AGaugeRange)base.List[index];
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000087AC File Offset: 0x000069AC
		public bool Contains(AGaugeRange itemType)
		{
			return base.List.Contains(itemType);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000087CC File Offset: 0x000069CC
		public int Add(AGaugeRange itemType)
		{
			itemType.SetOwner(this.Owner);
			bool flag = string.IsNullOrEmpty(itemType.Name);
			if (flag)
			{
				itemType.Name = this.GetUniqueName();
			}
			return base.List.Add(itemType);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008813 File Offset: 0x00006A13
		public void Remove(AGaugeRange itemType)
		{
			base.List.Remove(itemType);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00008824 File Offset: 0x00006A24
		public void Insert(int index, AGaugeRange itemType)
		{
			itemType.SetOwner(this.Owner);
			bool flag = string.IsNullOrEmpty(itemType.Name);
			if (flag)
			{
				itemType.Name = this.GetUniqueName();
			}
			base.List.Insert(index, itemType);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000886C File Offset: 0x00006A6C
		public int IndexOf(AGaugeRange itemType)
		{
			return base.List.IndexOf(itemType);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000888C File Offset: 0x00006A8C
		public AGaugeRange FindByName(string name)
		{
			foreach (object obj in base.List)
			{
				AGaugeRange agaugeRange = (AGaugeRange)obj;
				bool flag = agaugeRange.Name == name;
				if (flag)
				{
					return agaugeRange;
				}
			}
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00008900 File Offset: 0x00006B00
		protected override void OnInsert(int index, object value)
		{
			bool flag = string.IsNullOrEmpty(((AGaugeRange)value).Name);
			if (flag)
			{
				((AGaugeRange)value).Name = this.GetUniqueName();
			}
			base.OnInsert(index, value);
			((AGaugeRange)value).SetOwner(this.Owner);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008950 File Offset: 0x00006B50
		protected override void OnRemove(int index, object value)
		{
			bool flag = this.Owner != null;
			if (flag)
			{
				this.Owner.RepaintControl();
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00008978 File Offset: 0x00006B78
		protected override void OnClear()
		{
			bool flag = this.Owner != null;
			if (flag)
			{
				this.Owner.RepaintControl();
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000089A0 File Offset: 0x00006BA0
		private string GetUniqueName()
		{
			int num = 1;
			while (base.Count != 0)
			{
				bool flag = true;
				for (int i = 0; i < base.Count; i++)
				{
					bool flag2 = this[i].Name == "GaugeRange" + num.ToString();
					if (flag2)
					{
						flag = false;
						break;
					}
				}
				bool flag3 = flag;
				if (flag3)
				{
					break;
				}
				num++;
			}
			return "GaugeRange" + num.ToString();
		}

		// Token: 0x04000055 RID: 85
		private AGauge Owner;
	}
}
