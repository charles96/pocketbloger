using System;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace PocketBlogerPPC
{
    public enum Baud { Rate4800 = 4800, Rate9600 = 9600, Rate19200 = 19200, Rate38400 = 38400, Rate57600 = 57600, Rate115200 = 115200 }
    public enum Direction { Unknown = 'U', North = 'N', East = 'E', West = 'W', South = 'S' }
    public delegate void DataReceivedHandler(GpggaDataEventArgs e);

    public class GpsTracker
    {
        SerialPort serialPort = null;
        Thread threadGetData = null;
        bool activate = false;
        string sPort = String.Empty;
        Baud sBaud;

        public event DataReceivedHandler GpggaDataReceived;

        public GpsTracker(string port, Baud baud)
        {
            sPort = port;
            sBaud = baud;

            serialPort = new SerialPort(sPort, (int)sBaud);
        }

        private void GetData()
        {
            serialPort.Open();

            while (activate)
            {
                Received(serialPort.ReadExisting());
                Thread.Sleep(1000);
            }
        }

        private void Received(string data)
        {
            if (GpggaDataReceived != null)
            {
                GpggaDataReceived(new GpggaDataEventArgs(data));
            }
        }

        public void Start()
        {
            if (threadGetData == null)
            {
                activate = true;

                serialPort.ReadTimeout = 5000;
                threadGetData = new Thread(new ThreadStart(GetData));
                threadGetData.IsBackground = true;
                threadGetData.Start();
            }
        }

        public void Abort()
        {
            activate = false;

            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }

            if (threadGetData != null)
            {
                threadGetData.Abort();
                threadGetData = null;
            }
        }
    }

    public class GpsLogConvert
    {
        /// <summary>
        /// NMEA 좌표계 위도를 구글 위도로 변환
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        public static string LatitudeNmeaToKml(string coordinate)
        {
            double rtnvalue = 0;

            try
            {
                int dd = Convert.ToInt16(coordinate.Substring(0, 2));
                double mm = Convert.ToDouble(coordinate.Substring(2));
                rtnvalue = (mm / 60) + dd;
            }
            catch (Exception)
            {
                rtnvalue = 0;
            }

            return rtnvalue.ToString();
        }

        /// <summary>
        /// NMEA 좌표계 경도를 구글 경도로 변환
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        public static string LongitudeNmeaToKml(string coordinate)
        {
            double rtnvalue = 0;

            try
            {
                int dd = Convert.ToInt16(coordinate.Substring(0, 3));
                double mm = Convert.ToDouble(coordinate.Substring(3));
                rtnvalue = (mm / 60) + dd;
            }
            catch (Exception)
            {
                rtnvalue = 0;
            }

            return rtnvalue.ToString();
        }
    }


    public class GpggaDataEventArgs : EventArgs
    {
        Regex regEx = null;
        MatchCollection match = null;
        string express = @"\WGPGGA,(?<time>[\w\W][^',']{0,}),(?<latitude>[\w\W][^',']{0,}),(?<laPos>\w),(?<longitude>[\w\W][^',']{0,}),(?<longPos>\w),(?<IsValid>[\d][^',']{0,}),(?<satellite>[\d][^',']{0,}),(?<altitude>[\d][^',']{0,})";
        string source = String.Empty;

        public GpggaDataEventArgs(string NMEAdata)
        {
            this.source = NMEAdata;
            regEx = new Regex(express, RegexOptions.IgnoreCase
                  | RegexOptions.Multiline
                  | RegexOptions.IgnorePatternWhitespace
                  | RegexOptions.Compiled
                  );

            match = regEx.Matches(this.source);
        }

        public string NmeaData
        {
            get { return this.source; }
        }

        public bool IsValidGpsData
        {
            get
            {
                bool rtnvalue = false;

                if (match.Count > 0)
                {
                    if (Convert.ToInt16(match[0].Groups["IsValid"].Value) > 0)
                    {
                        rtnvalue = true;
                    }
                }

                return rtnvalue;
            }
        }

        public int SatelliteCount
        {
            get { return Convert.ToInt16(match[0].Groups["satellite"].Value); }
        }

        public Direction LongitudeDirection
        {
            get
            {
                Direction longDirec;

                switch (match[0].Groups["longPos"].Value.Trim().ToUpper())
                {
                    case "E":
                        longDirec = Direction.East;
                        break;
                    case "W":
                        longDirec = Direction.West;
                        break;
                    default:
                        longDirec = Direction.Unknown;
                        break;
                }

                return longDirec;
            }
        }

        public Direction LatitudeDirection
        {
            get
            {
                Direction laDirec;

                switch (match[0].Groups["laPos"].Value.Trim().ToUpper())
                {
                    case "N":
                        laDirec = Direction.North;
                        break;
                    case "S":
                        laDirec = Direction.South;
                        break;
                    default:
                        laDirec = Direction.Unknown;
                        break;
                }

                return laDirec;
            }
        }

        public string Altitude
        {
            get { return match[0].Groups["altitude"].Value; }
        }

        public string Latitude
        {
            get { return match[0].Groups["latitude"].Value; }
        }

        public string Longitude
        {
            get { return match[0].Groups["longitude"].Value; }
        }
    }
}
