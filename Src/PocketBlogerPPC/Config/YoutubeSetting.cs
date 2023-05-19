using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PocketBlogerPPC.Config
{
    public class YoutubeSetting
    {
        bool skip = false;
        string username = String.Empty;
        string password = String.Empty;

        [XmlAttribute("username")]
        public string UserName
        {
            get { return this.username; }
            set { this.username = value; }
        }

        [XmlAttribute("password")]
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        [XmlAttribute("IsSkip")]
        public bool IsSkip
        {
            get { return this.skip; }
            set { this.skip = value; }
        }
    }
}
