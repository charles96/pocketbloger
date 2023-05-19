using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using blogengineCf;
using Microsoft.WindowsMobile.Forms;
using System.Xml;
using System.Threading;
using System.Collections;
using PocketBlogerPPC.Config;
using PocketBlogerPPC.Gps;

namespace PocketBlogerPPC
{
    public partial class frmWrite : Form
    {
        MetaWebLogApi metalog = null;
        frmMain main = null;
        XmlDocument xDoc = null;
        FileInfo tagFile = null;
        XmlNodeList xTag = null;
        AppConfig config = null;
        LoadMetaData loadMeta = null;
       
        #region 수정관련 변수
        bool editFlag = false;
        string editIndex = String.Empty;
        string[] editCateName = null;
        int editItemIndex = 0;
        DateTime editDate;
        #endregion

        #region GPS 관련 변수
        PocketBlogerPPC.Gps.Gps gps = null;
        GpsDeviceState deviceState = null;
        double longitude = 0;
        double latitude = 0;
        #endregion

        string filename = String.Empty;
        string pathProgram = String.Empty;
        string cateName = String.Empty;

        string youtubename = String.Empty;
        string youtubepass = String.Empty;

        delegate void delegateUpload(string filename);
        delegate void delegateDialog(string title, string content, bool visible);
        delegate void delegateDialogTimer(string title, string content, int interval);
        delegate void delegeteGpsState(GpsDeviceState e);
        delegate void delegeteGps(GpsPosition gpsInfo);
        delegate void SetPostCallBack(BlogPost post);
        delegate void SetCategoryCallBack(List<BlogCategory> categoryList);

        public frmWrite(AppConfig conf)
        {
            InitializeComponent();
            this.config = conf;
            InitGps();
        }

        public frmWrite(frmMain mainform, MetaWebLogApi curMetaLog,AppConfig conf)
        {
            InitializeComponent();
            InitWrite(mainform, curMetaLog);
            this.config = conf;
            InitGps();
            this.editFlag = false;
        }

        public frmWrite(frmMain mainform, MetaWebLogApi curMetaLog, string conIdx, int itemIndex, AppConfig conf)
        {
            InitializeComponent();
            InitWrite(mainform, curMetaLog);
            this.config = conf;
            this.editFlag = true;
            this.editIndex = conIdx;
            this.editItemIndex = itemIndex;
            menuSignature.Checked = false;
            InitGps();
        }

        private void InitGps()
        {
            gps = new PocketBlogerPPC.Gps.Gps();
            gps.DeviceStateChanged += new DeviceStateChangedEventHandler(gps_DeviceStateChanged);
            gps.LocationChanged += new LocationChangedEventHandler(gps_LocationChanged);
        }

        private void frmWrite_Load(object sender, EventArgs e)
        {

            lblGpsStateDescription.Text = "위성으로 부터 현재 정보를 획득했습니다\r\n추가기능->첨부->서명->위치서명기능을 사용할 수 있습니다";
            lblGpsStateDescription.Visible = false;

            GetGpsInfo();

            int textboxWidth = config.Setting.Program.Form.TextBoxWidth;

            txtTitle.Size = new System.Drawing.Size(textboxWidth, 21);
            //txtContent.Size = new System.Drawing.Size(textboxWidth, 145);

            txtTitle.Focus();

            try
            {
                if (this.editFlag)
                {
                    LoadingContent();
                    LoadingCategory();
                    loadMeta.GetPost(this.editIndex);
                }
                else
                {
                    LoadingCategory();
                    loadMeta.GetCategories();
                }

                LoadHtml();
                menuBook.Enabled = (!String.IsNullOrEmpty(config.Setting.Api.Item[0].ApiKey));
            }
            catch (Exception)
            {
                MessageBox.Show("정보를 읽어오는데 실패했습니다!\r\n인터넷 연결을 확인해주세요.", "알림");
                this.Close();
            }
        }

        private void btnGps_Click(object sender, EventArgs e)
        {
            Sound sound = new Sound("");
            sound.Play();

            GetGpsInfo();
        }

