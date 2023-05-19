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
    public partial class frmBlogList : Form
    {
        AppConfig config = null;
        frmMain mainForm = null;
        BlogInfo blogInfo = null;

        public frmBlogList(frmMain main,AppConfig conf)
        {
            InitializeComponent();
            this.mainForm = main;
            this.config = conf;
        }

        private void frmBlogList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        public void RefreshList()
        {
            if (lstViewBlog.Items.Count > 0) lstViewBlog.Items.Clear();
            LoadList();
        }

        private void LoadList()
        {
            int deIndex = config.Setting.Program.Form.Default;
            this.blogInfo = this.config.Setting.BlogInformation;

            int blogCount = blogInfo.BlogItem.Count;

            if (blogCount > 0)
            {
                lstViewBlog.BeginUpdate();

                for (int count = 0; count < blogCount; count++)
                {
                    ListViewItem blogItem = new ListViewItem(Convert.ToString(count + 1));
                    blogItem.SubItems.Add(this.blogInfo.BlogItem[count].Title);
                    blogItem.SubItems.Add(this.blogInfo.BlogItem[count].Url);

                    if ((count + 1) % 2 == 0) blogItem.BackColor = System.Drawing.Color.Orange;
                    if ((deIndex - 1) == count) blogItem.SubItems.Add("기본");

                    lstViewBlog.Items.Add(blogItem);
                    Application.DoEvents();
                }

                if (lstViewBlog.Items.Count > 0)
                {
                    lstViewBlog.Items[0].Focused = true;
                    lstViewBlog.Items[0].Selected = true;
                }

                lstViewBlog.EndUpdate();
            }
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            mainForm.Read();
            this.Close();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            using (frmBlogAdd blogAdd = new frmBlogAdd(this,this.config))
            {
                blogAdd.ShowDialog();
            }
        }

        private void lstViewBlog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lstViewBlog.Items.Count > 0)
            {
                int selIndex = lstViewBlog.FocusedItem.Index;

                using (frmBlogAdd blogAdd = new frmBlogAdd(this, Convert.ToInt16(lstViewBlog.Items[selIndex].SubItems[0].Text),this.config))
                {
                    blogAdd.ShowDialog();
                }

                Application.DoEvents();
            }
        }

        private void BlogDelete()
        {
            DialogResult dResult = MessageBox.Show("블로그 정보를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

            if (dResult == DialogResult.Yes)
            {
                Application.DoEvents();

                if (lstViewBlog.Items.Count > 0)
                {
                    int selIndex = lstViewBlog.FocusedItem.Index;
                    this.blogInfo.BlogItem.RemoveAt(selIndex);
                    this.config.Save();

                    RefreshList();
                }
                else
                {
                    MessageBox.Show("블로그 정보가 없습니다", "알림");
                }
            }
        }

        private void BlogModify()
        {
            if (lstViewBlog.Items.Count > 0)
            {
                int selIndex = lstViewBlog.FocusedItem.Index;

                using (frmBlogAdd blogAdd = new frmBlogAdd(this, Convert.ToInt16(lstViewBlog.Items[selIndex].SubItems[0].Text),this.config))
                {
                    blogAdd.ShowDialog();
                }

                Application.DoEvents();
            }
        }

        private void menuModify_Click(object sender, EventArgs e)
        {
            BlogModify();
        }

        private void menuPenModify_Click(object sender, EventArgs e)
        {
            BlogModify();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            BlogDelete();
        }

        private void menuPenDelete_Click(object sender, EventArgs e)
        {
            BlogDelete();
        }
    }
}