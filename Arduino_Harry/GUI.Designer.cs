namespace Arduino_Harry
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnSerialMonitor = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuit = new DevExpress.XtraBars.BarButtonItem();
            this.Home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ChucNang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Option1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Option2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxCOM = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.comboBoxBaudRate = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btnConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnStopConnection = new DevExpress.XtraEditors.SimpleButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gridLookUpEditCOM = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBaudRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditCOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnExit,
            this.btnSetting,
            this.btnSerialMonitor,
            this.btnQuit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Home,
            this.DanhMuc});
            this.ribbon.Size = new System.Drawing.Size(906, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 7;
            this.btnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeGlyph")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnSetting
            // 
            this.btnSetting.Caption = "Setting";
            this.btnSetting.Id = 8;
            this.btnSetting.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSetting.LargeGlyph")));
            this.btnSetting.Name = "btnSetting";
            // 
            // btnSerialMonitor
            // 
            this.btnSerialMonitor.Caption = "Serial Monitor";
            this.btnSerialMonitor.Id = 11;
            this.btnSerialMonitor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSerialMonitor.LargeGlyph")));
            this.btnSerialMonitor.Name = "btnSerialMonitor";
            // 
            // btnQuit
            // 
            this.btnQuit.Caption = "Quit";
            this.btnQuit.Id = 12;
            this.btnQuit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuit.LargeGlyph")));
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuit_ItemClick);
            // 
            // Home
            // 
            this.Home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.HeThong,
            this.ChucNang});
            this.Home.Name = "Home";
            this.Home.Text = "Home";
            // 
            // HeThong
            // 
            this.HeThong.ItemLinks.Add(this.btnExit);
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "HeThong";
            // 
            // ChucNang
            // 
            this.ChucNang.ItemLinks.Add(this.btnSetting);
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Text = "ChucNang";
            // 
            // DanhMuc
            // 
            this.DanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Option1,
            this.Option2});
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Text = "DanhMuc";
            // 
            // Option1
            // 
            this.Option1.ItemLinks.Add(this.btnSerialMonitor);
            this.Option1.Name = "Option1";
            this.Option1.Text = "Option1";
            // 
            // Option2
            // 
            this.Option2.ItemLinks.Add(this.btnQuit);
            this.Option2.Name = "Option2";
            this.Option2.Text = "Option2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 401);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(906, 31);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = -1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(25, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Get Data ";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(12, 175);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(545, 220);
            this.textbox1.TabIndex = 3;
            this.textbox1.Text = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(644, 238);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "COM";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(793, 238);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Baud Rate";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(704, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Status";
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(689, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 7;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.Location = new System.Drawing.Point(593, 260);
            this.comboBoxCOM.MenuManager = this.ribbon;
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxCOM.Properties.LargeImages = this.imageCollection1;
            this.comboBoxCOM.Size = new System.Drawing.Size(135, 20);
            this.comboBoxCOM.TabIndex = 8;
            this.comboBoxCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOM_SelectedIndexChanged);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "File-Types-com-icon.png");
            this.imageCollection1.Images.SetKeyName(1, "Apps-Computer-B-icon.png");
            this.imageCollection1.Images.SetKeyName(2, "seo-web-code-icon.png");
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Location = new System.Drawing.Point(760, 260);
            this.comboBoxBaudRate.MenuManager = this.ribbon;
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxBaudRate.Properties.LargeImages = this.imageCollection1;
            this.comboBoxBaudRate.Size = new System.Drawing.Size(134, 20);
            this.comboBoxBaudRate.TabIndex = 9;
            // 
            // btnConnection
            // 
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.Location = new System.Drawing.Point(596, 318);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(132, 36);
            this.btnConnection.TabIndex = 10;
            this.btnConnection.Text = "Connection";
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnStopConnection
            // 
            this.btnStopConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnStopConnection.Image")));
            this.btnStopConnection.Location = new System.Drawing.Point(760, 318);
            this.btnStopConnection.Name = "btnStopConnection";
            this.btnStopConnection.Size = new System.Drawing.Size(134, 36);
            this.btnStopConnection.TabIndex = 11;
            this.btnStopConnection.Text = "Stop Connection";
            this.btnStopConnection.Click += new System.EventHandler(this.btnStopConnection_Click);
            // 
            // gridLookUpEditCOM
            // 
            this.gridLookUpEditCOM.EditValue = "COM3";
            this.gridLookUpEditCOM.Location = new System.Drawing.Point(593, 200);
            this.gridLookUpEditCOM.MenuManager = this.ribbon;
            this.gridLookUpEditCOM.Name = "gridLookUpEditCOM";
            this.gridLookUpEditCOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditCOM.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEditCOM.Size = new System.Drawing.Size(100, 20);
            this.gridLookUpEditCOM.TabIndex = 12;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 432);
            this.Controls.Add(this.gridLookUpEditCOM);
            this.Controls.Add(this.btnStopConnection);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "GUI";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBaudRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditCOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPage DanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Option1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Option2;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnSetting;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnSerialMonitor;
        private DevExpress.XtraBars.BarButtonItem btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textbox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl label5;
        public DevExpress.XtraEditors.ImageComboBoxEdit comboBoxCOM;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.ImageComboBoxEdit comboBoxBaudRate;
        private DevExpress.XtraEditors.SimpleButton btnConnection;
        private DevExpress.XtraEditors.SimpleButton btnStopConnection;
        private System.IO.Ports.SerialPort serialPort1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditCOM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}