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
            SetLanguage(Language.English);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public enum Language
        {
            Čeština,
            English
        }

        public static void SetLanguage(Language language) //Ĺanguage changing method
        {
            System.Globalization.CultureInfo cultureInfo;
            switch (language)
            {
                case Language.Čeština:
                    cultureInfo = new System.Globalization.CultureInfo("cs");
                    System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                    System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
                    break;
                case Language.English:
                    cultureInfo = new System.Globalization.CultureInfo("en");
                    System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
                    System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                    break;
                default:
                    break;
            }
        }
    }
}
