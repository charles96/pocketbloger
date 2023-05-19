using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PocketBlogerPPC
{
    public partial class MentBox : UserControl
    {
        public MentBox()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
        }

        public ProgressBar ProgressBar
        {
            get { return prgBar; }
            set { prgBar = value; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void Show(string title, string content)
        {
            lblTitle.Text = title;
            lblMent.Text = content;
            this.Visible = true;
            timer.Enabled = false;
            Application.DoEvents();
        }

        public void Show(string title, string content, int interval)
        {
            lblTitle.Text = title;
            lblMent.Text = content;
            this.Visible = true;
            timer.Interval = interval;
            timer.Enabled = true;
            Application.DoEvents();
        }

        public void Close()
        {
            this.Visible = false;
            Application.DoEvents();
        }
    }
}
