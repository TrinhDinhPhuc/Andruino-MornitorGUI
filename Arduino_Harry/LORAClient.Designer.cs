namespace Arduino_Harry
{
    partial class LORAClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LORAClient));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chBoxRTSEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDTREnable = new System.Windows.Forms.CheckBox();
            this.cBoxParityBit = new System.Windows.Forms.ComboBox();
            this.cBoxStopBit = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnCLOSE = new DevExpress.XtraEditors.SimpleButton();
            this.btnOPEN = new DevExpress.XtraEditors.SimpleButton();
            this.tBoxDataOUT = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.lblDataOUTLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCleanDATA = new DevExpress.XtraEditors.SimpleButton();
            this.bntSENDDATA = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.chBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearDataIN = new DevExpress.XtraEditors.SimpleButton();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.btnRESET = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.btnRESET);
            this.groupControl1.Controls.Add(this.chBoxRTSEnable);
            this.groupControl1.Controls.Add(this.chBoxDTREnable);
            this.groupControl1.Controls.Add(this.cBoxParityBit);
            this.groupControl1.Controls.Add(this.cBoxStopBit);
            this.groupControl1.Controls.Add(this.cBoxDataBits);
            this.groupControl1.Controls.Add(this.cBoxBaudRate);
            this.groupControl1.Controls.Add(this.cBoxCOMPORT);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(35, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(322, 285);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "OPTIONS";
            // 
            // chBoxRTSEnable
            // 
            this.chBoxRTSEnable.AutoSize = true;
            this.chBoxRTSEnable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxRTSEnable.ForeColor = System.Drawing.Color.Olive;
            this.chBoxRTSEnable.Location = new System.Drawing.Point(181, 216);
            this.chBoxRTSEnable.Name = "chBoxRTSEnable";
            this.chBoxRTSEnable.Size = new System.Drawing.Size(97, 20);
            this.chBoxRTSEnable.TabIndex = 11;
            this.chBoxRTSEnable.Text = "RTS Enable";
            this.chBoxRTSEnable.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_CheckedChanged);
            // 
            // chBoxDTREnable
            // 
            this.chBoxDTREnable.AutoSize = true;
            this.chBoxDTREnable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxDTREnable.ForeColor = System.Drawing.Color.Olive;
            this.chBoxDTREnable.Location = new System.Drawing.Point(54, 216);
            this.chBoxDTREnable.Name = "chBoxDTREnable";
            this.chBoxDTREnable.Size = new System.Drawing.Size(98, 20);
            this.chBoxDTREnable.TabIndex = 10;
            this.chBoxDTREnable.Text = "DRT Enable";
            this.chBoxDTREnable.UseVisualStyleBackColor = true;
            this.chBoxDTREnable.CheckedChanged += new System.EventHandler(this.chBoxDTREnable_CheckedChanged);
            // 
            // cBoxParityBit
            // 
            this.cBoxParityBit.FormattingEnabled = true;
            this.cBoxParityBit.Items.AddRange(new object[] {
            "None"});
            this.cBoxParityBit.Location = new System.Drawing.Point(96, 179);
            this.cBoxParityBit.Name = "cBoxParityBit";
            this.cBoxParityBit.Size = new System.Drawing.Size(166, 21);
            this.cBoxParityBit.TabIndex = 9;
            // 
            // cBoxStopBit
            // 
            this.cBoxStopBit.FormattingEnabled = true;
            this.cBoxStopBit.Items.AddRange(new object[] {
            "One"});
            this.cBoxStopBit.Location = new System.Drawing.Point(96, 143);
            this.cBoxStopBit.Name = "cBoxStopBit";
            this.cBoxStopBit.Size = new System.Drawing.Size(166, 21);
            this.cBoxStopBit.TabIndex = 8;
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "8",
            "16",
            "32"});
            this.cBoxDataBits.Location = new System.Drawing.Point(96, 105);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(166, 21);
            this.cBoxDataBits.TabIndex = 7;
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(96, 69);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(166, 21);
            this.cBoxBaudRate.TabIndex = 6;
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(96, 36);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(166, 21);
            this.cBoxCOMPORT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PARITY BIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "STOP BIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupBox1);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Location = new System.Drawing.Point(35, 312);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(322, 137);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "MENU CONTROL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatusCom);
            this.groupBox1.Location = new System.Drawing.Point(206, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT STATUS";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStatusCom.Location = new System.Drawing.Point(37, 47);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(35, 17);
            this.lblStatusCom.TabIndex = 4;
            this.lblStatusCom.Text = "OFF";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.progressBarControl1);
            this.groupControl3.Controls.Add(this.btnCLOSE);
            this.groupControl3.Controls.Add(this.btnOPEN);
            this.groupControl3.Location = new System.Drawing.Point(5, 18);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 100);
            this.groupControl3.TabIndex = 2;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(6, 70);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(189, 18);
            this.progressBarControl1.TabIndex = 5;
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(102, 32);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(75, 23);
            this.btnCLOSE.TabIndex = 4;
            this.btnCLOSE.Text = "CLOSE";
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // btnOPEN
            // 
            this.btnOPEN.Location = new System.Drawing.Point(21, 32);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(75, 23);
            this.btnOPEN.TabIndex = 3;
            this.btnOPEN.Text = "OPEN";
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // tBoxDataOUT
            // 
            this.tBoxDataOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tBoxDataOUT.Location = new System.Drawing.Point(14, 23);
            this.tBoxDataOUT.Multiline = true;
            this.tBoxDataOUT.Name = "tBoxDataOUT";
            this.tBoxDataOUT.Size = new System.Drawing.Size(397, 259);
            this.tBoxDataOUT.TabIndex = 2;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.chBoxWrite);
            this.groupControl4.Controls.Add(this.chBoxWriteLine);
            this.groupControl4.Controls.Add(this.lblDataOUTLength);
            this.groupControl4.Controls.Add(this.label6);
            this.groupControl4.Controls.Add(this.btnCleanDATA);
            this.groupControl4.Controls.Add(this.bntSENDDATA);
            this.groupControl4.Location = new System.Drawing.Point(14, 291);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(397, 121);
            this.groupControl4.TabIndex = 12;
            this.groupControl4.Text = "Menu Control";
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chBoxWrite.Location = new System.Drawing.Point(276, 36);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(56, 18);
            this.chBoxWrite.TabIndex = 24;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chBoxWriteLine.Location = new System.Drawing.Point(175, 36);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(78, 18);
            this.chBoxWriteLine.TabIndex = 23;
            this.chBoxWriteLine.Text = "WriteLine";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // lblDataOUTLength
            // 
            this.lblDataOUTLength.AutoSize = true;
            this.lblDataOUTLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOUTLength.Location = new System.Drawing.Point(308, 83);
            this.lblDataOUTLength.Name = "lblDataOUTLength";
            this.lblDataOUTLength.Size = new System.Drawing.Size(24, 16);
            this.lblDataOUTLength.TabIndex = 22;
            this.lblDataOUTLength.Text = "00";
            this.lblDataOUTLength.TextChanged += new System.EventHandler(this.lblDataOUTLength_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data OUT length :";
            // 
            // btnCleanDATA
            // 
            this.btnCleanDATA.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanDATA.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCleanDATA.Appearance.Options.UseFont = true;
            this.btnCleanDATA.Appearance.Options.UseForeColor = true;
            this.btnCleanDATA.Location = new System.Drawing.Point(36, 75);
            this.btnCleanDATA.Name = "btnCleanDATA";
            this.btnCleanDATA.Size = new System.Drawing.Size(112, 31);
            this.btnCleanDATA.TabIndex = 20;
            this.btnCleanDATA.Text = "Clean Data Out";
            this.btnCleanDATA.Click += new System.EventHandler(this.btnCleanDATA_Click);
            // 
            // bntSENDDATA
            // 
            this.bntSENDDATA.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSENDDATA.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.bntSENDDATA.Appearance.Options.UseFont = true;
            this.bntSENDDATA.Appearance.Options.UseForeColor = true;
            this.bntSENDDATA.Location = new System.Drawing.Point(47, 28);
            this.bntSENDDATA.Name = "bntSENDDATA";
            this.bntSENDDATA.Size = new System.Drawing.Size(91, 31);
            this.bntSENDDATA.TabIndex = 19;
            this.bntSENDDATA.Text = "SEND DATA";
            this.bntSENDDATA.Click += new System.EventHandler(this.bntSENDDATA_Click_1);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.chBoxAddToOldData);
            this.groupControl5.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupControl5.Controls.Add(this.lblDataInLength);
            this.groupControl5.Controls.Add(this.label8);
            this.groupControl5.Controls.Add(this.btnClearDataIN);
            this.groupControl5.Location = new System.Drawing.Point(19, 286);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(404, 126);
            this.groupControl5.TabIndex = 13;
            this.groupControl5.Text = "Menu Control";
            // 
            // chBoxAddToOldData
            // 
            this.chBoxAddToOldData.AutoSize = true;
            this.chBoxAddToOldData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chBoxAddToOldData.Location = new System.Drawing.Point(275, 36);
            this.chBoxAddToOldData.Name = "chBoxAddToOldData";
            this.chBoxAddToOldData.Size = new System.Drawing.Size(118, 18);
            this.chBoxAddToOldData.TabIndex = 24;
            this.chBoxAddToOldData.Text = "Add To Old Data";
            this.chBoxAddToOldData.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData_CheckedChanged);
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(162, 36);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(107, 18);
            this.chBoxAlwaysUpdate.TabIndex = 23;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInLength.Location = new System.Drawing.Point(308, 83);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(24, 16);
            this.lblDataInLength.TabIndex = 22;
            this.lblDataInLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data IN length :";
            // 
            // btnClearDataIN
            // 
            this.btnClearDataIN.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDataIN.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClearDataIN.Appearance.Options.UseFont = true;
            this.btnClearDataIN.Appearance.Options.UseForeColor = true;
            this.btnClearDataIN.Location = new System.Drawing.Point(39, 28);
            this.btnClearDataIN.Name = "btnClearDataIN";
            this.btnClearDataIN.Size = new System.Drawing.Size(97, 76);
            this.btnClearDataIN.TabIndex = 19;
            this.btnClearDataIN.Text = "Clear Data In";
            this.btnClearDataIN.Click += new System.EventHandler(this.btnClearDataIN_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tBoxDataIN.Location = new System.Drawing.Point(5, 23);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(418, 257);
            this.tBoxDataIN.TabIndex = 14;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.tBoxDataIN);
            this.groupControl6.Controls.Add(this.groupControl5);
            this.groupControl6.Location = new System.Drawing.Point(809, 21);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(436, 428);
            this.groupControl6.TabIndex = 15;
            this.groupControl6.Text = "RECEIVER";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.tBoxDataOUT);
            this.groupControl7.Controls.Add(this.groupControl4);
            this.groupControl7.Location = new System.Drawing.Point(370, 21);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(421, 428);
            this.groupControl7.TabIndex = 16;
            this.groupControl7.Text = "SENDER";
            // 
            // btnRESET
            // 
            this.btnRESET.Location = new System.Drawing.Point(125, 242);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(75, 23);
            this.btnRESET.TabIndex = 5;
            this.btnRESET.Text = "RESET";
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // LORAClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1258, 472);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "LORAClient";
            this.Text = "LORAClient";
            this.Load += new System.EventHandler(this.LORAClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cBoxParityBit;
        private System.Windows.Forms.ComboBox cBoxStopBit;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnCLOSE;
        private DevExpress.XtraEditors.SimpleButton btnOPEN;
        private System.Windows.Forms.TextBox tBoxDataOUT;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxRTSEnable;
        private System.Windows.Forms.CheckBox chBoxDTREnable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatusCom;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Label lblDataOUTLength;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnCleanDATA;
        private DevExpress.XtraEditors.SimpleButton bntSENDDATA;
        private System.Windows.Forms.CheckBox chBoxWrite;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.CheckBox chBoxAddToOldData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnClearDataIN;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.SimpleButton btnRESET;
    }
}