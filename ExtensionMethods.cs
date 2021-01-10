using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSBNebesky
{
    public static class ExtensionMethods
    {
        public static System.Drawing.Color ToColor(this MetroColorStyle style)
        {
            System.Drawing.Color color;
            color = System.Drawing.Color.FromName(style.ToString());
            return color;
        }
    }
}
