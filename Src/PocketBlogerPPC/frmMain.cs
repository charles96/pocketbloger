using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using blogengineCf;
using PocketBlogerPPC.Config;
using OpenNETCF;

namespace PocketBlogerPPC
{
    public partial class frmMain : Form
    {
        const int readPostCount = 30;
        public static int curBlogIdx = 0;

        #region 블로그 정보
        string bKey = String.Empty;
        string bname = String.Empty;
        string bPw = String.Empty;
        string bUri = null;
        #endregion

        delegate void delegateRead(List<BlogPost> blogList);
        delegate void delegateProgressBar(ProgressStateEventArgs eventArgs);
        delegate void delegateMenuEnable(bool enable);
        MetaWebLogApi metalog = null;
        OpenNETCF.Threading.Thread2 threadRead = null;

        PocketBlogerPPC.Config.AppConfig config = null;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MemoryDriveInfo driveInfo = new MemoryDriveInfo("/");
            MessageBox.Show(driveInfo.FreeBytesAvailable.ToString());
            //Read();
        }

        public void Read()
        {
            config = new PocketBlogerPPC.Config.AppConfig();

            if (config.Read())
            {
                switch (config.Setting.Program.Form.IsMaximumSize)
                {
                    case true:
                        this.WindowState = FormWindowState.Maximized;
                        this.statusBar.Visible = false;
                        menuScreenSize.Checked = true;
                        break;
                    case false:
                        this.WindowState = FormWindowState.Normal;
                        this.statusBar.Visible = true;
                        menuScreenSize.Checked = false;
                        break;
                }

                Application.DoEvents();

                List<BlogAccount> blogItem = this.config.Setting.BlogInformation.BlogItem;

                if (blogItem.Count > 0)
                {
                    if (curBlogIdx == 0) curBlogIdx = config.Setting.Program.Form.Default;

                    bKey = blogItem[curBlogIdx -1].Apikey;
                    bUri = blogItem[curBlogIdx - 1].Url;
                    bname = blogItem[curBlogIdx - 1].ID;
                    bPw = blogItem[curBlogIdx - 1].Password;

                    ReadBlogList();

                    metalog = new MetaWebLogApi();
                    metalog.ProgressState += new ProgressStateHandler(metalog_ProgressState);
                    metalog.BlogKey = bKey;
                    metalog.BlogUri = bUri;
                    metalog.Username = bname;
                    metalog.Password = bPw;
                    metalog.Timeout = 60000;
                   
                    threadRead = new OpenNETCF.Threading.Thread2(new ThreadStart(Deploy));
                    threadRead.IsBackground = true;
                    threadRead.Start();
                }
                else
                {
                    ReadBlogList();
                    CtrlMenu(false);
                    MessageBox.Show("블로그를 추가 해주세요!\r\n블로그 => 블로그설정", "알림");
                }
            }
            else
            {
                CtrlMenu(false);
                MessageBox.Show("블로그를 추가 해주세요!\r\n블로그 => 블로그설정", "알림");
            }
        }

        private void metalog_ProgressState(object sender, ProgressStateEventArgs e)
        {
            if (mentBox.InvokeRequired)
            {
                this.Invoke(new delegateProgressBar(ShowProgress), e);
            }
            else
            {
                ShowProgress(e);
            }
        }

        private void ShowProgress(ProgressStateEventArgs e)
        {
            if (e.CommandType == MetaWebLogCommandType.getRecentPosts)
            {
                string ment = String.Empty;

                mentBox.Visible = e.IsActivate;
                mentBox.ProgressBar.Minimum = 0;
                mentBox.ProgressBar.Maximum = 3;

                switch (e.Condition)
                {
                    case MetaWebLogState.GenerateDocument:
                        ment = "데이터를 생성 중 입니다..";
                        mentBox.ProgressBar.Value = 1;
                        break;
                    case MetaWebLogState.SendStream:
                        ment = "문서를 전송 합니다..";
                        mentBox.ProgressBar.Value = 2;
                        break;
                    case MetaWebLogState.ReceiveStream:
                        ment = "문서를 받고 있습니다..";
                        mentBox.ProgressBar.Value = 3;
                        break;
                    case MetaWebLogState.WebException:
                        ment = "인터넷 연결에 실패하였습니다!";
                        break;
                    case MetaWebLogState.Exception:
                        ment = "전송 도중 에러가 발생 하였습니다!";
                        break;
                    case MetaWebLogState.HaveNotResponse:
                        ment = "서버에서 응답이 없습니다!";
                        break;
                }

                mentBox.Show("최신 글을 읽어오고 있습니다", ment);
            }
        }


