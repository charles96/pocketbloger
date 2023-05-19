using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.IO.Ports;
using PocketBlogerPPC.Config;
using PocketBlogerPPC.Gps;
using Google.GData.YouTube;

namespace PocketBlogerPPC
{
    public partial class frmSetting : Form
    {
        AppConfig config = null;
        string sPort = String.Empty;
        delegate void delegateLogView(string log);
        delegate void delegeteGpsState(GpsDeviceState e);

        FormSetting configForm = null;
        UploadSetting configUpload = null;

        PocketBlogerPPC.Gps.Gps gps = null;

        public frmSetting(AppConfig conf)
        {
            InitializeComponent();
            
            this.config = conf;

            gps = new PocketBlogerPPC.Gps.Gps();
            gps.DeviceStateChanged += new DeviceStateChangedEventHandler(gps_DeviceStateChanged);
            gps.LocationChanged += new LocationChangedEventHandler(gps_LocationChanged);
        }

        private void gps_DeviceStateChanged(object sender, DeviceStateChangedEventArgs e)
        {
            GpsDeviceState state = e.DeviceState;

            if (lblGpsState.InvokeRequired)
            {
                lblGpsState.Invoke(new delegeteGpsState(GpsState),state);
            }
            else
            {
                GpsState(state);
            }
        }

        private void GpsState(GpsDeviceState e)
        {
            switch (e.DeviceState)
            {
                case GpsServiceState.Off:
                    lblGpsState.Text = "GPS상태 : 꺼짐";
                    break;
                case GpsServiceState.On:
                    lblGpsState.Text = "GPS상태 : 켜짐";
                    break;
                case GpsServiceState.ShuttingDown:
                    lblGpsState.Text = "GPS상태 : 셧다운중..";
                    break;
                case GpsServiceState.StartingUp:
                    lblGpsState.Text = "GPS상태 : 활성중..";
                    break;
                case GpsServiceState.Uninitialized:
                    lblGpsState.Text = "";
                    break;
                case GpsServiceState.Unknown:
                    lblGpsState.Text = "GPS상태 : 알수없음";
                    break;
                case GpsServiceState.Unloading:
                    lblGpsState.Text = "GPS상태 : 해제중..";
                    break;
            }
        }

        private void LogWrite(string log)
        {
            txtLog.Text = txtLog.Text + log + "\r\n";
        }

        private void gps_LocationChanged(object sender, LocationChangedEventArgs e)
        {
            GpsPosition position = e.Position;

            if (txtLog.InvokeRequired)
            {
                string log = String.Format("Lo:{0},La{1}", position.Longitude.ToString(), position.Latitude.ToString());
                txtLog.Invoke(new delegateLogView(LogWrite), log);
            }
            else
            {
                txtLog.Text = position.Latitude.ToString();
            }
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            GpsDeviceState state = gps.GetDeviceState();
            GpsState(state);

            configForm = config.Setting.Program.Form;
            configUpload = config.Setting.Program.Upload;
    
            chkMax.Checked = configForm.IsMaximumSize;
            chkSkip.Checked = configUpload.Youtube.IsSkip;
            nmImgWidth.Value = configUpload.Image.ImageWidth;
            txtTubeId.Text = configUpload.Youtube.UserName;
            txtTubePass.Text = configUpload.Youtube.Password;
            trkBarWidth.Value = configForm.TextBoxWidth;
            txtSign.Text = config.Setting.Program.Signature;
            txtbwrDir.Text = config.Setting.Program.ExternalBrowserDir;

            LoadApiList();

        }

        private void LoadApiList()
        {

            ArrayList arrApi = new ArrayList();
            arrApi.Add(new ItemInfo("등록할 Api를 선택하세요", ""));

            List<ApiItem> apilist = config.Setting.Api.Item;

            if (apilist.Count > 0)
            {
                foreach (ApiItem item in apilist)
                {
                    arrApi.Add(new ItemInfo(item.ServiceName, item.ApiKey));
                }
            }

            comboApi.DataSource = arrApi;
            comboApi.DisplayMember = "Key";
            comboApi.ValueMember = "Value";
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuOK_Click(object sender, EventArgs e)
        {
            int imgW = Convert.ToInt16(nmImgWidth.Value);
            int imgH = Convert.ToInt16("0");

            if (imgW < 100 || imgW > 1000)
            {
                MessageBox.Show("이미지 긴축 사이즈는 100~1000 사이로 설정하세요","알림");
                nmImgWidth.Focus();
            }
            else
            {
                configForm.IsMaximumSize = chkMax.Checked;
                
                if (comboApi.SelectedIndex > 0)
                {
                    config.Setting.Api.Item[comboApi.SelectedIndex -1].ApiKey = txtApi.Text;
                }
                
                config.Setting.Program.Upload.Image.ImageWidth = imgW;
                config.Setting.Program.Upload.Image.ImageHeight = imgH;
                config.Setting.Program.Upload.Youtube.UserName = txtTubeId.Text;
                config.Setting.Program.Upload.Youtube.Password = txtTubePass.Text;
                config.Setting.Program.Upload.Youtube.IsSkip = chkSkip.Checked;
                config.Setting.Program.Form.TextBoxWidth = trkBarWidth.Value;
                config.Setting.Program.Signature = txtSign.Text;
                config.Setting.Program.ExternalBrowserDir = txtbwrDir.Text;
                config.Save();

                this.Close();
            }
        }

        private void comboApi_SelectedValueChanged(object sender, EventArgs e)
        {
            int selIndex = comboApi.SelectedIndex;
            string strKey = String.Empty;

            txtApi.Enabled = (selIndex > 0);
            txtApi.Text = comboApi.SelectedValue.ToString();
        }

        private void trkBarWidth_ValueChanged(object sender, EventArgs e)
        {
            lblTextBoxWidth.Text = Convert.ToString(trkBarWidth.Value);
        }

        private void btnGpsTest_Click(object sender, EventArgs e)
        {
            switch (gps.Opened)
            {
                case true:
                    btnGpsTest.Text = "테스트";
                    gps.Close();
                    break;
                case false:
                    btnGpsTest.Text = "중지";
                    gps.Open();
                    break;
            }
        }

        private void frmSetting_Closed(object sender, EventArgs e)
        {
            if (gps.Opened) gps.Close();
        }

        private void btnExBrowser_Click(object sender, EventArgs e)
        {  
            osOpenDialog1.Filter = "Browser .exe|*.exe";
            osOpenDialog1.Show();

            DialogResult dResult = osOpenDialog1.DialogResult;

            if (dResult == DialogResult.Yes)
            {
                txtbwrDir.Text = osOpenDialog1.FileName;
            }

            osOpenDialog1.Dispose();
        }

        /*
        private void comboApi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtApi.Enabled = (comboApi.SelectedIndex != 0);

            string strKey = String.Empty;

            switch (comboApi.SelectedIndex)
            {
                case 1:
                    strKey = config.DaumSearchKey;
                    break;
            }

            txtApi.Text = strKey;
        }
       
        private delegate void deleLogWrite(string log);

        private void gps_GpggaDataReceived(GpggaDataEventArgs e)
        {
            if (e.IsValidGpsData)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new deleLogWrite(addLog), e.Latitude + ":" + e.Longitude);
                }
                else
                {
                    addLog(e.Latitude + ":" + e.Longitude);
                }
            }
        }

        bool startFlag = false;
         */
    }
}