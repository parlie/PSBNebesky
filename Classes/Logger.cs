using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSBNebesky
{
    public class Logger
    {
        private ListBox box;

        public Logger(ListBox _box)
        {
            box = _box;
        }

        public enum LogType
        {
            Error,
            Succes,
            Warning,
            Info
        }

        public static void Log(string _event, LogType type)
        {

        }

        private static void StoreLog(string data)
        {

        }

    }
}
