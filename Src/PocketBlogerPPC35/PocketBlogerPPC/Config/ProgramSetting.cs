using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace PocketBlogerPPC.Config
{
    public class ProgramSetting
    {
        FormSetting form;
        UploadSetting upload;
       
        string signature = "현재 게시글은 휴대폰에서 <A href='http://www.waifcat.com'style='FONT-WEIGHT: bold; FONT-SIZE: 12px' target=_blank>Pocket Bloger</A>를 통해 작성 되었습니다.";
        string exbrowser = String.Empty;

        [XmlElement("form")]
        public FormSetting Form
        {
            get { return this.form; }
            set { this.form = value; }
        }

        [XmlElement("upload")]
        public UploadSetting Upload
        {
            get { return this.upload; }
            set { this.upload = value; }
        }

        [XmlElement("signature")]
        public string Signature
        {
            get { return this.signature; }
            set { this.signature = value; }
        }

        [XmlElement("exBrowser")]
        public string ExternalBrowserDir
        {
            get { return this.exbrowser; }
            set { this.exbrowser = value; }
        }
    }
}
