namespace PocketBlogerPPC
{
    partial class frmMoveSearch
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
            this.menuSearch = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuAdjust = new System.Windows.Forms.MenuItem();
            this.menuClose = new System.Windows.Forms.MenuItem();
            this.lstViewMovie = new System.Windows.Forms.ListView();
            this.colTitle = new System.Windows.Forms.ColumnHeader();
            this.colDirec = new System.Windows.Forms.ColumnHeader();
            this.colActor = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuSearch);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuSearch
            // 
            this.menuSearch.Text = "검색";
            this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuAdjust);
            this.menuItem2.MenuItems.Add(this.menuClose);
            this.menuItem2.Text = "확인";
            // 
            // menuAdjust
            // 
            this.menuAdjust.Text = "적용";
            this.menuAdjust.Click += new System.EventHandler(this.menuAdjust_Click);
            // 
            // menuClose
            // 
            this.menuClose.Text = "취소";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // lstViewMovie
            // 
            this.lstViewMovie.Columns.Add(this.colTitle);
            this.lstViewMovie.Columns.Add(this.colDirec);
            this.lstViewMovie.Columns.Add(this.colActor);
            this.lstViewMovie.Columns.Add(this.colDate);
            this.lstViewMovie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstViewMovie.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lstViewMovie.FullRowSelect = true;
            this.lstViewMovie.Location = new System.Drawing.Point(0, 33);
            this.lstViewMovie.Name = "lstViewMovie";
            this.lstViewMovie.Size = new System.Drawing.Size(240, 235);
            this.lstViewMovie.TabIndex = 0;
            this.lstViewMovie.View = System.Windows.Forms.View.Details;
            // 
            // colTitle
            // 
            this.colTitle.Text = "제목";
            this.colTitle.Width = 60;
            // 
            // colDirec
            // 
            this.colDirec.Text = "감독";
            this.colDirec.Width = 60;
            // 
            // colActor
            // 
            this.colActor.Text = "배우";
            this.colActor.Width = 60;
            // 
            // colDate
            // 
            this.colDate.Text = "제작년도";
            this.colDate.Width = 60;
            // 
            // txtMovie
            // 
            this.txtMovie.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtMovie.Location = new System.Drawing.Point(65, 5);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(100, 19);
            this.txtMovie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.Text = "영화제목 :";
            // 
            // frmMoveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.lstViewMovie);
            this.Menu = this.mainMenu1;
            this.Name = "frmMoveSearch";
            this.Text = "영화 정보";
            this.Load += new System.EventHandler(this.frmMoveSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewMovie;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.ColumnHeader colDirec;
        private System.Windows.Forms.ColumnHeader colActor;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.MenuItem menuSearch;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuAdjust;
        private System.Windows.Forms.MenuItem menuClose;
        private System.Windows.Forms.Label label1;
    }
}