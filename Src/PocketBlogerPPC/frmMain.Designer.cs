#define designMode

namespace PocketBlogerPPC
{
    partial class frmMain
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
            int numSize, titleSize, dateSize, x, y;

            DeviceResolution resol = new DeviceResolution();
            resol.MainListView(out numSize, out titleSize, out dateSize);
            resol.MainMentBoxPosition(out x, out y);

            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuBlogSetting = new System.Windows.Forms.MenuItem();
            this.menuBlogMove = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuWrite = new System.Windows.Forms.MenuItem();
            this.menuModify = new System.Windows.Forms.MenuItem();
            this.menuDelete = new System.Windows.Forms.MenuItem();
            this.menuRead = new System.Windows.Forms.MenuItem();
            this.menuRefresh = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuScreenSize = new System.Windows.Forms.MenuItem();
            this.menuSetting = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.lstViewPostlist = new System.Windows.Forms.ListView();
            this.colIdx = new System.Windows.Forms.ColumnHeader();
            this.colTitle = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.conMenuAction = new System.Windows.Forms.ContextMenu();
            this.menuPenRead = new System.Windows.Forms.MenuItem();
            this.menuPenModify = new System.Windows.Forms.MenuItem();
            this.menuPenDelete = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.mentBox = new PocketBlogerPPC.MentBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem3);
            this.mainMenu1.MenuItems.Add(this.menuItem4);
            // 
            // menuItem3
            // 
            this.menuItem3.MenuItems.Add(this.menuBlogSetting);
            this.menuItem3.MenuItems.Add(this.menuBlogMove);
            this.menuItem3.Text = "블로그";
            // 
            // menuBlogSetting
            // 
            this.menuBlogSetting.Text = "블로그 설정(&S)";
            this.menuBlogSetting.Click += new System.EventHandler(this.menuBlogSetting_Click);
            // 
            // menuBlogMove
            // 
            this.menuBlogMove.Text = "블로그 이동(&M)";
            // 
            // menuItem4
            // 
            this.menuItem4.MenuItems.Add(this.menuItem6);
            this.menuItem4.MenuItems.Add(this.menuItem5);
            this.menuItem4.Text = "동작";
            // 
            // menuItem6
            // 
            this.menuItem6.MenuItems.Add(this.menuWrite);
            this.menuItem6.MenuItems.Add(this.menuModify);
            this.menuItem6.MenuItems.Add(this.menuDelete);
            this.menuItem6.MenuItems.Add(this.menuRead);
            this.menuItem6.MenuItems.Add(this.menuRefresh);
            this.menuItem6.Text = "동작(&A)";
            // 
            // menuWrite
            // 
            this.menuWrite.Text = "글 쓰기(&W)";
            this.menuWrite.Click += new System.EventHandler(this.menuWrite_Click);
            // 
            // menuModify
            // 
            this.menuModify.Text = "글 변경(&M)";
            this.menuModify.Click += new System.EventHandler(this.menuModify_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Text = "글 삭제(&D)";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuRead
            // 
            this.menuRead.Text = "글 읽기(&R)";
            this.menuRead.Click += new System.EventHandler(this.menuRead_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Text = "글 갱신(&L)";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.MenuItems.Add(this.menuScreenSize);
            this.menuItem5.MenuItems.Add(this.menuSetting);
            this.menuItem5.MenuItems.Add(this.menuAbout);
            this.menuItem5.MenuItems.Add(this.menuExit);
            this.menuItem5.Text = "프로그램(&P)";
            // 
            // menuScreenSize
            // 
            this.menuScreenSize.Text = "전체화면(&M)";
            this.menuScreenSize.Click += new System.EventHandler(this.menuScreenSize_Click);
            // 
            // menuSetting
            // 
            this.menuSetting.Text = "설정(&S)";
            this.menuSetting.Click += new System.EventHandler(this.menuSetting_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Text = "정보(&A)";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Text = "종료(&E)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // lstViewPostlist
            // 
            this.lstViewPostlist.BackColor = System.Drawing.Color.Gold;
            this.lstViewPostlist.Columns.Add(this.colIdx);
            this.lstViewPostlist.Columns.Add(this.colTitle);
            this.lstViewPostlist.Columns.Add(this.colDate);
            this.lstViewPostlist.ContextMenu = this.conMenuAction;
            this.lstViewPostlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewPostlist.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lstViewPostlist.FullRowSelect = true;
            this.lstViewPostlist.Location = new System.Drawing.Point(0, 0);
            this.lstViewPostlist.Name = "lstViewPostlist";
            this.lstViewPostlist.Size = new System.Drawing.Size(283, 268);
            this.lstViewPostlist.TabIndex = 0;
            this.lstViewPostlist.View = System.Windows.Forms.View.Details;
            this.lstViewPostlist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstViewPostlist_KeyPress);
            // 
            // colIdx
            // 
            this.colIdx.Text = "번호";
            this.colIdx.Width = numSize;
           
            // 
            // colTitle
            // 
            this.colTitle.Text = "                    제  목";
            this.colTitle.Width = titleSize;
            
            // 
            // colDate
            // 
            this.colDate.Text = "날 짜";
            this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDate.Width = dateSize;
            // 
            // conMenuAction
            // 
            this.conMenuAction.MenuItems.Add(this.menuPenRead);
            this.conMenuAction.MenuItems.Add(this.menuPenModify);
            this.conMenuAction.MenuItems.Add(this.menuPenDelete);
            // 
            // menuPenRead
            // 
            this.menuPenRead.Text = "글 읽기(&R)";
            this.menuPenRead.Click += new System.EventHandler(this.menuPenRead_Click);
            // 
            // menuPenModify
            // 
            this.menuPenModify.Text = "글 변경(&M)";
            this.menuPenModify.Click += new System.EventHandler(this.menuPenModify_Click);
            // 
            // menuPenDelete
            // 
            this.menuPenDelete.Text = "글 삭제(&D)";
            this.menuPenDelete.Click += new System.EventHandler(this.menuPenDelete_Click);
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar.Location = new System.Drawing.Point(0, 248);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(283, 20);
            this.statusBar.Text = "읽어온 최신 글..";
            // 
            // mentBox
            // 
            //this.mentBox.Location = new System.Drawing.Point(38, 97);
            this.mentBox.Location = new System.Drawing.Point(x, y);
           
            this.mentBox.Name = "mentBox";
            this.mentBox.Size = new System.Drawing.Size(245, 87);
            this.mentBox.TabIndex = 1;
            this.mentBox.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 281);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mentBox);
            this.Controls.Add(this.lstViewPostlist);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Pocket Bloger";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewPostlist;
        private System.Windows.Forms.ColumnHeader colIdx;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.ContextMenu conMenuAction;
        private System.Windows.Forms.MenuItem menuPenModify;
        private System.Windows.Forms.MenuItem menuPenDelete;
        private System.Windows.Forms.MenuItem menuBlogSetting;
        private System.Windows.Forms.MenuItem menuBlogMove;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuWrite;
        private System.Windows.Forms.MenuItem menuModify;
        private System.Windows.Forms.MenuItem menuDelete;
        private System.Windows.Forms.MenuItem menuRead;
        private System.Windows.Forms.MenuItem menuRefresh;
        private System.Windows.Forms.MenuItem menuItem5;
        private MentBox mentBox;
        private System.Windows.Forms.MenuItem menuScreenSize;
        private System.Windows.Forms.MenuItem menuSetting;
        private System.Windows.Forms.MenuItem menuAbout;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuPenRead;
        private System.Windows.Forms.StatusBar statusBar;
    }
}

