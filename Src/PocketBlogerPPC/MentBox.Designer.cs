namespace PocketBlogerPPC
{
    partial class MentBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.lblMent = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 24);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(7, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 20);
            this.lblTitle.Text = "label2";
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(8, 66);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(230, 15);
            // 
            // lblMent
            // 
            this.lblMent.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblMent.Location = new System.Drawing.Point(8, 31);
            this.lblMent.Name = "lblMent";
            this.lblMent.Size = new System.Drawing.Size(230, 32);
            this.lblMent.Text = "label1";
            // 
            // MentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.lblMent);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.panel1);
            this.Name = "MentBox";
            this.Size = new System.Drawing.Size(245, 89);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label lblMent;
        private System.Windows.Forms.Timer timer;
    }
}
