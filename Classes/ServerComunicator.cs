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
    public class ServerComunicator
    {
        public ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        Encoding e = Encoding.ASCII;

        public enum Command
        {
            GetUserValidation,
            GetMoneyAmount,
            UserMoneyDeposit,
            UserMoneyWithdrawal,
            UserNewTransaction,
            UserTransactionHistory
        };

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

        public bool HandleCommandRequest(Command command, List<string> list)
        {
            string commandString = "";
            switch (command)
            {
                case Command.GetUserValidation:
                    commandString = string.Empty;
                    commandString = $"0,{list[0]},{list[1]}"; //ID,CardNumber,PIN
                    break;
                case Command.GetMoneyAmount:
                    commandString = string.Empty;
                    commandString = "1"; //ID
                    break;
                case Command.UserMoneyDeposit:
                    commandString = string.Empty;
                    commandString = $"2,{list[0]}"; //ID,Amount
                    break;
                case Command.UserMoneyWithdrawal:
                    commandString = string.Empty;
                    commandString = $"3,{list[0]}"; //ID,Amount
                    break;
                case Command.UserNewTransaction:
                    commandString = string.Empty;
                    commandString = $"4,{list[0]},{list[1]}"; //ID,Account,Amount
                    break;
                case Command.UserTransactionHistory:
                    commandString = string.Empty;
                    commandString = $"5"; //ID
                    break;
                default:
                    break;
            }
            return HandleCommand(commandString);
        }

        private bool HandleCommand(string data)
        {
            Console.WriteLine(data);
            socket.Send(e.GetBytes(data));
            return true;
        }    

        public void TestConnection()
        {
            socket.Send(e.GetBytes("Testing connection...."));
        }
    }
}
