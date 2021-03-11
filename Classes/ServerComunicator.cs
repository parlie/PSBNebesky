using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace PSBNebesky
{
    public partial class ServerComunicator
    {
        public ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        Encoding e = Encoding.ASCII;

        public void Validate(object form)
        {
            while (true)
            {
                socket.SendTimeout = 4100;
                try
                {
                    Thread.Sleep(4000);
                    socket.Send(new byte[1]);
                }
                catch (Exception)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show((Form1)form, resources.GetString("serverFailedConnectionError"),
                        resources.GetString("generalErrorTitle"), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        Environment.Exit(1);
                    }
                    throw;
                }
            }
        }

        public void InitializeConnectionToServer(Form1 form)
        {
            try
            {
                socket.ConnectAsync(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 49152));
            }
            catch
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(form, resources.GetString("serverFailedConnectionError"),
                    resources.GetString("generalErrorTitle"), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                if(dr == DialogResult.OK)
                {
                    Environment.Exit(1);
                }
            }
        }

        public string HandleCommandRequest(Command command, List<string> list)
        {
            string commandString = "";
            switch (command)
            {
                case Command.GetUserValidation:
                    commandString = string.Empty;
                    commandString = $"i0,{list[0]},{list[1]}"; //ID,CardNumber,PIN
                    break;
                case Command.GetMoneyAmount:
                    commandString = string.Empty;
                    commandString = "i1"; //ID
                    break;
                case Command.UserMoneyDeposit:
                    commandString = string.Empty;
                    commandString = $"i2,{list[0]}"; //ID,Amount
                    break;
                case Command.UserMoneyWithdrawal:
                    commandString = string.Empty;
                    commandString = $"i3,{list[0]}"; //ID,Amount
                    break;
                case Command.UserNewTransaction:
                    commandString = string.Empty;
                    commandString = $"i4,{list[0]},{list[1]}"; //ID,Account,Amount
                    break;
                case Command.UserTransactionHistory:
                    commandString = string.Empty;
                    commandString = $"i5"; //ID
                    break;
                case Command.UserInvalidate:
                    commandString = string.Empty;
                    commandString = $"i6";
                    break;
                default:
                    break;
            }
            return HandleCommand(commandString);
        }

        private string HandleCommand(string data)
        {
            //Console.WriteLine(data);
            socket.Send(e.GetBytes(data));
            Byte[] b = new byte[255];
            socket.Receive(b,SocketFlags.None);
            return e.GetString(b);
        }    

        public void TestConnection()
        {
            socket.Send(e.GetBytes("Testing connection...."));
        }
    }
}
