using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PocketBlogerPPC.OpenApi
{
    public class MovieSearch
    {
        XmlDocument xDoc = null;
        XmlNodeList xMoveNode = null;
        List<MovieEntity> Movielist = null;
        MovieEntity MovieCatalog = null;
        string aKey = String.Empty;

        public MovieSearch(string apikey)
        {
            aKey = apikey;
            xDoc = new XmlDocument();
        }

        public List<MovieEntity> Query(string query)
        {
            string queryUri = String.Format("http://openapi.naver.com/search?key={0}&query={1}&display=10&start=1&target=movie", aKey, query);
            return ReadXml(queryUri);
        }

        private List<MovieEntity> ReadXml(string queryUri)
        {
            Movielist = new List<MovieEntity>();

            try
            {
                xDoc.Load(queryUri);
                xMoveNode = xDoc.GetElementsByTagName("item");

                foreach (XmlNode xitem in xMoveNode)
                {
                    if (xitem.ChildNodes.Count > 0)
                    {
                        MovieCatalog = new MovieEntity();

                        for (int count = 0; count < xitem.ChildNodes.Count; count++)
                        {
                            string value = xitem.ChildNodes[count].InnerText;

                            switch (xitem.ChildNodes[count].LocalName.Trim().ToUpper())
                            {
                                case "TITLE":
                                    MovieCatalog.Title = value;
                                    break;
                                case "IMAGE":
                                    MovieCatalog.ImageLink = value;
                                    break;
                                case "LINK":
                                    MovieCatalog.Link = value;
                                    break;
                                case "SUBTITLE":
                                    MovieCatalog.SubTitle = value;
                                    break;
                                case "PUBDATE":
                                    MovieCatalog.ReleaseDate = value;
                                    break;
                                case "ACTOR":
                                    MovieCatalog.Actor = FilterString(value);
                                    break;
                                case "DIRECTOR":
                                    MovieCatalog.Director = FilterString(value);
                                    break;
                            }
                        }

                        Movielist.Add(MovieCatalog);
                    }
                }
            }
            catch (Exception)
            {
                Movielist = null;
            }

            return Movielist;
        }

        private string FilterString(string value)
        {
            string rtnvalue = value.Replace("|", ",");
            rtnvalue = rtnvalue.Substring(0, rtnvalue.Length);
            return rtnvalue;
        }
    }
}
