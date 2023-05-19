using System;
using System.Windows.Forms;
using blogengineCf;
using PocketBlogerPPC.Config;

namespace PocketBlogerPPC
{
    public partial class frmContentView : Form
    {
        string postIndex = String.Empty;
        bool trans = true;
        MetaWebLogApi metalog = null;
        BlogPost article = null;
        frmMain mainForm = null;
        AppConfig config = null;
        int listIndex = 0;

        public frmContentView(frmMain main, int selectIndex, MetaWebLogApi curMetalog, string postIdx,AppConfig conf)
        {
            InitializeComponent();
            this.postIndex = postIdx;
            this.listIndex = selectIndex;
            this.config = conf;
            this.mainForm = main;
            this.metalog = curMetalog;
            this.article = metalog.GetPost(postIndex);

        }

        private void menulink_Click(object sender, EventArgs e)
        {
            string ment = String.Empty;
            string Url = String.Empty;
            string bwrdir = config.Setting.Program.ExternalBrowserDir;

            switch (trans)
            {
                case true:
                    ment = "웹 주소로 전환하여 보시겠습니까?";
                    break;
                case false:
                    ment = "일반 문서로 전환하여 보시겠습니까?";
                    break;
            }

            DialogResult dResult = MessageBox.Show(ment, "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            if (dResult == DialogResult.Yes)
            {
                Application.DoEvents();
                MenuItem curlink = (MenuItem)sender;

                switch (trans)
                {
                    case true:

                        if (!String.IsNullOrEmpty(bwrdir))
                        {
                            System.IO.FileInfo bwrfile = new System.IO.FileInfo(bwrdir);

                            if (bwrfile.Exists)
                            {
                                try
                                {
                                    System.Diagnostics.Process.Start(bwrdir, curlink.Text);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("문제가 발생했습니다 외부 브라우져 지정이 제대로 되었는지 세팅에서 확인하세요!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("브라우져 파일을 찾을수 없습니다!");
                            }

                        }
                        else
                        {
                            webBlog.Url = new Uri(curlink.Text);
                        }
                        break;
                    case false:
                        this.webBlog.DocumentText = article.Description;
                        break;
                }

                this.trans = (!trans);
            }
        }

        private void frmContentView_Load(object sender, EventArgs e)
        {
            this.Text = article.Title;
            this.webBlog.DocumentText = article.Description;

            DeployTags();

            if (article.Link != null)
            {
                MenuItem menulink = new MenuItem();
                menulink.Click += new EventHandler(menulink_Click);
                menulink.Text = article.Link.ToString();
                menuPageUrl.MenuItems.Add(menulink);
            }

            if (article.Categories != null)
            {
                string[] catelist = article.Categories;

                foreach (string cateName in catelist)
                {
                    MenuItem menuCate = new MenuItem();
                    menuCate.Text = cateName;
                    menuCategory.MenuItems.Add(menuCate);
                }
            }

        }

        private void DeployTags()
        {
            string[] tags = article.Keywords;

            if (tags != null)
            {
                if (tags.Length > 0)
                {
                    foreach (string tagitem in tags)
                    {
                        MenuItem menutag = new MenuItem();
                        menutag.Text = tagitem;
                        menuTags.MenuItems.Add(menutag);
                    }
                }
            }
        }


        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("현재 글을 정말 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dResult == DialogResult.Yes)
            {
                Application.DoEvents();
                metalog.DeletePost(postIndex);
                mainForm.RemoveContent(listIndex);
                this.Close();
            }
        }

        private void frmContentView_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (webBlog.IsBusy)
            {
                webBlog.Stop();
                webBlog.Dispose();
            }
        }
    }
}