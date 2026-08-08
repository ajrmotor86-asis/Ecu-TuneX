using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace _3D_Chart_Graph.Properties
{
	// Token: 0x02000020 RID: 32
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x00048E1A File Offset: 0x0004701A
		internal Resources()
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00048E24 File Offset: 0x00047024
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("_3D_Chart_Graph.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00048E6C File Offset: 0x0004706C
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00048E83 File Offset: 0x00047083
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00048E8C File Offset: 0x0004708C
		internal static Bitmap Analis
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Analis", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00048EBC File Offset: 0x000470BC
		internal static Bitmap WhatsApp_Image_2025_06_28_at_09_35_19
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("WhatsApp Image 2025-06-28 at 09.35.19", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00048EEC File Offset: 0x000470EC
		internal static Bitmap WhatsApp_Image_2025_06_28_at_12_52_53
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("WhatsApp Image 2025-06-28 at 12.52.53", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00048F1C File Offset: 0x0004711C
		internal static Bitmap WhatsApp_Image_2025_06_28_at_16_09_29
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("WhatsApp Image 2025-06-28 at 16.09.29", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400021C RID: 540
		private static ResourceManager resourceMan;

		// Token: 0x0400021D RID: 541
		private static CultureInfo resourceCulture;
	}
}
