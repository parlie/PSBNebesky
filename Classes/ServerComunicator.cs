using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;
using System.Windows.Forms;

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

        public async void InitializeConnectionToServer(Form1 form)
        {
            try
            {
                await socket.ConnectAsync(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 49152));
                socket.Send(e.GetBytes("welp"));
                
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

        public void HandleCommandRequest(Command command, List<string> list)
        {
            string commandString;
            switch (command)
            {
                case Command.GetUserValidation:
                    commandString = $"0,{list[0]},{list[1]}";
                    SendData(commandString);
                    break;
                case Command.GetMoneyAmount:
                    break;
                case Command.UserMoneyDeposit:
                    break;
                case Command.UserMoneyWithdrawal:
                    break;
                case Command.UserNewTransaction:
                    break;
                case Command.UserTransactionHistory:
                    break;
                default:
                    break;
            }
        }

        private void SendData(string data)
        {

        }    

        public void TestConnection()
        {
            socket.Send(e.GetBytes("I hope someone who should be here clicked that button, if youre customer, then well... Somethings wrong!"));
        }
    }
}
