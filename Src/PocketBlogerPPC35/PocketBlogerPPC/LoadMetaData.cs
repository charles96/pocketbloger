using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using blogengineCf;

namespace PocketBlogerPPC
{
    public delegate void DataResultHandler(ResultEventArgs e);

    public class LoadMetaData
    {
        public event DataResultHandler GetDataResult;
        MetaWebLogApi metalog = null;
        ResultEventArgs e = null;

        string idx;

        public LoadMetaData(MetaWebLogApi meta)
        {
            metalog = meta;
        }

        private void OnPostResult(ResultEventArgs e)
        {
            if (GetDataResult != null)
            {
                GetDataResult(e);
            }
        }

        public void GetPost(string index)
        {
            idx = index;
            Thread threadPost = new Thread(new ThreadStart(GetPostInfo));
            threadPost.IsBackground = true;
            threadPost.Start();
        }

        public void GetCategories()
        {
            Thread threadCate = new Thread(new ThreadStart(GetCategoryList));
            threadCate.IsBackground = true;
            threadCate.Start();
        }

        private void GetPostInfo()
        {
            e = new ResultEventArgs();
            e.CommandType = MetaWebLogCommandType.getPost;
            e.GetPostResult = metalog.GetPost(idx);
            OnPostResult(e);
        }

        private void GetCategoryList()
        {
            e = new ResultEventArgs();
            e.CommandType = MetaWebLogCommandType.getCategories;
            e.CategoryResult = metalog.GetCategories();
            OnPostResult(e);
        }
    }

    public class ResultEventArgs : EventArgs
    {
        MetaWebLogCommandType commType;
        BlogPost post = null;
        List<BlogCategory> category = null;

        public MetaWebLogCommandType CommandType
        {
            get { return commType; }
            set { commType = value; }
        }

        public BlogPost GetPostResult
        {
            get { return post; }
            set { post = value; }
        }

        public List<BlogCategory> CategoryResult
        {
            get { return category; }
            set { category = value; }
        }
    }
}
