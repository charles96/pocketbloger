namespace PocketBlogerPPC
{
    partial class frmBlogAdd
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
            this.menuOk = new System.Windows.Forms.MenuItem();
            this.menuCancel = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.txtBlogName = new System.Windows.Forms.TextBox();
            this.txtBlogKey = new System.Windows.Forms.TextBox();
            this.txtBlogId = new System.Windows.Forms.TextBox();
            this.txtBlogPw = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.chkShowPw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuOk);
            this.mainMenu1.MenuItems.Add(this.menuCancel);
            // 
            // menuOk
            // 
            this.menuOk.Text = "등록";
            this.menuOk.Click += new System.EventHandler(this.menuOk_Click);
            // 
            // menuCancel
            // 
            this.menuCancel.Text = "취소";
            this.menuCancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.Text = "블로그 명";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.Text = "블로그 키";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.Text = "아이디";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.Text = "패스워드";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(11, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.Text = "Rpc 주소";
            // 
            // chkDefault
            // 
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chkDefault.Location = new System.Drawing.Point(7, 148);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(100, 20);
            this.chkDefault.TabIndex = 5;
            this.chkDefault.Text = "기본 블로그";
            // 
            // txtBlogName
            // 
            this.txtBlogName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtBlogName.Location = new System.Drawing.Point(81, 10);
            this.txtBlogName.Name = "txtBlogName";
            this.txtBlogName.Size = new System.Drawing.Size(116, 19);
            this.txtBlogName.TabIndex = 6;
            // 
            // txtBlogKey
            // 
            this.txtBlogKey.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtBlogKey.Location = new System.Drawing.Point(81, 36);
            this.txtBlogKey.Name = "txtBlogKey";
            this.txtBlogKey.PasswordChar = '*';
            this.txtBlogKey.Size = new System.Drawing.Size(116, 19);
            this.txtBlogKey.TabIndex = 7;
            // 
            // txtBlogId
            // 
            this.txtBlogId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtBlogId.Location = new System.Drawing.Point(81, 62);
            this.txtBlogId.Name = "txtBlogId";
            this.txtBlogId.Size = new System.Drawing.Size(116, 19);
            this.txtBlogId.TabIndex = 8;
            // 
            // txtBlogPw
            // 
            this.txtBlogPw.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtBlogPw.Location = new System.Drawing.Point(81, 89);
            this.txtBlogPw.Name = "txtBlogPw";
            this.txtBlogPw.PasswordChar = '*';
            this.txtBlogPw.Size = new System.Drawing.Size(116, 19);
            this.txtBlogPw.TabIndex = 9;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtUrl.Location = new System.Drawing.Point(81, 117);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(116, 19);
            this.txtUrl.TabIndex = 10;
            this.txtUrl.Text = "http://";
            // 
            // chkShowPw
            // 
            this.chkShowPw.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chkShowPw.Location = new System.Drawing.Point(7, 170);
            this.chkShowPw.Name = "chkShowPw";
            this.chkShowPw.Size = new System.Drawing.Size(112, 20);
            this.chkShowPw.TabIndex = 16;
            this.chkShowPw.Text = "비밀번호 보기";
            this.chkShowPw.CheckStateChanged += new System.EventHandler(this.chkShowPw_CheckStateChanged);
            // 
            // frmBlogAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.chkShowPw);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtBlogPw);
            this.Controls.Add(this.txtBlogId);
            this.Controls.Add(this.txtBlogKey);
            this.Controls.Add(this.txtBlogName);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmBlogAdd";
            this.Text = "블로그 등록";
            this.Load += new System.EventHandler(this.frmBlogAdd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.TextBox txtBlogName;
        private System.Windows.Forms.TextBox txtBlogKey;
        private System.Windows.Forms.TextBox txtBlogId;
        private System.Windows.Forms.TextBox txtBlogPw;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.MenuItem menuOk;
        private System.Windows.Forms.MenuItem menuCancel;
        private System.Windows.Forms.CheckBox chkShowPw;
    }
}