using System;

// Token: 0x02000002 RID: 2
public static class Extensions
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
	public static int Clamp(this int value, int min, int max)
	{
		bool flag = value < min;
		int result;
		if (flag)
		{
			result = min;
		}
		else
		{
			bool flag2 = value > max;
			if (flag2)
			{
				result = max;
			}
			else
			{
				result = value;
			}
		}
		return result;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002074 File Offset: 0x00000274
	public static float Clamp(this float value, float min, float max)
	{
		bool flag = value < min;
		float result;
		if (flag)
		{
			result = min;
		}
		else
		{
			bool flag2 = value > max;
			if (flag2)
			{
				result = max;
			}
			else
			{
				result = value;
			}
		}
		return result;
	}
}
