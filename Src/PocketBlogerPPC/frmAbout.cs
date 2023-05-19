using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using OpenNETCF.Net;

namespace PocketBlogerPPC
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblDescription.Text = "본 프로그램은 프리웨어이며 MetaWebLog Api와 ㈜Daum 검색 Api, Naver Api, YouTube™ Api 및 Google™ Static maps Api를 이용하여 개발 되었습니다.";
            lblUser.Text = "사용자 : " + OpenNETCF.Environment2.UserName;
            lblModel.Text = "모델명 : " + OpenNETCF.Environment2.MachineName;
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkUrl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"\Windows\iexplore.exe", "http://www.waifcat.com/m/59");
        }
    }
}