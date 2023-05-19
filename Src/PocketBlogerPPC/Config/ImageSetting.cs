using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PocketBlogerPPC.Config
{
    public class ImageSetting
    {
        int imgW = 500;
        int imgH = 350;

        [XmlAttribute("width")]
        public int ImageWidth
        {
            get { return this.imgW; }
            set { this.imgW = value; }
        }

        [XmlAttribute("height")]
        public int ImageHeight
        {
            get { return this.imgH; }
            set { this.imgH = value; }
        }
    }
}
