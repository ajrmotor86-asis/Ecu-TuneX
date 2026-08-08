using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x0200001D RID: 29
	public partial class read_ID_KEY : Form
	{
		// Token: 0x06000276 RID: 630 RVA: 0x000412A4 File Offset: 0x0003F4A4
		public read_ID_KEY()
		{
			this.InitializeComponent();
			this.timer1.Interval = 500;
			this.timer1.Enabled = true;
			this.comboBox1.Items.Add("TYPE ECM");
			this.comboBox1.Items.Add("ADV 150 - 30400-K0WA");
			this.comboBox1.Items.Add("ADV 160 - 30400-K0WL");
			this.comboBox1.Items.Add("BEAT 110 - 30400-K1AL");
			this.comboBox1.Items.Add("PCX 150 - 30400-K97G");
			this.comboBox1.Items.Add("PCX 160 - 30400-K1ZG");
			this.comboBox1.Items.Add("PCX 160 - 30400-K1ZN");
			this.comboBox1.Items.Add("PCX 160 - 30400-K1ZV");
			this.comboBox1.Items.Add("STYLO 160 - 30400-K3VA");
			this.comboBox1.Items.Add("SCOOPY 110 - 30400-K2F");
			this.comboBox1.Items.Add("VARIO 125 - 30400-K2VG");
			this.comboBox1.Items.Add("VARIO 150 - 30400-K59J");
			this.comboBox1.Items.Add("VARIO 160 - 30400-K2SA");
			bool flag = this.comboBox1.Items.Count > 0;
			if (flag)
			{
				this.comboBox1.SelectedIndex = 0;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00041434 File Offset: 0x0003F634
		private bool InitFtdiIso()
		{
			byte[] array = new byte[1];
			byte[] array2 = new byte[]
			{
				1
			};
			uint num = 0U;
			bool flag = FTDI.FT_Open(0U, ref read_ID_KEY.ftHandle) > FTDI.FT_STATUS.FT_OK;
			bool flag2 = flag;
			bool result;
			if (flag2)
			{
				FTDI.FT_Close(read_ID_KEY.ftHandle);
				result = false;
			}
			else
			{
				bool flag3 = FTDI.FT_Purge(read_ID_KEY.ftHandle, 3U) > FTDI.FT_STATUS.FT_OK;
				bool flag4 = flag3;
				if (flag4)
				{
					FTDI.FT_Close(read_ID_KEY.ftHandle);
					result = false;
				}
				else
				{
					bool flag5 = FTDI.FT_SetBitMode(read_ID_KEY.ftHandle, 0, 0) > FTDI.FT_STATUS.FT_OK;
					bool flag6 = flag5;
					if (flag6)
					{
						FTDI.FT_Close(read_ID_KEY.ftHandle);
						result = false;
					}
					else
					{
						bool flag7 = FTDI.FT_SetDataCharacteristics(read_ID_KEY.ftHandle, 8, 0, 0) > FTDI.FT_STATUS.FT_OK;
						bool flag8 = flag7;
						if (flag8)
						{
							FTDI.FT_Close(read_ID_KEY.ftHandle);
							result = false;
						}
						else
						{
							bool flag9 = FTDI.FT_SetBaudRate(read_ID_KEY.ftHandle, 10400U) > FTDI.FT_STATUS.FT_OK;
							bool flag10 = flag9;
							if (flag10)
							{
								FTDI.FT_Close(read_ID_KEY.ftHandle);
								result = false;
							}
							else
							{
								bool flag11 = FTDI.FT_SetTimeouts(read_ID_KEY.ftHandle, 50U, 0U) > FTDI.FT_STATUS.FT_OK;
								bool flag12 = flag11;
								if (flag12)
								{
									FTDI.FT_Close(read_ID_KEY.ftHandle);
									result = false;
								}
								else
								{
									bool flag13 = FTDI.FT_SetLatencyTimer(read_ID_KEY.ftHandle, 8) > FTDI.FT_STATUS.FT_OK;
									bool flag14 = flag13;
									if (flag14)
									{
										FTDI.FT_Close(read_ID_KEY.ftHandle);
										result = false;
									}
									else
									{
										bool flag15 = FTDI.FT_SetBitMode(read_ID_KEY.ftHandle, 1, 1) > FTDI.FT_STATUS.FT_OK;
										bool flag16 = flag15;
										if (flag16)
										{
											FTDI.FT_Close(read_ID_KEY.ftHandle);
											result = false;
										}
										else
										{
											bool flag17 = FTDI.FT_Write(read_ID_KEY.ftHandle, array, (uint)array.Length, ref num) > FTDI.FT_STATUS.FT_OK;
											bool flag18 = flag17;
											if (flag18)
											{
												FTDI.FT_Close(read_ID_KEY.ftHandle);
												result = false;
											}
											else
											{
												Thread.Sleep(70);
												bool flag19 = FTDI.FT_Write(read_ID_KEY.ftHandle, array2, (uint)array2.Length, ref num) > FTDI.FT_STATUS.FT_OK;
												bool flag20 = flag19;
												if (flag20)
												{
													FTDI.FT_Close(read_ID_KEY.ftHandle);
													result = false;
												}
												else
												{
													bool flag21 = FTDI.FT_SetBitMode(read_ID_KEY.ftHandle, 0, 0) > FTDI.FT_STATUS.FT_OK;
													bool flag22 = flag21;
													if (flag22)
													{
														FTDI.FT_Close(read_ID_KEY.ftHandle);
														result = false;
													}
													else
													{
														bool flag23 = FTDI.FT_SetBaudRate(read_ID_KEY.ftHandle, 10400U) > FTDI.FT_STATUS.FT_OK;
														bool flag24 = flag23;
														if (flag24)
														{
															FTDI.FT_Close(read_ID_KEY.ftHandle);
															result = false;
														}
														else
														{
															bool flag25 = FTDI.FT_Purge(read_ID_KEY.ftHandle, 3U) > FTDI.FT_STATUS.FT_OK;
															bool flag26 = flag25;
															if (flag26)
															{
																FTDI.FT_Close(read_ID_KEY.ftHandle);
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

		// Token: 0x06000278 RID: 632 RVA: 0x000416E8 File Offset: 0x0003F8E8
		private bool SendCommand6(byte[] command, int commandSize, ref byte[] reply, ref uint replySize, int sleepMs = 0)
		{
			byte[] array = new byte[256];
			List<byte> list = new List<byte>();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			long num4 = (long)(50 + 2 * commandSize);
			bool flag = FTDI.FT_Write(read_ID_KEY.ftHandle, command, (uint)commandSize, ref num) > FTDI.FT_STATUS.FT_OK;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = FTDI.FT_SetLatencyTimer(read_ID_KEY.ftHandle, 8) > FTDI.FT_STATUS.FT_OK;
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
						bool flag4 = FTDI.FT_GetQueueStatus(read_ID_KEY.ftHandle, ref num2) == FTDI.FT_STATUS.FT_OK && num2 > 0U;
						if (flag4)
						{
							bool flag5 = FTDI.FT_Read(read_ID_KEY.ftHandle, array, num2, ref num3) == FTDI.FT_STATUS.FT_OK && num3 > 0U;
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
					FTDI.FT_Purge(read_ID_KEY.ftHandle, 3U);
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

		// Token: 0x06000279 RID: 633 RVA: 0x00041834 File Offset: 0x0003FA34
		private void eeprom1()
		{
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
				}
				bool flag6 = this.SendCommand6(array6, array6.Length, ref array5, ref num, 0);
				if (flag6)
				{
					string str5 = BitConverter.ToString(array5, 0, (int)num);
					Console.WriteLine("Response7: " + str5);
				}
				bool flag7 = this.SendCommand6(array7, array7.Length, ref array5, ref num, 0);
				if (flag7)
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
					bool flag8 = num > 12U;
					if (flag8)
					{
						int num2 = 10;
						while ((long)num2 < (long)((ulong)Math.Min(num, 12U)))
						{
							Console.Write(array5[num2].ToString("X2") + " ");
							bool flag9 = num2 == 10 || num2 == 11;
							if (flag9)
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
						TimeSpan elapsed = stopwatch.Elapsed;
					}));
					j = i;
				}
				stopwatch.Stop();
				base.Invoke(new Action(delegate()
				{
				}));
				this.binBytes = list.ToArray();
				this.SaveFileOnUIThread(list);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00041C18 File Offset: 0x0003FE18
		private void eeprom()
		{
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
					bool flag6 = num > 12U;
					if (flag6)
					{
						int num2 = 11;
						while ((long)num2 < (long)((ulong)Math.Min(num, 13U)))
						{
							Console.Write(array5[num2].ToString("X2") + " ");
							bool flag7 = num2 == 11 || num2 == 12;
							if (flag7)
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
						TimeSpan elapsed = stopwatch.Elapsed;
					}));
					j = i;
				}
				stopwatch.Stop();
				base.Invoke(new Action(delegate()
				{
				}));
				this.binBytes = list.ToArray();
				this.SaveFileOnUIThread(list);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00041F50 File Offset: 0x00040150
		private void SaveFileOnUIThread(List<byte> collectedData)
		{
			base.Invoke(new Action(delegate()
			{
				string text = "C:\\File EEPROM READ ID";
				string path = "File EEPROM READ ID " + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bin";
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

		// Token: 0x0600027C RID: 636 RVA: 0x00041F88 File Offset: 0x00040188
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
					bool flag2 = this.comboBox1.SelectedItem.ToString() == "VARIO 150 - 30400-K59J";
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
						bool flag4 = this.comboBox1.SelectedItem.ToString() == "ADV 150 - 30400-K0WA";
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
							bool flag6 = this.comboBox1.SelectedItem.ToString() == "PCX 150 - 30400-K97G";
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
								bool flag8 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZV";
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
									bool flag10 = this.comboBox1.SelectedItem.ToString() == "VARIO 125 - 30400-K2VG";
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
										bool flag12 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZG";
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
											bool flag14 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZG";
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
												bool flag16 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZN";
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
														bool flag20 = this.comboBox1.SelectedItem.ToString() == "BEAT 110 - 30400-K1AL";
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
															bool flag22 = this.comboBox1.SelectedItem.ToString() == "STYLO 160 - 30400-K3VA";
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
																bool flag24 = this.comboBox1.SelectedItem.ToString() == "VARIO 160 - 30400-K2SA";
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
																	bool flag26 = this.comboBox1.SelectedItem.ToString() == "ADV 160 - 30400-K0WL";
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
																			bool flag30 = this.comboBox1.SelectedItem.ToString() == "SCOOPY 110 - 30400-K2F";
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

		// Token: 0x0600027D RID: 637 RVA: 0x00042B20 File Offset: 0x00040D20
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
						this.textBox2.Text = text3;
						this.textBox3_TextChanged();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00042D10 File Offset: 0x00040F10
		private void textBox3_TextChanged()
		{
			string text = this.textBox2.Text.Trim();
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
					bool flag2 = num9 < 0L;
					if (flag2)
					{
						num9 = 0L;
					}
					this.textBox1.Text = "\ud83d\udd11 " + num9.ToString("D9");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error in conversion: " + ex.Message);
				}
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00042E2C File Offset: 0x0004102C
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
					this.textBox1.Text = "";
					for (int i = 0; i < array.Length; i += 4)
					{
						byte b = this.ConvertInputToByte(array[i]);
						byte b2 = this.ConvertInputToByte(array[i + 1]);
						byte b3 = this.ConvertInputToByte(array[i + 2]);
						byte b4 = this.ConvertInputToByte(array[i + 3]);
						uint num = (uint)((int)b4 << 8 | (int)b3);
						uint num2 = (uint)((int)b2 << 24 | (int)b << 16 | (int)num);
						string text2 = num2.ToString().PadLeft(9, '0');
						this.textBox1.Text = "\ud83d\udd11 {123456789}";
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
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0004302C File Offset: 0x0004122C
		private byte ConvertInputToByte(string input)
		{
			bool flag = string.IsNullOrEmpty(input);
			if (flag)
			{
				throw new ArgumentException("Input tidak boleh kosong.");
			}
			return Convert.ToByte(input, 16);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0004305C File Offset: 0x0004125C
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.comboBox1.SelectedItem == null;
				if (flag)
				{
					MessageBox.Show("Tidak Dapat Dijalankan. Silakan Pilih Type ECM terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					bool flag2 = this.comboBox1.SelectedItem.ToString() == "VARIO 150 - 30400-K59J";
					if (flag2)
					{
						DialogResult dialogResult = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
						bool flag3 = dialogResult == DialogResult.OK;
						if (flag3)
						{
							bool flag4 = this.eepromThread == null || !this.eepromThread.IsAlive;
							if (flag4)
							{
								this.eepromThread = new Thread(new ThreadStart(this.eeprom))
								{
									IsBackground = true
								};
								this.eepromThread.Start();
							}
							else
							{
								MessageBox.Show("Process is already running.");
							}
						}
					}
					else
					{
						bool flag5 = this.comboBox1.SelectedItem.ToString() == "ADV 150 - 30400-K0WA";
						if (flag5)
						{
							DialogResult dialogResult2 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
							bool flag6 = dialogResult2 == DialogResult.OK;
							if (flag6)
							{
								bool flag7 = this.eepromThread == null || !this.eepromThread.IsAlive;
								if (flag7)
								{
									this.eepromThread = new Thread(new ThreadStart(this.eeprom))
									{
										IsBackground = true
									};
									this.eepromThread.Start();
								}
								else
								{
									MessageBox.Show("Process is already running.");
								}
							}
						}
						else
						{
							bool flag8 = this.comboBox1.SelectedItem.ToString() == "PCX 150 - 30400-K97G";
							if (flag8)
							{
								DialogResult dialogResult3 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
								bool flag9 = dialogResult3 == DialogResult.OK;
								if (flag9)
								{
									bool flag10 = this.eepromThread == null || !this.eepromThread.IsAlive;
									if (flag10)
									{
										this.eepromThread = new Thread(new ThreadStart(this.eeprom))
										{
											IsBackground = true
										};
										this.eepromThread.Start();
									}
									else
									{
										MessageBox.Show("Process is already running.");
									}
								}
							}
							else
							{
								bool flag11 = this.comboBox1.SelectedItem.ToString() == "VARIO 125 - 30400-K2VG";
								if (flag11)
								{
									DialogResult dialogResult4 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
									bool flag12 = dialogResult4 == DialogResult.OK;
									if (flag12)
									{
										bool flag13 = this.eepromThread == null || !this.eepromThread.IsAlive;
										if (flag13)
										{
											this.eepromThread = new Thread(new ThreadStart(this.eeprom))
											{
												IsBackground = true
											};
											this.eepromThread.Start();
										}
										else
										{
											MessageBox.Show("Process is already running.");
										}
									}
								}
								else
								{
									bool flag14 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZG";
									if (flag14)
									{
										DialogResult dialogResult5 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
										bool flag15 = dialogResult5 == DialogResult.OK;
										if (flag15)
										{
											bool flag16 = this.eepromThread == null || !this.eepromThread.IsAlive;
											if (flag16)
											{
												this.eepromThread = new Thread(new ThreadStart(this.eeprom))
												{
													IsBackground = true
												};
												this.eepromThread.Start();
											}
											else
											{
												MessageBox.Show("Process is already running.");
											}
										}
									}
									else
									{
										bool flag17 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZN";
										if (flag17)
										{
											DialogResult dialogResult6 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
											bool flag18 = dialogResult6 == DialogResult.OK;
											if (flag18)
											{
												bool flag19 = this.eepromThread == null || !this.eepromThread.IsAlive;
												if (flag19)
												{
													this.eepromThread = new Thread(new ThreadStart(this.eeprom))
													{
														IsBackground = true
													};
													this.eepromThread.Start();
												}
												else
												{
													MessageBox.Show("Process is already running.");
												}
											}
										}
										else
										{
											bool flag20 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZV";
											if (flag20)
											{
												DialogResult dialogResult7 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
												bool flag21 = dialogResult7 == DialogResult.OK;
												if (flag21)
												{
													bool flag22 = this.eepromThread == null || !this.eepromThread.IsAlive;
													if (flag22)
													{
														this.eepromThread = new Thread(new ThreadStart(this.eeprom))
														{
															IsBackground = true
														};
														this.eepromThread.Start();
													}
													else
													{
														MessageBox.Show("Process is already running.");
													}
												}
											}
											else
											{
												bool flag23 = this.comboBox1.SelectedItem.ToString() == "BEAT 110 - 30400-K1AL";
												if (flag23)
												{
													DialogResult dialogResult8 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
													bool flag24 = dialogResult8 == DialogResult.OK;
													if (flag24)
													{
														bool flag25 = this.eepromThread == null || !this.eepromThread.IsAlive;
														if (flag25)
														{
															this.eepromThread = new Thread(new ThreadStart(this.eeprom))
															{
																IsBackground = true
															};
															this.eepromThread.Start();
														}
														else
														{
															MessageBox.Show("Process is already running.");
														}
													}
												}
												else
												{
													bool flag26 = this.comboBox1.SelectedItem.ToString() == "STYLO 160 - 30400-K3VA";
													if (flag26)
													{
														DialogResult dialogResult9 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
														bool flag27 = dialogResult9 == DialogResult.OK;
														if (flag27)
														{
															bool flag28 = this.eepromThread == null || !this.eepromThread.IsAlive;
															if (flag28)
															{
																this.eepromThread = new Thread(new ThreadStart(this.eeprom))
																{
																	IsBackground = true
																};
																this.eepromThread.Start();
															}
															else
															{
																MessageBox.Show("Process is already running.");
															}
														}
													}
													else
													{
														bool flag29 = this.comboBox1.SelectedItem.ToString() == "VARIO 160 - 30400-K2SA";
														if (flag29)
														{
															DialogResult dialogResult10 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
															bool flag30 = dialogResult10 == DialogResult.OK;
															if (flag30)
															{
																bool flag31 = this.eepromThread == null || !this.eepromThread.IsAlive;
																if (flag31)
																{
																	this.eepromThread = new Thread(new ThreadStart(this.eeprom))
																	{
																		IsBackground = true
																	};
																	this.eepromThread.Start();
																}
																else
																{
																	MessageBox.Show("Process is already running.");
																}
															}
														}
														else
														{
															bool flag32 = this.comboBox1.SelectedItem.ToString() == "ADV 160 - 30400-K0WL";
															if (flag32)
															{
																DialogResult dialogResult11 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
																bool flag33 = dialogResult11 == DialogResult.OK;
																if (flag33)
																{
																	bool flag34 = this.eepromThread == null || !this.eepromThread.IsAlive;
																	if (flag34)
																	{
																		this.eepromThread = new Thread(new ThreadStart(this.eeprom))
																		{
																			IsBackground = true
																		};
																		this.eepromThread.Start();
																	}
																	else
																	{
																		MessageBox.Show("Process is already running.");
																	}
																}
															}
															else
															{
																bool flag35 = this.comboBox1.SelectedItem.ToString() == "READ EEPROM SH";
																if (flag35)
																{
																	DialogResult dialogResult12 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
																	Thread.Sleep(50);
																	DialogResult dialogResult13 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nProses READ ECM ID", "READ ECM ID", MessageBoxButtons.OK);
																	bool flag36 = dialogResult12 == DialogResult.OK;
																	if (flag36)
																	{
																		bool flag37 = this.eepromThread == null || !this.eepromThread.IsAlive;
																		if (flag37)
																		{
																			this.eepromThread = new Thread(new ThreadStart(this.eeprom))
																			{
																				IsBackground = true
																			};
																			this.eepromThread.Start();
																		}
																		else
																		{
																			MessageBox.Show("Process is already running.");
																		}
																	}
																}
																else
																{
																	bool flag38 = this.comboBox1.SelectedItem.ToString() == "SCOOPY 110 - 30400-K2F";
																	if (flag38)
																	{
																		DialogResult dialogResult14 = MessageBox.Show("KUNCI KONTAK OFF - ON\r\nSelama 5 Detik\r\nKoneksi Ke EEPROM", "READ ECM ID", MessageBoxButtons.OK);
																		bool flag39 = dialogResult14 == DialogResult.OK;
																		if (flag39)
																		{
																			bool flag40 = this.eepromThread == null || !this.eepromThread.IsAlive;
																			if (flag40)
																			{
																				this.eepromThread = new Thread(new ThreadStart(this.eeprom1))
																				{
																					IsBackground = true
																				};
																				this.eepromThread.Start();
																			}
																			else
																			{
																				MessageBox.Show("Process is already running.");
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
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00043918 File Offset: 0x00041B18
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.comboBox1.SelectedItem == null;
				if (flag)
				{
					MessageBox.Show("Tidak Dapat Dijalankan. Silakan Pilih Type ECM terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					bool flag2 = this.comboBox1.SelectedItem.ToString() == "VARIO 150 - 30400-K59J";
					if (flag2)
					{
						DialogResult dialogResult = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						bool flag3 = dialogResult == DialogResult.OK;
						if (flag3)
						{
							this.EDIT_NUMBER();
							bool flag4 = this.eepromThread == null || !this.eepromThread.IsAlive;
							if (flag4)
							{
								this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
								{
									IsBackground = true
								};
								this.eepromThread.Start();
							}
							else
							{
								MessageBox.Show("Process is already running.");
							}
						}
					}
					else
					{
						bool flag5 = this.comboBox1.SelectedItem.ToString() == "ADV 150 - 30400-K0WA";
						if (flag5)
						{
							DialogResult dialogResult2 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							bool flag6 = dialogResult2 == DialogResult.OK;
							if (flag6)
							{
								this.EDIT_NUMBER();
								bool flag7 = this.eepromThread == null || !this.eepromThread.IsAlive;
								if (flag7)
								{
									this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
									{
										IsBackground = true
									};
									this.eepromThread.Start();
								}
								else
								{
									MessageBox.Show("Process is already running.");
								}
							}
						}
						else
						{
							bool flag8 = this.comboBox1.SelectedItem.ToString() == "PCX 150 - 30400-K97G";
							if (flag8)
							{
								DialogResult dialogResult3 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								bool flag9 = dialogResult3 == DialogResult.OK;
								if (flag9)
								{
									this.EDIT_NUMBER();
									bool flag10 = this.eepromThread == null || !this.eepromThread.IsAlive;
									if (flag10)
									{
										this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
										{
											IsBackground = true
										};
										this.eepromThread.Start();
									}
									else
									{
										MessageBox.Show("Process is already running.");
									}
								}
							}
							else
							{
								bool flag11 = this.comboBox1.SelectedItem.ToString() == "VARIO 125 - 30400-K2VG";
								if (flag11)
								{
									DialogResult dialogResult4 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									bool flag12 = dialogResult4 == DialogResult.OK;
									if (flag12)
									{
										this.EDIT_NUMBER();
										bool flag13 = this.eepromThread == null || !this.eepromThread.IsAlive;
										if (flag13)
										{
											this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
											{
												IsBackground = true
											};
											this.eepromThread.Start();
										}
										else
										{
											MessageBox.Show("Process is already running.");
										}
									}
								}
								else
								{
									bool flag14 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZG";
									if (flag14)
									{
										DialogResult dialogResult5 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
										bool flag15 = dialogResult5 == DialogResult.OK;
										if (flag15)
										{
											this.EDIT_NUMBER();
											bool flag16 = this.eepromThread == null || !this.eepromThread.IsAlive;
											if (flag16)
											{
												this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
												{
													IsBackground = true
												};
												this.eepromThread.Start();
											}
											else
											{
												MessageBox.Show("Process is already running.");
											}
										}
									}
									else
									{
										bool flag17 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZN";
										if (flag17)
										{
											DialogResult dialogResult6 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
											bool flag18 = dialogResult6 == DialogResult.OK;
											if (flag18)
											{
												this.EDIT_NUMBER();
												bool flag19 = this.eepromThread == null || !this.eepromThread.IsAlive;
												if (flag19)
												{
													this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
													{
														IsBackground = true
													};
													this.eepromThread.Start();
												}
												else
												{
													MessageBox.Show("Process is already running.");
												}
											}
										}
										else
										{
											bool flag20 = this.comboBox1.SelectedItem.ToString() == "PCX 160 - 30400-K1ZV";
											if (flag20)
											{
												DialogResult dialogResult7 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
												bool flag21 = dialogResult7 == DialogResult.OK;
												if (flag21)
												{
													this.EDIT_NUMBER();
													bool flag22 = this.eepromThread == null || !this.eepromThread.IsAlive;
													if (flag22)
													{
														this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
														{
															IsBackground = true
														};
														this.eepromThread.Start();
													}
													else
													{
														MessageBox.Show("Process is already running.");
													}
												}
											}
											else
											{
												bool flag23 = this.comboBox1.SelectedItem.ToString() == "BEAT 110 - 30400-K1AL";
												if (flag23)
												{
													DialogResult dialogResult8 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
													bool flag24 = dialogResult8 == DialogResult.OK;
													if (flag24)
													{
														this.EDIT_NUMBER();
														bool flag25 = this.eepromThread == null || !this.eepromThread.IsAlive;
														if (flag25)
														{
															this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
															{
																IsBackground = true
															};
															this.eepromThread.Start();
														}
														else
														{
															MessageBox.Show("Process is already running.");
														}
													}
												}
												else
												{
													bool flag26 = this.comboBox1.SelectedItem.ToString() == "STYLO 160 - 30400-K3VA";
													if (flag26)
													{
														DialogResult dialogResult9 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
														bool flag27 = dialogResult9 == DialogResult.OK;
														if (flag27)
														{
															this.EDIT_NUMBER();
															bool flag28 = this.eepromThread == null || !this.eepromThread.IsAlive;
															if (flag28)
															{
																this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
																{
																	IsBackground = true
																};
																this.eepromThread.Start();
															}
															else
															{
																MessageBox.Show("Process is already running.");
															}
														}
													}
													else
													{
														bool flag29 = this.comboBox1.SelectedItem.ToString() == "VARIO 160 - 30400-K2SA";
														if (flag29)
														{
															DialogResult dialogResult10 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
															bool flag30 = dialogResult10 == DialogResult.OK;
															if (flag30)
															{
																this.EDIT_NUMBER();
																bool flag31 = this.eepromThread == null || !this.eepromThread.IsAlive;
																if (flag31)
																{
																	this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
																	{
																		IsBackground = true
																	};
																	this.eepromThread.Start();
																}
																else
																{
																	MessageBox.Show("Process is already running.");
																}
															}
														}
														else
														{
															bool flag32 = this.comboBox1.SelectedItem.ToString() == "ADV 160 - 30400-K0WL";
															if (flag32)
															{
																DialogResult dialogResult11 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
																bool flag33 = dialogResult11 == DialogResult.OK;
																if (flag33)
																{
																	this.EDIT_NUMBER();
																	bool flag34 = this.eepromThread == null || !this.eepromThread.IsAlive;
																	if (flag34)
																	{
																		this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
																		{
																			IsBackground = true
																		};
																		this.eepromThread.Start();
																	}
																	else
																	{
																		MessageBox.Show("Process is already running.");
																	}
																}
															}
															else
															{
																bool flag35 = this.comboBox1.SelectedItem.ToString() == "SCOOPY 110 - 30400-K2F";
																if (flag35)
																{
																	DialogResult dialogResult12 = MessageBox.Show("Klik 'OK' Untuk Reset ID Kembali Baru", "RENEW ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
																	bool flag36 = dialogResult12 == DialogResult.OK;
																	if (flag36)
																	{
																		this.EDIT_NUMBER();
																		bool flag37 = this.eepromThread == null || !this.eepromThread.IsAlive;
																		if (flag37)
																		{
																			this.eepromThread = new Thread(new ThreadStart(this.writeeeprom1))
																			{
																				IsBackground = true
																			};
																			this.eepromThread.Start();
																		}
																		else
																		{
																			MessageBox.Show("Process is already running.");
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
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00044188 File Offset: 0x00042388
		private void EDIT_NUMBER()
		{
			string text = "000000000";
			uint num = Convert.ToUInt32(text.Trim(), 10);
			this.value1 = (byte)(num >> 16 & 255U);
			this.value2 = (byte)(num >> 24 & 255U);
			this.value3 = (byte)(num & 255U);
			this.value4 = (byte)(num >> 8 & 255U);
			string text2 = string.Format("{0:X2} {1:X2} {2:X2} {3:X2}", new object[]
			{
				this.value1,
				this.value2,
				this.value3,
				this.value4
			});
			this.textBox2.Text = text2;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00044240 File Offset: 0x00042440
		private void writeeeprom1()
		{
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
			byte[] value = new byte[20];
			uint length = 0U;
			bool flag = this.InitFtdiIso();
			if (flag)
			{
				base.Invoke(new Action(delegate()
				{
					this.progressBar1.Maximum = 256;
					this.progressBar1.Value = 0;
				}));
				bool flag2 = this.SendCommand6(array, array.Length, ref value, ref length, 0);
				if (flag2)
				{
					string str = BitConverter.ToString(value, 0, (int)length);
					Console.WriteLine("Response: " + str);
				}
				Thread.Sleep(150);
				bool flag3 = this.SendCommand6(array2, array2.Length, ref value, ref length, 0);
				if (flag3)
				{
					string str2 = BitConverter.ToString(value, 0, (int)length);
					Console.WriteLine("Response: " + str2);
				}
				Thread.Sleep(150);
				bool flag4 = this.SendCommand6(array3, array3.Length, ref value, ref length, 0);
				if (flag4)
				{
					string str3 = BitConverter.ToString(value, 0, (int)length);
					Console.WriteLine("Response: " + str3);
				}
				Thread.Sleep(150);
				bool flag5 = this.SendCommand6(array4, array4.Length, ref value, ref length, 0);
				if (flag5)
				{
					string str4 = BitConverter.ToString(value, 0, (int)length);
					Console.WriteLine("Response2: " + str4);
				}
				int j;
				int i;
				Action <>9__2;
				for (i = 0; i <= 255; i = j + 1)
				{
					byte[] array5 = new byte[]
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
					array5[4] = (byte)i;
					array5[6] = ((i % 2 != 0) ? this.value1 : this.value3);
					array5[7] = ((i % 2 != 0) ? this.value2 : this.value4);
					array5[8] = (byte)(256 - (74 + i + (int)((i % 2 != 0) ? this.value1 : this.value3) + (int)((i % 2 != 0) ? this.value2 : this.value4)));
					this.SendCommand6(array5, array5.Length, ref value, ref length, 0);
					Thread.Sleep(50);
					Action method;
					if ((method = <>9__2) == null)
					{
						method = (<>9__2 = delegate()
						{
							this.progressBar1.Value = i + 1;
							int num = (i + 1) * 100 / 256;
							TimeSpan elapsed = stopwatch.Elapsed;
						});
					}
					base.Invoke(method);
					j = i;
				}
				base.Invoke(new Action(delegate()
				{
					MessageBox.Show("RENEW ID KEY SUKSES\r\nID KEY SUDAH DI RESET (000000000)\r\nSILAHKAN READ ULANG ID KEY UNTUK MEMASTIKAN", "RENEW ID");
				}));
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00003C6B File Offset: 0x00001E6B
		private void read_ID_KEY_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00044544 File Offset: 0x00042744
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.teks = this.teks.Substring(1) + this.teks[0].ToString();
			this.Text = this.teks;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0004458A File Offset: 0x0004278A
		private void read_ID_KEY_FormClosing(object sender, FormClosingEventArgs e)
		{
			read_ID_KEY.endThread = true;
			FTDI.FT_Close(read_ID_KEY.ftHandle);
		}

		// Token: 0x040001E5 RID: 485
		private string teks = "⟶ ( \ud83d\udd11 Smartkey ) ⟵  \ud83d\udcbb Reset ID Smartkey  -  Read ID Smartkey  ";

		// Token: 0x040001E6 RID: 486
		private byte[] binBytes;

		// Token: 0x040001E7 RID: 487
		private static IntPtr ftHandle = IntPtr.Zero;

		// Token: 0x040001E8 RID: 488
		private Thread eepromThread;

		// Token: 0x040001E9 RID: 489
		private static bool endThread = false;

		// Token: 0x040001EA RID: 490
		private byte value1;

		// Token: 0x040001EB RID: 491
		private byte value2;

		// Token: 0x040001EC RID: 492
		private byte value3;

		// Token: 0x040001ED RID: 493
		private byte value4;
	}
}
