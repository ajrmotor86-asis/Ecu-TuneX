using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Text;
using Microsoft.CSharp;

namespace Plot3D
{
	// Token: 0x02000005 RID: 5
	public static class FunctionCompiler
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024B4 File Offset: 0x000006B4
		public static Graph3D.delRendererFunction Compile(string functionBody)
		{
			functionBody = functionBody.Trim().ToLower();
			bool flag = functionBody.Contains(";");
			if (flag)
			{
				throw new Exception("Function string cannot contain semicolon");
			}
			string text = string.Format("using {1};\npublic class Eval\n{{\n\tpublic static double e  {{ get {{ return System.Math.E;  }}  }}\n\tpublic static double pi {{ get {{ return System.Math.PI; }}  }}\n\tpublic static double abs  (double x)           {{ return System.Math.Abs(x);      }}\n\tpublic static double acos (double x)           {{ return System.Math.Acos(x);     }}\n\tpublic static double asin (double x)           {{ return System.Math.Asin(x);     }}\n\tpublic static double atan (double x)           {{ return System.Math.Atan(x);     }}\n\tpublic static double atan2(double x, double y) {{ return System.Math.Atan2(x, y); }}\n\tpublic static double ceil (double x)           {{ return System.Math.Ceiling(x);  }}\n\tpublic static double cos  (double x)           {{ return System.Math.Cos(x);      }}\n\tpublic static double cosh (double x)           {{ return System.Math.Cosh(x);     }}\n\tpublic static double exp  (double x)           {{ return System.Math.Exp(x);      }}\n\tpublic static double floor(double x)           {{ return System.Math.Floor(x);    }}\n\tpublic static double log  (double x)           {{ return System.Math.Log(x);      }}\n\tpublic static double log2 (double x)           {{ return System.Math.Log(x, 2.0); }}\n\tpublic static double log10(double x)           {{ return System.Math.Log10(x);    }}\n\tpublic static double max  (double x, double y) {{ return System.Math.Max(x, y);   }}\n\tpublic static double min  (double x, double y) {{ return System.Math.Min(x, y);   }}\n\tpublic static double pow  (double x, double y) {{ return System.Math.Pow(x, y);   }}\n\tpublic static double round(double x)           {{ return System.Math.Round(x);    }}\n\tpublic static double sign (double x)           {{ return System.Math.Sign(x);     }}\n\tpublic static double sin  (double x)           {{ return System.Math.Sin(x);      }}\n\tpublic static double sinh (double x)           {{ return System.Math.Sinh(x);     }}\n\tpublic static double sqrt (double x)           {{ return System.Math.Sqrt(x);     }}\n\tpublic static double tan  (double x)           {{ return System.Math.Tan(x);      }}\n\tpublic static double tanh (double x)           {{ return System.Math.Tanh(x);     }}\n\tpublic static double __eval(params double[] __X)\n\t{{\n\t\tdouble x = __X[0];\n\t\tdouble y = __X[1];\n\t\treturn {0};\n\t}}\n\tpublic static {2} __get()\n\t{{\n\t\treturn __eval;\n\t}}\n}}", functionBody, typeof(delCompiledFunction).Namespace, typeof(delCompiledFunction).Name);
			CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider();
			CompilerResults compilerResults = csharpCodeProvider.CompileAssemblyFromSource(new CompilerParameters
			{
				CompilerOptions = "/t:library",
				GenerateInMemory = true,
				ReferencedAssemblies = 
				{
					"mscorlib.dll",
					"System.dll",
					Assembly.GetExecutingAssembly().Location
				}
			}, new string[]
			{
				text
			});
			bool hasErrors = compilerResults.Errors.HasErrors;
			if (hasErrors)
			{
				StringBuilder stringBuilder = new StringBuilder();
				bool flag2 = compilerResults.Errors.Count == 1;
				if (flag2)
				{
					stringBuilder.Append("Compilation error:\n");
				}
				else
				{
					stringBuilder.AppendFormat("{0} Compilation errors:\n", compilerResults.Errors.Count);
				}
				foreach (object obj in compilerResults.Errors)
				{
					CompilerError compilerError = (CompilerError)obj;
					stringBuilder.Append(compilerError.ErrorText);
					stringBuilder.Append("\n");
				}
				stringBuilder.Append("\nSupported math functions are:\ne, pi, abs(), acos(), asin(), atan(), atan2(), ceil(), cos(), cosh(), exp(), floor(), log(), log2(), log10(), max(), min(), pow(), round(), sign(), sin(), sinh(), sqrt(), tan(), tanh()\n");
				throw new Exception(stringBuilder.ToString());
			}
			MethodInfo method = compilerResults.CompiledAssembly.GetType("Eval").GetMethod("__get");
			delCompiledFunction f_Compiled = (delCompiledFunction)method.Invoke(null, null);
			return (double X, double Y) => f_Compiled(new double[]
			{
				X,
				Y
			});
		}

		// Token: 0x04000001 RID: 1
		private const string EVAL_CLASS = "using {1};\npublic class Eval\n{{\n\tpublic static double e  {{ get {{ return System.Math.E;  }}  }}\n\tpublic static double pi {{ get {{ return System.Math.PI; }}  }}\n\tpublic static double abs  (double x)           {{ return System.Math.Abs(x);      }}\n\tpublic static double acos (double x)           {{ return System.Math.Acos(x);     }}\n\tpublic static double asin (double x)           {{ return System.Math.Asin(x);     }}\n\tpublic static double atan (double x)           {{ return System.Math.Atan(x);     }}\n\tpublic static double atan2(double x, double y) {{ return System.Math.Atan2(x, y); }}\n\tpublic static double ceil (double x)           {{ return System.Math.Ceiling(x);  }}\n\tpublic static double cos  (double x)           {{ return System.Math.Cos(x);      }}\n\tpublic static double cosh (double x)           {{ return System.Math.Cosh(x);     }}\n\tpublic static double exp  (double x)           {{ return System.Math.Exp(x);      }}\n\tpublic static double floor(double x)           {{ return System.Math.Floor(x);    }}\n\tpublic static double log  (double x)           {{ return System.Math.Log(x);      }}\n\tpublic static double log2 (double x)           {{ return System.Math.Log(x, 2.0); }}\n\tpublic static double log10(double x)           {{ return System.Math.Log10(x);    }}\n\tpublic static double max  (double x, double y) {{ return System.Math.Max(x, y);   }}\n\tpublic static double min  (double x, double y) {{ return System.Math.Min(x, y);   }}\n\tpublic static double pow  (double x, double y) {{ return System.Math.Pow(x, y);   }}\n\tpublic static double round(double x)           {{ return System.Math.Round(x);    }}\n\tpublic static double sign (double x)           {{ return System.Math.Sign(x);     }}\n\tpublic static double sin  (double x)           {{ return System.Math.Sin(x);      }}\n\tpublic static double sinh (double x)           {{ return System.Math.Sinh(x);     }}\n\tpublic static double sqrt (double x)           {{ return System.Math.Sqrt(x);     }}\n\tpublic static double tan  (double x)           {{ return System.Math.Tan(x);      }}\n\tpublic static double tanh (double x)           {{ return System.Math.Tanh(x);     }}\n\tpublic static double __eval(params double[] __X)\n\t{{\n\t\tdouble x = __X[0];\n\t\tdouble y = __X[1];\n\t\treturn {0};\n\t}}\n\tpublic static {2} __get()\n\t{{\n\t\treturn __eval;\n\t}}\n}}";
	}
}
