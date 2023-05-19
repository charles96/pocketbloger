using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PocketBlogerPPC.OpenApi
{
    public class MovieEntity
    {
        string title = String.Empty;
        string subtitle = String.Empty;
        string link = String.Empty;
        string imgUrl = String.Empty;
        string date = String.Empty;
        string director = String.Empty;
        string actor = String.Empty;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string SubTitle
        {
            get { return this.subtitle; }
            set { this.subtitle = value; }
        }

        public string Link
        {
            get { return this.link; }
            set { this.link = value; }
        }

        public string ImageLink
        {
            get { return this.imgUrl; }
            set { this.imgUrl = value; }
        }

        public string ReleaseDate
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Director
        {
            get { return this.director; }
            set { this.director = value; }
        }

        public string Actor
        {
            get { return this.actor; }
            set { this.actor = value; }
        }
    }
}
