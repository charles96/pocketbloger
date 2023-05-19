using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PocketBlogerPPC
{
    public class DeviceResolution
    {
        string mName = String.Empty;

        public DeviceResolution()
        {
            this.mName = OpenNETCF.Environment2.MachineName;
        }

        public void MainListView(out int numSize, out int titleSize, out int dateSize)
        { 
            switch(this.mName.ToUpper())
            {
                case "SCH-M480": //미라지
                    numSize = 40;
                    titleSize = 210;
                    dateSize = 50;
                    break;
                case "SCH-M490": //T옴니아 
                    numSize = 40;
                    titleSize = 140;
                    dateSize = 50;
                    break;
                case "SCH-M495": //T옴니아
                    numSize = 40;
                    titleSize = 140;
                    dateSize = 50;
                    break;
                default:
                    numSize = 40;
                    titleSize = 210;
                    dateSize = 50;
                    break;
            }
        }

        public void WriteTextBox(out int heightSize)
        {
            switch (this.mName.ToUpper())
            {    case "SCH-M480": //미라지
                    heightSize = 172;
                    break;
                case "SCH-M490": //T옴니아
                    heightSize  = 250;
                    break;
                case "SCH-M495": //T옴니아
                    heightSize  = 250;
                    break;
                default:
                    heightSize = 172;
                    break;
            }
        }

        public void MainMentBoxPosition(out int x, out int y)
        {
            switch (this.mName.ToUpper())
            {
                case "SCH-M480": //미라지
                    x = 38;
                    y = 97;
                    break;
                case "SCH-M490": //T옴니아
                    x = 0;
                    y = 99;
                    break;
                case "SCH-M495": //T옴니아
                    x = 0;
                    y = 99;
                    break;
                default:
                    x = 38;
                    y = 97;
                    break;
            }
        }
    }
}
