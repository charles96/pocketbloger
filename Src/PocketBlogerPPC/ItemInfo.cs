using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PocketBlogerPPC
{
    public class ItemInfo
    {
        string iKey = String.Empty;
        string iValue = String.Empty;

        public ItemInfo(string key, string value)
        {
            this.iKey = key;
            this.iValue = value;
        }

        public string Key
        {
            get { return this.iKey; }
        }

        public string Value
        {
            get { return this.iValue; }
        }
    }
}
