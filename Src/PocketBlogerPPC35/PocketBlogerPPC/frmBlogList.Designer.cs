namespace PocketBlogerPPC
{
    partial class frmBlogList
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
            this.menuAdd = new System.Windows.Forms.MenuItem();
            this.menuModify = new System.Windows.Forms.MenuItem();
            this.menuDelete = new System.Windows.Forms.MenuItem();
            this.menuClose = new System.Windows.Forms.MenuItem();
            this.lstViewBlog = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuPenModify = new System.Windows.Forms.MenuItem();
            this.menuPenDelete = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuClose);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuAdd);
            this.menuItem1.MenuItems.Add(this.menuModify);
            this.menuItem1.MenuItems.Add(this.menuDelete);
            this.menuItem1.Text = "동작";
            // 
            // menuAdd
            // 
            this.menuAdd.Text = "추가";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuModify
            // 
            this.menuModify.Text = "변경";
            this.menuModify.Click += new System.EventHandler(this.menuModify_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Text = "삭제";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuClose
            // 
            this.menuClose.Text = "닫기";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // lstViewBlog
            // 
            this.lstViewBlog.BackColor = System.Drawing.Color.Gold;
            this.lstViewBlog.Columns.Add(this.columnHeader1);
            this.lstViewBlog.Columns.Add(this.columnHeader2);
            this.lstViewBlog.Columns.Add(this.columnHeader3);
            this.lstViewBlog.Columns.Add(this.columnHeader4);
            this.lstViewBlog.ContextMenu = this.contextMenu1;
            this.lstViewBlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewBlog.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lstViewBlog.FullRowSelect = true;
            this.lstViewBlog.Location = new System.Drawing.Point(0, 0);
            this.lstViewBlog.Name = "lstViewBlog";
            this.lstViewBlog.Size = new System.Drawing.Size(320, 320);
            this.lstViewBlog.TabIndex = 0;
            this.lstViewBlog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "등록";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = " 블로그명";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "블로그 주소";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "비고";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 60;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuPenModify);
            this.contextMenu1.MenuItems.Add(this.menuPenDelete);
            // 
            // menuPenModify
            // 
            this.menuPenModify.Text = "블로그 변경";
            this.menuPenModify.Click += new System.EventHandler(this.menuPenModify_Click);
            // 
            // menuPenDelete
            // 
            this.menuPenDelete.Text = "블로그 삭제";
            this.menuPenDelete.Click += new System.EventHandler(this.menuPenDelete_Click);
            // 
            // frmBlogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.lstViewBlog);
            this.Menu = this.mainMenu1;
            this.Name = "frmBlogList";
            this.Text = "블로그 리스트";
            this.Load += new System.EventHandler(this.frmBlogList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuAdd;
        private System.Windows.Forms.MenuItem menuModify;
        private System.Windows.Forms.MenuItem menuDelete;
        private System.Windows.Forms.MenuItem menuClose;
        private System.Windows.Forms.ListView lstViewBlog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuPenModify;
        private System.Windows.Forms.MenuItem menuPenDelete;
    }
}