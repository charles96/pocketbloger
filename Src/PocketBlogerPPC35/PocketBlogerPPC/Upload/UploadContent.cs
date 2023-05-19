using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using blogengineCf;
using Google.GData.Client;
using Google.GData.YouTube;
using Google.GData.Extensions.MediaRss;
using System.Runtime.InteropServices;


namespace PocketBlogerPPC
{
    public delegate void UploadStateHandler(UploadStateEventArgs e);

    public abstract class UploadContent
    {
        public event UploadStateHandler UploadState;

        protected void OnState(UploadStateEventArgs e)
        {
            if (UploadState != null)
            {
                UploadState(e);
            }
        }

        public abstract void Upload();

    }

    public class MovieUploader : UploadContent
    {
        string movieTitle = String.Empty;
        string movieContent = String.Empty;
        string movieFileName = String.Empty;
        
        YouTubeService service = null;

        public MovieUploader(string title,string content,string filename,string username,string password)
        {
            movieTitle = title;
            movieContent = content;
            movieFileName = filename;

            service = new YouTubeService("pocket bloger", "ytapi-INCHULHONG-pocketbloger-4lea34g9-0", "AI39si5nnXX9jCp5-l8q-XEeTfG5eH_j7wRULFryQqQsQ05DrkMiGeKaYxRVfbkXVj7jmagKwJmkKZeFZb0xzDWca4fm4N2pxA");
            service.setUserCredentials(username, password);
        }

        public override void Upload()
        {
            UploadStateEventArgs e = new UploadStateEventArgs();
            
            e.State = UploadStates.Start;
            base.OnState(e);

            try
            {
                YouTubeEntry newEntry = new YouTubeEntry();

                #region 동영상 GPS 정보
                //newEntry.Location = new GeoRssWhere(37, -122);
                //newEntry.setYouTubeExtension("location", "Mountain View, CA");
                #endregion

                newEntry.Media = new MediaGroup();
                newEntry.Media.Categories.Add(new MediaCategory("Autos", YouTubeNameTable.CategorySchema));
                newEntry.Media.Categories.Add(new MediaCategory("엔터테인먼트", YouTubeNameTable.DeveloperTagSchema));

                newEntry.Media.Title = new MediaTitle(movieTitle); //제목
                newEntry.Media.Description = new MediaDescription(movieContent); //설명
                newEntry.Media.Keywords = new MediaKeywords("MobileMovie"); //태그

                newEntry.MediaSource = new MediaFileSource(movieFileName, "video/skm");
                YouTubeEntry createdEntry = service.Upload(newEntry);
                int lindex = createdEntry.Id.Uri.Content.LastIndexOf("/") + 1;
                string youtubeKey = createdEntry.Id.Uri.Content.Substring(lindex);
                string youtubeUrl = String.Format("http://www.youtube.com/v/{0}", youtubeKey);

                e.State = UploadStates.Successed;
                e.ContentUrl = new Uri(youtubeUrl);
                base.OnState(e);
            }
            catch (OutOfMemoryException)
            {
                e.State = UploadStates.OutOfMemoryException;
                base.OnState(e);
            }
            catch (Exception)
            {
                e.State = UploadStates.Failed;
                base.OnState(e);
            }
        }
    }


    public class ImageUploader : UploadContent
    {
        private ImageUtil imgFile = null;
        private string imageFileName = String.Empty;
        private MetaWebLogApi metaWeb = null;

        public ImageUploader(MetaWebLogApi metaApi,string filename)
        {
            metaWeb = metaApi;
            imageFileName = filename;
            imgFile = new ImageUtil(filename);
        }

        public ImageUploader(MetaWebLogApi metaApi, string filename, string Atitude, string longtitude)
        {
            metaWeb = metaApi;
            imageFileName = filename;
            imgFile = new ImageUtil(filename);
        }

        public override void Upload()
        {
            UploadStateEventArgs e = new UploadStateEventArgs();
            
            try
            {
                switch (imgFile.Exists)
                {
                    case true:
                        byte[] buffer;

                        e.State = UploadStates.Start;
                        base.OnState(e);

                        using (FileStream fileStream = new FileStream(imageFileName, FileMode.Open))
                        {
                            buffer = new byte[imgFile.Length];
                            fileStream.Read(buffer, 0, buffer.Length);
                        }

                        BlogImageFile imgInfo = metaWeb.NewMediaObject(imgFile.Name, buffer, imgFile.MimeType);

                        if (imgInfo != null)
                        {
                            e.ContentUrl = imgInfo.Url;
                            e.ImageWidth = imgFile.Width;
                            e.ImageHeight = imgFile.Height;
                            e.State = UploadStates.Successed;

                            base.OnState(e);
                        }
                        else
                        {
                            e.State = UploadStates.Failed;
                            base.OnState(e);
                        }

                        break;
                    case false:
                        e.State = UploadStates.Failed;
                        base.OnState(e);

                        break;

                }
            }
            catch (OutOfMemoryException)
            {
                e.State = UploadStates.OutOfMemoryException;
                base.OnState(e);
            }
            catch (Exception)
            {
                e.State = UploadStates.Failed;
                base.OnState(e);
            }
        }
    }

    public enum UploadStates { Start, Successed, Failed, OutOfMemoryException }

    public class UploadStateEventArgs : EventArgs
    {
        UploadStates upState;

        Uri conUrl = null;
        int imgW = 0;
        int imgH = 0;

        public Uri ContentUrl
        {
            get { return this.conUrl; }
            set { this.conUrl = value; }
        }

        public int ImageWidth
        {
            get { return this.imgW; }
            set { this.imgW = value; }
        }

        public int ImageHeight
        {
            get { return this.imgH; }
            set { this.imgH = value; }
        }
        
        public UploadStates State
        {
            get { return upState; }
            set { upState = value; }
        }
    }
}
