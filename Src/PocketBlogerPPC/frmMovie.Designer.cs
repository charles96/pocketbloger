namespace PocketBlogerPPC
{
    partial class frmMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovie));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuOK = new System.Windows.Forms.MenuItem();
            this.menuClose = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTubePw = new System.Windows.Forms.TextBox();
            this.txtTubeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.mentBox = new PocketBlogerPPC.MentBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuOK);
            this.mainMenu1.MenuItems.Add(this.menuClose);
            // 
            // menuOK
            // 
            this.menuOK.Text = "확인";
            this.menuOK.Click += new System.EventHandler(this.menuOK_Click);
            // 
            // menuClose
            // 
            this.menuClose.Text = "취소";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTubePw);
            this.panel1.Controls.Add(this.txtTubeId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 63);
            // 
            // txtTubePw
            // 
            this.txtTubePw.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTubePw.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtTubePw.Location = new System.Drawing.Point(115, 33);
            this.txtTubePw.Name = "txtTubePw";
            this.txtTubePw.PasswordChar = '*';
            this.txtTubePw.Size = new System.Drawing.Size(89, 19);
            this.txtTubePw.TabIndex = 5;
            // 
            // txtTubeId
            // 
            this.txtTubeId.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTubeId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtTubeId.Location = new System.Drawing.Point(115, 6);
            this.txtTubeId.Name = "txtTubeId";
            this.txtTubeId.Size = new System.Drawing.Size(89, 19);
            this.txtTubeId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(80, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.Text = "PW :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.Text = "ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(11, 71);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(216, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtContent.Location = new System.Drawing.Point(11, 111);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(216, 61);
            this.txtContent.TabIndex = 2;
            // 
            // mentBox
            // 
            this.mentBox.Location = new System.Drawing.Point(43, 69);
            this.mentBox.Name = "mentBox";
            this.mentBox.Size = new System.Drawing.Size(239, 118);
            this.mentBox.TabIndex = 4;
            this.mentBox.Visible = false;
            // 
            // frmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.mentBox);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.Name = "frmMovie";
            this.Text = "동영상 정보 입력";
            this.Load += new System.EventHandler(this.frmMovie_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuOK;
        private System.Windows.Forms.MenuItem menuClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTubeId;
        private System.Windows.Forms.TextBox txtTubePw;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private MentBox mentBox;
    }
}