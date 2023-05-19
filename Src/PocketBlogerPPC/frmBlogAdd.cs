using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PocketBlogerPPC.Config;

namespace PocketBlogerPPC
{
    public partial class frmBlogAdd : Form
    {
        AppConfig config = null;
        frmBlogList bloglistForm = null;

        int bCount = 0;
        int mIndex = 0;

        public frmBlogAdd(frmBlogList bloglist,AppConfig conf)
        {
            InitializeComponent();
            this.bloglistForm = bloglist;
            this.config = conf;

            menuOk.Text = "등록";
        }

        public frmBlogAdd(frmBlogList bloglist, int Index,AppConfig conf)
        {
            InitializeComponent();
            this.mIndex = Index;
            this.bloglistForm = bloglist;
            this.config = conf;

            menuOk.Text = "변경";
        }


        private void menuCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuOk_Click(object sender, EventArgs e)
        {
            if (txtBlogName.Text.Length <= 0)
            {
                MessageBox.Show("블로그 명을 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtBlogName.Focus();
            }
            else if (txtBlogKey.Text.Length <= 0)
            {
                MessageBox.Show("블로그 키를 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtBlogKey.Focus();
            }
            else if (txtBlogName.Text.Length <= 0)
            {
                MessageBox.Show("로그인 아이디를 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtBlogName.Focus();
            }
            else if (txtBlogPw.Text.Length <= 0)
            {
                MessageBox.Show("패스워드를 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtBlogPw.Focus();
            }
            else if (txtUrl.Text.Length <= 0)
            {
                MessageBox.Show("RPC 서버 주소를 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtUrl.Focus();
            }
            else
            {
                if (menuOk.Text == "등록")
                {
                    BlogAccount account = new BlogAccount();
                    account.Apikey = txtBlogKey.Text;
                    account.ID = txtBlogId.Text;
                    account.Password = txtBlogPw.Text;
                    account.Title = txtBlogName.Text;
                    account.Url = txtUrl.Text;
                    account.Index = bCount + 1;

                    config.Setting.BlogInformation.BlogItem.Add(account);

                    if (chkDefault.Checked) config.Setting.Program.Form.Default = bCount + 1;

                    frmMain.curBlogIdx = bCount + 1;
                }
                else
                {
                    if (chkDefault.Checked) config.Setting.Program.Form.Default = mIndex;
                    //config.BlogServer.Modify(cIndex - 1, txtBlogName.Text, txtBlogKey.Text, txtBlogId.Text, txtBlogPw.Text, txtUrl.Text);
                    config.Setting.BlogInformation.BlogItem[mIndex - 1].Apikey = txtBlogKey.Text;
                    config.Setting.BlogInformation.BlogItem[mIndex - 1].ID = txtBlogId.Text;
                    config.Setting.BlogInformation.BlogItem[mIndex - 1].Password = txtBlogPw.Text;
                    config.Setting.BlogInformation.BlogItem[mIndex - 1].Title = txtBlogName.Text;
                    config.Setting.BlogInformation.BlogItem[mIndex - 1].Url = txtUrl.Text;

                }

                config.Save();
                Application.DoEvents();
                bloglistForm.RefreshList();
                this.Close();
            }
        }

        private void frmBlogAdd_Load(object sender, EventArgs e)
        {
            bCount = this.config.Setting.BlogInformation.BlogItem.Count;

            if (mIndex != 0) // 수정일 경우
            {
                txtBlogName.Text = this.config.Setting.BlogInformation.BlogItem[mIndex - 1].Title;
                txtUrl.Text = this.config.Setting.BlogInformation.BlogItem[mIndex - 1].Url;
                txtBlogId.Text = this.config.Setting.BlogInformation.BlogItem[mIndex - 1].ID;
                txtBlogPw.Text = this.config.Setting.BlogInformation.BlogItem[mIndex - 1].Password;
                txtBlogKey.Text = this.config.Setting.BlogInformation.BlogItem[mIndex - 1].Apikey;
                chkDefault.Checked = (this.config.Setting.Program.Form.Default == mIndex);
                Application.DoEvents();
            }
        }

        private void chkShowPw_CheckStateChanged(object sender, EventArgs e)
        {
            switch (chkShowPw.Checked)
            {
                case true:
                    txtBlogKey.PasswordChar = Char.MinValue;
                    txtBlogPw.PasswordChar = Char.MinValue;
                    break;
                case false:
                    txtBlogKey.PasswordChar = '*';
                    txtBlogPw.PasswordChar = '*';
                    break;
            }
        }
    }
}