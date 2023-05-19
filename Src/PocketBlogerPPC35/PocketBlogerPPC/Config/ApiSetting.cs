using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace PocketBlogerPPC.Config
{

    public class ApiSetting
    {
        List<ApiItem> apilist = null;

        public ApiSetting()
        {
            apilist = new List<ApiItem>();
        }

        [XmlElement("ApiItem")]
        public List<ApiItem> Item
        {
            get { return this.apilist; }
            set { this.apilist = value; }
        }
    }

    public class ApiItem
    {
        string name = String.Empty;
        string key = String.Empty;

        [XmlAttribute("ServiceName")]
        public string ServiceName
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [XmlAttribute("ApiKey")]
        public string ApiKey
        {
            get { return this.key; }
            set { this.key = value; }
        }
    }
}
