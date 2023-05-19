using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBlogerPPC
{
    public class HtmlTag
    {
        public static string GoogleMap(string latitude, string longitude)
        {
            string tag = String.Format("<a href='http://maps.google.com/?ie=UTF8&ll={0},{1}&t=h&z=15'><img src='http://maps.google.com/staticmap?center={0},{1}&amp;zoom=15&amp;size=350x100&amp;maptype=satellite&amp;markers={0},{1}&amp;key=ABQIAAAAx-GAeOugDxDLnv0QuXiZTxQVW7GeWYQB8PfQEVfiBdBrAb6JtxSmprmR0drWAH6tncGe3Jro-0b3kw&amp;sensor=false' border='0' /></a>", latitude, longitude);
           
            StringBuilder mTag = new StringBuilder();
            mTag.Append("이 글을 포스팅 위치 <br/>");
            mTag.Append(tag);

            return mTag.ToString();
        }

        public static string Youtube(string movieUri)
        {
            StringBuilder mTag = new StringBuilder();
            mTag.Append("<!---동영상 시작-->");
            mTag.Append(String.Format("<object width='425' height='350'><param name='movie' value='{0}'></param>", movieUri));
            mTag.Append(String.Format("<embed src='{0}' type='application/x-shockwave-flash' width='425' height='350'></embed></object>", movieUri));
            mTag.Append("<!---동영상 끝-->");
            return mTag.ToString();
        }

        public static string Movie(string title,string subTitle,string director,string actor,string date,string imgUrl)
        {
            string mtitle = title + "(" + subTitle + ")";

            StringBuilder tag = new StringBuilder();
            tag.Append("<DIV id=daum_book style='CLEAR: both; BORDER-RIGHT: #eeeeee 1px solid; PADDING-RIGHT: 10px; BORDER-TOP: #eeeeee 1px solid; PADDING-LEFT: 10px; PADDING-BOTTOM: 10px; MARGIN: 5px 0px 0px; BORDER-LEFT: #eeeeee 1px solid; WIDTH: 94%; PADDING-TOP: 10px; BORDER-BOTTOM: #eeeeee 1px solid'>");

            if (!String.IsNullOrEmpty(imgUrl))
            {
                tag.Append(String.Format("<IMG id=p_cover style='BORDER-RIGHT: #ddd 0px solid; BORDER-TOP: #ddd 0px solid; FLOAT: left; BORDER-LEFT: #ddd 0px solid; MARGIN-RIGHT: 10px; BORDER-BOTTOM: #ddd 0px solid; HEIGHT: 99px' src='{0}'>", imgUrl));
            }

            tag.Append(String.Format("<A id=p_title style='FONT-WEIGHT: bold; FONT-SIZE: 12px' target=_blank>{0}</A>", mtitle));
            tag.Append(String.Format("<DIV id=p_author_area style='MARGIN-BOTTOM: 8px'>감독 <SPAN id=p_author>{0}</SPAN> </DIV>", director));
            tag.Append(String.Format("<DIV id=p_author_area style='MARGIN-BOTTOM: 8px'>배우 <SPAN id=p_publish>{0}</SPAN> </DIV>", actor));
            tag.Append(String.Format("<DIV id=p_author_area style='MARGIN-BOTTOM: 8px'>제작년도 <SPAN id=p_author>{0}</SPAN></DIV></DIV>", date));
            
            return tag.ToString();
        }

        public static string Book(string title, string description, string author, string coverImgUrl, string company)
        {
            StringBuilder tag = new StringBuilder();
            tag.Append("<DIV id=daum_book style='CLEAR: both; BORDER-RIGHT: #eeeeee 1px solid; PADDING-RIGHT: 10px; BORDER-TOP: #eeeeee 1px solid; PADDING-LEFT: 10px; PADDING-BOTTOM: 10px; MARGIN: 5px 0px 0px; BORDER-LEFT: #eeeeee 1px solid; WIDTH: 94%; PADDING-TOP: 10px; BORDER-BOTTOM: #eeeeee 1px solid'>");

            if (!String.IsNullOrEmpty(coverImgUrl))
            {
                tag.Append(String.Format("<IMG id=p_cover style='BORDER-RIGHT: #ddd 0px solid; BORDER-TOP: #ddd 0px solid; FLOAT: left; BORDER-LEFT: #ddd 0px solid; MARGIN-RIGHT: 10px; BORDER-BOTTOM: #ddd 0px solid; HEIGHT: 99px' src='{0}'>", coverImgUrl));
            }

            tag.Append(String.Format("<A id=p_title style='FONT-WEIGHT: bold; FONT-SIZE: 12px' target=_blank>{0}</A>", title));
            tag.Append(String.Format("<DIV id=p_author_area style='MARGIN-BOTTOM: 8px'><SPAN id=p_author>{0}</SPAN> 지음 | <SPAN id=p_publish>{1}</SPAN> 펴냄 </DIV>", author, company));
            tag.Append(String.Format("<DIV style='OVERFLOW: hidden; HEIGHT: 52px'><SPAN id=p_description style='MARGIN: 2px; FONT: 12px/1.5 Dotum, Sans-Serif'>{0}</SPAN> </DIV></DIV>", description));

            return tag.ToString();
        }

    }
}
