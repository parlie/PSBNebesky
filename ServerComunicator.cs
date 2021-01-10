using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Net.Security;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

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
            UserMOneyWithdrawal,
            UserNewTransaction,
            UserTransactionHistory
        };

        public async void InitializeConnectionToServer(Form1 form)
        {
            try
            {
                await socket.ConnectAsync(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 49152));
                byte[] b = new byte[256];
                
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
            SecureString @string = new SecureString();
            switch (command)
            {
                case Command.GetUserValidation:
                    break;
                case Command.GetMoneyAmount:
                    break;
                case Command.UserMoneyDeposit:
                    break;
                case Command.UserMOneyWithdrawal:
                    break;
                case Command.UserNewTransaction:
                    break;
                case Command.UserTransactionHistory:
                    break;
                default:
                    break;
            }
        }

        private void SendData(SecureString data)
        {

        }    
    }
}
