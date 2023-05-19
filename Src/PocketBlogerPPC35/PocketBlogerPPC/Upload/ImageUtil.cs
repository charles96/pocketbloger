using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace PocketBlogerPPC
{
    class ImageUtil
    {
        FileInfo imgFileInfo = null;
        Bitmap bitmapImg = null;
        bool existsImg = false;
        int imgW = 0;
        int imgH = 0;

        public ImageUtil(string filename)
        {
            imgFileInfo = new FileInfo(filename);

            if (imgFileInfo.Exists)
            {
                this.existsImg = true;

                using (bitmapImg = new Bitmap(filename))
                {
                    imgW = bitmapImg.Width;
                    imgH = bitmapImg.Height;
                }
            }
        }

        public bool Exists
        {
            get { return existsImg; }
        }

        public string Name
        {
            get { return imgFileInfo.Name; }
        }

        public string FullName
        {
            get { return imgFileInfo.FullName; }
        }

        public long Length
        {
            get { return imgFileInfo.Length; }
        }

        public string MimeType
        {
            get
            {
                string rtnValue = String.Empty;

                switch (imgFileInfo.Extension.ToUpper())
                {
                    case ".JPG":
                        rtnValue = "image/jpeg";
                        break;
                    case ".GIF":
                        rtnValue = "image/gif";
                        break;
                    case ".PNG":
                        rtnValue = "image/png";
                        break;
                    case ".BMP":
                        rtnValue = "image/bmp";
                        break;
                }

                return rtnValue;
            }
        }

        public int Width
        {
            get { return this.imgW; }
        }

        public int Height
        {
            get { return this.imgH; }
        }
    }
}
