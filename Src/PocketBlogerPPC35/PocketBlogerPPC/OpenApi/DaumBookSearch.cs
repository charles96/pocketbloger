using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PocketBlogerPPC.OpenApi
{
    public class DaumBookSearch
    {
        XmlDocument xDoc = null;
        XmlNodeList xbookList = null;
        List<BookCatalog> booklist = null;
        BookCatalog bookInfo = null;
        string aKey = String.Empty;

        public DaumBookSearch(string apikey)
        {
            aKey = apikey;
            xDoc = new XmlDocument();
        }

        public List<BookCatalog> Query(string query)
        {
            string queryUri = String.Format("http://apis.daum.net/search/book?apikey={0}&q={1}", aKey, query);
            return ReadXml(queryUri);
        }

        private List<BookCatalog> ReadXml(string queryUri)
        {
            booklist = new List<BookCatalog>();

            try
            {
                xDoc.Load(queryUri);
                xbookList = xDoc.GetElementsByTagName("item");

                foreach (XmlNode xitem in xbookList)
                {
                    if (xitem.ChildNodes.Count > 0)
                    {
                        bookInfo = new BookCatalog();

                        for (int count = 0; count < xitem.ChildNodes.Count; count++)
                        {
                            string value = xitem.ChildNodes[count].InnerText;

                            switch (xitem.ChildNodes[count].LocalName.Trim().ToUpper())
                            {
                                case "TITLE":
                                    bookInfo.Title = value.Replace("<B>", "").Replace("</B>", "");
                                    break;
                                case "COVER_S_URL":
                                    bookInfo.ImageCoverSmall = value;
                                    break;
                                case "COVER_L_URL":
                                    bookInfo.ImageCoverLarge = value;
                                    break;
                                case "DESCRIPTION":
                                    bookInfo.Description = value;
                                    break;
                                case "AUTHOR":
                                    bookInfo.Author = value.Replace("<B>", "").Replace("</B>", "");
                                    break;
                                case "CATEGORY":
                                    bookInfo.Category = value;
                                    break;
                                case "LINK":
                                    bookInfo.Url = value;
                                    break;
                                case "PUB_NM":
                                    bookInfo.Company = value;
                                    break;
                            }
                        }

                        booklist.Add(bookInfo);
                    }
                }
            }
            catch (Exception)
            {
                booklist = null;
            }

            return booklist;
        }
    }
}
