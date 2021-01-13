using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSBNebesky
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetLanguage();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }

        /// <summary>
        /// Slouží pro prvnotní nastavení jazyka na výchozí - v mém případě je výchozí jazyk vždy čestina. Nelze použít metodu Form1.ChangeLanguage,
        /// neboť Program.cs je při spuštění konstruován dříve než Form1.cs - metoda ChangeLanguage je tedy nedostupná.
        /// </summary>
        public static void SetLanguage()
        {
            System.Globalization.CultureInfo cultureInfo;
            cultureInfo = new System.Globalization.CultureInfo("cs");
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }
    }
}
