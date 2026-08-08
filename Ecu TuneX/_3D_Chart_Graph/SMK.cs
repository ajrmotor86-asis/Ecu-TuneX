using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using SPECIALIST_PH_TUNER;
using ZXing;
using ZXing.Common;

namespace _3D_Chart_Graph
{
	// Token: 0x0200001E RID: 30
	public partial class SMK : Form
	{
		// Token: 0x0600028B RID: 651 RVA: 0x00044BD8 File Offset: 0x00042DD8
		public SMK()
		{
			this.InitializeComponent();
			this.comboBox1.Items.Add("TYPE ECM");
			this.comboBox1.Items.Add("ADV 150 - 30400-K0WA-N01");
			this.comboBox1.Items.Add("ADV 160 - 30400-K0WL-NXX");
			this.comboBox1.Items.Add("BEAT 110 - 30400-K1AL-NB1");
			this.comboBox1.Items.Add("PCX 150 - 30400-K97G-NXX");
			this.comboBox1.Items.Add("PCX 160 - 30400-K1ZG-NXX");
			this.comboBox1.Items.Add("PCX 160 - 30400-K1ZN-NXX");
			this.comboBox1.Items.Add("STYLO 160 - 30400-K3VA-N01");
			this.comboBox1.Items.Add("SCOOPY 110 - 30400-K2F-NXX");
			this.comboBox1.Items.Add("VARIO 125 - 30400-K2VG-N42");
			this.comboBox1.Items.Add("VARIO 150 - 30400-K59J-A71");
			this.comboBox1.Items.Add("VARIO 160 - 30400-K2SA-N02");
			bool flag = this.comboBox1.Items.Count > 0;
			if (flag)
			{
				this.comboBox1.SelectedIndex = 0;
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00044D34 File Offset: 0x00042F34
		private bool InitFtdiIso()
		{
			byte[] array = new byte[1];
			byte[] array2 = new byte[]
			{
				1
			};
			uint num = 0U;
			bool flag = Class15.FT_Open(0U, ref SMK.ftHandle) > Class15.Enum5.const_0;
			bool flag2 = flag;
			bool result;
			if (flag2)
			{
				Class15.FT_Close(SMK.ftHandle);
				result = false;
			}
			else
			{
				bool flag3 = Class15.FT_Purge(SMK.ftHandle, 3U) > Class15.Enum5.const_0;
				bool flag4 = flag3;
				if (flag4)
				{
					Class15.FT_Close(SMK.ftHandle);
					result = false;
				}
				else
				{
					bool flag5 = Class15.FT_SetBitMode(SMK.ftHandle, 0, 0) > Class15.Enum5.const_0;
					bool flag6 = flag5;
					if (flag6)
					{
						Class15.FT_Close(SMK.ftHandle);
						result = false;
					}
					else
					{
						bool flag7 = Class15.FT_SetDataCharacteristics(SMK.ftHandle, 8, 0, 0) > Class15.Enum5.const_0;
						bool flag8 = flag7;
						if (flag8)
						{
							Class15.FT_Close(SMK.ftHandle);
							result = false;
						}
						else
						{
							bool flag9 = Class15.FT_SetBaudRate(SMK.ftHandle, 10400U) > Class15.Enum5.const_0;
							bool flag10 = flag9;
							if (flag10)
							{
								Class15.FT_Close(SMK.ftHandle);
								result = false;
							}
							else
							{
								bool flag11 = Class15.FT_SetTimeouts(SMK.ftHandle, 50U, 0U) > Class15.Enum5.const_0;
								bool flag12 = flag11;
								if (flag12)
								{
									Class15.FT_Close(SMK.ftHandle);
									result = false;
								}
								else
								{
									bool flag13 = Class15.FT_SetLatencyTimer(SMK.ftHandle, 8) > Class15.Enum5.const_0;
									bool flag14 = flag13;
									if (flag14)
									{
										Class15.FT_Close(SMK.ftHandle);
										result = false;
									}
									else
									{
										bool flag15 = Class15.FT_SetBitMode(SMK.ftHandle, 1, 1) > Class15.Enum5.const_0;
										bool flag16 = flag15;
										if (flag16)
										{
											Class15.FT_Close(SMK.ftHandle);
											result = false;
										}
										else
										{
											bool flag17 = Class15.FT_Write(SMK.ftHandle, array, (uint)array.Length, ref num) > Class15.Enum5.const_0;
											bool flag18 = flag17;
											if (flag18)
											{
												Class15.FT_Close(SMK.ftHandle);
												result = false;
											}
											else
											{
												Thread.Sleep(70);
												bool flag19 = Class15.FT_Write(SMK.ftHandle, array2, (uint)array2.Length, ref num) > Class15.Enum5.const_0;
												bool flag20 = flag19;
												if (flag20)
												{
													Class15.FT_Close(SMK.ftHandle);
													result = false;
												}
												else
												{
													bool flag21 = Class15.FT_SetBitMode(SMK.ftHandle, 0, 0) > Class15.Enum5.const_0;
													bool flag22 = flag21;
													if (flag22)
													{
														Class15.FT_Close(SMK.ftHandle);
														result = false;
													}
													else
													{
														bool flag23 = Class15.FT_SetBaudRate(SMK.ftHandle, 10400U) > Class15.Enum5.const_0;
														bool flag24 = flag23;
														if (flag24)
														{
															Class15.FT_Close(SMK.ftHandle);
															result = false;
														}
														else
														{
															bool flag25 = Class15.FT_Purge(SMK.ftHandle, 3U) > Class15.Enum5.const_0;
															bool flag26 = flag25;
															if (flag26)
															{
																Class15.FT_Close(SMK.ftHandle);
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

		// Token: 0x0600028D RID: 653 RVA: 0x00044FE8 File Offset: 0x000431E8
		private bool SendCommand6(byte[] command, int commandSize, ref byte[] reply, ref uint replySize, int sleepMs = 0)
		{
			byte[] array = new byte[256];
			List<byte> list = new List<byte>();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			long num4 = (long)(50 + 2 * commandSize);
			bool flag = Class15.FT_Write(SMK.ftHandle, command, (uint)commandSize, ref num) > Class15.Enum5.const_0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = Class15.FT_SetLatencyTimer(SMK.ftHandle, 8) > Class15.Enum5.const_0;
				if (flag2)
				{
					result = false;
				}
				else
				{
					bool flag3 = sleepMs > 0;
					if (flag3)
					{
						Thread.Sleep(sleepMs);
					}
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					bool flag7;
					do
					{
						bool flag4 = Class15.FT_GetQueueStatus(SMK.ftHandle, ref num2) == Class15.Enum5.const_0 && num2 > 0U;
						if (flag4)
						{
							bool flag5 = Class15.FT_Read(SMK.ftHandle, array, num2, ref num3) == Class15.Enum5.const_0 && num3 > 0U;
							if (flag5)
							{
								list.AddRange(array.Take((int)num3));
								bool flag6 = num2 == 0U;
								if (flag6)
								{
									break;
								}
							}
						}
						flag7 = (stopwatch.ElapsedMilliseconds >= num4);
					}
					while (!flag7);
					stopwatch.Stop();
					Class15.FT_Purge(SMK.ftHandle, 3U);
					bool flag8 = list.Count > 0;
					if (flag8)
					{
						replySize = (uint)list.Count;
						reply = list.ToArray();
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00045134 File Offset: 0x00043334
		private void eeprom1()
		{
			this.lblStatus.Text = " Proses READ ID KEIHIN ,Silahkan tunggu sebentar . ";
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			byte[] array = new byte[]
			{
				254,
				4,
				114,
				140
			};
			byte[] array2 = new byte[]
			{
				114,
				5,
				0,
				240,
				153
			};
			byte[] array3 = new byte[]
			{
				39,
				11,
				224,
				72,
				101,
				108,
				108,
				111,
				72,
				111,
				67
			};
			byte[] array4 = new byte[]
			{
				39,
				11,
				224,
				119,
				65,
				114,
				101,
				89,
				111,
				117,
				34
			};
			byte[] array5 = new byte[256];
			byte[] array6 = new byte[]
			{
				130,
				130,
				16,
				6,
				0,
				230
			};
			byte[] array7 = new byte[]
			{
				130,
				130,
				16,
				6,
				1,
				229
			};
			byte[] array8 = new byte[]
			{
				130,
				130,
				16,
				6,
				1,
				229
			};
			uint num = 0U;
			List<byte> list = new List<byte>();
			bool flag = this.InitFtdiIso();
			if (flag)
			{
				base.Invoke(new Action(delegate()
				{
					this.progressBar1.Maximum = 256;
					this.progressBar1.Value = 0;
				}));
				bool flag2 = this.SendCommand6(array, array.Length, ref array5, ref num, 0);
				if (flag2)
				{
					string str = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str);
				}
				Thread.Sleep(150);
				bool flag3 = this.SendCommand6(array2, array2.Length, ref array5, ref num, 0);
				if (flag3)
				{
					string str2 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str2);
				}
				Thread.Sleep(150);
				bool flag4 = this.SendCommand6(array3, array3.Length, ref array5, ref num, 0);
				if (flag4)
				{
					string str3 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str3);
				}
				Thread.Sleep(150);
				bool flag5 = this.SendCommand6(array4, array4.Length, ref array5, ref num, 0);
				if (flag5)
				{
					string str4 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response2: " + str4);
					bool flag6 = num < 13U;
					if (flag6)
					{
						MessageBox.Show("Security Access Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
				}
				bool flag7 = this.SendCommand6(array6, array6.Length, ref array5, ref num, 0);
				if (flag7)
				{
					string str5 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response7: " + str5);
				}
				bool flag8 = this.SendCommand6(array7, array7.Length, ref array5, ref num, 0);
				if (flag8)
				{
					string str6 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response8: " + str6);
				}
				Console.WriteLine("Response Data:");
				int j;
				int i;
				for (i = 0; i <= 255; i = j + 1)
				{
					byte[] array9 = new byte[]
					{
						130,
						130,
						16,
						6,
						0,
						0
					};
					this.SendCommand6(array9, array9.Length, ref array5, ref num, 0);
					bool flag9 = num > 12U;
					if (flag9)
					{
						int num2 = 10;
						while ((long)num2 < (long)((ulong)Math.Min(num, 12U)))
						{
							Console.Write(array5[num2].ToString("X2") + " ");
							bool flag10 = num2 == 10 || num2 == 11;
							if (flag10)
							{
								list.Add(array5[num2]);
							}
							num2++;
						}
						Console.WriteLine();
					}
					else
					{
						Console.WriteLine("Data kosong.");
					}
					base.Invoke(new Action(delegate()
					{
						this.progressBar1.Value = i + 1;
						int num3 = (i + 1) * 100 / 256;
						this.PERSEN.Text = string.Format("{0} %", num3);
						TimeSpan elapsed = stopwatch.Elapsed;
						this.label2.Text = string.Format("{0} Detik", elapsed.Seconds);
					}));
					j = i;
				}
				stopwatch.Stop();
				Class15.FT_Close(SMK.ftHandle);
				base.Invoke(new Action(delegate()
				{
					this.lblStatus.Text = " Proses READ ID KEIHIN Selesai ";
					this.label3.Text = string.Format("Proses READ ID Key : Keihin {0} Detik.", stopwatch.Elapsed.Seconds);
				}));
				this.binBytes = list.ToArray();
				this.SaveFileOnUIThread1(list);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00045544 File Offset: 0x00043744
		private void eeprom()
		{
			this.lblStatus.Text = " Proses READ ID Shindengen ,Silahkan tunggu sebentar... ";
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			byte[] array = new byte[]
			{
				254,
				4,
				114,
				140
			};
			byte[] array2 = new byte[]
			{
				114,
				5,
				0,
				240,
				153
			};
			byte[] array3 = new byte[]
			{
				145,
				145,
				13,
				223,
				158,
				141,
				154,
				134,
				144,
				138,
				140,
				155,
				136
			};
			byte[] array4 = new byte[]
			{
				145,
				145,
				13,
				223,
				146,
				158,
				134,
				150,
				139,
				141,
				134,
				192,
				106
			};
			byte[] array5 = new byte[20];
			uint num = 0U;
			List<byte> list = new List<byte>();
			bool flag = this.InitFtdiIso();
			if (flag)
			{
				base.Invoke(new Action(delegate()
				{
					this.progressBar1.Maximum = 256;
					this.progressBar1.Value = 0;
				}));
				bool flag2 = this.SendCommand6(array, array.Length, ref array5, ref num, 0);
				if (flag2)
				{
					string str = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str);
				}
				Thread.Sleep(150);
				bool flag3 = this.SendCommand6(array2, array2.Length, ref array5, ref num, 0);
				if (flag3)
				{
					string str2 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str2);
				}
				Thread.Sleep(150);
				bool flag4 = this.SendCommand6(array3, array3.Length, ref array5, ref num, 0);
				if (flag4)
				{
					string str3 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str3);
				}
				Thread.Sleep(150);
				bool flag5 = this.SendCommand6(array4, array4.Length, ref array5, ref num, 0);
				if (flag5)
				{
					string str4 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response2: " + str4);
					bool flag6 = num < 15U;
					if (flag6)
					{
						MessageBox.Show("Security Access Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
				}
				Console.WriteLine("Response Data:");
				int j;
				int i;
				for (i = 0; i <= 255; i = j + 1)
				{
					byte[] array6 = new byte[]
					{
						145,
						145,
						7,
						64,
						0,
						0,
						0
					};
					this.SendCommand6(array6, array6.Length, ref array5, ref num, 0);
					Thread.Sleep(100);
					bool flag7 = num > 12U;
					if (flag7)
					{
						int num2 = 11;
						while ((long)num2 < (long)((ulong)Math.Min(num, 13U)))
						{
							Console.Write(array5[num2].ToString("X2") + " ");
							bool flag8 = num2 == 11 || num2 == 12;
							if (flag8)
							{
								list.Add(array5[num2]);
							}
							num2++;
						}
						Console.WriteLine();
					}
					else
					{
						Console.WriteLine("Data tidak cukup untuk menampilkan byte 11 dan 12.");
					}
					base.Invoke(new Action(delegate()
					{
						this.progressBar1.Value = i + 1;
						int num3 = (i + 1) * 100 / 256;
						this.PERSEN.Text = string.Format("{0} %", num3);
						TimeSpan elapsed = stopwatch.Elapsed;
						this.label2.Text = string.Format("{0} Detik", elapsed.Seconds);
					}));
					j = i;
				}
				stopwatch.Stop();
				Class15.FT_Close(SMK.ftHandle);
				base.Invoke(new Action(delegate()
				{
					this.lblStatus.Text = " Proses READ ID SHINDENGEN Selesai ";
					this.label3.Text = string.Format("Proses READ ID Key : Shindengen {0} Detik.", stopwatch.Elapsed.Seconds);
				}));
				this.binBytes = list.ToArray();
				this.SaveFileOnUIThread1(list);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000458AC File Offset: 0x00043AAC
		private void SaveFileOnUIThread(List<byte> collectedData)
		{
			base.Invoke(new Action(delegate()
			{
				string text = "C:\\Users\\S'COM\\Desktop\\File EEPROM READ ID";
				string path = "File EEPROM READ ID .bin";
				string text2 = Path.Combine(text, path);
				bool flag = !Directory.Exists(text);
				if (flag)
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text2, collectedData.ToArray());
				Console.WriteLine("Data berhasil disimpan ke: " + text2);
				this.progressBar1.Value = 0;
				this.baca();
			}));
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000458E4 File Offset: 0x00043AE4
		private void SaveFileOnUIThread1(List<byte> collectedData)
		{
			base.Invoke(new Action(delegate()
			{
				string text = "C:\\File EEPROM READ ID";
				object selectedItem = this.comboBox1.SelectedItem;
				string arg = ((selectedItem != null) ? selectedItem.ToString() : null) ?? "Default";
				string path = string.Format("{0}{1: dd-MM-yyyy}.bin", arg, DateTime.Now);
				string text2 = Path.Combine(text, path);
				bool flag = !Directory.Exists(text);
				if (flag)
				{
					Directory.CreateDirectory(text);
				}
				try
				{
					File.WriteAllBytes(text2, collectedData.ToArray());
					Console.WriteLine("Data berhasil disimpan ke: " + text2);
					this.progressBar1.Value = 0;
					this.baca();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Gagal menyimpan file: " + ex.Message);
				}
			}));
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0004591C File Offset: 0x00043B1C
		private void baca()
		{
			try
			{
				bool flag = this.binBytes == null;
				if (flag)
				{
					MessageBox.Show("Tidak ada data yang dikumpulkan. Silakan jalankan fungsi EEPROM terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					bool flag2 = this.comboBox1.SelectedItem.ToString() == "VARIO 150 - 30400-K59J-A71";
					if (flag2)
					{
						bool flag3 = this.binBytes.Length >= 88;
						if (flag3)
						{
							this.ProcessPcxValues(new byte[]
							{
								this.binBytes[144],
								this.binBytes[145]
							}, new byte[]
							{
								this.binBytes[160],
								this.binBytes[161]
							});
						}
						else
						{
							MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
					else
					{
						bool flag4 = this.comboBox1.SelectedItem.ToString() == "ADV 150 - 30400-K0WA-N01";
						if (flag4)
						{
							bool flag5 = this.binBytes.Length >= 88;
							if (flag5)
							{
								this.ProcessPcxValues(new byte[]
								{
									this.binBytes[64],
									this.binBytes[65]
								}, new byte[]
								{
									this.binBytes[80],
									this.binBytes[81]
								});
							}
							else
							{
								MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
						}
						else
						{
							bool flag6 = this.comboBox1.SelectedItem.ToString() == "PCX 150 - 30400-K97G-NXX";
							if (flag6)
							{
								bool flag7 = this.binBytes.Length >= 88;
								if (flag7)
								{
									this.ProcessPcxValues(new byte[]
									{
										this.binBytes[64],
										this.binBytes[65]
									}, new byte[]
									{
										this.binBytes[80],
										this.binBytes[81]
									});
								}
								else
								{
									MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
							}
							else
							{
								bool flag8 = this.comboBox1.SelectedItem.ToString() == "PCX 150 - 30400-K97G-N31";
								if (flag8)
								{
									bool flag9 = this.binBytes.Length >= 88;
									if (flag9)
									{
										this.ProcessPcxValues(new byte[]
										{
											this.binBytes[64],
											this.binBytes[65]
										}, new byte[]
										{
											this.binBytes[80],
											this.binBytes[81]
										});
									}
									else
									{
										MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									}
								}
								else
								{
									bool flag10 = this.comboBox1.SelectedItem.ToString() == "VARIO 125 - 30400-K2VG-N42";
									if (flag10)
									{
										bool flag11 = this.binBytes.Length >= 88;
										if (flag11)
										{
											this.ProcessPcxValues(new byte[]
											{
												this.binBytes[60],
												this.binBytes[61]
											}, new byte[]
											{
												this.binBytes[62],
												this.binBytes[63]
											});
										}
										else
										{
											MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										}
									}
									else
									{
										bool flag12 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZG-NXX";
										if (flag12)
										{
											bool flag13 = this.binBytes.Length >= 88;
											if (flag13)
											{
												this.ProcessPcxValues(new byte[]
												{
													this.binBytes[64],
													this.binBytes[65]
												}, new byte[]
												{
													this.binBytes[76],
													this.binBytes[77]
												});
											}
											else
											{
												MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
											}
										}
										else
										{
											bool flag14 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZG-N21";
											if (flag14)
											{
												bool flag15 = this.binBytes.Length >= 88;
												if (flag15)
												{
													this.ProcessPcxValues(new byte[]
													{
														this.binBytes[64],
														this.binBytes[65]
													}, new byte[]
													{
														this.binBytes[76],
														this.binBytes[77]
													});
												}
												else
												{
													MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
												}
											}
											else
											{
												bool flag16 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZN-NXX";
												if (flag16)
												{
													bool flag17 = this.binBytes.Length >= 88;
													if (flag17)
													{
														this.ProcessPcxValues(new byte[]
														{
															this.binBytes[64],
															this.binBytes[65]
														}, new byte[]
														{
															this.binBytes[76],
															this.binBytes[77]
														});
													}
													else
													{
														MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
													}
												}
												else
												{
													bool flag18 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZN-N51";
													if (flag18)
													{
														bool flag19 = this.binBytes.Length >= 88;
														if (flag19)
														{
															this.ProcessPcxValues(new byte[]
															{
																this.binBytes[64],
																this.binBytes[65]
															}, new byte[]
															{
																this.binBytes[76],
																this.binBytes[77]
															});
														}
														else
														{
															MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
														}
													}
													else
													{
														bool flag20 = this.comboBox1.SelectedItem.ToString() == "BEAT 110 - 30400-K1AL-NB1";
														if (flag20)
														{
															bool flag21 = this.binBytes.Length >= 88;
															if (flag21)
															{
																this.ProcessPcxValues(new byte[]
																{
																	this.binBytes[60],
																	this.binBytes[61]
																}, new byte[]
																{
																	this.binBytes[62],
																	this.binBytes[63]
																});
															}
															else
															{
																MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
															}
														}
														else
														{
															bool flag22 = this.comboBox1.SelectedItem.ToString() == "STYLO 160 - 30400-K3VA-N01";
															if (flag22)
															{
																bool flag23 = this.binBytes.Length >= 88;
																if (flag23)
																{
																	this.ProcessPcxValues(new byte[]
																	{
																		this.binBytes[60],
																		this.binBytes[61]
																	}, new byte[]
																	{
																		this.binBytes[62],
																		this.binBytes[63]
																	});
																}
																else
																{
																	MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																}
															}
															else
															{
																bool flag24 = this.comboBox1.SelectedItem.ToString() == "VARIO 160 - 30400-K2SA-N02";
																if (flag24)
																{
																	bool flag25 = this.binBytes.Length >= 88;
																	if (flag25)
																	{
																		this.ProcessPcxValues(new byte[]
																		{
																			this.binBytes[60],
																			this.binBytes[61]
																		}, new byte[]
																		{
																			this.binBytes[62],
																			this.binBytes[63]
																		});
																	}
																	else
																	{
																		MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																	}
																}
																else
																{
																	bool flag26 = this.comboBox1.SelectedItem.ToString() == "ADV 160 - 30400-K0WL-NXX";
																	if (flag26)
																	{
																		bool flag27 = this.binBytes.Length >= 88;
																		if (flag27)
																		{
																			this.ProcessPcxValues(new byte[]
																			{
																				this.binBytes[64],
																				this.binBytes[65]
																			}, new byte[]
																			{
																				this.binBytes[76],
																				this.binBytes[77]
																			});
																		}
																		else
																		{
																			MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																		}
																	}
																	else
																	{
																		bool flag28 = this.comboBox1.SelectedItem.ToString() == "ADV 160 - 30400-K0WL-NB1";
																		if (flag28)
																		{
																			bool flag29 = this.binBytes.Length >= 88;
																			if (flag29)
																			{
																				byte[] firstValue = new byte[]
																				{
																					this.binBytes[64],
																					this.binBytes[65]
																				};
																				byte[] secondValue = new byte[]
																				{
																					this.binBytes[76],
																					this.binBytes[77]
																				};
																				this.ProcessPcxValues(firstValue, secondValue);
																				this.ProcessPcxValues(firstValue, secondValue);
																			}
																			else
																			{
																				MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																			}
																		}
																		else
																		{
																			bool flag30 = this.comboBox1.SelectedItem.ToString() == "SCOOPY 110 - 30400-K2F-NXX";
																			if (flag30)
																			{
																				bool flag31 = this.binBytes.Length >= 88;
																				if (flag31)
																				{
																					this.ProcessKEIHIN(new byte[]
																					{
																						this.binBytes[70],
																						this.binBytes[71]
																					}, new byte[]
																					{
																						this.binBytes[72],
																						this.binBytes[73]
																					});
																				}
																				else
																				{
																					MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																				}
																			}
																			else
																			{
																				bool flag32 = this.comboBox1.SelectedItem.ToString() == "SCOOPY 110 - 30400-K2F-N91";
																				if (flag32)
																				{
																					bool flag33 = this.binBytes.Length >= 88;
																					if (flag33)
																					{
																						this.ProcessKEIHIN(new byte[]
																						{
																							this.binBytes[70],
																							this.binBytes[71]
																						}, new byte[]
																						{
																							this.binBytes[72],
																							this.binBytes[73]
																						});
																					}
																					else
																					{
																						MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																					}
																				}
																				else
																				{
																					bool flag34 = this.comboBox1.SelectedItem.ToString() == "SCOOPY 110 - 30400-K2F-ND1";
																					if (flag34)
																					{
																						bool flag35 = this.binBytes.Length >= 88;
																						if (flag35)
																						{
																							this.ProcessKEIHIN(new byte[]
																							{
																								this.binBytes[70],
																								this.binBytes[71]
																							}, new byte[]
																							{
																								this.binBytes[72],
																								this.binBytes[73]
																							});
																						}
																						else
																						{
																							MessageBox.Show("Gagal Read Data\r\nRestart your ECM\r\nUlangi Dari Awal", "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Terjadi kesalahan saat memproses data: " + ex.Message, "READ ECM ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000464B4 File Offset: 0x000446B4
		private void ProcessPcxValueskh(byte[] firstValue, byte[] secondValue)
		{
			try
			{
				string str = BitConverter.ToString(firstValue).Replace("-", "");
				string str2 = BitConverter.ToString(secondValue).Replace("-", "");
				string text = str + str2;
				bool flag = text.Length != 8;
				if (!flag)
				{
					bool flag2 = text == "00000000";
					if (flag2)
					{
						SMK.ecmIdStr = "000000000";
					}
					else
					{
						string hex = text.Substring(0, 4);
						string hex2 = this.SwapBytes(hex);
						string hex3 = this.RightShift(hex2, 2);
						string str3 = this.SubtractHex(hex3, "2000");
						string hex4 = text.Substring(4, 4);
						string hex5 = this.XorHex(hex4, "80");
						string str4 = this.SwapBytes(hex5);
						string value = str3 + str4;
						SMK.ecmIdStr = Convert.ToInt64(value, 16).ToString().PadLeft(9, '0');
						this.textBox3.Text = SMK.ecmIdStr;
						this.textBox2.Text = SMK.ecmIdStr;
						string text2 = SMK.ecmIdStr;
						bool flag3 = !string.IsNullOrEmpty(text2);
						if (flag3)
						{
							BarcodeWriter barcodeWriter = new BarcodeWriter
							{
								Format = 16,
								Options = new EncodingOptions
								{
									Height = 150,
									Width = 400
								}
							};
							Bitmap image = barcodeWriter.Write(text2);
							this.pictureBoxBarcode.Image = image;
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0004665C File Offset: 0x0004485C
		private string SwapBytes(string hex)
		{
			bool flag = hex.Length != 4;
			if (flag)
			{
				throw new FormatException("DATA ERROR");
			}
			return hex.Substring(2, 2) + hex.Substring(0, 2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000466A0 File Offset: 0x000448A0
		private string RightShift(string hex, int shift)
		{
			int num = Convert.ToInt32(hex, 16);
			return (num >> shift).ToString("X4");
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000466D0 File Offset: 0x000448D0
		private string SubtractHex(string hex1, string hex2)
		{
			int num = Convert.ToInt32(hex1, 16);
			int num2 = Convert.ToInt32(hex2, 16);
			return (num - num2).ToString("X4");
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00046704 File Offset: 0x00044904
		private string XorHex(string hex1, string hex2)
		{
			int num = Convert.ToInt32(hex1, 16);
			int num2 = Convert.ToInt32(hex2, 16);
			return (num ^ num2).ToString("X4");
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00046738 File Offset: 0x00044938
		private void ProcessKEIHIN(byte[] firstValue, byte[] secondValue)
		{
			string str = BitConverter.ToString(firstValue).Replace("-", " ");
			string str2 = BitConverter.ToString(secondValue).Replace("-", " ");
			try
			{
				string text = str2 + " " + str;
				string[] array = text.Split(new char[]
				{
					' ',
					',',
					'-',
					':'
				}, StringSplitOptions.RemoveEmptyEntries);
				bool flag = array.Length % 4 != 0;
				if (flag)
				{
					MessageBox.Show("Jumlah byte harus kelipatan 4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					for (int i = 0; i < array.Length; i += 4)
					{
						byte b = this.ConvertInputToByte(array[i]);
						byte b2 = this.ConvertInputToByte(array[i + 1]);
						byte b3 = this.ConvertInputToByte(array[i + 2]);
						byte b4 = this.ConvertInputToByte(array[i + 3]);
						uint num = (uint)((int)b4 << 8 | (int)b3);
						uint num2 = (uint)((int)b << 16 | (int)b2 << 24 | (int)num);
						string text2 = num2.ToString().PadLeft(9, '0');
						this.value1 = (byte)(num2 >> 16 & 255U);
						this.value2 = (byte)(num2 >> 24 & 255U);
						this.value3 = (byte)(num2 & 255U);
						this.value4 = (byte)(num2 >> 8 & 255U);
						string text3 = string.Format("{0:X2} {1:X2} {2:X2} {3:X2}", new object[]
						{
							this.value3,
							this.value4,
							this.value1,
							this.value2
						});
						this.textBox3.Text = text3;
						this.textBox3_TextChanged();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00046928 File Offset: 0x00044B28
		private void textBox3_TextChanged()
		{
			string text = this.textBox3.Text.Trim();
			string[] array = text.Split(new char[]
			{
				' '
			});
			bool flag = array.Length < 4;
			if (flag)
			{
				MessageBox.Show("Input harus terdiri dari 4 byte hexadecimal, dipisahkan oleh spasi.");
			}
			else
			{
				try
				{
					int num = Convert.ToInt32(array[0], 16);
					int num2 = Convert.ToInt32(array[1], 16);
					int num3 = Convert.ToInt32(array[2], 16);
					int num4 = Convert.ToInt32(array[3], 16);
					long num5 = (long)(num2 << 8 | num);
					long num6 = (long)(num4 << 8 | num3);
					long num7 = (num5 * 65536L >> 2) - 536870912L;
					long num8 = num6 ^ 32768L;
					long num9 = num7 + num8;
					this.textBox2.Text = num9.ToString("D9");
					string text2 = num9.ToString();
					bool flag2 = !string.IsNullOrEmpty(text2);
					if (flag2)
					{
						BarcodeWriter barcodeWriter = new BarcodeWriter
						{
							Format = 16,
							Options = new EncodingOptions
							{
								Height = 150,
								Width = 400
							}
						};
						Bitmap image = barcodeWriter.Write(text2);
						this.pictureBoxBarcode.Image = image;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error in conversion: " + ex.Message);
				}
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00046A90 File Offset: 0x00044C90
		private void ProcessPcxValues(byte[] firstValue, byte[] secondValue)
		{
			string str = BitConverter.ToString(firstValue).Replace("-", " ");
			string str2 = BitConverter.ToString(secondValue).Replace("-", " ");
			try
			{
				string text = str2 + " " + str;
				string[] array = text.Split(new char[]
				{
					' ',
					',',
					'-',
					':'
				}, StringSplitOptions.RemoveEmptyEntries);
				bool flag = array.Length % 4 != 0;
				if (flag)
				{
					MessageBox.Show("Jumlah byte harus kelipatan 4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.textBox2.Text = "";
					for (int i = 0; i < array.Length; i += 4)
					{
						byte b = this.ConvertInputToByte(array[i]);
						byte b2 = this.ConvertInputToByte(array[i + 1]);
						byte b3 = this.ConvertInputToByte(array[i + 2]);
						byte b4 = this.ConvertInputToByte(array[i + 3]);
						uint num = (uint)((int)b4 << 8 | (int)b3);
						uint num2 = (uint)((int)b2 << 24 | (int)b << 16 | (int)num);
						string text2 = num2.ToString().PadLeft(9, '0');
						this.textBox2.Text = (text2 ?? "");
						this.value1 = (byte)(num2 >> 16 & 255U);
						this.value2 = (byte)(num2 >> 24 & 255U);
						this.value3 = (byte)(num2 & 255U);
						this.value4 = (byte)(num2 >> 8 & 255U);
						string text3 = string.Format("{0:X2} {1:X2} {2:X2} {3:X2}", new object[]
						{
							this.value3,
							this.value4,
							this.value1,
							this.value2
						});
						bool flag2 = !string.IsNullOrEmpty(text2);
						if (flag2)
						{
							BarcodeWriter barcodeWriter = new BarcodeWriter
							{
								Format = 16,
								Options = new EncodingOptions
								{
									Height = 150,
									Width = 400
								}
							};
							Bitmap image = barcodeWriter.Write(text2);
							this.pictureBoxBarcode.Image = image;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00046CF4 File Offset: 0x00044EF4
		private byte ConvertInputToByte(string input)
		{
			bool flag = string.IsNullOrEmpty(input);
			if (flag)
			{
				throw new ArgumentException("Input tidak boleh kosong.");
			}
			return Convert.ToByte(input, 16);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00046D24 File Offset: 0x00044F24
		[DebuggerStepThrough]
		private void button1_Click(object sender, EventArgs e)
		{
			SMK.<button1_Click>d__31 <button1_Click>d__ = new SMK.<button1_Click>d__31();
			<button1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button1_Click>d__.<>4__this = this;
			<button1_Click>d__.sender = sender;
			<button1_Click>d__.e = e;
			<button1_Click>d__.<>1__state = -1;
			<button1_Click>d__.<>t__builder.Start<SMK.<button1_Click>d__31>(ref <button1_Click>d__);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00046D6C File Offset: 0x00044F6C
		[DebuggerStepThrough]
		private void button2_Click(object sender, EventArgs e)
		{
			SMK.<button2_Click>d__32 <button2_Click>d__ = new SMK.<button2_Click>d__32();
			<button2_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button2_Click>d__.<>4__this = this;
			<button2_Click>d__.sender = sender;
			<button2_Click>d__.e = e;
			<button2_Click>d__.<>1__state = -1;
			<button2_Click>d__.<>t__builder.Start<SMK.<button2_Click>d__32>(ref <button2_Click>d__);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00046DB4 File Offset: 0x00044FB4
		private void eepromkeihin3()
		{
			this.lblStatus.Text = " PROSES RESET EEPROM KEIHIN ,Silahkan tunggu sebentar ";
			byte[] array = new byte[]
			{
				254,
				4,
				114,
				140
			};
			byte[] array2 = new byte[]
			{
				114,
				5,
				0,
				240,
				153
			};
			byte[] array3 = new byte[]
			{
				39,
				11,
				224,
				72,
				101,
				108,
				108,
				111,
				72,
				111,
				67
			};
			byte[] array4 = new byte[]
			{
				39,
				11,
				224,
				119,
				65,
				114,
				101,
				89,
				111,
				117,
				34
			};
			byte[] array5 = new byte[256];
			byte[] array6 = new byte[]
			{
				130,
				130,
				16,
				6,
				0,
				230
			};
			byte[] array7 = new byte[]
			{
				130,
				130,
				16,
				6,
				1,
				229
			};
			byte[] array8 = new byte[]
			{
				130,
				130,
				16,
				6,
				1,
				229
			};
			uint num = 0U;
			bool flag = this.InitFtdiIso();
			if (flag)
			{
				base.Invoke(new Action(delegate()
				{
					this.progressBar1.Maximum = 256;
					this.progressBar1.Value = 0;
				}));
				bool flag2 = this.SendCommand6(array, array.Length, ref array5, ref num, 0);
				if (flag2)
				{
					string str = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str);
				}
				Thread.Sleep(150);
				bool flag3 = this.SendCommand6(array2, array2.Length, ref array5, ref num, 0);
				if (flag3)
				{
					string str2 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str2);
				}
				Thread.Sleep(150);
				bool flag4 = this.SendCommand6(array3, array3.Length, ref array5, ref num, 0);
				if (flag4)
				{
					string str3 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str3);
				}
				Thread.Sleep(150);
				bool flag5 = this.SendCommand6(array4, array4.Length, ref array5, ref num, 0);
				if (flag5)
				{
					string str4 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response2: " + str4);
					bool flag6 = num < 13U;
					if (flag6)
					{
						MessageBox.Show("Security Access Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
				}
				bool flag7 = this.SendCommand6(array6, array6.Length, ref array5, ref num, 0);
				if (flag7)
				{
					string str5 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response7: " + str5);
				}
				bool flag8 = this.SendCommand6(array7, array7.Length, ref array5, ref num, 0);
				if (flag8)
				{
					string str6 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response8: " + str6);
				}
				Console.WriteLine("Response Data:");
				int num5;
				int i;
				for (i = 0; i <= 255; i = num5 + 1)
				{
					byte[] array9 = new byte[]
					{
						130,
						130,
						16,
						6,
						0,
						0
					};
					array9[4] = (byte)i;
					int num2 = 5;
					int num3 = 256;
					int num4 = 282;
					num5 = i;
					i = num5 + 1;
					array9[num2] = (byte)(num3 - (num4 + num5) % 256);
					byte[] array10 = array9;
					this.SendCommand6(array10, array10.Length, ref array5, ref num, 0);
					Console.WriteLine(string.Join(" ", from b in array10
					select b.ToString("X2")));
					bool flag9 = num > 12U;
					if (flag9)
					{
						int num6 = 10;
						while ((long)num6 < (long)((ulong)Math.Min(num, 12U)))
						{
							Console.Write(array5[num6].ToString("X2") + " ");
							bool flag10 = num6 == 10 || num6 == 11;
							if (flag10)
							{
								this.collectedData2.Add(array5[num6]);
							}
							num6++;
						}
						Console.WriteLine();
					}
					else
					{
						Console.WriteLine("Data tidak cukup untuk menampilkan byte 11 dan 12.");
					}
					base.Invoke(new Action(delegate()
					{
						this.progressBar1.Value = i + 1;
					}));
					num5 = i;
				}
				this.binBytes = this.collectedData2.ToArray();
				this.collectedData2[70] = 0;
				this.collectedData2[71] = 0;
				this.collectedData2[72] = 0;
				this.collectedData2[73] = 0;
				int count = this.collectedData2.Count;
				int y;
				for (y = 0; y < 256; y = num5 + 1)
				{
					int num7 = y * 2 % count;
					byte b5 = this.collectedData2[num7];
					byte b2 = this.collectedData2[(num7 + 1) % count];
					byte[] array11 = new byte[]
					{
						130,
						130,
						20,
						8,
						0,
						0,
						0,
						0
					};
					array11[4] = (byte)y;
					array11[5] = b5;
					array11[6] = b2;
					int num8 = 7;
					int num9 = 256;
					byte b3 = (byte)(288 + (int)((byte)y));
					byte b4 = b5;
					b5 = b4 + 1;
					array11[num8] = (byte)(num9 - (int)(b3 + b4) % 256);
					byte[] array12 = array11;
					this.SendCommand6(array12, array12.Length, ref array5, ref num, 0);
					string str7 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine(string.Join(" ", from b in array12
					select b.ToString("X2")));
					base.Invoke(new Action(delegate()
					{
						this.progressBar1.Value = y + 1;
					}));
					Console.WriteLine("Response cmd: " + str7);
					num5 = y;
				}
				base.Invoke(new Action(delegate()
				{
					this.textBox2.Text = "000000000";
					this.lblStatus.Text = " Reset EEPROM KEIHIN SELESAI !!! ";
				}));
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00047350 File Offset: 0x00045550
		[DebuggerStepThrough]
		private void button3_Click(object sender, EventArgs e)
		{
			SMK.<button3_Click>d__35 <button3_Click>d__ = new SMK.<button3_Click>d__35();
			<button3_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button3_Click>d__.<>4__this = this;
			<button3_Click>d__.sender = sender;
			<button3_Click>d__.e = e;
			<button3_Click>d__.<>1__state = -1;
			<button3_Click>d__.<>t__builder.Start<SMK.<button3_Click>d__35>(ref <button3_Click>d__);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00047398 File Offset: 0x00045598
		private void eeprom3()
		{
			this.lblStatus.Text = " PROSES RESET ID SHINDENGEN ,Silahkan tunggu sebentar ";
			byte[] array = new byte[]
			{
				254,
				4,
				114,
				140
			};
			byte[] array2 = new byte[]
			{
				114,
				5,
				0,
				240,
				153
			};
			byte[] array3 = new byte[]
			{
				145,
				145,
				13,
				223,
				158,
				141,
				154,
				134,
				144,
				138,
				140,
				155,
				136
			};
			byte[] array4 = new byte[]
			{
				145,
				145,
				13,
				223,
				146,
				158,
				134,
				150,
				139,
				141,
				134,
				192,
				106
			};
			byte[] array5 = new byte[256];
			uint num = 0U;
			List<byte> list = new List<byte>();
			bool flag = this.InitFtdiIso();
			if (flag)
			{
				base.Invoke(new Action(delegate()
				{
					this.progressBar1.Maximum = 256;
					this.progressBar1.Value = 0;
				}));
				bool flag2 = this.SendCommand6(array, array.Length, ref array5, ref num, 0);
				if (flag2)
				{
					string str = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str);
				}
				Thread.Sleep(150);
				bool flag3 = this.SendCommand6(array2, array2.Length, ref array5, ref num, 0);
				if (flag3)
				{
					string str2 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str2);
				}
				Thread.Sleep(150);
				bool flag4 = this.SendCommand6(array3, array3.Length, ref array5, ref num, 0);
				if (flag4)
				{
					string str3 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response: " + str3);
				}
				Thread.Sleep(150);
				bool flag5 = this.SendCommand6(array4, array4.Length, ref array5, ref num, 0);
				if (flag5)
				{
					string str4 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response2: " + str4);
					bool flag6 = num < 15U;
					if (flag6)
					{
						MessageBox.Show("Security Access Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
				}
				Console.WriteLine("Response Data:");
				int num3;
				int i;
				for (i = 0; i <= 255; i = num3 + 1)
				{
					byte[] array6 = new byte[]
					{
						145,
						145,
						7,
						64,
						0,
						0,
						0
					};
					this.SendCommand6(array6, array6.Length, ref array5, ref num, 0);
					bool flag7 = num > 12U;
					if (flag7)
					{
						int num2 = 11;
						while ((long)num2 < (long)((ulong)Math.Min(num, 13U)))
						{
							Console.Write(array5[num2].ToString("X2") + " ");
							bool flag8 = num2 == 11 || num2 == 12;
							if (flag8)
							{
								list.Add(array5[num2]);
							}
							num2++;
						}
						Console.WriteLine();
					}
					else
					{
						Console.WriteLine("scurytyacces failed");
					}
					base.Invoke(new Action(delegate()
					{
						this.progressBar1.Value = i + 1;
					}));
					num3 = i;
				}
				this.binBytes = list.ToArray();
				for (int j = 32; j <= 175; j++)
				{
					this.binBytes[j] = 0;
				}
				int num4 = this.binBytes.Length;
				int y;
				for (y = 0; y < 256; y = num3 + 1)
				{
					int num5 = y * 2 % num4;
					byte b3 = this.binBytes[num5];
					byte b2 = this.binBytes[(num5 + 1) % num4];
					byte[] array7 = new byte[]
					{
						145,
						145,
						9,
						65,
						0,
						0,
						0,
						0,
						0
					};
					this.SendCommand6(array7, array7.Length, ref array5, ref num, 0);
					string str5 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine(string.Join(" ", from b in array7
					select b.ToString("X2")));
					base.Invoke(new Action(delegate()
					{
						this.progressBar1.Value = y + 1;
					}));
					Console.WriteLine("Response cmd: " + str5);
					num3 = y;
				}
				base.Invoke(new Action(delegate()
				{
					this.textBox2.Text = "000000000";
					this.lblStatus.Text = " PROSES RESET ID SHINDENGEN SELESAI !!! ";
				}));
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00047814 File Offset: 0x00045A14
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.comboBox1.SelectedItem.ToString() == "VARIO 150 - 30400-K59J-A71";
			if (flag)
			{
				this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
			}
			else
			{
				bool flag2 = this.comboBox1.SelectedItem.ToString() == "TYPE ECM";
				if (flag2)
				{
					this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih type ECM terlebih dahulu";
					this.textBox2.Text = "000000000";
					this.textBox1.Text = "";
				}
				else
				{
					bool flag3 = this.comboBox1.SelectedItem.ToString() == "ADV 150 - 30400-K0WA-N01";
					if (flag3)
					{
						this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
					}
					else
					{
						bool flag4 = this.comboBox1.SelectedItem.ToString() == "PCX 150 - 30400-K97G-NXX";
						if (flag4)
						{
							this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
						}
						else
						{
							bool flag5 = this.comboBox1.SelectedItem.ToString() == "VARIO 125 - 30400-K2VG-N42";
							if (flag5)
							{
								this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
							}
							else
							{
								bool flag6 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZG-NXX";
								if (flag6)
								{
									this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
								}
								else
								{
									bool flag7 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZN-NXX";
									if (flag7)
									{
										this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
									}
									else
									{
										bool flag8 = this.comboBox1.SelectedItem.ToString() == "BEAT 110 - 30400-K1AL-NB1";
										if (flag8)
										{
											this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
										}
										else
										{
											bool flag9 = this.comboBox1.SelectedItem.ToString() == "STYLO 160 - 30400-K3VA-N01";
											if (flag9)
											{
												this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
											}
											else
											{
												bool flag10 = this.comboBox1.SelectedItem.ToString() == "VARIO 160 - 30400-K2SA-N02";
												if (flag10)
												{
													this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
												}
												else
												{
													bool flag11 = this.comboBox1.SelectedItem.ToString() == "ADV 160 - 30400-K0WL-NXX";
													if (flag11)
													{
														this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
													}
													else
													{
														bool flag12 = this.comboBox1.SelectedItem.ToString() == "SCOOPY 110 - 30400-K2F-NXX";
														if (flag12)
														{
															this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih Menu Read atau Reset";
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

		// Token: 0x060002A2 RID: 674 RVA: 0x00047AD1 File Offset: 0x00045CD1
		private void SMK_Load(object sender, EventArgs e)
		{
			this.textBox2.Text = "\ud83d\udd11 ---------";
			this.lblStatus.Text = "\ud83d\udd0d Silahkan pilih type ECM terlebih dahulu";
		}

		// Token: 0x040001F7 RID: 503
		private string receivedtype;

		// Token: 0x040001F8 RID: 504
		private static IntPtr ftHandle = IntPtr.Zero;

		// Token: 0x040001F9 RID: 505
		private byte[] binBytes;

		// Token: 0x040001FA RID: 506
		private static string ecmIdStr;

		// Token: 0x040001FB RID: 507
		private Thread eepromThread;

		// Token: 0x040001FC RID: 508
		private byte nilai11;

		// Token: 0x040001FD RID: 509
		private byte nilai12;

		// Token: 0x040001FE RID: 510
		private byte nilai112;

		// Token: 0x040001FF RID: 511
		private byte nilai122;

		// Token: 0x04000200 RID: 512
		private static bool endThread = false;

		// Token: 0x04000201 RID: 513
		private byte value1;

		// Token: 0x04000202 RID: 514
		private byte value2;

		// Token: 0x04000203 RID: 515
		private byte value3;

		// Token: 0x04000204 RID: 516
		private byte value4;

		// Token: 0x04000205 RID: 517
		private List<byte> collectedData2 = new List<byte>();
	}
}
