using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSBNebesky.Classes
{
    public static class ExtensionMethods
    {
        public static System.Drawing.Color ToColor(this MetroColorStyle style)
        {
            System.Drawing.Color color;
            color = System.Drawing.Color.FromName(style.ToString());
            return color;
        }

        public static Type GetObjectType(this object o)
        {
            string s = o.ToString();
            if(s.Contains("0"))
            {
                return Type.Money;
            }
            else if(s.Contains("1"))
            {
                return Type.Card;
            }
            else
            {
                return Type.Fail;
            }
        }

        public static int Count(this char[] charar, char ch)
        {
            int count = 0;
            foreach (char item in charar)
            {
                if (item == ch)
                {
                    count++;
                }
            }
            return count;
        }

        public static string Dotted(this string hold)
        {
            string s = hold;
            if(s.Length > 3 && s.Length < 7)
            {
                s = s.Insert(s.Length-3,".");
            }
            else if(s.Length > 6 && s.Length < 10)
            {
                s = s.Insert(s.Length - 6, ".");
                s = s.Insert(s.Length - 3, ".");
            }
            else if(s.Length > 9)
            {
                s = s.Insert(s.Length - 9, ".");
                s = s.Insert(s.Length - 6, ".");
                s = s.Insert(s.Length - 3, ".");
            }
            return s;
        }
    }
}
