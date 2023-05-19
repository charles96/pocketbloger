using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PocketBlogerPPC.Config
{
    public class FormSetting
    {
        bool maxSize = false;
        int idx = 1;
        int textboxWidth = 291;

        [XmlAttribute("maxSize")]
        public bool IsMaximumSize
        {
            get { return this.maxSize; }
            set { this.maxSize = value; }
        }

        [XmlAttribute("default")]
        public int Default
        {
            get { return this.idx; }
            set { this.idx = value; }
        }

        [XmlAttribute("textboxWidth")]
        public int TextBoxWidth
        {
            get { return this.textboxWidth; }
            set { this.textboxWidth = value; }
        }
    }
}
