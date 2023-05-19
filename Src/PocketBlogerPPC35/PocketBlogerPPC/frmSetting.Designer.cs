namespace PocketBlogerPPC
{
    partial class frmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuOK = new System.Windows.Forms.MenuItem();
            this.menuCancel = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExBrowser = new System.Windows.Forms.Button();
            this.txtbwrDir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextBoxWidth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trkBarWidth = new System.Windows.Forms.TrackBar();
            this.nmImgWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSkip = new System.Windows.Forms.CheckBox();
            this.txtTubePass = new System.Windows.Forms.TextBox();
            this.txtTubeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtApi = new System.Windows.Forms.TextBox();
            this.comboApi = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblGpsState = new System.Windows.Forms.Label();
            this.btnGpsTest = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.osOpenDialog1 = new FileDialogs.OSOpenDialog(this.components);
            this.groupBox1 = new OpenNETCF.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuOK);
            this.mainMenu1.MenuItems.Add(this.menuCancel);
            // 
            // menuOK
            // 
            this.menuOK.Text = "저장";
            this.menuOK.Click += new System.EventHandler(this.menuOK_Click);
            // 
            // menuCancel
            // 
            this.menuCancel.Text = "취소";
            this.menuCancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.nmImgWidth);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkMax);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(320, 295);
            this.tabPage1.Text = "프로그램";
            // 
            // btnExBrowser
            // 
            this.btnExBrowser.Location = new System.Drawing.Point(147, 44);
            this.btnExBrowser.Name = "btnExBrowser";
            this.btnExBrowser.Size = new System.Drawing.Size(72, 20);
            this.btnExBrowser.TabIndex = 10;
            this.btnExBrowser.Text = "찾기";
            this.btnExBrowser.Click += new System.EventHandler(this.btnExBrowser_Click);
            // 
            // txtbwrDir
            // 
            this.txtbwrDir.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtbwrDir.Location = new System.Drawing.Point(9, 44);
            this.txtbwrDir.Name = "txtbwrDir";
            this.txtbwrDir.Size = new System.Drawing.Size(132, 19);
            this.txtbwrDir.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblTextBoxWidth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.trkBarWidth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 85);
            // 
            // lblTextBoxWidth
            // 
            this.lblTextBoxWidth.Location = new System.Drawing.Point(11, 27);
            this.lblTextBoxWidth.Name = "lblTextBoxWidth";
            this.lblTextBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.lblTextBoxWidth.Text = "290";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(11, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.Text = "텍스트 박스 가로 사이즈  조절";
            // 
            // trkBarWidth
            // 
            this.trkBarWidth.Location = new System.Drawing.Point(4, 50);
            this.trkBarWidth.Maximum = 390;
            this.trkBarWidth.Minimum = 190;
            this.trkBarWidth.Name = "trkBarWidth";
            this.trkBarWidth.Size = new System.Drawing.Size(200, 30);
            this.trkBarWidth.TabIndex = 0;
            this.trkBarWidth.TickFrequency = 10;
            this.trkBarWidth.Value = 290;
            this.trkBarWidth.ValueChanged += new System.EventHandler(this.trkBarWidth_ValueChanged);
            // 
            // nmImgWidth
            // 
            this.nmImgWidth.BackColor = System.Drawing.Color.Gainsboro;
            this.nmImgWidth.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.nmImgWidth.Location = new System.Drawing.Point(11, 148);
            this.nmImgWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmImgWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmImgWidth.Name = "nmImgWidth";
            this.nmImgWidth.Size = new System.Drawing.Size(59, 20);
            this.nmImgWidth.TabIndex = 2;
            this.nmImgWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(10, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.Text = "img의 긴축 고정 사이즈 : ";
            // 
            // chkMax
            // 
            this.chkMax.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chkMax.Location = new System.Drawing.Point(9, 99);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(100, 20);
            this.chkMax.TabIndex = 0;
            this.chkMax.Text = "전체 화면";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.chkSkip);
            this.tabPage3.Controls.Add(this.txtTubePass);
            this.tabPage3.Controls.Add(this.txtTubeId);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(320, 295);
            this.tabPage3.Text = "동영상";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.Text = "패스워드 :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.Text = "아이디 :";
            // 
            // chkSkip
            // 
            this.chkSkip.Checked = true;
            this.chkSkip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkip.Location = new System.Drawing.Point(10, 82);
            this.chkSkip.Name = "chkSkip";
            this.chkSkip.Size = new System.Drawing.Size(156, 20);
            this.chkSkip.TabIndex = 3;
            this.chkSkip.Text = "추가 정보 입력 생략";
            // 
            // txtTubePass
            // 
            this.txtTubePass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTubePass.Location = new System.Drawing.Point(82, 55);
            this.txtTubePass.Name = "txtTubePass";
            this.txtTubePass.PasswordChar = '*';
            this.txtTubePass.Size = new System.Drawing.Size(100, 21);
            this.txtTubePass.TabIndex = 2;
            // 
            // txtTubeId
            // 
            this.txtTubeId.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTubeId.Location = new System.Drawing.Point(82, 28);
            this.txtTubeId.Name = "txtTubeId";
            this.txtTubeId.Size = new System.Drawing.Size(100, 21);
            this.txtTubeId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.Text = "유튜브 계정 입력";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtApi);
            this.tabPage2.Controls.Add(this.comboApi);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(312, 293);
            this.tabPage2.Text = "API 설정";
            // 
            // txtApi
            // 
            this.txtApi.Location = new System.Drawing.Point(9, 39);
            this.txtApi.Name = "txtApi";
            this.txtApi.Size = new System.Drawing.Size(161, 21);
            this.txtApi.TabIndex = 1;
            // 
            // comboApi
            // 
            this.comboApi.Location = new System.Drawing.Point(9, 10);
            this.comboApi.Name = "comboApi";
            this.comboApi.Size = new System.Drawing.Size(161, 22);
            this.comboApi.TabIndex = 0;
            this.comboApi.SelectedValueChanged += new System.EventHandler(this.comboApi_SelectedValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.txtSign);
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(312, 293);
            this.tabPage4.Text = "서명";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.Text = "서명에 사용할 내용을 입력하세요.";
            // 
            // txtSign
            // 
            this.txtSign.Location = new System.Drawing.Point(8, 37);
            this.txtSign.Multiline = true;
            this.txtSign.Name = "txtSign";
            this.txtSign.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSign.Size = new System.Drawing.Size(188, 116);
            this.txtSign.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblGpsState);
            this.tabPage5.Controls.Add(this.btnGpsTest);
            this.tabPage5.Controls.Add(this.txtLog);
            this.tabPage5.Location = new System.Drawing.Point(0, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(312, 293);
            this.tabPage5.Text = "GPS세팅";
            // 
            // lblGpsState
            // 
            this.lblGpsState.Location = new System.Drawing.Point(16, 17);
            this.lblGpsState.Name = "lblGpsState";
            this.lblGpsState.Size = new System.Drawing.Size(72, 20);
            this.lblGpsState.Text = "GPS 상태 : ";
            // 
            // btnGpsTest
            // 
            this.btnGpsTest.Location = new System.Drawing.Point(15, 39);
            this.btnGpsTest.Name = "btnGpsTest";
            this.btnGpsTest.Size = new System.Drawing.Size(72, 20);
            this.btnGpsTest.TabIndex = 1;
            this.btnGpsTest.Text = "테스트";
            this.btnGpsTest.Click += new System.EventHandler(this.btnGpsTest_Click);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtLog.Location = new System.Drawing.Point(15, 65);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(220, 125);
            this.txtLog.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbwrDir);
            this.groupBox1.Controls.Add(this.btnExBrowser);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(10, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 77);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.Text = "브라우져 설정";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(9, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 20);
            this.label8.Text = "외부 웹브라우져를 등록하세요";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "frmSetting";
            this.Text = "설정";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.Closed += new System.EventHandler(this.frmSetting_Closed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nmImgWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuItem menuOK;
        private System.Windows.Forms.MenuItem menuCancel;
        private System.Windows.Forms.TextBox txtApi;
        private System.Windows.Forms.ComboBox comboApi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSkip;
        private System.Windows.Forms.TextBox txtTubePass;
        private System.Windows.Forms.TextBox txtTubeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trkBarWidth;
        private System.Windows.Forms.Label lblTextBoxWidth;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnGpsTest;
        private System.Windows.Forms.Label lblGpsState;
        private System.Windows.Forms.TextBox txtbwrDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExBrowser;
        private FileDialogs.OSOpenDialog osOpenDialog1;
        private OpenNETCF.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
    }
}