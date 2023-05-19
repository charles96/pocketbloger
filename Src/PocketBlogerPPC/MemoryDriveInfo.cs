using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace PocketBlogerPPC
{
    public class MemoryDriveInfo
    {
        [DllImport("Coredll", CharSet = CharSet.Auto)]
        static extern int GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);
        ulong freeMem,totalMem,totalFreeMem;


        public MemoryDriveInfo(string drivename)
        {
            GetDiskFreeSpaceEx(drivename,out freeMem,out totalMem, out totalFreeMem);
        }

        public ulong FreeBytesAvailable
        {
            get { return this.freeMem; }
        }

        public ulong TotalNumberOfBytes
        {
            get { return this.totalMem; }
        }

        public ulong TotalNumberOfFreeBytes
        {
            get { return this.totalFreeMem; }
        }

        
    }
}
