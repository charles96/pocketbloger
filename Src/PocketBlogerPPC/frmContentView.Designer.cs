namespace PocketBlogerPPC
{
    partial class frmContentView
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
            this.menuTags = new System.Windows.Forms.MenuItem();
            this.menuPageUrl = new System.Windows.Forms.MenuItem();
            this.menuCategory = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuDelete = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.webBlog = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuTags);
            this.menuItem1.MenuItems.Add(this.menuPageUrl);
            this.menuItem1.MenuItems.Add(this.menuCategory);
            this.menuItem1.Text = "글정보";
            // 
            // menuTags
            // 
            this.menuTags.Text = "태그(&T)";
            // 
            // menuPageUrl
            // 
            this.menuPageUrl.Text = "페이지 주소(&U)";
            // 
            // menuCategory
            // 
            this.menuCategory.Text = "카테고리(&C)";
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuDelete);
            this.menuItem2.MenuItems.Add(this.menuExit);
            this.menuItem2.Text = "동작";
            // 
            // menuDelete
            // 
            this.menuDelete.Text = "삭제(&D)";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuExit
            // 
            this.menuExit.Text = "닫기(&E)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // webBlog
            // 
            this.webBlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBlog.Location = new System.Drawing.Point(0, 0);
            this.webBlog.Name = "webBlog";
            this.webBlog.ScriptErrorsSuppressed = true;
            this.webBlog.Size = new System.Drawing.Size(320, 320);
            // 
            // frmContentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.webBlog);
            this.Menu = this.mainMenu1;
            this.Name = "frmContentView";
            this.Text = "frmContentView";
            this.Load += new System.EventHandler(this.frmContentView_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmContentView_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBlog;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuTags;
        private System.Windows.Forms.MenuItem menuPageUrl;
        private System.Windows.Forms.MenuItem menuCategory;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuDelete;
        private System.Windows.Forms.MenuItem menuExit;
    }
}