using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PocketBlogerPPC.Config
{
    public class BlogInfo
    {
        List<BlogAccount> bItem;

        [XmlElement("bitem")]
        public List<BlogAccount> BlogItem
        {
            get { return this.bItem; }
            set { this.bItem = value; }
        }
    }

    public class BlogAccount
    {
        int idx;
        string apikey = String.Empty;
        string userid = String.Empty;
        string pass = String.Empty;
        string url = String.Empty;
        string title = String.Empty;

        [XmlAttribute("Idx")]
        public int Index
        {
            get { return this.idx; }
            set { this.idx = value; }
        }

        [XmlAttribute("Key")]
        public string Apikey
        {
            get { return this.apikey; }
            set { this.apikey = value; }
        }

        [XmlAttribute("id")]
        public string ID
        {
            get { return this.userid; }
            set { this.userid = value; }
        }

        [XmlAttribute("password")]
        public string Password
        {
            get { return this.pass; }
            set { this.pass = value; }
        }

        [XmlAttribute("url")]
        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }

        [XmlAttribute("Title")]
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
    }
}