        private void GetGpsInfo()
        {
            try
            {
                gps.Open();

                deviceState = gps.GetDeviceState();
                GpsPosition gpsPos = gps.GetPosition();

                if (String.IsNullOrEmpty(deviceState.FriendlyName))
                {
                    lblGpsChipName.Text = "GPS 비활성화";
                }
                else
                {
                    lblGpsChipName.Text = deviceState.FriendlyName;
                }

                if (gpsPos.LatitudeValid && gpsPos.LongitudeValid && gpsPos.SatelliteCountValid)
                {
                    this.latitude = gpsPos.Latitude;
                    this.longitude = gpsPos.Longitude;

                    lblSatelliteCount.Text = String.Format("감지된 위성 수 : {0}", gpsPos.SatelliteCount);
                    lblLatitude.Text = String.Format("위도: {0}", this.latitude);
                    lblLongitude.Text = String.Format("경도: {0}", this.longitude);

                    if ((this.latitude > 0) && (this.longitude > 0))
                    {
                        lblGpsStateDescription.Visible = true;
                        menuGpsSign.Enabled = true;
                    }
                }

                gps.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("GPS정보를 읽어오는데 문제가 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (gps.Opened) gps.Close();
            }
        }

        private void gps_DeviceStateChanged(object sender, DeviceStateChangedEventArgs e)
        {
            GpsDeviceState state = e.DeviceState;
           
            if (this.InvokeRequired)
            {
                this.Invoke(new delegeteGpsState(GpsState), state);
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
                    btnGps.Text = "GPS 꺼짐";
                    btnGps.Enabled = false;
                    break;
                case GpsServiceState.On:
                    btnGps.Text = "수신대기";
                    btnGps.Enabled = true;
                    break;
                case GpsServiceState.ShuttingDown:
                    btnGps.Text = "셧다운 중.";
                    btnGps.Enabled = false;
                    break;
                case GpsServiceState.StartingUp:
                    btnGps.Text = "활성중..";
                    btnGps.Enabled = false;
                    break;
                case GpsServiceState.Uninitialized:
                    btnGps.Text = "";
                    btnGps.Enabled = false;
                    break;
                case GpsServiceState.Unknown:
                    btnGps.Text = "알수없음";
                    btnGps.Enabled = false;
                    break;
                case GpsServiceState.Unloading:
                    btnGps.Text = "해제중..";
                    btnGps.Enabled = false;
                    break;
            }
        }
   
        private void gps_LocationChanged(object sender, LocationChangedEventArgs e)
        {
            GpsPosition position = e.Position;
         
            if ((position.Longitude > 0) && (position.Latitude > 0))
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new delegeteGps(NotificationGpsDetect), position);
                }
                else
                {
                    NotificationGpsDetect(position);
                }
            }
        }

        private void NotificationGpsDetect(GpsPosition gpsPos)
        {
            if (gpsPos.SatelliteCountValid) lblSatelliteCount.Text = String.Format("감지된 위성 수 : {0}", gpsPos.SatelliteCount);

            if ((gpsPos.LatitudeValid) && (gpsPos.LongitudeValid))
            {
                this.latitude = gpsPos.Latitude;
                this.longitude = gpsPos.Longitude;

                lblLatitude.Text = String.Format("위도: {0}",this.latitude);
                lblLongitude.Text = String.Format("경도: {0}", this.longitude);

                lblGpsStateDescription.Visible = true;
                menuGpsSign.Enabled = true;
            }
        }

        private void LoadingContent()
        {
            txtContent.Text = "로딩 중..";
            txtTitle.Text = "로딩 중..";
        }

        private void LoadingCategory()
        {
            comCategory.Items.Add("로딩 중..");
            comCategory.SelectedIndex = 0;
        }

        private void InitWrite(frmMain mainform, MetaWebLogApi curMetaLog)
        {
            metalog = curMetaLog;

            loadMeta = new LoadMetaData(metalog);
            loadMeta.GetDataResult += new DataResultHandler(loadMeta_GetDataResult);

            main = mainform;

            xDoc = new XmlDocument();
            pathProgram = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);

            string phyPath = String.Format("{0}/tags.xml", pathProgram);
            tagFile = new FileInfo(phyPath);

            if (tagFile.Exists)
            {
                xDoc.Load(phyPath);
                xTag = xDoc.GetElementsByTagName("item");
            }
        }

        private void loadMeta_GetDataResult(ResultEventArgs e)
        {
            switch (e.CommandType)
            { 
                case MetaWebLogCommandType.getPost:
                    SetPost(e.GetPostResult);
                    break;
                case MetaWebLogCommandType.getCategories:
                    SetCategoryList(e.CategoryResult);
                    break;
            }
        }

        private void SetPost(BlogPost post)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new SetPostCallBack(SetPost), post);
                }
                else
                {
                    if (post != null)
                    {
                        txtTitle.Text = post.Title;
                        txtContent.Text = post.Description;
                        this.editCateName = post.Categories;

                        switch (post.Publish)
                        {
                            case true:
                                rdoOpen.Checked = true;
                                break;
                            case false:
                                rdoNotOpen.Checked = true;
                                break;
                        }

                        this.editDate = CheckDateTime(post.DateCreated);

                        loadMeta.GetCategories();
                    }
                    else
                    {
                        MessageBox.Show("데이터를 가져오지 못했습니다\r\n인터넷 연결상태를 확인하세요!", "알림");
                        this.Close();
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                this.Close();
            }
        }

        private void SetCategoryList(List<BlogCategory> catelist)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new SetCategoryCallBack(SetCategoryList), catelist);
                }
                else
                {
                    int count = 1;
                    int setCount = 0;

                    comCategory.Items.Clear();

                    ArrayList arrCategory = new ArrayList();
                    arrCategory.Add(new ItemInfo("카테고리를 선택하세요", "카테고리를 선택하세요"));

                    if (catelist != null)
                    {
                        foreach (BlogCategory cate in catelist)
                        {
                            arrCategory.Add(new ItemInfo(cate.Title, cate.Title));

                            #region 글 변경을 선택 시 현재글의 카테고리를 자동 선택
                            if (editCateName != null)
                            {
                                foreach (string cateitem in editCateName)
                                {
                                    if (cateitem == cate.Title)
                                    {
                                        setCount = count;
                                    }
                                }
                            }
                            #endregion

                            count++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("데이터를 가져오지 못했습니다\r\n인터넷 연결상태를 확인하세요!", "알림");
                    }

                    comCategory.DataSource = arrCategory;
                    comCategory.DisplayMember = "Name";
                    comCategory.ValueMember = "Value";
                    comCategory.SelectedIndex = setCount;
                }
            }
            catch (ObjectDisposedException)
            {
                this.Close();
            }
        }

        private DateTime CheckDateTime(string datetime)
        {
            DateTime rtnDateTime;

            try
            {
                rtnDateTime = Convert.ToDateTime(datetime);
            }
            catch
            {
                rtnDateTime = DateTime.Now;
            }

            return rtnDateTime;
        }

         /// <summary>
        /// 태그 로드
        /// </summary>
        private void LoadHtml()
        {
            if (xTag.Count > 0)
            {
                foreach (XmlNode tagNode in xTag)
                {
                    MenuItem menuTagItem = new MenuItem();
                    menuTagItem.Click += new EventHandler(menuTagItem_Click);
                    menuTagItem.Text = tagNode.Attributes[0].Value;
                    menuHtml.MenuItems.Add(menuTagItem);
                }
            }
        }

        private void menuTagItem_Click(object sender, EventArgs e)
        {
            MenuItem selectItem = (MenuItem)sender;

            foreach (XmlNode tagNode in xTag)
            {
                if (tagNode.Attributes[0].Value == selectItem.Text)
                {
                    txtContent.Text = txtContent.Text + tagNode.ChildNodes[0].InnerText;
                    break;
                }
            }
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        public void WriteContent(string Tag)
        {
            txtContent.Text = txtContent.Text + Tag;
        }

        private void imgUpload_UploadState(UploadStateEventArgs e)
        {
            switch (e.State)
            {
                case UploadStates.Start:
                    MentBoxShowDialog("알 림", "이미지를 올리고 있습니다\r\n잠시만 기다려 주세요..", true);
                    break;
                case UploadStates.Failed:
                    MessageBox.Show("업로드가 실패 되었습니다.\r\n인터넷 연결 상태를 확인해주세요..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    break;
                case UploadStates.OutOfMemoryException:
                    MessageBox.Show("업로드가 실패했습니다.\r\n주 메모리의 여유공간을 확보해주세요..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    break;
                case UploadStates.Successed:

                    #region 이미지 사이즈
                    int fixImageSize = config.Setting.Program.Upload.Image.ImageWidth; //이미지 긴축 고정 사이즈
                  
                    int imgWidth = e.ImageWidth;
                    int imgHeight = e.ImageHeight;

                    int setW, setH;

                    if (imgWidth > imgHeight) //이미지 가로 사이즈가 클 경우
                    {
                        setW = fixImageSize;
                        setH = (imgHeight * fixImageSize) / imgWidth;
                    }
                    else //세로 사이즈가 클경우
                    {
                        setW = (imgWidth * fixImageSize) / imgHeight;
                        setH = fixImageSize;
                    }
                    #endregion

                    MentBoxShowDialog("알 림", "업로드가 실패 되었습니다.\r\n서버 문제인지 확인해주세요..", false);

                    string imgTag = String.Format("<img src='{0}' width='{1}' height='{2}' border='0'/>", e.ContentUrl, setW, setH);

                    if (txtContent.InvokeRequired)
                    {
                        this.Invoke(new delegateUpload(WriteContent), imgTag);
                    }
                    else
                    {
                        WriteContent(imgTag);
                    }
                    break;
            }
        }

        private void movieUpload_UploadState(UploadStateEventArgs e)
        {
            switch (e.State)
            {
                case UploadStates.Start:
                    MentBoxShowDialog("알 림", "동영상을 올리고 있습니다\r\n잠시만 기다려 주세요..", true);
                    break;
                case UploadStates.Failed:
                    MessageBox.Show("업로드가 실패 되었습니다.\r\n인터넷 연결 상태를 확인해주세요..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    break;
                case UploadStates.OutOfMemoryException:
                    MessageBox.Show("업로드가 실패했습니다.\r\n주 메모리의 여유공간을 확보해주세요..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    break;
                case UploadStates.Successed:

                    MentBoxShowDialog("알 림", "업로드가 실패 되었습니다.\r\n서버 문제인지 확인해주세요..", false);
                    
                    if (txtContent.InvokeRequired)
                    {
                        this.Invoke(new delegateUpload(WriteContent), HtmlTag.Youtube(e.ContentUrl.ToString()));
                    }
                    else
                    {
                        WriteContent(HtmlTag.Youtube(e.ContentUrl.ToString()));
                    }

                    YoutubeSetting youtube = config.Setting.Program.Upload.Youtube;

                    if (String.IsNullOrEmpty(youtube.UserName))
                    {
                        youtube.UserName = youtubename;
                        youtube.Password = youtubepass;

                        config.Setting.Program.Upload.Youtube = youtube;
                        config.Save();
                    }

                    break;
            }
        }


        private void menuLocalPic_Click(object sender, EventArgs e)
        {
            using (SelectPictureDialog picDialog = new SelectPictureDialog())
            {
                DirectoryInfo imageFolder = new DirectoryInfo(pathProgram + "\\Images\\");
                
                if (!imageFolder.Exists)
                {
                    imageFolder.Create();
                }

                picDialog.Filter = "Jpeg Files|*.jpg|Gif Files|*.gif|Png Files|*.png";
                picDialog.InitialDirectory = imageFolder.FullName;

                if (picDialog.ShowDialog() == DialogResult.OK)
                {
                    tabWrite.SelectedIndex = 0;
                    filename = picDialog.FileName;
                   
                    ImageUploader imgUpload = new ImageUploader(metalog, filename);
                    imgUpload.UploadState += new UploadStateHandler(imgUpload_UploadState);
                    
                    Thread threadUploadPic = new Thread(new ThreadStart(imgUpload.Upload));
                    threadUploadPic.IsBackground = true;
                    threadUploadPic.Start();
                }
            }
        }

        private void menuShootPic_Click(object sender, EventArgs e)
        {
            string imagePath = pathProgram + "\\Images\\";
            string imageFileName = String.Format("pb_{0}.jpg", DateTime.Now.ToString("yyyyMMddHHmmss"));

            DirectoryInfo imagefolder = new DirectoryInfo(imagePath);

            if (!imagefolder.Exists)
            {
                imagefolder.Create();
            }

            using (CameraCaptureDialog cameraDialog = new CameraCaptureDialog())
            {
                cameraDialog.Mode = CameraCaptureMode.Still;
                cameraDialog.StillQuality = CameraCaptureStillQuality.Low;
                cameraDialog.DefaultFileName = imageFileName;
                cameraDialog.InitialDirectory = imagePath;
                DialogResult dResult = cameraDialog.ShowDialog();

                if (dResult == DialogResult.OK)
                {
                    tabWrite.SelectedIndex = 0;
                    filename = cameraDialog.FileName;

                    if (!String.IsNullOrEmpty(filename))
                    {
                        ImageUploader imgUpload = new ImageUploader(metalog, filename);
                        imgUpload.UploadState += new UploadStateHandler(imgUpload_UploadState);

                        Thread threadUploadPic = new Thread(new ThreadStart(imgUpload.Upload));
                        threadUploadPic.IsBackground = true;
                        threadUploadPic.Start();
                    }
                }
            }
        }

        private void menuLocalMovie_Click(object sender, EventArgs e)
        {
            string moviePath = pathProgram + "\\Movie\\";
            string resultfile = String.Empty;
            DirectoryInfo moviefolder = new DirectoryInfo(moviePath);

            if (!moviefolder.Exists)
            {
                moviefolder.Create();
            }

            DialogResult dResult;

            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "3gp Files|*.3gp|skm Files|*.skm|Wmv Files|*.wmv|k3g Files|*.k3g|";
                openDialog.InitialDirectory = moviePath;
                dResult = openDialog.ShowDialog();
                resultfile = openDialog.FileName;
            }

            if ((dResult == DialogResult.OK) && (!String.IsNullOrEmpty(resultfile)))
            {
                YoutubeSetting youtubeSet = config.Setting.Program.Upload.Youtube;

                if (youtubeSet.IsSkip)
                {
                    UploadMovie("PocketBlogerUpload" + DateTime.Now.ToString("yyyy-MM-dd"), "PocketBlogerUpload", resultfile, youtubeSet.UserName, youtubeSet.Password);
                }
                else
                {
                    using (frmMovie movieForm = new frmMovie(this.config))
                    {
                        dResult = movieForm.ShowDialog();

                        if (dResult == DialogResult.OK)
                        {
                            tabWrite.SelectedIndex = 0;

                            youtubename = movieForm.Username;
                            youtubepass = movieForm.Password;

                            UploadMovie(movieForm.Title, movieForm.Content, resultfile, youtubename, youtubepass);
                        }
                    }
                }
            }
        }

        private void UploadMovie(string title, string content,string filename,string loginId,string loginPass)
        {
            MovieUploader movieUpload = new MovieUploader(title, content, filename, loginId, loginPass);
            movieUpload.UploadState += new UploadStateHandler(movieUpload_UploadState);

            Thread threadmovUp = new Thread(new ThreadStart(movieUpload.Upload));
            threadmovUp.Start();
        }

        private void menuShootMovie_Click(object sender, EventArgs e)
        {
            string movieFileName = String.Format("pb_{0}.skm", DateTime.Now.ToString("yyyyMMddHHmmss"));
            string moviePath = pathProgram + "\\Movie\\";
            string resultfile = String.Empty;
            DirectoryInfo moviefolder = new DirectoryInfo(moviePath);

            if (!moviefolder.Exists)
            {
                moviefolder.Create();
            }
            
            DialogResult dResult;

            using (CameraCaptureDialog camera = new CameraCaptureDialog())
            {
                camera.VideoTypes = CameraCaptureVideoTypes.All;
                camera.Mode = CameraCaptureMode.VideoWithAudio;
                camera.InitialDirectory = moviePath;
                camera.DefaultFileName = movieFileName;

                dResult = camera.ShowDialog();
                resultfile = camera.FileName;
            }

            if ((dResult == DialogResult.OK) && (!String.IsNullOrEmpty(resultfile)))
            {
                using (frmMovie movieForm = new frmMovie(this.config))
                {
                    dResult = movieForm.ShowDialog();
                    
                    if (dResult == DialogResult.OK)
                    {
                        tabWrite.SelectedIndex = 0;

                        youtubename = movieForm.Username;
                        youtubepass = movieForm.Password;

                        MovieUploader movieUpload = new MovieUploader(movieForm.Title, movieForm.Content, resultfile, youtubename, youtubepass);
                        movieUpload.UploadState += new UploadStateHandler(movieUpload_UploadState);
                        
                        Thread threadmovUp = new Thread(new ThreadStart(movieUpload.Upload));
                        threadmovUp.Start();
                    }
                }
            }
        }

        private void MentBoxShow(string title, string ment, bool visible)
        {
            mentBox.ProgressBar.Visible = false;

            switch (visible)
            {
                case true:
                    mentBox.Show(title, ment);
                    break;
                case false:
                    mentBox.Close();
                    break;
            }
        }

        private void MentBoxShowDialog(string caption, string ment, bool visible)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delegateDialog(MentBoxShow), caption, ment, visible);
            }
            else
            {
                MentBoxShow(caption, ment, visible);
            }
        }

        private void MentBoxShowDialog(string caption, string ment, int interval)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delegateDialogTimer(MentBoxTimer), caption, ment, interval);
            }
            else
            {
                MentBoxTimer(caption, ment, interval);
            }
        }

        private void MentBoxTimer(string title, string ment, int interval)
        {
            mentBox.ProgressBar.Visible = false;
            mentBox.Show(title, ment, interval);
        }

        private string AddSign(string body)
        {
            string signBegin = "<br/><DIV style='CLEAR: both; BORDER-RIGHT: #eeeeee 1px solid; PADDING-RIGHT: 10px; BORDER-TOP: #eeeeee 1px solid; PADDING-LEFT: 10px; PADDING-BOTTOM: 10px; MARGIN: 5px 0px 0px; BORDER-LEFT: #eeeeee 1px solid; WIDTH: 95%; PADDING-TOP: 10px; BORDER-BOTTOM: #eeeeee 1px solid'><center>";
            string signEnd = "</center></DIV>";

            string signMent = config.Setting.Program.Signature.Replace("&lt;", "<").Replace("&gt;", ">");

            if (menuSignature.Checked)
            {
                body = body + signBegin + signMent + signEnd;
            }
            else if (menuGpsSign.Checked)
            {
                body = body + signBegin + HtmlTag.GoogleMap(this.latitude.ToString(), this.longitude.ToString()) + "<br/>" + signMent + signEnd;
            }

            return body;
        }

        private void menuWrite_Click(object sender, EventArgs e)
        {
            tabWrite.SelectedIndex = 0;
            mentBox.ProgressBar.Visible = false;

            if (txtTitle.Text.Length <= 0)
            {
                mentBox.Show("알림", "제목을 입력 해 주세요!", 3000);
                txtTitle.Focus();
            }
            else if (txtContent.Text.Length <= 0)
            {
                mentBox.Show("알림", "내용을 입력 해 주세요!", 3000);
                txtContent.Focus();
            }
            else
            {
                string body = ContentWrap(txtContent.Text);

                if (!this.editFlag)
                {
                    string postIdx = metalog.NewPost(new object[1] { comCategory.Text }, txtTitle.Text, AddSign(body), rdoOpen.Checked);
                    main.AddContent(postIdx, txtTitle.Text);
                }
                else
                {
                    metalog.EditPost(this.editIndex, new object[1] { comCategory.Text }, txtTitle.Text, AddSign(body), rdoOpen.Checked, editDate);
                    main.ModifyContent(this.editItemIndex, txtTitle.Text, rdoOpen.Checked);
                }

                this.Close();
            }
        }

        private string ContentWrap(string body)
        {
            if (chkWrap.Checked)
            {
                body = body.Replace("\r\n", "<br/>");
            }

            return body;
        }

        private void menuBook_Click(object sender, EventArgs e)
        {
            using (frmBookSearch book = new frmBookSearch(this, config.Setting.Api.Item[0].ApiKey))
            {
                book.ShowDialog();
            }

            Application.DoEvents();
        }

        private void menuMovie_Click(object sender, EventArgs e)
        {
            using (frmMoveSearch movieForm = new frmMoveSearch(this, config.Setting.Api.Item[1].ApiKey))
            {
                movieForm.ShowDialog();
            }
        }

        private void tabWrite_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabWrite.SelectedIndex == 3)
            {
                this.Text = String.Format("미리보기 - {0}", txtTitle.Text);
                webBrowser.DocumentText = ContentWrap(txtContent.Text);
            }
            else
            {
                this.Text = "글 쓰기";
            }
        }

        private void menuSignature_Click(object sender, EventArgs e)
        {
            if (menuGpsSign.Checked) menuGpsSign.Checked = false;
            menuSignature.Checked = (!menuSignature.Checked);
        }

        private void menuGpsSign_Click(object sender, EventArgs e)
        {
            if (menuSignature.Checked) menuSignature.Checked = false;
            
            switch (menuGpsSign.Checked)
            { 
                case true:
                    menuGpsSign.Checked = false;
                    break;
                case false:
                    menuGpsSign.Checked = true;
                    break;
            }
        }

        private void frmWrite_Closed(object sender, EventArgs e)
        {
            if (gps.Opened) gps.Close();
        }
    }
}