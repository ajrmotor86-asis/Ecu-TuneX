using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x02000016 RID: 22
	public partial class Diag : Form
	{
		// Token: 0x0600012A RID: 298 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		public Diag()
		{
			this.InitializeComponent();
			base.MinimizeBox = false;
			base.ControlBox = true;
			this.listBox1.Visible = false;
			this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
			this.listBox1.DrawItem += this.listBox1_DrawItem1;
			this.timer1.Interval = 500;
			this.timer1.Enabled = true;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000AB8F File Offset: 0x00008D8F
		private void Diag_Load(object sender, EventArgs e)
		{
			this.InitFtdiIso();
			this.InitializeDataGridView();
			this.InitializeDataGridView2();
			base.FormClosing += this.SecondForm_FormClosing;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000ABBC File Offset: 0x00008DBC
		private void InitializeDataGridView()
		{
			this.dataGridView = new DataGridView
			{
				Dock = DockStyle.Fill,
				ColumnCount = 2,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
				ReadOnly = true,
				Enabled = false,
				AllowUserToAddRows = false,
				AllowUserToDeleteRows = false,
				AllowUserToResizeColumns = false,
				AllowUserToResizeRows = false,
				SelectionMode = DataGridViewSelectionMode.FullRowSelect,
				MultiSelect = false,
				RowHeadersVisible = true
			};
			this.dataGridView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView.ClearSelection();
			this.dataGridView.SelectionChanged += delegate(object s, EventArgs e)
			{
				this.dataGridView.ClearSelection();
			};
			this.dataGridView.Columns[0].HeaderText = "Parameter";
			this.dataGridView.Columns[1].HeaderText = "Value";
			this.dataGridView.Rows.Add(new object[]
			{
				"Engine RPM"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Throttle Position Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Throttle Position "
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Engine Temp Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Engine Temp "
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Intake Air Temperartur Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Intake Air Temperartur "
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Manifold Absolute Pressure Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Manifold Absolute Pressure"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Voltage Battery"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Injection Duration"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"MODE"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Ignition Timming"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Vehicle Speed Sensor"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"TableType"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Handle grip position 1 Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Handle grip position 2 Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Handle grip position 1 °"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Handle grip position 2 °"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Throttle Position 1 Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Throttle Position 2 Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Throttle Position 1 °"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Throttle Position 2 °"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"COR"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Intake Air Temperartur Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Intake Air Temperartur "
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Manifold Absolute Pressure Volt"
			});
			this.dataGridView.Rows.Add(new object[]
			{
				"Manifold Absolute Pressure"
			});
			for (int i = 0; i < this.dataGridView.Rows.Count; i++)
			{
				this.dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
			}
			this.dataGridView.CellFormatting += delegate(object s, DataGridViewCellFormattingEventArgs e)
			{
				e.CellStyle.BackColor = this.dataGridView.DefaultCellStyle.BackColor;
				e.CellStyle.SelectionBackColor = this.dataGridView.DefaultCellStyle.BackColor;
				e.CellStyle.SelectionForeColor = this.dataGridView.DefaultCellStyle.ForeColor;
			};
			this.panel2.Controls.Add(this.dataGridView);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000B080 File Offset: 0x00009280
		private void dtc()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				115,
				2,
				20
			};
			byte[] array2 = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref array2, ref num, 0);
			string text = BitConverter.ToString(array2).Replace("-", "");
			byte b = array2[5];
			byte b2 = array2[6];
			byte b3 = array2[7];
			byte b4 = array2[8];
			byte b5 = array2[9];
			byte b6 = array2[10];
			this.Hasil = string.Format("{0}-{1}, {2}-{3}, {4}-{5}", new object[]
			{
				b,
				b2,
				b3,
				b4,
				b5,
				b6
			});
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000B14C File Offset: 0x0000934C
		private void dtc2()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				115,
				1,
				21
			};
			byte[] array2 = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref array2, ref num, 0);
			string text = BitConverter.ToString(array2).Replace("-", "");
			byte b = array2[5];
			byte b2 = array2[6];
			byte b3 = array2[7];
			byte b4 = array2[8];
			byte b5 = array2[9];
			byte b6 = array2[10];
			this.Hasil2 = string.Format("{0}-{1}, {2}-{3}, {4}-{5}", new object[]
			{
				b,
				b2,
				b3,
				b4,
				b5,
				b6
			});
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000B218 File Offset: 0x00009418
		private void dtc3()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				116,
				2,
				19
			};
			byte[] array2 = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref array2, ref num, 0);
			string text = BitConverter.ToString(array2).Replace("-", "");
			byte b = array2[5];
			byte b2 = array2[6];
			byte b3 = array2[7];
			byte b4 = array2[8];
			byte b5 = array2[9];
			byte b6 = array2[10];
			this.Hasil3 = string.Format("{0}-{1}, {2}-{3}, {4}-{5}", new object[]
			{
				b,
				b2,
				b3,
				b4,
				b5,
				b6
			});
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000B2E4 File Offset: 0x000094E4
		private void dtc4()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				116,
				1,
				20
			};
			byte[] array2 = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref array2, ref num, 0);
			string text = BitConverter.ToString(array2).Replace("-", "");
			byte b = array2[5];
			byte b2 = array2[6];
			byte b3 = array2[7];
			byte b4 = array2[8];
			byte b5 = array2[9];
			byte b6 = array2[10];
			this.Hasil4 = string.Format("{0}-{1}, {2}-{3}, {4}-{5}", new object[]
			{
				b,
				b2,
				b3,
				b4,
				b5,
				b6
			});
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000B3AF File Offset: 0x000095AF
		private void Gabung(ref string gabung, string hasil1, string hasil2, string hasil3, string hasil4)
		{
			gabung = string.Concat(new string[]
			{
				hasil1,
				", ",
				hasil2,
				", ",
				hasil3,
				", ",
				hasil4
			});
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000B3EC File Offset: 0x000095EC
		private void ContohPemanggilanGabung()
		{
			this.Gabung(ref this.hasilGabungan, this.Hasil, this.Hasil2, this.Hasil3, this.Hasil4);
			Console.WriteLine(this.hasilGabungan);
			this.DisplayResponse(this.hasilGabungan);
			this.dtcCounter = 1;
			this.dtcTitleAdded = false;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000B448 File Offset: 0x00009648
		private void DisplayResponse(string hasilGabungan)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"1-1",
					"MAP sensor circuit low voltage"
				},
				{
					"1-2",
					"MAP sensor circuit high voltage"
				},
				{
					"2-1",
					"MAP sensor performance problem"
				},
				{
					"7-1",
					"ECT sensor circuit low voltage"
				},
				{
					"7-2",
					"ECT sensor circuit high voltage"
				},
				{
					"8-1",
					"TP sensor circuit low voltage"
				},
				{
					"8-2",
					"TP sensor circuit high voltage"
				},
				{
					"9-1",
					"IAT sensor circuit low voltage"
				},
				{
					"9-2",
					"IAT sensor circuit high voltage"
				},
				{
					"11-1",
					"VS sensor no signal"
				},
				{
					"12-1",
					"No.1 primary injector circuit malfunction"
				},
				{
					"13-1",
					"No.2 primary injector circuit malfunction"
				},
				{
					"14-1",
					"No.3 primary injector circuit malfunction"
				},
				{
					"15-1",
					"No.4 primary injector circuit malfunction"
				},
				{
					"16-1",
					"No.1 secondary injector circuit malfunction"
				},
				{
					"17-1",
					"No.2 secondary injector circuit malfunction"
				},
				{
					"18-1",
					"CMP sensor no signal"
				},
				{
					"19-1",
					"CKP sensor no signal"
				},
				{
					"21-1",
					"0₂ sensor malfunction"
				},
				{
					"23-1",
					"0₂ sensor heater malfunction"
				},
				{
					"25-2",
					"Knock sensor circuit malfunction"
				},
				{
					"25-3",
					"Knock sensor circuit malfunction"
				},
				{
					"29-1",
					"IACV circuit malfunction"
				},
				{
					"33-2",
					"ECM EEPROM malfunction"
				},
				{
					"34-1",
					"ECV POT low voltage malfunction"
				},
				{
					"34-2",
					"ECV POT high voltage malfunction"
				},
				{
					"35-1",
					"EGCA malfunction"
				},
				{
					"48-1",
					"No.3 secondary injector circuit malfunction"
				},
				{
					"49-1",
					"No.4 secondary injector circuit malfunction"
				},
				{
					"51-1",
					"HESD linear solenoid malfunction"
				},
				{
					"54-1",
					"Bank angle sensor circuit low voltage"
				},
				{
					"54-2",
					"Bank angle sensor circuit high voltage"
				},
				{
					"56-1",
					"Knock sensor IC malfunction"
				},
				{
					"57-1",
					"Engine coolant over temperature"
				},
				{
					"57-2",
					"Engine coolant over temperature"
				},
				{
					"86-1",
					"Serial communication malfunction"
				},
				{
					"91-1",
					"Coil Ignition Primary Malfungtion"
				},
				{
					"91-2",
					"Coil Ignition Primary Malfungtion"
				}
			};
			string[] array = hasilGabungan.Split(new string[]
			{
				", "
			}, StringSplitOptions.None);
			foreach (string key in array)
			{
				string message;
				bool flag = dictionary.TryGetValue(key, out message);
				if (flag)
				{
					this.ShowMessageInListBox(message);
				}
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000B72C File Offset: 0x0000992C
		private void ShowMessageInListBox(string message)
		{
			string format = "{0}. {1}";
			int num = this.dtcCounter;
			this.dtcCounter = num + 1;
			string item = string.Format(format, num, message);
			this.listBox1.Items.Add(item);
			this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000B77C File Offset: 0x0000997C
		private void listBox1_DrawItem1(object sender, DrawItemEventArgs e)
		{
			bool flag = e.Index < 0;
			if (!flag)
			{
				string s = this.listBox1.Items[e.Index].ToString();
				float num = 10f;
				float y = (float)e.Bounds.Top + num;
				e.Graphics.DrawString(s, this.listBox1.Font, Brushes.Black, (float)e.Bounds.Left, y);
				e.DrawFocusRectangle();
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000B803 File Offset: 0x00009A03
		private void ClearAllMessages()
		{
			this.listBox1.Items.Clear();
			this.dtcTitleAdded = false;
			this.listBox1.Refresh();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000B82C File Offset: 0x00009A2C
		private void rst()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				96,
				1,
				40
			};
			byte[] value = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref value, ref num, 0);
			string text = BitConverter.ToString(value).Replace("-", "");
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000B888 File Offset: 0x00009A88
		private void rst1()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				96,
				3,
				38
			};
			byte[] value = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref value, ref num, 0);
			string text = BitConverter.ToString(value).Replace("-", "");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000B8E4 File Offset: 0x00009AE4
		private void rst2()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				0,
				240,
				153
			};
			byte[] value = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref value, ref num, 0);
			string text = BitConverter.ToString(value).Replace("-", "");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000B940 File Offset: 0x00009B40
		private void rst3()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				96,
				1,
				40
			};
			byte[] value = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref value, ref num, 0);
			string text = BitConverter.ToString(value).Replace("-", "");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000B99C File Offset: 0x00009B9C
		private void rst4()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				116,
				3,
				18
			};
			byte[] value = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref value, ref num, 0);
			string text = BitConverter.ToString(value).Replace("-", "");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000B9F8 File Offset: 0x00009BF8
		private void InitializeDataGridView2()
		{
			this.dataGridView2 = new DataGridView
			{
				Dock = DockStyle.Fill,
				ColumnCount = 2,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
				ReadOnly = true,
				Enabled = false,
				AllowUserToAddRows = false,
				AllowUserToDeleteRows = false,
				AllowUserToResizeColumns = false,
				AllowUserToResizeRows = false,
				SelectionMode = DataGridViewSelectionMode.FullRowSelect,
				MultiSelect = false,
				RowHeadersVisible = true
			};
			this.dataGridView2.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView2.ClearSelection();
			this.dataGridView2.SelectionChanged += delegate(object s, EventArgs e)
			{
				this.dataGridView2.ClearSelection();
			};
			this.dataGridView2.Columns[0].HeaderText = "Parameter";
			this.dataGridView2.Columns[1].HeaderText = "Value";
			this.dataGridView2.Rows.Add(new object[]
			{
				"Oxygen Sensor"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Oxygen Sensor Volt"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Short term Fuel Trim"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Air Fuel Ratio"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Fast Idle Step"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Bank Angle Sensor"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Switch Starter"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Side Stand Switch"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Gear Status"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Fuel Pump"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Cooling Fan"
			});
			this.dataGridView2.Rows.Add(new object[]
			{
				"Gear Position"
			});
			for (int i = 0; i < this.dataGridView2.Rows.Count; i++)
			{
				this.dataGridView2.Rows[i].HeaderCell.Value = (i + 1).ToString();
			}
			this.dataGridView2.CellFormatting += delegate(object s, DataGridViewCellFormattingEventArgs e)
			{
				e.CellStyle.BackColor = this.dataGridView2.DefaultCellStyle.BackColor;
				e.CellStyle.SelectionBackColor = this.dataGridView2.DefaultCellStyle.BackColor;
				e.CellStyle.SelectionForeColor = this.dataGridView2.DefaultCellStyle.ForeColor;
			};
			this.panel3.Controls.Add(this.dataGridView2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000BCCC File Offset: 0x00009ECC
		private void LoopDat17(CancellationToken token)
		{
			while (!token.IsCancellationRequested)
			{
				bool flag = this.tek11;
				if (flag)
				{
					this.dat11();
					this.dat20();
				}
				bool flag2 = this.tek10;
				if (flag2)
				{
					this.dat10();
					this.dat20();
				}
				bool flag3 = this.tek13;
				if (flag3)
				{
					this.dat13();
					this.dat20();
				}
				bool flag4 = this.tek16;
				if (flag4)
				{
					this.dat16();
					this.dat20();
				}
				bool flag5 = this.tek17;
				if (flag5)
				{
					this.dat17();
					this.dat20();
				}
				Task.Delay(10, token);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000BD84 File Offset: 0x00009F84
		private void dat10()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				113,
				16,
				8
			};
			byte[] array2 = new byte[256];
			uint length = 0U;
			this.SendCommand(array, array.Length, ref array2, ref length, 0);
			string str = BitConverter.ToString(array2, 0, (int)length);
			Console.WriteLine("Response dat10: " + str);
			bool flag = array2[1] == 5;
			if (flag)
			{
				this.tek10 = false;
			}
			else
			{
				try
				{
					bool flag2 = array2.Length >= 1;
					if (flag2)
					{
						int rpm = ((int)array2[4] << 8) + (int)array2[5];
						float tps = (float)array2[6] * 5f / 256f;
						float tps2 = (float)array2[7] / 2f;
						float ect = (float)array2[8] * 5f / 256f;
						float ect2 = (float)(array2[9] - 40);
						float iat = (float)array2[10] * 5f / 256f;
						float iat2 = (float)(array2[11] - 40);
						float map = (float)array2[12] * 5f / 256f;
						int num = (int)array2[13];
						float bat = (float)array2[16] / 10f;
						int vss = (int)array2[17];
						float inj = (float)(((int)array2[18] << 8) + (int)array2[19]) / 200f;
						float adv = (float)array2[20] / 2f - 64f;
						this.UpdateGridView(rpm, tps, tps2, ect, ect2, iat, iat2, map, (float)num, bat, inj, 0, adv, vss, 16, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0);
					}
					else
					{
						Console.WriteLine("Response array is too small to be parsed.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error decoding data: " + ex.Message);
				}
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000BF68 File Offset: 0x0000A168
		private void datD1()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				113,
				209,
				71
			};
			byte[] array2 = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref array2, ref num, 0);
			try
			{
				Console.WriteLine("array9 (Hex): " + BitConverter.ToString(array2));
				this.bas = (this.sss = (this.ssw = (this.ggs = (this.pom = (this.fan = (this.ggv = "OFF"))))));
				this.ggs = "Netral";
				switch (array2[4])
				{
				case 0:
					this.ggs = "OnGear";
					this.ssw = "OFF";
					this.sss = "OFF";
					break;
				case 1:
					this.bas = "ON";
					this.ggs = "Netral";
					this.ssw = "OFF";
					this.sss = "ON";
					break;
				case 2:
					this.ssw = "ON";
					break;
				default:
					this.ssw = "OFF";
					break;
				}
				switch (array2[8])
				{
				case 0:
					this.pom = "OFF";
					break;
				case 1:
				case 5:
					this.pom = "ON";
					break;
				case 4:
					this.pom = "OFF";
					break;
				}
				this.fan = ((array2[9] == 1) ? "ON" : "OFF");
				byte b = array2[10];
				byte b2 = b;
				byte b3 = b2;
				if (b3 <= 16)
				{
					switch (b3)
					{
					case 0:
						this.ggv = "-";
						goto IL_261;
					case 1:
						this.ggv = "1";
						goto IL_261;
					case 2:
						this.ggv = "2";
						goto IL_261;
					case 3:
					case 5:
					case 6:
					case 7:
						break;
					case 4:
						this.ggv = "3";
						goto IL_261;
					case 8:
						this.ggv = "4";
						goto IL_261;
					default:
						if (b3 == 16)
						{
							this.ggv = "5";
							goto IL_261;
						}
						break;
					}
				}
				else
				{
					if (b3 == 32)
					{
						this.ggv = "N";
						goto IL_261;
					}
					if (b3 == 128)
					{
						this.ggv = "6";
						goto IL_261;
					}
				}
				this.ggv = "-";
				IL_261:
				this.UpdateGridView2(this.oxi, this.o2v, this.stf, this.afr, this.fiz, this.bas, this.sss, this.ssw, this.ggs, this.pom, this.fan, this.ggv);
				Console.WriteLine("Data updated in GridView.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error decoding data: " + ex.Message);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000C26C File Offset: 0x0000A46C
		private void dat20()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				113,
				32,
				248
			};
			byte[] array2 = new byte[256];
			uint num = 0U;
			this.SendCommand(array, array.Length, ref array2, ref num, 0);
			try
			{
				this.o2 = (float)(BitConverter.ToUInt16(array2, 4) & ushort.MaxValue) / 13.1427078f / 1000f;
				this.stf = (float)(array2[5] & byte.MaxValue) / 128.256516f;
				this.oxi = this.o2;
				this.o2v = (float)(array2[4] & byte.MaxValue) / 50.9937f;
				this.afr = (float)(-5.351 * (double)this.o2v + 17.700000762939453);
				this.UpdateGridView2(this.oxi, this.o2v, this.stf, this.afr, this.fiz, this.bas, this.sss, this.ssw, this.ggs, this.pom, this.fan, this.ggv);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error decoding data: " + ex.Message);
			}
			this.datD1();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		private void UpdateGridView2(float oxi, float o2v, float stf, float afr, string fiz, string bas, string sss, string ssw, string ggs, string pom, string fan, string ggv)
		{
			bool invokeRequired = this.dataGridView2.InvokeRequired;
			if (invokeRequired)
			{
				this.dataGridView2.Invoke(new Action(delegate()
				{
					this.UpdateRows2(oxi, o2v, stf, afr, fiz, bas, sss, ssw, ggs, pom, fan, ggv);
				}));
			}
			else
			{
				this.UpdateRows2(oxi, o2v, stf, afr, fiz, bas, sss, ssw, ggs, pom, fan, ggv);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000C49C File Offset: 0x0000A69C
		private void UpdateRows2(float oxi, float o2v, float stf, float afr, string fiz, string bas, string sss, string ssw, string ggs, string pom, string fan, string ggv)
		{
			Console.WriteLine(string.Concat(new string[]
			{
				"Updating GridView with bas: ",
				bas,
				", sss: ",
				sss,
				", ssw: ",
				ssw,
				", ggs: ",
				ggs,
				", pom: ",
				pom,
				", fan: ",
				fan,
				", ggv: ",
				ggv
			}));
			this.dataGridView2.Rows[0].Cells[1].Value = oxi.ToString("F4");
			this.dataGridView2.Rows[1].Cells[1].Value = o2v.ToString("F4") + " Volt";
			this.dataGridView2.Rows[2].Cells[1].Value = stf.ToString("F4");
			this.dataGridView2.Rows[3].Cells[1].Value = afr.ToString("F2") + " : 1";
			this.dataGridView2.Rows[4].Cells[1].Value = fiz;
			this.dataGridView2.Rows[5].Cells[1].Value = bas;
			this.dataGridView2.Rows[6].Cells[1].Value = sss;
			this.dataGridView2.Rows[7].Cells[1].Value = ssw;
			this.dataGridView2.Rows[8].Cells[1].Value = ggs;
			this.dataGridView2.Rows[9].Cells[1].Value = pom;
			this.dataGridView2.Rows[10].Cells[1].Value = fan;
			this.dataGridView2.Rows[11].Cells[1].Value = ggv;
			this.dataGridView2.InvalidateCell(this.dataGridView2.Rows[5].Cells[1]);
			this.dataGridView2.InvalidateCell(this.dataGridView2.Rows[6].Cells[1]);
			this.dataGridView2.InvalidateCell(this.dataGridView2.Rows[7].Cells[1]);
			this.dataGridView2.InvalidateCell(this.dataGridView2.Rows[8].Cells[1]);
			this.dataGridView2.InvalidateCell(this.dataGridView2.Rows[9].Cells[1]);
			this.dataGridView2.InvalidateCell(this.dataGridView2.Rows[10].Cells[1]);
			this.dataGridView2.InvalidateCell(this.dataGridView2.Rows[11].Cells[1]);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000C828 File Offset: 0x0000AA28
		private void dat11()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				113,
				17,
				7
			};
			byte[] array2 = new byte[256];
			uint length = 0U;
			this.SendCommand(array, array.Length, ref array2, ref length, 0);
			string str = BitConverter.ToString(array2, 0, (int)length);
			Console.WriteLine("Response 11: " + str);
			bool flag = array2[1] == 5;
			if (flag)
			{
				this.tek11 = false;
			}
			else
			{
				try
				{
					bool flag2 = array2.Length >= 1;
					if (flag2)
					{
						int rpm = ((int)array2[4] << 8) + (int)array2[5];
						float tps = (float)array2[6] * 5f / 256f;
						float tps2 = (float)array2[7] / 2f;
						float ect = (float)array2[8] * 5f / 256f;
						float ect2 = (float)(array2[9] - 40);
						float iat = (float)array2[10] * 5f / 256f;
						float iat2 = (float)(array2[11] - 40);
						float map = (float)array2[12] * 5f / 256f;
						int num = (int)array2[13];
						float bat = (float)array2[16] / 10f;
						int vss = (int)array2[17];
						float inj = (float)(((int)array2[18] << 8) + (int)array2[19]) / 200f;
						float adv = (float)array2[20] / 2f - 64f;
						float num2 = (float)array2[22] / 10000f;
						this.UpdateGridView(rpm, tps, tps2, ect, ect2, iat, iat2, map, (float)num, bat, inj, 0, adv, vss, 17, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0);
					}
					else
					{
						Console.WriteLine("Response array is too small to be parsed.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error decoding data: " + ex.Message);
				}
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000CA1C File Offset: 0x0000AC1C
		private void dat13()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				113,
				19,
				5
			};
			byte[] array2 = new byte[256];
			uint length = 0U;
			this.SendCommand(array, array.Length, ref array2, ref length, 0);
			string str = BitConverter.ToString(array2, 0, (int)length);
			Console.WriteLine("Response 13: " + str);
			bool flag = array2[1] == 5;
			if (flag)
			{
				this.tek13 = false;
			}
			else
			{
				try
				{
					bool flag2 = array2.Length >= 1;
					if (flag2)
					{
						int rpm = ((int)array2[4] << 8) + (int)array2[5];
						float tps = (float)array2[6] * 5f / 256f;
						float tps2 = (float)array2[7] / 2f;
						float ect = (float)array2[8] * 5f / 256f;
						float ect2 = (float)(array2[9] - 40);
						float iat = (float)array2[10] * 5f / 256f;
						float iat2 = (float)(array2[11] - 40);
						float map = (float)array2[12] * 5f / 256f;
						int num = (int)array2[13];
						float bat = (float)array2[14] / 10f;
						float inj = (float)(((int)array2[15] << 8) + (int)array2[16]) / 200f;
						float adv = (float)array2[17] / 2f - 64f;
						this.UpdateGridView(rpm, tps, tps2, ect, ect2, iat, iat2, map, (float)num, bat, inj, 0, adv, 0, 19, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0);
					}
					else
					{
						Console.WriteLine("Response array is too small to be parsed.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error decoding data: " + ex.Message);
				}
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		private void dat16()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				113,
				22,
				2
			};
			byte[] array2 = new byte[256];
			uint length = 0U;
			this.SendCommand(array, array.Length, ref array2, ref length, 0);
			string str = BitConverter.ToString(array2, 0, (int)length);
			Console.WriteLine("Response 16: " + str);
			bool flag = array2[1] == 5;
			if (flag)
			{
				this.tek16 = false;
			}
			else
			{
				try
				{
					bool flag2 = array2.Length >= 2;
					if (flag2)
					{
						int rpm = ((int)array2[4] << 8) + (int)array2[5];
						float num = (float)array2[6] * 5f / 256f;
						float num2 = (float)array2[7] * 5f / 256f;
						float num3 = (float)array2[8] / 2f;
						float num4 = (float)array2[9] / 2f;
						float num5 = (float)array2[10] * 5f / 256f;
						float num6 = (float)array2[11] * 5f / 256f;
						float num7 = (float)array2[12] / 2f;
						float num8 = (float)array2[13] / 2f;
						int num9 = (int)array2[14];
						float num10 = (float)array2[15] * 5f / 256f;
						float num11 = (float)array2[16] - 40f;
						float num12 = (float)array2[17] * 5f / 256f;
						float num13 = (float)array2[18] - 40f;
						float num14 = (float)array2[19] * 5f / 256f;
						int num15 = (int)array2[20];
						float num16 = (float)array2[21] / 10f;
						int num17 = (int)array2[22];
						float num18 = (float)array2[23] / 200f;
						float num19 = (float)array2[24] / 2f - 64f;
						this.UpdateGridView(rpm, (float)((int)Math.Round((double)num)), (float)((int)Math.Round((double)num2)), (float)((int)Math.Round((double)num3)), (float)((int)Math.Round((double)num4)), (float)((int)Math.Round((double)num5)), (float)((int)Math.Round((double)num6)), (float)((int)Math.Round((double)num7)), (float)((int)Math.Round((double)num8)), (float)num9, (float)((int)Math.Round((double)num10)), (int)Math.Round((double)num11), (float)((int)Math.Round((double)num12)), (int)Math.Round((double)num13), (int)Math.Round((double)num14), (float)num15, (float)((int)Math.Round((double)num16)), (float)num17, (float)((int)Math.Round((double)num18)), (float)((int)Math.Round((double)num19)), 0f, 0f, 0f, 0, 0f, 0f, 0f, 0);
					}
					else
					{
						Console.WriteLine("Response array is too small to be parsed.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error decoding data: " + ex.Message);
				}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		private void dat17()
		{
			byte[] array = new byte[]
			{
				114,
				5,
				113,
				23,
				1
			};
			byte[] array2 = new byte[256];
			uint length = 0U;
			this.SendCommand(array, array.Length, ref array2, ref length, 0);
			string str = BitConverter.ToString(array2, 0, (int)length);
			Console.WriteLine("Response 17: " + str);
			bool flag = array2[1] == 5;
			if (flag)
			{
				this.tek17 = false;
			}
			else
			{
				try
				{
					int rpm = ((int)array2[4] << 8) + (int)array2[5];
					float tps = (float)array2[6] * 5f / 256f;
					float tps2 = (float)array2[7] / 2f;
					float ect = (array2[12] != byte.MaxValue) ? ((float)array2[12] * 5f / 256f) : ((float)array2[8] * 5f / 256f);
					float ect2 = (float)((array2[13] != byte.MaxValue) ? (array2[13] - 40) : (array2[9] - 40));
					float bat = (float)array2[14] / 10f;
					float inj = (float)(((int)array2[15] << 8) + (int)array2[16]) / 200f;
					int num = (int)array2[18];
					bool flag2 = num == 128 || num == 103;
					int mode;
					if (flag2)
					{
						mode = 1;
					}
					else
					{
						bool flag3 = num == 102;
						if (flag3)
						{
							mode = 2;
						}
						else
						{
							bool flag4 = num == 60;
							if (flag4)
							{
								mode = 3;
							}
							else
							{
								bool flag5 = num == 89;
								if (flag5)
								{
									mode = 4;
								}
								else
								{
									bool flag6 = num == 121;
									if (flag6)
									{
										mode = 0;
									}
									else
									{
										mode = 0;
									}
								}
							}
						}
					}
					bool flag7 = num < 128;
					if (flag7)
					{
						this.fiz = "ON";
					}
					else
					{
						this.fiz = "OFF";
					}
					float adv = (float)array2[17] / 2f - 64f;
					int vss = (int)array2[19];
					int tableType = (int)array2[2];
					this.UpdateGridView(rpm, tps, tps2, ect, ect2, 0f, 0f, 0f, 0f, bat, inj, mode, adv, vss, tableType, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0);
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error decoding data: " + ex.Message);
				}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000D12C File Offset: 0x0000B32C
		private void UpdateGridView(int rpm, float tps1, float tps2, float ect1, float ect2, float iat1, float iat2, float map1, float map2, float bat, float inj, int MODE, float adv, int vss, int tableType, float ap1_0 = 0f, float ap2_0 = 0f, float ap1_1 = 0f, float ap2_1 = 0f, float tp1_0 = 0f, float tp2_0 = 0f, float tp1_1 = 0f, float tp2_1 = 0f, int cor = 0, float iat11 = 0f, float iat21 = 0f, float map11 = 0f, int map21 = 0)
		{
			bool invokeRequired = this.dataGridView.InvokeRequired;
			if (invokeRequired)
			{
				this.dataGridView.Invoke(new Action(delegate()
				{
					this.UpdateRows(rpm, tps1, tps2, ect1, ect2, iat1, iat2, map1, map2, bat, inj, MODE, adv, vss, tableType, ap1_0, ap2_0, ap1_1, ap2_1, tp1_0, tp2_0, tp1_1, tp2_1, cor, iat11, iat21, map11, map21);
				}));
			}
			else
			{
				this.UpdateRows(rpm, tps1, tps2, ect1, ect2, iat1, iat2, map1, map2, bat, inj, MODE, adv, vss, tableType, ap1_0, ap2_0, ap1_1, ap2_1, tp1_0, tp2_0, tp1_1, tp2_1, cor, iat11, iat21, map11, map21);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000D304 File Offset: 0x0000B504
		private void UpdateRows(int rpm, float tps1, float tps2, float ect1, float ect2, float iat1, float iat2, float map1, float map2, float bat, float inj, int MODE, float adv, int vss, int tableType, float ap1_0, float ap2_0, float ap1_1, float ap2_1, float tp1_0, float tp2_0, float tp1_1, float tp2_1, int cor, float iat11, float iat21, float map11, int map21)
		{
			this.dataGridView.Rows[0].Cells[1].Value = rpm.ToString() + " RPM";
			this.dataGridView.Rows[1].Cells[1].Value = tps1.ToString() + " Volt";
			this.dataGridView.Rows[2].Cells[1].Value = tps2.ToString() + " °";
			this.dataGridView.Rows[3].Cells[1].Value = ect1.ToString() + " Volt";
			this.dataGridView.Rows[4].Cells[1].Value = ect2.ToString() + " °C";
			this.dataGridView.Rows[5].Cells[1].Value = iat1.ToString() + " Volt";
			this.dataGridView.Rows[6].Cells[1].Value = iat2.ToString() + " °C";
			this.dataGridView.Rows[7].Cells[1].Value = map1.ToString() + " Volt";
			this.dataGridView.Rows[8].Cells[1].Value = map2.ToString();
			this.dataGridView.Rows[9].Cells[1].Value = bat.ToString() + " Volt";
			this.dataGridView.Rows[10].Cells[1].Value = inj.ToString() + " ms";
			this.dataGridView.Rows[11].Cells[1].Value = MODE.ToString();
			this.dataGridView.Rows[12].Cells[1].Value = adv.ToString() + " °";
			this.dataGridView.Rows[13].Cells[1].Value = vss.ToString() + " km/h";
			this.dataGridView.Rows[14].Cells[1].Value = tableType.ToString();
			this.dataGridView.Rows[15].Cells[1].Value = ap1_0.ToString() + " Volt";
			this.dataGridView.Rows[16].Cells[1].Value = ap2_0.ToString() + " Volt";
			this.dataGridView.Rows[17].Cells[1].Value = ap1_1.ToString() + " °";
			this.dataGridView.Rows[18].Cells[1].Value = ap2_1.ToString() + " °";
			this.dataGridView.Rows[19].Cells[1].Value = tp1_0.ToString() + " Volt";
			this.dataGridView.Rows[20].Cells[1].Value = tp2_0.ToString() + " Volt";
			this.dataGridView.Rows[21].Cells[1].Value = tp1_1.ToString() + " °";
			this.dataGridView.Rows[22].Cells[1].Value = tp2_1.ToString() + " °";
			this.dataGridView.Rows[23].Cells[1].Value = cor.ToString();
			this.dataGridView.Rows[24].Cells[1].Value = iat11.ToString() + " Volt";
			this.dataGridView.Rows[25].Cells[1].Value = iat21.ToString() + " °C";
			this.dataGridView.Rows[26].Cells[1].Value = map11.ToString() + " Volt";
			this.dataGridView.Rows[27].Cells[1].Value = map21.ToString();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000D888 File Offset: 0x0000BA88
		private void start()
		{
			this._cancellationTokenSource = new CancellationTokenSource();
			Thread thread = new Thread(delegate()
			{
				this.LoopDat17(this._cancellationTokenSource.Token);
			})
			{
				IsBackground = true
			};
			thread.Start();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		[DebuggerStepThrough]
		private void button2_Click(object sender, EventArgs e)
		{
			Diag.<button2_Click>d__64 <button2_Click>d__ = new Diag.<button2_Click>d__64();
			<button2_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button2_Click>d__.<>4__this = this;
			<button2_Click>d__.sender = sender;
			<button2_Click>d__.e = e;
			<button2_Click>d__.<>1__state = -1;
			<button2_Click>d__.<>t__builder.Start<Diag.<button2_Click>d__64>(ref <button2_Click>d__);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000D90B File Offset: 0x0000BB0B
		private void button1_Click(object sender, EventArgs e)
		{
			CancellationTokenSource cancellationTokenSource = this._cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
			this.CloseFtdiConnection();
			base.Close();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000D930 File Offset: 0x0000BB30
		private void CloseFtdiConnection()
		{
			bool flag = Diag.ftHandle != IntPtr.Zero;
			if (flag)
			{
				FTDI.FT_Close(Diag.ftHandle);
				Diag.ftHandle = IntPtr.Zero;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000D968 File Offset: 0x0000BB68
		private bool InitFtdiIso()
		{
			byte[] array = new byte[1];
			byte[] array2 = new byte[]
			{
				1
			};
			uint num = 0U;
			bool flag = FTDI.FT_Open(0U, ref Diag.ftHandle) > FTDI.FT_STATUS.FT_OK;
			bool flag2 = flag;
			bool result;
			if (flag2)
			{
				FTDI.FT_Close(Diag.ftHandle);
				result = false;
			}
			else
			{
				bool flag3 = FTDI.FT_Purge(Diag.ftHandle, 3U) > FTDI.FT_STATUS.FT_OK;
				bool flag4 = flag3;
				if (flag4)
				{
					FTDI.FT_Close(Diag.ftHandle);
					result = false;
				}
				else
				{
					bool flag5 = FTDI.FT_SetBitMode(Diag.ftHandle, 0, 0) > FTDI.FT_STATUS.FT_OK;
					bool flag6 = flag5;
					if (flag6)
					{
						FTDI.FT_Close(Diag.ftHandle);
						result = false;
					}
					else
					{
						bool flag7 = FTDI.FT_SetDataCharacteristics(Diag.ftHandle, 8, 0, 0) > FTDI.FT_STATUS.FT_OK;
						bool flag8 = flag7;
						if (flag8)
						{
							FTDI.FT_Close(Diag.ftHandle);
							result = false;
						}
						else
						{
							bool flag9 = FTDI.FT_SetBaudRate(Diag.ftHandle, 10400U) > FTDI.FT_STATUS.FT_OK;
							bool flag10 = flag9;
							if (flag10)
							{
								FTDI.FT_Close(Diag.ftHandle);
								result = false;
							}
							else
							{
								bool flag11 = FTDI.FT_SetTimeouts(Diag.ftHandle, 50U, 0U) > FTDI.FT_STATUS.FT_OK;
								bool flag12 = flag11;
								if (flag12)
								{
									FTDI.FT_Close(Diag.ftHandle);
									result = false;
								}
								else
								{
									bool flag13 = FTDI.FT_SetLatencyTimer(Diag.ftHandle, 8) > FTDI.FT_STATUS.FT_OK;
									bool flag14 = flag13;
									if (flag14)
									{
										FTDI.FT_Close(Diag.ftHandle);
										result = false;
									}
									else
									{
										bool flag15 = FTDI.FT_SetBitMode(Diag.ftHandle, 1, 1) > FTDI.FT_STATUS.FT_OK;
										bool flag16 = flag15;
										if (flag16)
										{
											FTDI.FT_Close(Diag.ftHandle);
											result = false;
										}
										else
										{
											bool flag17 = FTDI.FT_Write(Diag.ftHandle, array, (uint)array.Length, ref num) > FTDI.FT_STATUS.FT_OK;
											bool flag18 = flag17;
											if (flag18)
											{
												FTDI.FT_Close(Diag.ftHandle);
												result = false;
											}
											else
											{
												Thread.Sleep(70);
												bool flag19 = FTDI.FT_Write(Diag.ftHandle, array2, (uint)array2.Length, ref num) > FTDI.FT_STATUS.FT_OK;
												bool flag20 = flag19;
												if (flag20)
												{
													FTDI.FT_Close(Diag.ftHandle);
													result = false;
												}
												else
												{
													bool flag21 = FTDI.FT_SetBitMode(Diag.ftHandle, 0, 0) > FTDI.FT_STATUS.FT_OK;
													bool flag22 = flag21;
													if (flag22)
													{
														FTDI.FT_Close(Diag.ftHandle);
														result = false;
													}
													else
													{
														bool flag23 = FTDI.FT_SetBaudRate(Diag.ftHandle, 10400U) > FTDI.FT_STATUS.FT_OK;
														bool flag24 = flag23;
														if (flag24)
														{
															FTDI.FT_Close(Diag.ftHandle);
															result = false;
														}
														else
														{
															bool flag25 = FTDI.FT_Purge(Diag.ftHandle, 3U) > FTDI.FT_STATUS.FT_OK;
															bool flag26 = flag25;
															if (flag26)
															{
																FTDI.FT_Close(Diag.ftHandle);
																result = false;
															}
															else
															{
																Thread.Sleep(130);
																result = true;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		private bool SendCommand(byte[] command, int commandSize, ref byte[] reply, ref uint replySize, int sleepMs = 0)
		{
			byte[] array = new byte[256];
			byte[] array2 = new byte[256];
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			uint num5 = 0U;
			long num6 = (long)(50 + 2 * commandSize);
			bool flag = FTDI.FT_Write(Diag.ftHandle, command, (uint)commandSize, ref num) > FTDI.FT_STATUS.FT_OK;
			bool flag2 = flag;
			bool result;
			if (flag2)
			{
				result = false;
			}
			else
			{
				bool flag3 = FTDI.FT_SetLatencyTimer(Diag.ftHandle, 8) > FTDI.FT_STATUS.FT_OK;
				bool flag4 = !flag3;
				if (flag4)
				{
					bool flag5 = sleepMs > 0;
					bool flag6 = flag5;
					if (flag6)
					{
						Thread.Sleep(sleepMs);
					}
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					for (;;)
					{
						bool flag7 = FTDI.FT_GetQueueStatus(Diag.ftHandle, ref num2) == FTDI.FT_STATUS.FT_OK && num2 > 0U && (ulong)num2 < (ulong)((long)array.Length) && FTDI.FT_Read(Diag.ftHandle, array, num2, ref num3) == FTDI.FT_STATUS.FT_OK && num3 > 0U;
						bool flag8 = flag7;
						if (flag8)
						{
							Array.Copy(array, 0L, array2, (long)((ulong)num4), (long)((ulong)num3));
							num4 += num3;
							bool flag9 = (ulong)num4 >= (ulong)((long)(commandSize + 2));
							bool flag10 = flag9;
							if (flag10)
							{
								bool flag11 = num5 == 0U;
								bool flag12 = flag11;
								if (flag12)
								{
									num5 = (uint)array2[commandSize + 1];
								}
								bool flag13 = (ulong)num4 - (ulong)((long)commandSize) == (ulong)num5;
								bool flag14 = flag13;
								if (flag14)
								{
									replySize = num5;
									Array.Copy(array2, (long)((ulong)(num4 - num5)), reply, 0L, (long)((ulong)num5));
									bool flag15 = this.ValidateChecksum(reply, (int)num5);
									bool flag16 = flag15;
									if (flag16)
									{
										break;
									}
								}
							}
						}
						bool flag17 = stopwatch.ElapsedMilliseconds >= num6;
						if (flag17)
						{
							goto Block_13;
						}
					}
					stopwatch.Stop();
					FTDI.FT_Purge(Diag.ftHandle, 3U);
					result = true;
					goto IL_1C3;
					Block_13:
					stopwatch.Stop();
					FTDI.FT_Purge(Diag.ftHandle, 3U);
					return false;
				}
				result = false;
			}
			IL_1C3:
			return result;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000DDF8 File Offset: 0x0000BFF8
		private bool ValidateChecksum(byte[] data, int dataSize)
		{
			return this.Checksum8BitHonda(data, dataSize - 1, 0) == data[dataSize - 1];
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000DE1C File Offset: 0x0000C01C
		private byte Checksum8BitHonda(byte[] data, int dataSize, int startPos = 0)
		{
			int num = startPos + dataSize;
			int num2 = 0;
			while (startPos < num)
			{
				num2 += (int)data[startPos];
				startPos++;
			}
			return (byte)((num2 ^ 255) + 1 & 255);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000DE5C File Offset: 0x0000C05C
		private void button3_Click(object sender, EventArgs e)
		{
			CancellationTokenSource cancellationTokenSource = this._cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
			this.listBox1.Visible = true;
			this.ClearAllMessages();
			this.dtc();
			this.dtc2();
			this.dtc3();
			this.dtc4();
			this.ContohPemanggilanGabung();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
		private void button4_Click(object sender, EventArgs e)
		{
			CancellationTokenSource cancellationTokenSource = this._cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
			this.rst();
			this.rst1();
			this.rst2();
			this.rst3();
			this.rst4();
			Thread.Sleep(1000);
			MessageBox.Show("Reset ECM OK", "Reset ECM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, (MessageBoxOptions)262144);
			this.ClearAllMessages();
			this.dtc();
			this.dtc2();
			this.dtc3();
			this.dtc4();
			this.ContohPemanggilanGabung();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000DF45 File Offset: 0x0000C145
		private void SecondForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CancellationTokenSource cancellationTokenSource = this._cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000DF5A File Offset: 0x0000C15A
		private void Diag_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.CloseFtdiConnection();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000DF64 File Offset: 0x0000C164
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.teks = this.teks.Substring(1) + this.teks[0].ToString();
			this.Text = this.teks;
		}

		// Token: 0x04000094 RID: 148
		private string teks = "⟶ (\ud83d\udcbb Scan - \ud83d\udd0d Diag  ) ⟵  \ud83d\udcbb Scanner Pc  -  \ud83d\udd0d Diagnosa Kerusakan (DTC) ";

		// Token: 0x04000095 RID: 149
		private static IntPtr ftHandle = IntPtr.Zero;

		// Token: 0x04000096 RID: 150
		private bool tek10 = true;

		// Token: 0x04000097 RID: 151
		private bool tek11 = true;

		// Token: 0x04000098 RID: 152
		private bool tek13 = true;

		// Token: 0x04000099 RID: 153
		private bool tek16 = true;

		// Token: 0x0400009A RID: 154
		private bool tek17 = true;

		// Token: 0x0400009B RID: 155
		private CancellationTokenSource _cancellationTokenSource;

		// Token: 0x0400009C RID: 156
		private DataGridView dataGridView;

		// Token: 0x0400009D RID: 157
		private DataGridView dataGridView2;

		// Token: 0x0400009E RID: 158
		private string combinedResult = "";

		// Token: 0x0400009F RID: 159
		private Dictionary<string, string> errorMessages = new Dictionary<string, string>();

		// Token: 0x040000A0 RID: 160
		private string Hasil = "-";

		// Token: 0x040000A1 RID: 161
		private string Hasil2 = "-";

		// Token: 0x040000A2 RID: 162
		private string Hasil3 = "-";

		// Token: 0x040000A3 RID: 163
		private string Hasil4 = "-";

		// Token: 0x040000A4 RID: 164
		private string hasilGabungan = "-";

		// Token: 0x040000A5 RID: 165
		private int dtcCounter = 1;

		// Token: 0x040000A6 RID: 166
		private bool dtcTitleAdded = false;

		// Token: 0x040000A7 RID: 167
		private float o2 = 0f;

		// Token: 0x040000A8 RID: 168
		private float oxi = 0f;

		// Token: 0x040000A9 RID: 169
		private float o2v = 0f;

		// Token: 0x040000AA RID: 170
		private float stf = 0f;

		// Token: 0x040000AB RID: 171
		private float afr = 0f;

		// Token: 0x040000AC RID: 172
		private string fiz = "-";

		// Token: 0x040000AD RID: 173
		private string bas = "-";

		// Token: 0x040000AE RID: 174
		private string sss = "-";

		// Token: 0x040000AF RID: 175
		private string ssw = "-";

		// Token: 0x040000B0 RID: 176
		private string ggs = "-";

		// Token: 0x040000B1 RID: 177
		private string pom = "-";

		// Token: 0x040000B2 RID: 178
		private string fan = "-";

		// Token: 0x040000B3 RID: 179
		private string ggv = "-";
	}
}