        private void menuBlog_Click(object sender, EventArgs e)
        {
            MenuItem selectitem = (MenuItem)sender;
           
            if (!selectitem.Checked)
            {
                int idx = selectitem.Text.IndexOf(":");
                curBlogIdx = Convert.ToInt16(selectitem.Text.Substring(idx + 1));
                Read();
            }
        }

        /// <summary>
        /// 블로그 리스트를 읽어옴
        /// </summary>
        public void ReadBlogList()
        {
            if (menuBlogMove.MenuItems.Count > 0) menuBlogMove.MenuItems.Clear();

            for (int count = 0; count < config.Setting.BlogInformation.BlogItem.Count; count++)
            {
                MenuItem menuBlog = new MenuItem();
                string blogName = config.Setting.BlogInformation.BlogItem[count].Title;

                if (curBlogIdx == (count + 1))
                {
                    this.Text = String.Format("Pocket Bloger - {0}", blogName);
                    menuBlog.Checked = true;
                }

                menuBlog.Text = String.Format("{0}:{1}", blogName, count+1);
                menuBlog.Click += new EventHandler(menuBlog_Click);
                menuBlogMove.MenuItems.Add(menuBlog);
            }
        }

        private void Deploy()
        {
            List<BlogPost> bloglist = metalog.GetRecentPosts(readPostCount);

            if (bloglist != null)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new delegateRead(ReadPostList), bloglist);
                }
                else
                {
                    ReadPostList(bloglist);
                }
            }
            else
            {
                MessageBox.Show("데이터를 가져오지 못했습니다!\r\n인터넷이 연결되어있지 않거나 블로그 정보가 잘못 입력 되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                this.Invoke(new delegateMenuEnable(CtrlMenu), false); 
                Application.DoEvents();
            }
        }

        private void ReadPostList(List<BlogPost> blogList)
        {
            if (lstViewPostlist.Items.Count > 0) lstViewPostlist.Items.Clear();

            if (blogList != null)
            {
                
                mentBox.Visible = true;
                mentBox.ProgressBar.Visible = true;
                mentBox.ProgressBar.Minimum = 0;
                mentBox.ProgressBar.Maximum = blogList.Count;
                mentBox.Show("잠시만 기다리세요", "블로그 리스트 출력 중..");

                ListViewItem blogItem = null;

                lstViewPostlist.BeginUpdate();

                int tCount = blogList.Count;

                for (int i = 0; i < tCount; i++)
                {
                    blogItem = new ListViewItem(blogList[i].PostId);
                    blogItem.SubItems.Add(blogList[i].Title);
                    blogItem.SubItems.Add(blogList[i].DateCreated);

                    if ((i + 1) % 2 == 0) blogItem.BackColor = System.Drawing.Color.Orange;

                    switch (blogList[i].Publish)
                    {
                        case true:
                            blogItem.ForeColor = System.Drawing.Color.Black;
                            break;
                        case false:
                            blogItem.ForeColor = System.Drawing.Color.Blue;
                            break;
                    }

                    mentBox.ProgressBar.Value = i + 1;
                    lstViewPostlist.Items.Add(blogItem);
                }

                lstViewPostlist.EndUpdate();

                statusBar.Text = String.Format("읽어온 최신 글 수 : {0}", tCount);
                mentBox.Visible = false;
                SelectFirstItem();
                CtrlMenu(true);
            }
            else
            {
                MessageBox.Show("데이터를 가져오는데 실패 했습니다!\r\n인터넷 연결이 되었는지 확인해 주세요", "알림");
            }
        }

        private void CtrlMenu(bool enable)
        {
            menuDelete.Enabled = enable;
            menuWrite.Enabled = enable;
            menuModify.Enabled = enable;
            menuRead.Enabled = enable;
            menuRefresh.Enabled = enable;
        }

        private void SelectFirstItem()
        {
            if (lstViewPostlist.Items.Count > 0)
            {
                lstViewPostlist.Items[0].Focused = true;
                lstViewPostlist.Items[0].Selected = true;
            }
        }

        public void ModifyContent(int index, string title, bool publish)
        {
            lstViewPostlist.Items[index].SubItems[1].Text = title;

            switch (publish)
            {
                case true:
                    lstViewPostlist.Items[index].ForeColor = System.Drawing.Color.Black;
                    break;
                case false:
                    lstViewPostlist.Items[index].ForeColor = System.Drawing.Color.Blue;
                    break;
            }
        }

        public void RemoveContent(int index)
        {
            lstViewPostlist.Items.RemoveAt(index);
        }

        public void AddContent(string postId, string title)
        {
            if (!String.IsNullOrEmpty(postId))
            {
                ListViewItem blogItem = new ListViewItem(postId);
                blogItem.SubItems.Add(title);
                blogItem.SubItems.Add(DateTime.Now.ToString("yyyyMMdd"));
                blogItem.BackColor = System.Drawing.Color.Chocolate;
                lstViewPostlist.Items.Insert(0, blogItem);
                SelectFirstItem();
            }
            else
            {
                mentBox.Show("알림", "글을 쓰지 못했습니다!", 4000);
            }
        }

        private void menuWrite_Click(object sender, EventArgs e)
        {
            using (frmWrite writeForm = new frmWrite(this, metalog,this.config))
            {
                writeForm.ShowDialog();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuScreenSize_Click(object sender, EventArgs e)
        {
            menuScreenSize.Checked = (!menuScreenSize.Checked);

            switch (menuScreenSize.Checked)
            {
                case true:
                    this.WindowState = FormWindowState.Maximized;
                    this.statusBar.Visible = false;
                    break;
                case false:
                    this.WindowState = FormWindowState.Normal;
                    this.statusBar.Visible = true;
                    break;
            }

        }

        private void menuBlogSetting_Click(object sender, EventArgs e)
        {
            using (frmBlogList blogList = new frmBlogList(this,this.config))
            {
                blogList.ShowDialog();
            }
        }

        private void menuModify_Click(object sender, EventArgs e)
        {
            ContentModify();
        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            lstViewPostlist.Items.Clear();
       
            OpenNETCF.Threading.Thread2 threadRead = new OpenNETCF.Threading.Thread2(new ThreadStart(Deploy));
            threadRead.IsBackground = true;
            threadRead.Start();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            ContentDelete();
        }

        private void ContentDelete()
        {
            int idx = lstViewPostlist.FocusedItem.Index;

            string articleTitle = lstViewPostlist.Items[idx].SubItems[1].Text;
            string ment = String.Format("다음 글을 정말 삭제하시겠습니까?\r\n{0}", articleTitle);
            DialogResult dResult = MessageBox.Show(ment, "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dResult == DialogResult.Yes)
            {
                Application.DoEvents();
                mentBox.ProgressBar.Visible = false;
                mentBox.Show("알림", "글을 삭제 하고 있습니다..");
                metalog.DeletePost(lstViewPostlist.Items[idx].SubItems[0].Text);
                RemoveContent(idx);
                SelectFirstItem();
                mentBox.Visible = false;
            }
        }

        private void ContentModify()
        {
            int itemIndex = lstViewPostlist.FocusedItem.Index;
            using (frmWrite write = new frmWrite(this, metalog, lstViewPostlist.Items[itemIndex].SubItems[0].Text, itemIndex,this.config))
            {
                write.ShowDialog();
            }
        }

        private void ContentRead()
        {
            if (lstViewPostlist.Items.Count > 0)
            {
                int selIndex = lstViewPostlist.FocusedItem.Index;
                using (frmContentView contentView = new frmContentView(this, selIndex, metalog, lstViewPostlist.Items[selIndex].SubItems[0].Text, this.config))
                {
                    contentView.ShowDialog();
                }

                Application.DoEvents();
            }
        }

        private void lstViewPostlist_KeyPress(object sender, KeyPressEventArgs e)
        {
            ContentRead();
        }

        private void menuRead_Click(object sender, EventArgs e)
        {
            ContentRead();
        }

        private void menuPenRead_Click(object sender, EventArgs e)
        {
            ContentRead();
        }

        private void menuPenModify_Click(object sender, EventArgs e)
        {
            ContentModify();
        }

        private void menuPenDelete_Click(object sender, EventArgs e)
        {
            ContentDelete();
        }

        private void menuSetting_Click(object sender, EventArgs e)
        {
            using (frmSetting settingForm = new frmSetting(this.config))
            {
                settingForm.ShowDialog();
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            using (frmAbout aboutForm = new frmAbout())
            {
                aboutForm.ShowDialog();
            }
        }

        private void frmMain_Closing(object sender, CancelEventArgs e)
        {
            if (this.threadRead.IsAlive) this.threadRead.Abort();
        }

    }
}