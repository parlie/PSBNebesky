using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PSBNebesky.Classes
{
    public static class DnDHandler
    {
        public static decimal MoneyHandler(string[] values)
        {
            decimal value = 0.00m;
            Money m;
            List<string> localValues = new List<string>();
            foreach(var item in values)
            {
                if(JsonConvert.DeserializeObject(item).GetObjectType() == Type.Money)
                {
                    localValues.Add(item);
                }
            }
            foreach(var item in localValues)
            {
                m = (Money)JsonConvert.DeserializeObject(item);
                value += m.value;
            }
            return value;
        }

        public static void CardHandler(ServerComunicator com, string cardNumber, string pin)
        {
            com.HandleCommandRequest(ServerComunicator.Command.GetUserValidation, new List<string>() { cardNumber, pin });
        }
    }
}
