using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PocketBlogerPPC.Config
{
    public class UploadSetting
    {
        YoutubeSetting youtube;
        ImageSetting image;

        [XmlElement("youtube")]
        public YoutubeSetting Youtube
        {
            get { return this.youtube; }
            set { this.youtube = value; }
        }

        [XmlElement("image")]
        public ImageSetting Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
    }
}
