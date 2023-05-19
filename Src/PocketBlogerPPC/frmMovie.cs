using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PocketBlogerPPC.Config;

namespace PocketBlogerPPC
{
    public partial class frmMovie : Form
    {
        AppConfig config = null;

        public frmMovie(AppConfig conf)
        {
            InitializeComponent();
            this.config = conf;
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            int txtBoxW = config.Setting.Program.Form.TextBoxWidth;

            txtTubeId.Text = config.Setting.Program.Upload.Youtube.UserName;
            txtTubePw.Text = config.Setting.Program.Upload.Youtube.Password;

            txtTitle.Size = new System.Drawing.Size(txtBoxW, 21);
            txtContent.Size = new System.Drawing.Size(txtBoxW, 61);
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Username
        {
            get { return this.txtTubeId.Text; }
        }

        public string Password
        {
            get { return this.txtTubePw.Text; }
        }

        public string Title
        {
            get { return this.txtTitle.Text; }
        }

        public string Content
        {
            get { return this.txtContent.Text; }
        }

        private void menuOK_Click(object sender, EventArgs e)
        {
            mentBox.ProgressBar.Visible = false;

            if (String.IsNullOrEmpty(txtTubeId.Text))
            {
                mentBox.Show("알림", "유튜브 아이디를 입력하세요", 3000);
                txtTubeId.Focus();
            }
            else if (String.IsNullOrEmpty(txtTubePw.Text))
            {
                mentBox.Show("알림", "유튜브 패스워드를 입력하세요", 3000);
                txtTubePw.Focus();
            }
            else if (String.IsNullOrEmpty(txtTitle.Text))
            {
                mentBox.Show("알림", "제목을 입력하세요", 3000);
                txtTitle.Focus();
            }
            else if (String.IsNullOrEmpty(txtContent.Text))
            {
                mentBox.Show("알림", "내용을 입력하세요", 3000);
                txtContent.Focus();
            }
            else
            {
                DialogResult dResult = MessageBox.Show("적용 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                if (dResult == DialogResult.Yes)
                {
                    Application.DoEvents();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

    }
}