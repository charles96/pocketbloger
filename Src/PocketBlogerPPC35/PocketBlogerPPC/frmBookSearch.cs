using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using blogengineCf;
using PocketBlogerPPC.OpenApi;

namespace PocketBlogerPPC
{
    public partial class frmBookSearch : Form
    {
        DaumBookSearch book = null;
        frmWrite writeForm = null;

        string key = String.Empty;
        string bookquery = String.Empty;
        delegate void delegateListView(List<BookCatalog> bookInfo);

        public frmBookSearch(frmWrite write, string apiKey)
        {
            key = apiKey;
            InitializeComponent();
            writeForm = write;
            book = new DaumBookSearch(key);
        }

        private void frmBookSearch_Load(object sender, EventArgs e)
        {
            txtBookName.Focus();
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(key))
            {
                mentBox.ProgressBar.Visible = false;
                mentBox.Show("알림", "다음 블로그 API KEY를 입력하셔야 사용하실수 있습니다", 3000);
                Thread.Sleep(3000);
                this.Close();
            }
            if (txtBookName.Text.Length <= 0)
            {
                mentBox.ProgressBar.Visible = false;
                mentBox.Show("알림", "검색할 책 제목을 입력하세요", 3000);
                txtBookName.Focus();
            }
            else
            {
                menuOk.Enabled = false;
                mentBox.ProgressBar.Visible = false;
                mentBox.Show("알림", "책 정보를 검색하고 있습니다..");
                bookquery = txtBookName.Text;

                Thread threadBook = new Thread(new ThreadStart(GetBookList));
                threadBook.IsBackground = true;
                threadBook.Start();
            }
        }

        private void GetBookList()
        {
            List<BookCatalog> booklist = book.Query(bookquery);

            if (lstViewBook.InvokeRequired)
            {
                this.Invoke(new delegateListView(ListUpBook), booklist);
            }
            else
            {
                ListUpBook(booklist);
            }
        }

        private void ListUpBook(List<BookCatalog> bookInfo)
        {

            if (bookInfo != null)
            {
                int resultCount = bookInfo.Count;

                if (resultCount > 0)
                {
                    if (lstViewBook.Items.Count > 0) lstViewBook.Items.Clear();

                    int count = 0;

                    mentBox.ProgressBar.Visible = true;
                    mentBox.ProgressBar.Minimum = count;
                    mentBox.ProgressBar.Maximum = resultCount;
                    mentBox.Show("알림", "책 리스트를 읽고 있습니다..");

                    lstViewBook.BeginUpdate();

                    foreach (object objBook in bookInfo)
                    {
                        BookCatalog bookResult = (BookCatalog)objBook;

                        ListViewItem bookItem = new ListViewItem(bookResult.Title);
                        bookItem.SubItems.Add(bookResult.Author);
                        bookItem.SubItems.Add(bookResult.Description);
                        bookItem.SubItems.Add(bookResult.ImageCoverLarge);
                        bookItem.SubItems.Add(bookResult.Company);

                        if ((count + 1) % 2 == 0)
                        {
                            bookItem.BackColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            bookItem.BackColor = System.Drawing.Color.Yellow;
                        }
                        mentBox.ProgressBar.Value = count;
                        lstViewBook.Items.Add(bookItem);
                        count++;
                    }

                    lstViewBook.EndUpdate();

                    lstViewBook.Items[0].Focused = true;
                    lstViewBook.Items[0].Selected = true;
                    mentBox.Visible = false;
                    menuOk.Enabled = true;
                }
                else
                {
                    mentBox.ProgressBar.Visible = false;
                    menuOk.Enabled = true;
                    mentBox.Show("알림", "검색된 내용이 없습니다", 3000);
                }
            }
            else
            {
                mentBox.ProgressBar.Visible = false;
                mentBox.Show("검색에 실패하였습니다!", "검색Api가 정확히 입력되었는지\r\n확인하세요!", 4000);
                menuOk.Enabled = true;
            }
        }

        private void SelectBook()
        {
            if (lstViewBook.Items.Count > 0)
            {
                DialogResult dResult = MessageBox.Show("선택한 책을 적용하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (dResult == DialogResult.Yes)
                {
                    int selIdx = lstViewBook.FocusedItem.Index;

                    string title = lstViewBook.Items[selIdx].SubItems[0].Text;
                    string author = lstViewBook.Items[selIdx].SubItems[1].Text;
                    string description = lstViewBook.Items[selIdx].SubItems[2].Text;
                    string coverimg = lstViewBook.Items[selIdx].SubItems[3].Text;
                    string company = lstViewBook.Items[selIdx].SubItems[4].Text;

                    writeForm.WriteContent(HtmlTag.Book(title, description, author, coverimg, company));
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("검색된 결과가 없습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuAdjust_Click(object sender, EventArgs e)
        {
            SelectBook();
        }

        private void lstViewBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            SelectBook();
        }

        private void menuSelect_Click(object sender, EventArgs e)
        {
            SelectBook();
        }
    }
}