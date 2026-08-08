using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace _3D_Chart_Graph
{
	// Token: 0x0200001F RID: 31
	public partial class SplashScreen : Form
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00048660 File Offset: 0x00046860
		public SplashScreen()
		{
			this.InitializeComponent();
			base.ControlBox = false;
			this.timer = new Timer();
			this.timer.Interval = 7000;
			this.timer.Tick += this.Timer_Tick;
			this.timer.Start();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000486F5 File Offset: 0x000468F5
		private void Timer_Tick(object sender, EventArgs e)
		{
			this.timer.Stop();
			base.Close();
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0004870C File Offset: 0x0004690C
		private void SplashScreen_Load(object sender, EventArgs e)
		{
			string text = SplashScreen.GetProcessorId().Trim();
			Debug.WriteLine("Processor Serial Number: " + text);
			string text2 = SplashScreen.GetDiskSerialNumber().Trim();
			Debug.WriteLine("Disk Serial Number: " + text2);
			string text3 = text + "_" + text2;
			Debug.WriteLine("Combined Serial Number: " + text3);
			string text4 = this.ProcessDiskSerial(text3);
			Debug.WriteLine("Processed Combined Serial Number: " + text4);
			string[] array = this.DecryptKeyFromFile();
			string text5 = array[0];
			string text6 = array[1];
			string text7 = array[2];
			Debug.WriteLine("Stored Key: " + text5);
			Debug.WriteLine("User Name: " + text6);
			Debug.WriteLine("Phone Number: " + text7);
			bool flag = string.IsNullOrEmpty(text6) || string.IsNullOrEmpty(text7) || text4 != text5;
			if (flag)
			{
				this.ShowSaveFileDialog1(text3);
				Application.Exit();
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00048810 File Offset: 0x00046A10
		private void ShowSaveFileDialog1(string combinedSerialNumber)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Text files (*.dat)|*.dat|All files (*.*)|*.*",
				Title = "Save HWID",
				FileName = "HWID.dat"
			};
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					File.WriteAllText(saveFileDialog.FileName, combinedSerialNumber);
					Debug.WriteLine("Saved serial number to " + saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					Debug.WriteLine("Error saving file: " + ex.Message);
				}
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000488AC File Offset: 0x00046AAC
		private static string GetDiskSerialNumber()
		{
			string result;
			try
			{
				string text = string.Empty;
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_PhysicalMedia");
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object obj = managementObject["SerialNumber"];
					text = ((obj != null) ? obj.ToString().Trim() : null);
					bool flag = !string.IsNullOrEmpty(text);
					if (flag)
					{
						break;
					}
				}
				result = text;
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error retrieving disk serial number: " + ex.Message);
				result = "Error";
			}
			return result;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00048974 File Offset: 0x00046B74
		private static string GetProcessorId()
		{
			string result = string.Empty;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					object obj = managementObject["ProcessorId"];
					result = ((obj != null) ? obj.ToString() : null);
				}
			}
			return result;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000489F8 File Offset: 0x00046BF8
		private string ProcessDiskSerial(string serialNumber)
		{
			string result;
			try
			{
				char[] array = new char[serialNumber.Length];
				for (int i = 0; i < serialNumber.Length; i++)
				{
					char c = serialNumber[i];
					array[i] = (c - '\u0002' + '\u0005') * '\a';
				}
				result = new string(array);
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error in processing serial number: " + ex.Message);
				result = "Error";
			}
			return result;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00048A7C File Offset: 0x00046C7C
		private string DecryptString(string encryptedText)
		{
			string result;
			using (Aes aes = Aes.Create())
			{
				aes.Key = this.Key;
				aes.IV = this.IV;
				ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
				try
				{
					byte[] buffer = Convert.FromBase64String(encryptedText);
					using (MemoryStream memoryStream = new MemoryStream(buffer))
					{
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
						{
							using (StreamReader streamReader = new StreamReader(cryptoStream))
							{
								result = streamReader.ReadToEnd();
							}
						}
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine("Error decrypting string: " + ex.Message);
					result = "Error";
				}
			}
			return result;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00048B84 File Offset: 0x00046D84
		private string[] DecryptKeyFromFile()
		{
			try
			{
				bool flag = File.Exists("license.lic");
				if (!flag)
				{
					Debug.WriteLine("Key file not found.");
					return new string[]
					{
						"Not Found",
						"",
						""
					};
				}
				string text = File.ReadAllText("license.lic").Trim();
				string[] array = text.Split(new string[]
				{
					"//"
				}, StringSplitOptions.None);
				bool flag2 = array.Length >= 3;
				if (flag2)
				{
					string text2 = this.DecryptString(array[0]);
					string text3 = this.DecryptString(array[1]);
					string text4 = this.DecryptString(array[2]);
					return new string[]
					{
						text2,
						text3,
						text4
					};
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error reading or decrypting key file: " + ex.Message);
				return new string[]
				{
					"Error",
					"",
					""
				};
			}
			return new string[]
			{
				"Error",
				"",
				""
			};
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00048CB8 File Offset: 0x00046EB8
		private string HashSerialNumber(string serialNumber)
		{
			string result;
			using (SHA256 sha = SHA256.Create())
			{
				byte[] value = sha.ComputeHash(Encoding.UTF8.GetBytes(serialNumber));
				result = BitConverter.ToString(value).Replace("-", "").ToUpper();
			}
			return result;
		}

		// Token: 0x04000216 RID: 534
		private Timer timer;

		// Token: 0x04000217 RID: 535
		private const string KeyFilePath = "license.lic";

		// Token: 0x04000218 RID: 536
		private readonly byte[] Key = Encoding.UTF8.GetBytes("ABCDEF0123456789");

		// Token: 0x04000219 RID: 537
		private readonly byte[] IV = Encoding.UTF8.GetBytes("0123456789ABCDEF");
	}
}
