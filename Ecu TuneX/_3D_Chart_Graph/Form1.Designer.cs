namespace _3D_Chart_Graph
{
	// Token: 0x02000018 RID: 24
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000246 RID: 582 RVA: 0x0003A488 File Offset: 0x00038688
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0003A4C0 File Offset: 0x000386C0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_3D_Chart_Graph.Form1));
			this.show_all = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.txtInput = new global::System.Windows.Forms.TextBox();
			this.TbFileName = new global::System.Windows.Forms.TextBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.CbFastWrite = new global::System.Windows.Forms.CheckBox();
			this.TbStartOffset = new global::System.Windows.Forms.TextBox();
			this.TbChecksumOffset = new global::System.Windows.Forms.TextBox();
			this.button12 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.BtnWrite = new global::System.Windows.Forms.Button();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.TxtPb = new global::System.Windows.Forms.Label();
			this.label17 = new global::System.Windows.Forms.Label();
			this.TxtEcmId = new global::System.Windows.Forms.Label();
			this.TxtFlashCount = new global::System.Windows.Forms.Label();
			this.TxtConnStat = new global::System.Windows.Forms.Label();
			this.PbProgress = new global::System.Windows.Forms.ProgressBar();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.TxtPartCode = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.menuStrip7 = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openFileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.button9 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.diagnosticToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.resetCountToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.keihinToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.shindengenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.breakpointToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.readIDBarcodeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem23 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.breakpointToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.breakpoinRPMToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.breakpointTPSToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.breakpointIAPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rpmVsTps1ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rpmVsTps2ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rpmVsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rpmVsIAPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ignitionToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ignition4ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ignition5ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.limiterToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.limiter6ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.limiter7ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.settinganLaiinToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem16 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem17 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem18 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem19 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem20 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem21 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem22 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.offMode4ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.offBASSensorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.offMAPSensorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.offECTSensorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.offIATSensorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.offVSSSensorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.offMAPSensorToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label19 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.button10 = new global::System.Windows.Forms.Button();
			this.panelDATA = new global::System.Windows.Forms.Panel();
			this.panel4.SuspendLayout();
			this.menuStrip7.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panelDATA.SuspendLayout();
			base.SuspendLayout();
			this.show_all.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.show_all.BackColor = global::System.Drawing.Color.Yellow;
			this.show_all.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.show_all.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.show_all.ForeColor = global::System.Drawing.Color.Black;
			this.show_all.Location = new global::System.Drawing.Point(747, 116);
			this.show_all.Name = "show_all";
			this.show_all.Size = new global::System.Drawing.Size(91, 32);
			this.show_all.TabIndex = 2;
			this.show_all.Text = "\ud83d\udccaGraph";
			this.show_all.UseVisualStyleBackColor = false;
			this.show_all.Click += new global::System.EventHandler(this.show_all_Click);
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.BackColor = global::System.Drawing.Color.Black;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Segoe UI Black", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(310, 9);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(64, 24);
			this.button2.TabIndex = 23;
			this.button2.Text = "Execute";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.btnOK_Click_1);
			this.txtInput.BackColor = global::System.Drawing.Color.Black;
			this.txtInput.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtInput.ForeColor = global::System.Drawing.Color.Cyan;
			this.txtInput.Location = new global::System.Drawing.Point(235, 8);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new global::System.Drawing.Size(61, 24);
			this.txtInput.TabIndex = 20;
			this.txtInput.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtInput.TextChanged += new global::System.EventHandler(this.txtInput_TextChanged);
			this.TbFileName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.TbFileName.BackColor = global::System.Drawing.Color.Black;
			this.TbFileName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TbFileName.ForeColor = global::System.Drawing.Color.Ivory;
			this.TbFileName.Location = new global::System.Drawing.Point(47, 122);
			this.TbFileName.Multiline = true;
			this.TbFileName.Name = "TbFileName";
			this.TbFileName.Size = new global::System.Drawing.Size(135, 29);
			this.TbFileName.TabIndex = 13;
			this.button3.BackColor = global::System.Drawing.Color.DarkOrange;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.Black;
			this.button3.Location = new global::System.Drawing.Point(8, 637);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(121, 37);
			this.button3.TabIndex = 15;
			this.button3.Text = "\ud83d\udd0cConnect ECM";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.CbFastWrite.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.CbFastWrite.AutoSize = true;
			this.CbFastWrite.Checked = true;
			this.CbFastWrite.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.CbFastWrite.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CbFastWrite.ForeColor = global::System.Drawing.Color.Red;
			this.CbFastWrite.Location = new global::System.Drawing.Point(1022, 124);
			this.CbFastWrite.Name = "CbFastWrite";
			this.CbFastWrite.Size = new global::System.Drawing.Size(52, 21);
			this.CbFastWrite.TabIndex = 15;
			this.CbFastWrite.Text = "Fast";
			this.CbFastWrite.UseVisualStyleBackColor = true;
			this.TbStartOffset.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.TbStartOffset.BackColor = global::System.Drawing.Color.Black;
			this.TbStartOffset.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TbStartOffset.ForeColor = global::System.Drawing.Color.White;
			this.TbStartOffset.Location = new global::System.Drawing.Point(1083, 124);
			this.TbStartOffset.Multiline = true;
			this.TbStartOffset.Name = "TbStartOffset";
			this.TbStartOffset.Size = new global::System.Drawing.Size(77, 29);
			this.TbStartOffset.TabIndex = 3;
			this.TbStartOffset.Text = "Auto";
			this.TbStartOffset.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.TbChecksumOffset.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.TbChecksumOffset.BackColor = global::System.Drawing.Color.Black;
			this.TbChecksumOffset.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TbChecksumOffset.ForeColor = global::System.Drawing.Color.White;
			this.TbChecksumOffset.Location = new global::System.Drawing.Point(1194, 124);
			this.TbChecksumOffset.Multiline = true;
			this.TbChecksumOffset.Name = "TbChecksumOffset";
			this.TbChecksumOffset.Size = new global::System.Drawing.Size(77, 29);
			this.TbChecksumOffset.TabIndex = 4;
			this.TbChecksumOffset.Text = "Auto";
			this.TbChecksumOffset.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.button12.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button12.BackColor = global::System.Drawing.Color.SpringGreen;
			this.button12.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button12.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button12.ForeColor = global::System.Drawing.Color.Black;
			this.button12.Location = new global::System.Drawing.Point(940, 116);
			this.button12.Name = "button12";
			this.button12.Size = new global::System.Drawing.Size(76, 33);
			this.button12.TabIndex = 20;
			this.button12.Text = "▶️ Run";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new global::System.EventHandler(this.button12_Click);
			this.button8.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button8.BackColor = global::System.Drawing.Color.OrangeRed;
			this.button8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button8.ForeColor = global::System.Drawing.Color.Black;
			this.button8.Location = new global::System.Drawing.Point(844, 116);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(90, 33);
			this.button8.TabIndex = 15;
			this.button8.Text = "\ud83d\udd04Auto Map";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.BackColor = global::System.Drawing.Color.DeepSkyBlue;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.Black;
			this.button1.Location = new global::System.Drawing.Point(657, 117);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(84, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "\ud83d\udcc8Live Data";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.BtnWrite.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.BtnWrite.BackColor = global::System.Drawing.Color.Lime;
			this.BtnWrite.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnWrite.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.BtnWrite.ForeColor = global::System.Drawing.Color.Black;
			this.BtnWrite.Location = new global::System.Drawing.Point(574, 117);
			this.BtnWrite.Name = "BtnWrite";
			this.BtnWrite.Size = new global::System.Drawing.Size(77, 32);
			this.BtnWrite.TabIndex = 11;
			this.BtnWrite.Text = "⚡FLASH";
			this.BtnWrite.UseVisualStyleBackColor = false;
			this.BtnWrite.Click += new global::System.EventHandler(this.BtnWrite_Click_1);
			this.panel4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel4.BackColor = global::System.Drawing.Color.Black;
			this.panel4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.TxtPb);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.TxtEcmId);
			this.panel4.Controls.Add(this.TxtFlashCount);
			this.panel4.Controls.Add(this.TxtConnStat);
			this.panel4.Controls.Add(this.PbProgress);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Location = new global::System.Drawing.Point(135, 637);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(968, 37);
			this.panel4.TabIndex = 12;
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.BackColor = global::System.Drawing.Color.Black;
			this.label3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Cyan;
			this.label3.Location = new global::System.Drawing.Point(713, -1);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(253, 37);
			this.label3.TabIndex = 21;
			this.label3.Text = "label3";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.TxtPb.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.TxtPb.BackColor = global::System.Drawing.Color.Black;
			this.TxtPb.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.TxtPb.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TxtPb.ForeColor = global::System.Drawing.Color.OrangeRed;
			this.TxtPb.Location = new global::System.Drawing.Point(658, 3);
			this.TxtPb.Name = "TxtPb";
			this.TxtPb.Size = new global::System.Drawing.Size(58, 27);
			this.TxtPb.TabIndex = 20;
			this.TxtPb.Text = "⏳100%";
			this.TxtPb.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label17.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label17.BackColor = global::System.Drawing.Color.Black;
			this.label17.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.ForeColor = global::System.Drawing.Color.White;
			this.label17.Location = new global::System.Drawing.Point(179, 4);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(76, 23);
			this.label17.TabIndex = 18;
			this.label17.Text = "ECM ID :";
			this.label17.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.TxtEcmId.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.TxtEcmId.BackColor = global::System.Drawing.Color.Black;
			this.TxtEcmId.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TxtEcmId.ForeColor = global::System.Drawing.Color.White;
			this.TxtEcmId.Location = new global::System.Drawing.Point(261, 5);
			this.TxtEcmId.Name = "TxtEcmId";
			this.TxtEcmId.Size = new global::System.Drawing.Size(130, 23);
			this.TxtEcmId.TabIndex = 17;
			this.TxtEcmId.Text = "-";
			this.TxtEcmId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.TxtFlashCount.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.TxtFlashCount.BackColor = global::System.Drawing.Color.Black;
			this.TxtFlashCount.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TxtFlashCount.ForeColor = global::System.Drawing.Color.White;
			this.TxtFlashCount.Location = new global::System.Drawing.Point(481, 5);
			this.TxtFlashCount.Name = "TxtFlashCount";
			this.TxtFlashCount.Size = new global::System.Drawing.Size(32, 23);
			this.TxtFlashCount.TabIndex = 5;
			this.TxtFlashCount.Text = "-";
			this.TxtFlashCount.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.TxtConnStat.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.TxtConnStat.BackColor = global::System.Drawing.Color.Black;
			this.TxtConnStat.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TxtConnStat.ForeColor = global::System.Drawing.Color.Red;
			this.TxtConnStat.Location = new global::System.Drawing.Point(5, 5);
			this.TxtConnStat.Name = "TxtConnStat";
			this.TxtConnStat.Size = new global::System.Drawing.Size(190, 23);
			this.TxtConnStat.TabIndex = 2;
			this.TxtConnStat.Text = "-";
			this.TxtConnStat.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.PbProgress.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.PbProgress.ForeColor = global::System.Drawing.Color.Lime;
			this.PbProgress.Location = new global::System.Drawing.Point(519, 3);
			this.PbProgress.Maximum = 10000;
			this.PbProgress.Name = "PbProgress";
			this.PbProgress.Size = new global::System.Drawing.Size(133, 27);
			this.PbProgress.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
			this.PbProgress.TabIndex = 6;
			this.label14.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.label14.BackColor = global::System.Drawing.Color.Black;
			this.label14.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label14.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.ForeColor = global::System.Drawing.Color.Yellow;
			this.label14.Location = new global::System.Drawing.Point(713, -2);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(253, 37);
			this.label14.TabIndex = 16;
			this.label14.Text = "label14";
			this.label14.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label14.Click += new global::System.EventHandler(this.label14_Click);
			this.label18.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label18.BackColor = global::System.Drawing.Color.Black;
			this.label18.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.Color.Lime;
			this.label18.Location = new global::System.Drawing.Point(397, 7);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(116, 23);
			this.label18.TabIndex = 19;
			this.label18.Text = "FLASH COUNT :";
			this.label18.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.comboBox1.BackColor = global::System.Drawing.Color.Black;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBox1.ForeColor = global::System.Drawing.Color.White;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(8, 84);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(219, 25);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			this.TxtPartCode.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.TxtPartCode.BackColor = global::System.Drawing.Color.Black;
			this.TxtPartCode.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.TxtPartCode.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.TxtPartCode.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TxtPartCode.ForeColor = global::System.Drawing.Color.White;
			this.TxtPartCode.Location = new global::System.Drawing.Point(8, 33);
			this.TxtPartCode.Name = "TxtPartCode";
			this.TxtPartCode.Size = new global::System.Drawing.Size(219, 47);
			this.TxtPartCode.TabIndex = 14;
			this.TxtPartCode.Text = "ECM PART CODE";
			this.TxtPartCode.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label7.BackColor = global::System.Drawing.Color.Black;
			this.label7.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 39.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(6, 18);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(217, 54);
			this.label7.TabIndex = 14;
			this.label7.Text = "0";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label6.BackColor = global::System.Drawing.Color.Black;
			this.label6.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 39.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(6, 18);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(136, 54);
			this.label6.TabIndex = 13;
			this.label6.Text = "0";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label5.BackColor = global::System.Drawing.Color.Black;
			this.label5.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 39.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(6, 18);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(136, 54);
			this.label5.TabIndex = 13;
			this.label5.Text = "0";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label4.BackColor = global::System.Drawing.Color.Black;
			this.label4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 39.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(6, 18);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(136, 54);
			this.label4.TabIndex = 12;
			this.label4.Text = "0";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.saveFileDialog1.FileOk += new global::System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			this.label11.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label11.BackColor = global::System.Drawing.Color.Black;
			this.label11.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 39.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(6, 18);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(136, 54);
			this.label11.TabIndex = 19;
			this.label11.Text = "0";
			this.label11.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label8.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label8.BackColor = global::System.Drawing.Color.Black;
			this.label8.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 39.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(6, 18);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(136, 54);
			this.label8.TabIndex = 17;
			this.label8.Text = "0";
			this.label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.menuStrip7.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.diagnosticToolStripMenuItem,
				this.resetCountToolStripMenuItem,
				this.breakpointToolStripMenuItem1,
				this.toolStripMenuItem23,
				this.breakpointToolStripMenuItem2,
				this.fueToolStripMenuItem,
				this.ignitionToolStripMenuItem,
				this.limiterToolStripMenuItem,
				this.settinganLaiinToolStripMenuItem
			});
			this.menuStrip7.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip7.Name = "menuStrip7";
			this.menuStrip7.Size = new global::System.Drawing.Size(1280, 25);
			this.menuStrip7.TabIndex = 16;
			this.menuStrip7.Text = "menuStrip7";
			this.menuStrip7.ItemClicked += new global::System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip7_ItemClicked);
			this.fileToolStripMenuItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.openFileToolStripMenuItem,
				this.button9,
				this.saveAsToolStripMenuItem
			});
			this.fileToolStripMenuItem.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(57, 21);
			this.fileToolStripMenuItem.Text = "\ud83d\udcc1File";
			this.openFileToolStripMenuItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
			this.openFileToolStripMenuItem.Size = new global::System.Drawing.Size(146, 22);
			this.openFileToolStripMenuItem.Text = "\ud83d\udcc4 Open File";
			this.openFileToolStripMenuItem.Click += new global::System.EventHandler(this.button2_Click);
			this.button9.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(146, 22);
			this.button9.Text = "\ud83d\udcbe Save";
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.saveAsToolStripMenuItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new global::System.Drawing.Size(146, 22);
			this.saveAsToolStripMenuItem.Text = "\ud83d\udcbe Save As";
			this.saveAsToolStripMenuItem.Click += new global::System.EventHandler(this.button11_Click);
			this.diagnosticToolStripMenuItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.diagnosticToolStripMenuItem.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.diagnosticToolStripMenuItem.Name = "diagnosticToolStripMenuItem";
			this.diagnosticToolStripMenuItem.Size = new global::System.Drawing.Size(97, 21);
			this.diagnosticToolStripMenuItem.Text = "\ud83d\udcbbDiagnostic";
			this.diagnosticToolStripMenuItem.Click += new global::System.EventHandler(this.button7_Click);
			this.resetCountToolStripMenuItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.resetCountToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.keihinToolStripMenuItem,
				this.shindengenToolStripMenuItem
			});
			this.resetCountToolStripMenuItem.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.resetCountToolStripMenuItem.Name = "resetCountToolStripMenuItem";
			this.resetCountToolStripMenuItem.Size = new global::System.Drawing.Size(106, 21);
			this.resetCountToolStripMenuItem.Text = "\ud83d\udd04Reset Count";
			this.keihinToolStripMenuItem.Name = "keihinToolStripMenuItem";
			this.keihinToolStripMenuItem.Size = new global::System.Drawing.Size(142, 22);
			this.keihinToolStripMenuItem.Text = "keihin";
			this.shindengenToolStripMenuItem.Name = "shindengenToolStripMenuItem";
			this.shindengenToolStripMenuItem.Size = new global::System.Drawing.Size(142, 22);
			this.shindengenToolStripMenuItem.Text = "Shindengen";
			this.shindengenToolStripMenuItem.Click += new global::System.EventHandler(this.button5_Click);
			this.breakpointToolStripMenuItem1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.breakpointToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.readIDBarcodeToolStripMenuItem
			});
			this.breakpointToolStripMenuItem1.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.breakpointToolStripMenuItem1.Name = "breakpointToolStripMenuItem1";
			this.breakpointToolStripMenuItem1.Size = new global::System.Drawing.Size(61, 21);
			this.breakpointToolStripMenuItem1.Text = "\ud83d\udee0️Tool";
			this.breakpointToolStripMenuItem1.Click += new global::System.EventHandler(this.breakpointToolStripMenuItem1_Click);
			this.readIDBarcodeToolStripMenuItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.readIDBarcodeToolStripMenuItem.Name = "readIDBarcodeToolStripMenuItem";
			this.readIDBarcodeToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.readIDBarcodeToolStripMenuItem.Text = "\ud83d\udd11 Read ID Barcode";
			this.readIDBarcodeToolStripMenuItem.Click += new global::System.EventHandler(this.readIDBarcodeToolStripMenuItem_Click);
			this.toolStripMenuItem23.Name = "toolStripMenuItem23";
			this.toolStripMenuItem23.Size = new global::System.Drawing.Size(55, 21);
			this.toolStripMenuItem23.Text = "➤➤➤";
			this.breakpointToolStripMenuItem2.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.breakpoinRPMToolStripMenuItem,
				this.breakpointTPSToolStripMenuItem,
				this.breakpointIAPToolStripMenuItem
			});
			this.breakpointToolStripMenuItem2.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.breakpointToolStripMenuItem2.Name = "breakpointToolStripMenuItem2";
			this.breakpointToolStripMenuItem2.Size = new global::System.Drawing.Size(99, 21);
			this.breakpointToolStripMenuItem2.Text = "\ud83d\uded1Breakpoint";
			this.breakpoinRPMToolStripMenuItem.Name = "breakpoinRPMToolStripMenuItem";
			this.breakpoinRPMToolStripMenuItem.Size = new global::System.Drawing.Size(102, 22);
			this.breakpoinRPMToolStripMenuItem.Text = "RPM";
			this.breakpoinRPMToolStripMenuItem.Click += new global::System.EventHandler(this.breakpoinRPMToolStripMenuItem_Click_1);
			this.breakpointTPSToolStripMenuItem.Name = "breakpointTPSToolStripMenuItem";
			this.breakpointTPSToolStripMenuItem.Size = new global::System.Drawing.Size(102, 22);
			this.breakpointTPSToolStripMenuItem.Text = "TPS";
			this.breakpointTPSToolStripMenuItem.Click += new global::System.EventHandler(this.breakpointTPSToolStripMenuItem_Click_1);
			this.breakpointIAPToolStripMenuItem.Name = "breakpointIAPToolStripMenuItem";
			this.breakpointIAPToolStripMenuItem.Size = new global::System.Drawing.Size(102, 22);
			this.breakpointIAPToolStripMenuItem.Text = "IAP";
			this.breakpointIAPToolStripMenuItem.Click += new global::System.EventHandler(this.breakpointIAPToolStripMenuItem_Click_1);
			this.fueToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.rpmVsTps1ToolStripMenuItem,
				this.rpmVsTps2ToolStripMenuItem,
				this.rpmVsToolStripMenuItem,
				this.rpmVsIAPToolStripMenuItem
			});
			this.fueToolStripMenuItem.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.fueToolStripMenuItem.Name = "fueToolStripMenuItem";
			this.fueToolStripMenuItem.Size = new global::System.Drawing.Size(58, 21);
			this.fueToolStripMenuItem.Text = "⛽Fuel";
			this.rpmVsTps1ToolStripMenuItem.Name = "rpmVsTps1ToolStripMenuItem";
			this.rpmVsTps1ToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.rpmVsTps1ToolStripMenuItem.Text = "RPM vs TPS 1";
			this.rpmVsTps1ToolStripMenuItem.Click += new global::System.EventHandler(this.rpmVsTps1ToolStripMenuItem_Click);
			this.rpmVsTps2ToolStripMenuItem.Name = "rpmVsTps2ToolStripMenuItem";
			this.rpmVsTps2ToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.rpmVsTps2ToolStripMenuItem.Text = "RPM vs TPS 2";
			this.rpmVsTps2ToolStripMenuItem.Click += new global::System.EventHandler(this.rpmVsTps2ToolStripMenuItem_Click);
			this.rpmVsToolStripMenuItem.Name = "rpmVsToolStripMenuItem";
			this.rpmVsToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.rpmVsToolStripMenuItem.Text = "RPM vs TPS 3";
			this.rpmVsToolStripMenuItem.Click += new global::System.EventHandler(this.rpmVsToolStripMenuItem_Click);
			this.rpmVsIAPToolStripMenuItem.Name = "rpmVsIAPToolStripMenuItem";
			this.rpmVsIAPToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.rpmVsIAPToolStripMenuItem.Text = "RPM vs IAP";
			this.rpmVsIAPToolStripMenuItem.Click += new global::System.EventHandler(this.rpmVsIAPToolStripMenuItem_Click);
			this.ignitionToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem6,
				this.toolStripMenuItem7,
				this.toolStripMenuItem8,
				this.ignition4ToolStripMenuItem,
				this.ignition5ToolStripMenuItem
			});
			this.ignitionToolStripMenuItem.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ignitionToolStripMenuItem.Name = "ignitionToolStripMenuItem";
			this.ignitionToolStripMenuItem.Size = new global::System.Drawing.Size(78, 21);
			this.ignitionToolStripMenuItem.Text = "⚡Ignition";
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new global::System.Drawing.Size(128, 22);
			this.toolStripMenuItem6.Text = "Ignition 1";
			this.toolStripMenuItem6.Click += new global::System.EventHandler(this.toolStripMenuItem6_Click);
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new global::System.Drawing.Size(128, 22);
			this.toolStripMenuItem7.Text = "Ignition 2";
			this.toolStripMenuItem7.Click += new global::System.EventHandler(this.toolStripMenuItem7_Click);
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new global::System.Drawing.Size(128, 22);
			this.toolStripMenuItem8.Text = "Ignition 3";
			this.toolStripMenuItem8.Click += new global::System.EventHandler(this.toolStripMenuItem8_Click);
			this.ignition4ToolStripMenuItem.Name = "ignition4ToolStripMenuItem";
			this.ignition4ToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.ignition4ToolStripMenuItem.Text = "Ignition 4";
			this.ignition4ToolStripMenuItem.Click += new global::System.EventHandler(this.ignition4ToolStripMenuItem_Click);
			this.ignition5ToolStripMenuItem.Name = "ignition5ToolStripMenuItem";
			this.ignition5ToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.ignition5ToolStripMenuItem.Text = "Ignition 5";
			this.ignition5ToolStripMenuItem.Click += new global::System.EventHandler(this.ignition5ToolStripMenuItem_Click);
			this.limiterToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem10,
				this.toolStripMenuItem11,
				this.toolStripMenuItem12,
				this.toolStripMenuItem13,
				this.toolStripMenuItem14,
				this.limiter6ToolStripMenuItem,
				this.limiter7ToolStripMenuItem
			});
			this.limiterToolStripMenuItem.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.limiterToolStripMenuItem.Name = "limiterToolStripMenuItem";
			this.limiterToolStripMenuItem.Size = new global::System.Drawing.Size(75, 21);
			this.limiterToolStripMenuItem.Text = "\ud83d\udcc9Limiter";
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new global::System.Drawing.Size(125, 22);
			this.toolStripMenuItem10.Text = "Limiter 1";
			this.toolStripMenuItem10.Click += new global::System.EventHandler(this.toolStripMenuItem10_Click);
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new global::System.Drawing.Size(125, 22);
			this.toolStripMenuItem11.Text = "Limiter 2";
			this.toolStripMenuItem11.Click += new global::System.EventHandler(this.toolStripMenuItem11_Click);
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new global::System.Drawing.Size(125, 22);
			this.toolStripMenuItem12.Text = "Limiter 3";
			this.toolStripMenuItem12.Click += new global::System.EventHandler(this.toolStripMenuItem12_Click);
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new global::System.Drawing.Size(125, 22);
			this.toolStripMenuItem13.Text = "Limiter 4";
			this.toolStripMenuItem13.Click += new global::System.EventHandler(this.toolStripMenuItem13_Click);
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new global::System.Drawing.Size(125, 22);
			this.toolStripMenuItem14.Text = "Limiter 5";
			this.toolStripMenuItem14.Click += new global::System.EventHandler(this.toolStripMenuItem14_Click);
			this.limiter6ToolStripMenuItem.Name = "limiter6ToolStripMenuItem";
			this.limiter6ToolStripMenuItem.Size = new global::System.Drawing.Size(125, 22);
			this.limiter6ToolStripMenuItem.Text = "Limiter 6";
			this.limiter6ToolStripMenuItem.Click += new global::System.EventHandler(this.limiter6ToolStripMenuItem_Click);
			this.limiter7ToolStripMenuItem.Name = "limiter7ToolStripMenuItem";
			this.limiter7ToolStripMenuItem.Size = new global::System.Drawing.Size(125, 22);
			this.limiter7ToolStripMenuItem.Text = "Limiter 7";
			this.limiter7ToolStripMenuItem.Click += new global::System.EventHandler(this.limiter7ToolStripMenuItem_Click);
			this.settinganLaiinToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem16,
				this.toolStripMenuItem17,
				this.toolStripMenuItem18,
				this.toolStripMenuItem19,
				this.toolStripMenuItem20,
				this.toolStripMenuItem21,
				this.toolStripMenuItem22,
				this.offMode4ToolStripMenuItem,
				this.offBASSensorToolStripMenuItem,
				this.offMAPSensorToolStripMenuItem,
				this.offECTSensorToolStripMenuItem,
				this.offIATSensorToolStripMenuItem,
				this.offVSSSensorToolStripMenuItem,
				this.offMAPSensorToolStripMenuItem1
			});
			this.settinganLaiinToolStripMenuItem.Font = new global::System.Drawing.Font("Franklin Gothic Medium", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.settinganLaiinToolStripMenuItem.Name = "settinganLaiinToolStripMenuItem";
			this.settinganLaiinToolStripMenuItem.Size = new global::System.Drawing.Size(117, 21);
			this.settinganLaiinToolStripMenuItem.Text = "⚙️Settingan Lain";
			this.toolStripMenuItem16.Name = "toolStripMenuItem16";
			this.toolStripMenuItem16.Size = new global::System.Drawing.Size(192, 22);
			this.toolStripMenuItem16.Text = "OFF IMMO";
			this.toolStripMenuItem16.Click += new global::System.EventHandler(this.toolStripMenuItem16_Click);
			this.toolStripMenuItem17.Name = "toolStripMenuItem17";
			this.toolStripMenuItem17.Size = new global::System.Drawing.Size(192, 22);
			this.toolStripMenuItem17.Text = "OFF DTC O2";
			this.toolStripMenuItem17.Click += new global::System.EventHandler(this.toolStripMenuItem17_Click);
			this.toolStripMenuItem18.Name = "toolStripMenuItem18";
			this.toolStripMenuItem18.Size = new global::System.Drawing.Size(192, 22);
			this.toolStripMenuItem18.Text = "OFF O2 CORRECTION";
			this.toolStripMenuItem18.Click += new global::System.EventHandler(this.toolStripMenuItem18_Click);
			this.toolStripMenuItem19.Name = "toolStripMenuItem19";
			this.toolStripMenuItem19.Size = new global::System.Drawing.Size(192, 22);
			this.toolStripMenuItem19.Text = "OFF MODE 0";
			this.toolStripMenuItem19.Click += new global::System.EventHandler(this.toolStripMenuItem19_Click);
			this.toolStripMenuItem20.Name = "toolStripMenuItem20";
			this.toolStripMenuItem20.Size = new global::System.Drawing.Size(192, 22);
			this.toolStripMenuItem20.Text = "OFF MODE 1";
			this.toolStripMenuItem20.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
			this.toolStripMenuItem21.Name = "toolStripMenuItem21";
			this.toolStripMenuItem21.Size = new global::System.Drawing.Size(192, 22);
			this.toolStripMenuItem21.Text = "OFF MODE 2";
			this.toolStripMenuItem21.Click += new global::System.EventHandler(this.toolStripMenuItem21_Click);
			this.toolStripMenuItem22.Name = "toolStripMenuItem22";
			this.toolStripMenuItem22.Size = new global::System.Drawing.Size(192, 22);
			this.toolStripMenuItem22.Text = "OFF MODE 3";
			this.toolStripMenuItem22.Click += new global::System.EventHandler(this.toolStripMenuItem22_Click);
			this.offMode4ToolStripMenuItem.Name = "offMode4ToolStripMenuItem";
			this.offMode4ToolStripMenuItem.Size = new global::System.Drawing.Size(192, 22);
			this.offMode4ToolStripMenuItem.Text = "OFF MODE 4";
			this.offMode4ToolStripMenuItem.Click += new global::System.EventHandler(this.offMode4ToolStripMenuItem_Click);
			this.offBASSensorToolStripMenuItem.Name = "offBASSensorToolStripMenuItem";
			this.offBASSensorToolStripMenuItem.Size = new global::System.Drawing.Size(192, 22);
			this.offBASSensorToolStripMenuItem.Text = "OFF BAS SENSOR";
			this.offBASSensorToolStripMenuItem.Click += new global::System.EventHandler(this.offBASSensorToolStripMenuItem_Click);
			this.offMAPSensorToolStripMenuItem.Name = "offMAPSensorToolStripMenuItem";
			this.offMAPSensorToolStripMenuItem.Size = new global::System.Drawing.Size(192, 22);
			this.offMAPSensorToolStripMenuItem.Text = "OFF IACV SENSOR";
			this.offMAPSensorToolStripMenuItem.Click += new global::System.EventHandler(this.offMAPSensorToolStripMenuItem_Click);
			this.offECTSensorToolStripMenuItem.Name = "offECTSensorToolStripMenuItem";
			this.offECTSensorToolStripMenuItem.Size = new global::System.Drawing.Size(192, 22);
			this.offECTSensorToolStripMenuItem.Text = "OFF ECT SENSOR";
			this.offECTSensorToolStripMenuItem.Click += new global::System.EventHandler(this.offECTSensorToolStripMenuItem_Click);
			this.offIATSensorToolStripMenuItem.Name = "offIATSensorToolStripMenuItem";
			this.offIATSensorToolStripMenuItem.Size = new global::System.Drawing.Size(192, 22);
			this.offIATSensorToolStripMenuItem.Text = "OFF IAT SENSOR";
			this.offIATSensorToolStripMenuItem.Click += new global::System.EventHandler(this.offIATSensorToolStripMenuItem_Click);
			this.offVSSSensorToolStripMenuItem.Name = "offVSSSensorToolStripMenuItem";
			this.offVSSSensorToolStripMenuItem.Size = new global::System.Drawing.Size(192, 22);
			this.offVSSSensorToolStripMenuItem.Text = "OFF VSS SENSOR";
			this.offVSSSensorToolStripMenuItem.Click += new global::System.EventHandler(this.offVSSSensorToolStripMenuItem_Click);
			this.offMAPSensorToolStripMenuItem1.Name = "offMAPSensorToolStripMenuItem1";
			this.offMAPSensorToolStripMenuItem1.Size = new global::System.Drawing.Size(192, 22);
			this.offMAPSensorToolStripMenuItem1.Text = "OFF MAP SENSOR";
			this.offMAPSensorToolStripMenuItem1.Click += new global::System.EventHandler(this.offMAPSensorToolStripMenuItem1_Click);
			this.comboBox2.BackColor = global::System.Drawing.Color.Black;
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBox2.ForeColor = global::System.Drawing.Color.Cyan;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new global::System.Drawing.Point(67, 9);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(98, 23);
			this.comboBox2.TabIndex = 17;
			this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.groupBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox1.Location = new global::System.Drawing.Point(233, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(229, 81);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "RPM";
			this.groupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox2.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox2.Location = new global::System.Drawing.Point(475, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(148, 81);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "TPS";
			this.groupBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox3.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox3.Location = new global::System.Drawing.Point(637, 27);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(148, 81);
			this.groupBox3.TabIndex = 19;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "INJECTOR";
			this.groupBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox4.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox4.Location = new global::System.Drawing.Point(799, 27);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(148, 81);
			this.groupBox4.TabIndex = 19;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "IGNITION";
			this.groupBox5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox5.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox5.Location = new global::System.Drawing.Point(961, 27);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(148, 81);
			this.groupBox5.TabIndex = 19;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "SUHU MESIN";
			this.groupBox6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox6.Controls.Add(this.label11);
			this.groupBox6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox6.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox6.Location = new global::System.Drawing.Point(1123, 27);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(148, 81);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "HP";
			this.label15.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label15.AutoSize = true;
			this.label15.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.ForeColor = global::System.Drawing.Color.White;
			this.label15.Location = new global::System.Drawing.Point(1080, 109);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(76, 15);
			this.label15.TabIndex = 21;
			this.label15.Text = "Start Offset";
			this.label16.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.ForeColor = global::System.Drawing.Color.White;
			this.label16.Location = new global::System.Drawing.Point(1177, 109);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(94, 15);
			this.label16.TabIndex = 22;
			this.label16.Text = "Ceksum Offset";
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(4, 127);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(42, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "File";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label19.Font = new global::System.Drawing.Font("Segoe UI Black", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.ForeColor = global::System.Drawing.Color.White;
			this.label19.Location = new global::System.Drawing.Point(6, 14);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(55, 19);
			this.label19.TabIndex = 23;
			this.label19.Text = "Function :";
			this.label19.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label20.Font = new global::System.Drawing.Font("Segoe UI Black", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label20.ForeColor = global::System.Drawing.Color.White;
			this.label20.Location = new global::System.Drawing.Point(171, 12);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(58, 19);
			this.label20.TabIndex = 24;
			this.label20.Text = "Value :";
			this.label20.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupBox7.Controls.Add(this.button2);
			this.groupBox7.Controls.Add(this.label19);
			this.groupBox7.Controls.Add(this.label20);
			this.groupBox7.Controls.Add(this.txtInput);
			this.groupBox7.Controls.Add(this.comboBox2);
			this.groupBox7.Location = new global::System.Drawing.Point(188, 114);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(380, 37);
			this.groupBox7.TabIndex = 20;
			this.groupBox7.TabStop = false;
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			this.pictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(1109, 637);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(162, 37);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label2.BackColor = global::System.Drawing.Color.Yellow;
			this.label2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(1309, 148);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(98, 44);
			this.label2.TabIndex = 16;
			this.label2.Text = "AFR";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label9.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label9.BackColor = global::System.Drawing.Color.Yellow;
			this.label9.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(1290, 180);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(98, 41);
			this.label9.TabIndex = 18;
			this.label9.Text = "Idc";
			this.label9.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label10.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label10.BackColor = global::System.Drawing.Color.Yellow;
			this.label10.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(1271, 159);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(93, 44);
			this.label10.TabIndex = 17;
			this.label10.Text = "Load %";
			this.label10.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.button4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(1341, 369);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(81, 23);
			this.button4.TabIndex = 13;
			this.button4.Text = "Undo";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click_1);
			this.button6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button6.Location = new global::System.Drawing.Point(1451, 369);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(76, 23);
			this.button6.TabIndex = 14;
			this.button6.Text = "Redo";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.textBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.textBox1.Location = new global::System.Drawing.Point(1342, 343);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(61, 20);
			this.textBox1.TabIndex = 16;
			this.textBox1.Text = "BORE";
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.textBox2.Location = new global::System.Drawing.Point(1428, 343);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(61, 20);
			this.textBox2.TabIndex = 17;
			this.textBox2.Text = "STROKE";
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label12.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label12.BackColor = global::System.Drawing.Color.White;
			this.label12.Location = new global::System.Drawing.Point(1409, 343);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(13, 20);
			this.label12.TabIndex = 18;
			this.label12.Text = "X";
			this.label12.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label13.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label13.BackColor = global::System.Drawing.Color.Silver;
			this.label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.Color.Black;
			this.label13.Location = new global::System.Drawing.Point(1342, 316);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(185, 23);
			this.label13.TabIndex = 3;
			this.label13.Text = "Volume Silinder (CC)";
			this.label13.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.button10.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button10.Location = new global::System.Drawing.Point(1472, 342);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(31, 20);
			this.button10.TabIndex = 19;
			this.button10.Text = "Ok";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.panelDATA.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelDATA.BackColor = global::System.Drawing.Color.Black;
			this.panelDATA.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelDATA.BackgroundImage");
			this.panelDATA.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelDATA.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelDATA.Controls.Add(this.button10);
			this.panelDATA.Controls.Add(this.label13);
			this.panelDATA.Controls.Add(this.label12);
			this.panelDATA.Controls.Add(this.textBox2);
			this.panelDATA.Controls.Add(this.textBox1);
			this.panelDATA.Controls.Add(this.button6);
			this.panelDATA.Controls.Add(this.button4);
			this.panelDATA.Controls.Add(this.label10);
			this.panelDATA.Controls.Add(this.label9);
			this.panelDATA.Controls.Add(this.label2);
			this.panelDATA.Font = new global::System.Drawing.Font("Lucida Console", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panelDATA.ForeColor = global::System.Drawing.Color.Black;
			this.panelDATA.Location = new global::System.Drawing.Point(8, 157);
			this.panelDATA.Name = "panelDATA";
			this.panelDATA.Size = new global::System.Drawing.Size(1263, 476);
			this.panelDATA.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1280, 683);
			base.Controls.Add(this.groupBox7);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.CbFastWrite);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.button12);
			base.Controls.Add(this.groupBox6);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.groupBox5);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.TbStartOffset);
			base.Controls.Add(this.TbFileName);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.TbChecksumOffset);
			base.Controls.Add(this.panelDATA);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.menuStrip7);
			base.Controls.Add(this.show_all);
			base.Controls.Add(this.BtnWrite);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.TxtPartCode);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ecu TuneX";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.panel4.ResumeLayout(false);
			this.menuStrip7.ResumeLayout(false);
			this.menuStrip7.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panelDATA.ResumeLayout(false);
			this.panelDATA.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400016D RID: 365
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.Button show_all;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.ProgressBar PbProgress;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.Button BtnWrite;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.Label TxtConnStat;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.Label TxtPartCode;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.TextBox TbStartOffset;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.TextBox TbChecksumOffset;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.TextBox TbFileName;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.Label TxtFlashCount;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.CheckBox CbFastWrite;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.Button button12;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.Forms.MenuStrip menuStrip7;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.ToolStripMenuItem diagnosticToolStripMenuItem;

		// Token: 0x0400018B RID: 395
		private global::System.Windows.Forms.ToolStripMenuItem resetCountToolStripMenuItem;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.ToolStripMenuItem breakpointToolStripMenuItem1;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.ToolStripMenuItem breakpointToolStripMenuItem2;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.ToolStripMenuItem fueToolStripMenuItem;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.ToolStripMenuItem ignitionToolStripMenuItem;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.ToolStripMenuItem limiterToolStripMenuItem;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.ToolStripMenuItem settinganLaiinToolStripMenuItem;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.ToolStripMenuItem breakpoinRPMToolStripMenuItem;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Forms.ToolStripMenuItem breakpointTPSToolStripMenuItem;

		// Token: 0x04000195 RID: 405
		private global::System.Windows.Forms.ToolStripMenuItem breakpointIAPToolStripMenuItem;

		// Token: 0x04000196 RID: 406
		private global::System.Windows.Forms.ToolStripMenuItem rpmVsTps1ToolStripMenuItem;

		// Token: 0x04000197 RID: 407
		private global::System.Windows.Forms.ToolStripMenuItem rpmVsTps2ToolStripMenuItem;

		// Token: 0x04000198 RID: 408
		private global::System.Windows.Forms.ToolStripMenuItem rpmVsToolStripMenuItem;

		// Token: 0x04000199 RID: 409
		private global::System.Windows.Forms.ToolStripMenuItem rpmVsIAPToolStripMenuItem;

		// Token: 0x0400019A RID: 410
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

		// Token: 0x0400019B RID: 411
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;

		// Token: 0x0400019C RID: 412
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;

		// Token: 0x0400019D RID: 413
		private global::System.Windows.Forms.ToolStripMenuItem ignition4ToolStripMenuItem;

		// Token: 0x0400019E RID: 414
		private global::System.Windows.Forms.ToolStripMenuItem ignition5ToolStripMenuItem;

		// Token: 0x0400019F RID: 415
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;

		// Token: 0x040001A0 RID: 416
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;

		// Token: 0x040001A1 RID: 417
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;

		// Token: 0x040001A2 RID: 418
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;

		// Token: 0x040001A4 RID: 420
		private global::System.Windows.Forms.ToolStripMenuItem limiter6ToolStripMenuItem;

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.Forms.ToolStripMenuItem limiter7ToolStripMenuItem;

		// Token: 0x040001A6 RID: 422
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;

		// Token: 0x040001A7 RID: 423
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;

		// Token: 0x040001A8 RID: 424
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;

		// Token: 0x040001A9 RID: 425
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;

		// Token: 0x040001AA RID: 426
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;

		// Token: 0x040001AB RID: 427
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;

		// Token: 0x040001AD RID: 429
		private global::System.Windows.Forms.ToolStripMenuItem offMode4ToolStripMenuItem;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.ToolStripMenuItem offBASSensorToolStripMenuItem;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.ToolStripMenuItem offMAPSensorToolStripMenuItem;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.ToolStripMenuItem offECTSensorToolStripMenuItem;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.ToolStripMenuItem offIATSensorToolStripMenuItem;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.ToolStripMenuItem offVSSSensorToolStripMenuItem;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.ToolStripMenuItem offMAPSensorToolStripMenuItem1;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x040001BA RID: 442
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.ToolStripMenuItem button9;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Forms.Label TxtEcmId;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Forms.ToolStripMenuItem keihinToolStripMenuItem;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.ToolStripMenuItem shindengenToolStripMenuItem;

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040001C3 RID: 451
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040001C4 RID: 452
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040001C5 RID: 453
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040001C6 RID: 454
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001C7 RID: 455
		private global::System.Windows.Forms.Label TxtPb;

		// Token: 0x040001C8 RID: 456
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001C9 RID: 457
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040001CA RID: 458
		private global::System.Windows.Forms.ToolStripMenuItem readIDBarcodeToolStripMenuItem;

		// Token: 0x040001CB RID: 459
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040001CC RID: 460
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.Forms.TextBox txtInput;

		// Token: 0x040001CE RID: 462
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040001D0 RID: 464
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001D3 RID: 467
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040001D5 RID: 469
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040001D6 RID: 470
		private global::System.Windows.Forms.Button button6;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040001DA RID: 474
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040001DB RID: 475
		private global::System.Windows.Forms.Button button10;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Forms.Panel panelDATA;
	}
}
