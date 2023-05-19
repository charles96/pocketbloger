using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PocketBlogerPPC.OpenApi;

namespace PocketBlogerPPC
{
    public partial class frmMoveSearch : Form
    {
        MovieSearch movie = null;
        List<MovieEntity> movieCatalog = null;
        frmWrite writeForm = null;

        string apiKey = String.Empty;

        public frmMoveSearch(frmWrite write, string key)
        {
            InitializeComponent();
            writeForm = write;
            this.apiKey = key;
        }

        private void frmMoveSearch_Load(object sender, EventArgs e)
        {
            movie = new MovieSearch(this.apiKey);
            txtMovie.Focus();
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMovie.Text.Trim()))
            {
                if (lstViewMovie.Items.Count > 0) lstViewMovie.Items.Clear();

                movieCatalog = movie.Query(txtMovie.Text);

                if (movieCatalog.Count > 0)
                {
                    foreach (MovieEntity movieItem in movieCatalog)
                    {
                        ListViewItem listItem = new ListViewItem(movieItem.Title);
                        listItem.SubItems.Add(movieItem.Director);
                        listItem.SubItems.Add(movieItem.Actor);
                        listItem.SubItems.Add(movieItem.ReleaseDate);
                        lstViewMovie.Items.Add(listItem);
                    }
                }
                else
                {
                    MessageBox.Show("일치하는 영화제목이 없습니다.다른 제목으로 검색해보세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                    txtMovie.Focus();
                }
            }
            else
            {
                MessageBox.Show("검색하고자하는 영화의 제목을 입력해주세요","알림",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                txtMovie.Focus();
            }
        }

        private void menuAdjust_Click(object sender, EventArgs e)
        {
            if (lstViewMovie.Items.Count > 0)
            {
                DialogResult dResult = MessageBox.Show("선택한 영화를 적용하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (dResult == DialogResult.Yes)
                {
                    int selIdx = lstViewMovie.FocusedItem.Index;
                    writeForm.WriteContent(HtmlTag.Movie(movieCatalog[selIdx].Title, movieCatalog[selIdx].SubTitle, movieCatalog[selIdx].Director, movieCatalog[selIdx].Actor, movieCatalog[selIdx].ReleaseDate, movieCatalog[selIdx].ImageLink));
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("검색된 결과가 없습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }
    }
}