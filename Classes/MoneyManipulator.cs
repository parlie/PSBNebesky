using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PSBNebesky.Classes
{
    public static class MoneyManipulator
    {
        public static decimal RoundToHundreds(decimal number)
        {
            if (number.ToString().Length < 3)
            {
                return 200m;
            }
            return FixValue(Math.Round(number / 100m, 0) * 100);
        }

        public static decimal FixValue(decimal number)
        {
            string s = number.ToString();
            if (s.Length > 2)
            {
                s = s.Substring(s.Length - 3, 3);
                if (s == "300")
                {
                    number = number + 100m;
                }
            }
            return number;
        }

        public static List<decimal> DivideByNotes(decimal number)
        {
            int zdroj = Convert.ToInt32(number);
            int hold = 0;
            int amount5t = 0;
            int amount2t = 0;
            int amount1t = 0;
            int amount5h = 0;
            int amount2h = 0;

            try //5000
            {
                hold = zdroj % 5000;
                amount5t = (zdroj - hold) / 5000;
                zdroj = hold;
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                hold = zdroj % 2000;
                amount2t = (zdroj - hold) / 2000;
                zdroj = hold;
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                hold = zdroj % 1000;
                amount1t = (zdroj - hold) / 1000;
                zdroj = hold;
            }
            catch (Exception)
            {

                throw;
            }

            if (zdroj == 900 || zdroj == 700 || zdroj == 500)
            {
                hold = zdroj % 500;
                amount5h = (zdroj - hold) / 500;
                zdroj = hold;
            }

            try
            {
                hold = zdroj % 200;
                amount2h = (zdroj - hold) / 200;
                zdroj = hold;
            }
            catch (Exception)
            {

                throw;
            }

            List<decimal> list = new List<decimal>() { amount5t, amount2t, amount1t, amount5h, amount2h };
            return list;
        }

        public static bool Withdrawl(List<decimal> list,decimal value, ServerComunicator comunicator)
        {
            Money m;
            int val = 0;
            if(comunicator.HandleCommandRequest(ServerComunicator.Command.UserMoneyWithdrawal, new List<string>() { value.ToString() }).Contains("i3,b1"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == 0)
                    {
                        val = 5000;
                    }
                    else if (i == 1)
                    {
                        val = 2000;
                    }
                    else if (i == 2)
                    {
                        val = 1000;
                    }
                    else if (i == 3)
                    {
                        val = 500;
                    }
                    else if (i == 4)
                    {
                        val = 200;
                    }
                    for (int ii = 0; ii < list[i]; ii++)
                    {
                        Thread.Sleep(100);
                        m = new Money();
                        m.value = Convert.ToInt32(val);
                        File.WriteAllText($"./Money/{val}_{DateTime.Now.Ticks.ToString()}.json", JsonConvert.SerializeObject(m));
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Withdrawl(decimal number, ServerComunicator comunicator)
        {
            Money m = new Money();
            m.value = Convert.ToInt32(number);

            if (comunicator.HandleCommandRequest(ServerComunicator.Command.UserMoneyWithdrawal, new List<string>() { number.ToString() }).Contains("i3,b1"))
            {
                if (File.Exists($"./Money/{number}.json"))
                {
                    File.WriteAllText($"./Money/{number}_{DateTime.Now.Ticks.ToString()}.json", JsonConvert.SerializeObject(m));
                }
                else
                {
                    File.WriteAllText($"./Money/{number}.json", JsonConvert.SerializeObject(m));
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
