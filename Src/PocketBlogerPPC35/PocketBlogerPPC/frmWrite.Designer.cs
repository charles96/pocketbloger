namespace PocketBlogerPPC
{
    partial class frmWrite
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuHtml = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuLocalPic = new System.Windows.Forms.MenuItem();
            this.menuShootPic = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuLocalMovie = new System.Windows.Forms.MenuItem();
            this.menuShootMovie = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuBook = new System.Windows.Forms.MenuItem();
            this.menuMovie = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuSignature = new System.Windows.Forms.MenuItem();
            this.menuGpsSign = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuWrite = new System.Windows.Forms.MenuItem();
            this.menuCancel = new System.Windows.Forms.MenuItem();
            this.tabWrite = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mentBox = new PocketBlogerPPC.MentBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkWrap = new System.Windows.Forms.CheckBox();
            this.comCategory = new System.Windows.Forms.ComboBox();
            this.rdoNotOpen = new System.Windows.Forms.RadioButton();
            this.rdoOpen = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGps = new System.Windows.Forms.Button();
            this.lblGpsChipName = new System.Windows.Forms.Label();
            this.lblGpsStateDescription = new System.Windows.Forms.Label();
            this.lblSatelliteCount = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabWrite.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuHtml);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.Text = "추가기능";
            // 
            // menuHtml
            // 
            this.menuHtml.Text = "HTML(&H)";
            // 
            // menuItem4
            // 
            this.menuItem4.MenuItems.Add(this.menuItem10);
            this.menuItem4.MenuItems.Add(this.menuItem11);
            this.menuItem4.MenuItems.Add(this.menuItem6);
            this.menuItem4.MenuItems.Add(this.menuItem3);
            this.menuItem4.Text = "첨부(&A)";
            // 
            // menuItem10
            // 
            this.menuItem10.MenuItems.Add(this.menuLocalPic);
            this.menuItem10.MenuItems.Add(this.menuShootPic);
            this.menuItem10.Text = "사진(&P)";
            // 
            // menuLocalPic
            // 
            this.menuLocalPic.Text = "로컬 사진(&L)";
            this.menuLocalPic.Click += new System.EventHandler(this.menuLocalPic_Click);
            // 
            // menuShootPic
            // 
            this.menuShootPic.Text = "촬영(&S)";
            this.menuShootPic.Click += new System.EventHandler(this.menuShootPic_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.MenuItems.Add(this.menuLocalMovie);
            this.menuItem11.MenuItems.Add(this.menuShootMovie);
            this.menuItem11.Text = "동영상(&M)";
            // 
            // menuLocalMovie
            // 
            this.menuLocalMovie.Text = "로컬 동영상(&L)";
            this.menuLocalMovie.Click += new System.EventHandler(this.menuLocalMovie_Click);
            // 
            // menuShootMovie
            // 
            this.menuShootMovie.Text = "촬영(&S)";
            this.menuShootMovie.Click += new System.EventHandler(this.menuShootMovie_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.MenuItems.Add(this.menuBook);
            this.menuItem6.MenuItems.Add(this.menuMovie);
            this.menuItem6.Text = "기타(&E)";
            // 
            // menuBook
            // 
            this.menuBook.Text = "책 정보(&B)";
            this.menuBook.Click += new System.EventHandler(this.menuBook_Click);
            // 
            // menuMovie
            // 
            this.menuMovie.Text = "영화정보(&M)";
            this.menuMovie.Click += new System.EventHandler(this.menuMovie_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.MenuItems.Add(this.menuSignature);
            this.menuItem3.MenuItems.Add(this.menuGpsSign);
            this.menuItem3.Text = "서명(&S)";
            // 
            // menuSignature
            // 
            this.menuSignature.Checked = true;
            this.menuSignature.Text = "서명(&S)";
            this.menuSignature.Click += new System.EventHandler(this.menuSignature_Click);
            // 
            // menuGpsSign
            // 
            this.menuGpsSign.Enabled = false;
            this.menuGpsSign.Text = "위치서명(&G)";
            this.menuGpsSign.Click += new System.EventHandler(this.menuGpsSign_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuWrite);
            this.menuItem2.MenuItems.Add(this.menuCancel);
            this.menuItem2.Text = "올리기";
            // 
            // menuWrite
            // 
            this.menuWrite.Text = "전송(&S)";
            this.menuWrite.Click += new System.EventHandler(this.menuWrite_Click);
            // 
            // menuCancel
            // 
            this.menuCancel.Text = "취소(&C)";
            this.menuCancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // tabWrite
            // 
            this.tabWrite.Controls.Add(this.tabPage1);
            this.tabWrite.Controls.Add(this.tabPage2);
            this.tabWrite.Controls.Add(this.tabPage4);
            this.tabWrite.Controls.Add(this.tabPage3);
            this.tabWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWrite.Location = new System.Drawing.Point(0, 0);
            this.tabWrite.Name = "tabWrite";
            this.tabWrite.SelectedIndex = 0;
            this.tabWrite.Size = new System.Drawing.Size(240, 268);
            this.tabWrite.TabIndex = 0;
            this.tabWrite.SelectedIndexChanged += new System.EventHandler(this.tabWrite_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.mentBox);
            this.tabPage1.Controls.Add(this.txtContent);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 245);
            this.tabPage1.Text = "글 쓰기";
            // 
            // mentBox
            // 
            this.mentBox.Location = new System.Drawing.Point(28, 70);
            this.mentBox.Name = "mentBox";
            this.mentBox.Size = new System.Drawing.Size(267, 91);
            this.mentBox.TabIndex = 3;
            this.mentBox.Visible = false;
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContent.Location = new System.Drawing.Point(0, 73);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(240, 172);
            this.txtContent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "내 용";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(4, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(290, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.Text = "제 목";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkWrap);
            this.tabPage2.Controls.Add(this.comCategory);
            this.tabPage2.Controls.Add(this.rdoNotOpen);
            this.tabPage2.Controls.Add(this.rdoOpen);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 245);
            this.tabPage2.Text = "글 설정";
            // 
            // chkWrap
            // 
            this.chkWrap.Checked = true;
            this.chkWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWrap.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chkWrap.Location = new System.Drawing.Point(4, 63);
            this.chkWrap.Name = "chkWrap";
            this.chkWrap.Size = new System.Drawing.Size(188, 20);
            this.chkWrap.TabIndex = 3;
            this.chkWrap.Text = "엔터시 줄바꿈 태그 사용";
            // 
            // comCategory
            // 
            this.comCategory.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.comCategory.Location = new System.Drawing.Point(7, 7);
            this.comCategory.Name = "comCategory";
            this.comCategory.Size = new System.Drawing.Size(222, 20);
            this.comCategory.TabIndex = 2;
            // 
            // rdoNotOpen
            // 
            this.rdoNotOpen.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.rdoNotOpen.Location = new System.Drawing.Point(59, 37);
            this.rdoNotOpen.Name = "rdoNotOpen";
            this.rdoNotOpen.Size = new System.Drawing.Size(100, 20);
            this.rdoNotOpen.TabIndex = 1;
            this.rdoNotOpen.TabStop = false;
            this.rdoNotOpen.Text = "비공개";
            // 
            // rdoOpen
            // 
            this.rdoOpen.Checked = true;
            this.rdoOpen.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.rdoOpen.Location = new System.Drawing.Point(7, 37);
            this.rdoOpen.Name = "rdoOpen";
            this.rdoOpen.Size = new System.Drawing.Size(55, 20);
            this.rdoOpen.TabIndex = 0;
            this.rdoOpen.Text = "공개";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.lblGpsStateDescription);
            this.tabPage4.Controls.Add(this.lblSatelliteCount);
            this.tabPage4.Controls.Add(this.lblLongitude);
            this.tabPage4.Controls.Add(this.lblLatitude);
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(240, 245);
            this.tabPage4.Text = "위치정보";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnGps);
            this.panel1.Controls.Add(this.lblGpsChipName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 74);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.Text = "현재 위치를 블로그에 표시하세요";
            // 
            // btnGps
            // 
            this.btnGps.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnGps.Location = new System.Drawing.Point(8, 48);
            this.btnGps.Name = "btnGps";
            this.btnGps.Size = new System.Drawing.Size(72, 20);
            this.btnGps.TabIndex = 13;
            this.btnGps.Text = "수신";
            this.btnGps.Click += new System.EventHandler(this.btnGps_Click);
            // 
            // lblGpsChipName
            // 
            this.lblGpsChipName.Location = new System.Drawing.Point(8, 28);
            this.lblGpsChipName.Name = "lblGpsChipName";
            this.lblGpsChipName.Size = new System.Drawing.Size(189, 20);
            this.lblGpsChipName.Text = "label3";
            // 
            // lblGpsStateDescription
            // 
            this.lblGpsStateDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblGpsStateDescription.ForeColor = System.Drawing.Color.Blue;
            this.lblGpsStateDescription.Location = new System.Drawing.Point(17, 165);
            this.lblGpsStateDescription.Name = "lblGpsStateDescription";
            this.lblGpsStateDescription.Size = new System.Drawing.Size(199, 72);
            this.lblGpsStateDescription.Text = "정보를 받았습니다";
            this.lblGpsStateDescription.Visible = false;
            // 
            // lblSatelliteCount
            // 
            this.lblSatelliteCount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSatelliteCount.Location = new System.Drawing.Point(17, 88);
            this.lblSatelliteCount.Name = "lblSatelliteCount";
            this.lblSatelliteCount.Size = new System.Drawing.Size(189, 20);
            this.lblSatelliteCount.Text = "감지된 위성 수 :";
            // 
            // lblLongitude
            // 
            this.lblLongitude.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblLongitude.Location = new System.Drawing.Point(17, 138);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(189, 20);
            this.lblLongitude.Text = "경도 :";
            // 
            // lblLatitude
            // 
            this.lblLatitude.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblLatitude.Location = new System.Drawing.Point(17, 114);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(189, 20);
            this.lblLatitude.Text = "위도 :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 242);
            this.tabPage3.Text = "미리보기";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(232, 242);
            // 
            // frmWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabWrite);
            this.Menu = this.mainMenu1;
            this.Name = "frmWrite";
            this.Text = "글 쓰기";
            this.Load += new System.EventHandler(this.frmWrite_Load);
            this.Closed += new System.EventHandler(this.frmWrite_Closed);
            this.tabWrite.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuHtml;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuLocalPic;
        private System.Windows.Forms.MenuItem menuShootPic;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuLocalMovie;
        private System.Windows.Forms.MenuItem menuShootMovie;
        private System.Windows.Forms.MenuItem menuBook;
        private System.Windows.Forms.MenuItem menuSignature;
        private System.Windows.Forms.MenuItem menuWrite;
        private System.Windows.Forms.MenuItem menuCancel;
        private System.Windows.Forms.TabControl tabWrite;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox comCategory;
        private System.Windows.Forms.RadioButton rdoNotOpen;
        private System.Windows.Forms.RadioButton rdoOpen;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MentBox mentBox;
        private System.Windows.Forms.CheckBox chkWrap;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuGpsSign;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblSatelliteCount;
        private System.Windows.Forms.Label lblGpsStateDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGps;
        private System.Windows.Forms.Label lblGpsChipName;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuMovie;

    }
}