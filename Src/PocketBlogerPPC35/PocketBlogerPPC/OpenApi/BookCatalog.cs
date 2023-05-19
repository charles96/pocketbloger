using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PocketBlogerPPC.OpenApi
{
    public class BookCatalog
    {
        string bTitle = String.Empty;
        string bAuthor = String.Empty;
        string bDescription = String.Empty;
        string bCategory = String.Empty;
        string blink = String.Empty;
        string bCompany = String.Empty;
        DateTime bPublish;

        string imgSmall = null;
        string imgLarge = null;

        public string Title
        {
            get { return this.bTitle; }
            set { this.bTitle = value; }
        }

        public string Author
        {
            get { return this.bAuthor; }
            set { this.bAuthor = value; }
        }

        public string ImageCoverSmall
        {
            get { return this.imgSmall; }
            set { this.imgSmall = value; }
        }

        public string ImageCoverLarge
        {
            get { return this.imgLarge; }
            set { this.imgLarge = value; }
        }

        public string Company
        {
            get { return this.bCompany; }
            set { this.bCompany = value; }
        }

        public string Url
        {
            get { return this.blink; }
            set { this.blink = value; }
        }

        public string Description
        {
            get { return this.bDescription; }
            set { this.bDescription = value; }
        }

        public DateTime Publication
        {
            get { return this.bPublish; }
            set { this.bPublish = value; }
        }

        public string Category
        {
            get { return this.bCategory; }
            set { this.bCategory = value; }
        }
    }
}
