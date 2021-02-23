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
            if(s.Contains("Money"))
            {
                return Type.Money;
            }
            else if(s.Contains("Card"))
            {
                return Type.Card;
            }
            else
            {
                return Type.Fail;
            }
        }
    }
}
