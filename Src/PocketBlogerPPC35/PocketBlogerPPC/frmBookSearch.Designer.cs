namespace PocketBlogerPPC
{
    partial class frmBookSearch
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
            this.menuOk = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuAdjust = new System.Windows.Forms.MenuItem();
            this.menuCancel = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewBook = new System.Windows.Forms.ListView();
            this.colTitle = new System.Windows.Forms.ColumnHeader();
            this.colAuthor = new System.Windows.Forms.ColumnHeader();
            this.colDescription = new System.Windows.Forms.ColumnHeader();
            this.colImg = new System.Windows.Forms.ColumnHeader();
            this.colCompany = new System.Windows.Forms.ColumnHeader();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuSelect = new System.Windows.Forms.MenuItem();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.mentBox = new PocketBlogerPPC.MentBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuOk);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuOk
            // 
            this.menuOk.Text = "검색";
            this.menuOk.Click += new System.EventHandler(this.menuOk_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuAdjust);
            this.menuItem2.MenuItems.Add(this.menuCancel);
            this.menuItem2.Text = "확인";
            // 
            // menuAdjust
            // 
            this.menuAdjust.Text = "적용";
            this.menuAdjust.Click += new System.EventHandler(this.menuAdjust_Click);
            // 
            // menuCancel
            // 
            this.menuCancel.Text = "취소";
            this.menuCancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.Text = "도서 명 :";
            // 
            // lstViewBook
            // 
            this.lstViewBook.BackColor = System.Drawing.Color.Tan;
            this.lstViewBook.Columns.Add(this.colTitle);
            this.lstViewBook.Columns.Add(this.colAuthor);
            this.lstViewBook.Columns.Add(this.colDescription);
            this.lstViewBook.Columns.Add(this.colImg);
            this.lstViewBook.Columns.Add(this.colCompany);
            this.lstViewBook.ContextMenu = this.contextMenu1;
            this.lstViewBook.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lstViewBook.FullRowSelect = true;
            this.lstViewBook.Location = new System.Drawing.Point(0, 51);
            this.lstViewBook.Name = "lstViewBook";
            this.lstViewBook.Size = new System.Drawing.Size(320, 211);
            this.lstViewBook.TabIndex = 1;
            this.lstViewBook.View = System.Windows.Forms.View.Details;
            this.lstViewBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstViewBook_KeyPress);
            // 
            // colTitle
            // 
            this.colTitle.Text = "책이름";
            this.colTitle.Width = 130;
            // 
            // colAuthor
            // 
            this.colAuthor.Text = "저자";
            this.colAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAuthor.Width = 60;
            // 
            // colDescription
            // 
            this.colDescription.Text = "설명";
            this.colDescription.Width = 120;
            // 
            // colImg
            // 
            this.colImg.Text = "이미지";
            this.colImg.Width = 60;
            // 
            // colCompany
            // 
            this.colCompany.Text = "출판";
            this.colCompany.Width = 60;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuSelect);
            // 
            // menuSelect
            // 
            this.menuSelect.Text = "선택";
            this.menuSelect.Click += new System.EventHandler(this.menuSelect_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtBookName.Location = new System.Drawing.Point(75, 14);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(150, 19);
            this.txtBookName.TabIndex = 0;
            // 
            // mentBox
            // 
            this.mentBox.Location = new System.Drawing.Point(41, 99);
            this.mentBox.Name = "mentBox";
            this.mentBox.Size = new System.Drawing.Size(245, 87);
            this.mentBox.TabIndex = 3;
            this.mentBox.Visible = false;
            // 
            // frmBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.mentBox);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lstViewBook);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmBookSearch";
            this.Text = "책 검색";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewBook;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colAuthor;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colImg;
        private System.Windows.Forms.ColumnHeader colCompany;
        private System.Windows.Forms.MenuItem menuOk;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuAdjust;
        private System.Windows.Forms.MenuItem menuCancel;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuSelect;
        private MentBox mentBox;
    }
}