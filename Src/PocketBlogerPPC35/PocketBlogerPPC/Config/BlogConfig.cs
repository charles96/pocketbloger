using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace PocketBlogerPPC.Config
{

    [Serializable]
    [XmlRoot("Config")]
    public class BlogConfig
    {
        ProgramSetting program;
        ApiSetting api;
        BlogInfo bInfo;

        [XmlElement("program")]
        public ProgramSetting Program
        {
            get { return this.program; }
            set { this.program = value; }
        }

        [XmlElement("blogInfo")]
        public BlogInfo BlogInformation
        {
            get { return this.bInfo; }
            set { this.bInfo = value; }
        }

        [XmlElement("api")]
        public ApiSetting Api
        {
            get { return this.api; }
            set { this.api = value; }
        }
    }

    public class AppConfig
    {
        string phyPath = String.Empty;
        XmlSerializer serializer = null;
        BlogConfig config = null;
        FileInfo confile = null;

        public AppConfig()
        {
            phyPath = String.Format("{0}/config.xml", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName));
            serializer = new XmlSerializer(typeof(BlogConfig));
            confile = new FileInfo(phyPath);
        }

        public bool Read()
        {
            bool rtnValue = false;

            if (confile.Exists)
            {
                using (Stream stream = new FileStream(phyPath, FileMode.Open, FileAccess.Read))
                {
                    this.config = (BlogConfig)serializer.Deserialize(stream);
                    stream.Close();
                }

                rtnValue = true;
            }
            else
            {
                FormSetting form = new FormSetting();
                form.Default = 0;
                form.IsMaximumSize = false;
                form.TextBoxWidth = 290;

                #region 업로드 초기화
                YoutubeSetting youtube = new YoutubeSetting();
                youtube.UserName = "";
                youtube.Password = "";
                youtube.IsSkip = false;

                ImageSetting img = new ImageSetting();
                img.ImageWidth = 500;
                img.ImageHeight = 300;

                UploadSetting upload = new UploadSetting();
                upload.Image = img;
                upload.Youtube = youtube;
                #endregion

                ProgramSetting program = new ProgramSetting();
                program.Form = form;
                program.Upload = upload;

                #region API 초기화
                
                ApiItem apiItem = new ApiItem();
                apiItem.ServiceName = "daum 검색 api";
                apiItem.ApiKey = "2247a2cce8ea81be204f106dafcd6af84908738d";

                ApiItem naverItem = new ApiItem();
                naverItem.ServiceName = "Naver API";
                naverItem.ApiKey = "5e8d913ccc7c24efe568ae6f8f7e5d4b";

                ApiSetting api = new ApiSetting();
                api.Item.Add(apiItem);
                api.Item.Add(naverItem);
                #endregion
                
                BlogInfo bloginfo = new BlogInfo();
                bloginfo.BlogItem = new List<BlogAccount>();

                this.config = new PocketBlogerPPC.Config.BlogConfig();
                this.config.Program = program;
                this.config.BlogInformation = bloginfo;
                this.config.Api = api;
                
                rtnValue = false;
            }

            return rtnValue;
        }

        public void Save()
        {
            TextWriter writer = new StreamWriter(phyPath);
            serializer.Serialize(writer, this.config);
            writer.Close();
        }

        public BlogConfig Setting
        {
            get { return this.config; }
        }
    }
}
