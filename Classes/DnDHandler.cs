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
            string s;
            foreach(var item in values)
            {
                s = File.ReadAllText(item);
                Console.WriteLine(item);
                if(JsonConvert.DeserializeObject(s).GetObjectType() == Type.Money)
                {
                    localValues.Add(item);
                }
            }
            foreach(var item in localValues)
            {
                Console.WriteLine(item);
                s = File.ReadAllText(item);
                m = JsonConvert.DeserializeObject<Money>(s);
                value += m.value;
            }
            return value;
        }
    }
}
