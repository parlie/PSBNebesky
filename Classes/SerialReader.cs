using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace PSBNebesky.Classes
{
    public static class SerialReader
    {
        public static void ReadCardFromSerial(object f)
        {
            Form1 form = (Form1)f;
            string s = "";
            try
            {
                SerialPort serialPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
                while (true)
                {
                    s = serialPort.ReadExisting();
                    s = s.Trim();
                    if (s.Length == 10)
                    {
                        Console.WriteLine(s);
                        form.Invoke(new Action(() => { form.SetSignIn(s.ToString()); }));
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Missing COM");
            }

        }
    }
}