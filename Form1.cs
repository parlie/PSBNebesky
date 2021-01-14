using System;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework;
using System.Timers;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Threading;
using System.Resources;
using System.ComponentModel;
using System.Collections.Generic;
using System.Security;
using BCrypt.Net;
using BCrypt;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading.Tasks;

namespace PSBNebesky
{
    public partial class Form1 : MetroForm
    {
        MetroColorStyle MainStyle;
        public ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        ServerComunicator comunicator = new ServerComunicator();
        PrivateFontCollection pfc = new PrivateFontCollection();

        public Form1()
        {
            InitializeComponent();
            AddFontFromResource(pfc, "DejaVuSansMono.ttf");
            ControlSetup();
            HideAllExcept(mainPage);
            OnStart();
            ChangeColor(MetroColorStyle.Teal);
          //  comunicator.InitializeConnectionToServer(this);
        }

        #region Variables
        private bool console = false;
        private int defaultWindowSizeW = 1146;
        private int biggerWindowSizeW = 1497;
        ToolTip tip = new ToolTip();

        private enum Language
        {
            Čeština,
            English,
            Default
        }

        #endregion


        #region HotFix


        /// <summary>
        /// Přidá zvolený font ze zdrojů do seznamu vlastních fontů
        /// </summary>
        /// <param name="privateFontCollection">Kolekce fontů</param>
        /// <param name="fontResourceName">Název zdroje</param>
        private static void AddFontFromResource(PrivateFontCollection privateFontCollection, string fontResourceName)
        {
            var fontBytes = GetFontResourceBytes(Assembly.GetExecutingAssembly(), fontResourceName);
            var fontData = Marshal.AllocCoTaskMem(fontBytes.Length);
            Marshal.Copy(fontBytes, 0, fontData, fontBytes.Length);
            privateFontCollection.AddMemoryFont(fontData, fontBytes.Length);
        }

        /// <summary>
        /// Vrátí velikost zdroje fontu z aktualního sestavení
        /// </summary>
        /// <param name="assembly">Aktuální sestavení</param>
        /// <param name="fontResourceName">Název zdroje</param>
        /// <returns></returns>
        private static byte[] GetFontResourceBytes(Assembly assembly, string fontResourceName)
        {
            var resourceStream = assembly.GetManifestResourceStream($"PSBNebesky.Resources.{fontResourceName}");
            if (resourceStream == null)
                throw new Exception(string.Format("Unable to find font '{0}' in embedded resources.", fontResourceName));
            var fontBytes = new byte[resourceStream.Length];
            resourceStream.Read(fontBytes, 0, (int)resourceStream.Length);
            resourceStream.Close();
            return fontBytes;
        }

        /// <summary>
        /// Nastaví velikost okna, znemožní uživateli měnit velikost okna a potvrdí jazyk na češtinu
        /// </summary>
        private void OnStart()
        {
            this.Size = new System.Drawing.Size(defaultWindowSizeW, this.Size.Height);
            this.SizeGripStyle = SizeGripStyle.Hide;
            buttonCzech.Enabled = false;
        }

        /// <summary>
        /// Nastaví font, velikost fontu, barvu a pozici textu pro každý prvek na obrazovce
        /// </summary>
        public void ControlSetup()
        {
            metroPanel1.Select();
            foreach (Control main in this.Controls)
            {
                if (main is MetroTabControl)
                {
                    foreach (Control tab in main.Controls)
                    {
                        if (tab is MetroTabPage)
                        {
                            foreach (Control item in tab.Controls)
                            {
                                if (item is MetroPanel)
                                {
                                    foreach (Control c in item.Controls)
                                    {
                                        if (c is MetroTile)
                                        {
                                            (c as MetroTile).TileTextFontSize = MetroTileTextSize.Tall;
                                            (c as MetroTile).TileTextFontWeight = MetroTileTextWeight.Bold;
                                            (c as MetroTile).TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                                            (c as MetroTile).Font = new System.Drawing.Font(pfc.Families[0], 18);
                                        }
                                    }
                                }
                                else if (item is MetroTile)
                                {
                                    (item as MetroTile).TileTextFontSize = MetroTileTextSize.Tall;
                                    (item as MetroTile).TileTextFontWeight = MetroTileTextWeight.Bold;
                                    (item as MetroTile).TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                                    (item as MetroTile).Font = new System.Drawing.Font(pfc.Families[0], 18);
                                }
                                else if (item is TextBox)
                                {
                                    if ((item as TextBox).Name.Contains("signIn"))
                                    {
                                        if ((item as TextBox).Name.Contains("Pass"))
                                        {
                                            (item as TextBox).TextAlign = HorizontalAlignment.Center;
                                            (item as TextBox).Font = new System.Drawing.Font(pfc.Families[0], 20);
                                        }
                                        else
                                        {
                                            (item as TextBox).TextAlign = HorizontalAlignment.Center;
                                            (item as TextBox).Font = new System.Drawing.Font(pfc.Families[0], 20);
                                        }
                                    }
                                }
                                else if (item is Label)
                                {
                                    (item as Label).Font = new System.Drawing.Font(pfc.Families[0], 40);
                                    (item as Label).TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                                }
                                else if (item is FlowLayoutPanel)
                                {
                                    foreach (Control items in item.Controls)
                                    {
                                        if(items is MetroPanel)
                                        {
                                            foreach (var mp in items.Controls)
                                            {
                                                if(mp is TextBox)
                                                {
                                                    if((mp as TextBox).Name.Contains("CustomValue"))
                                                    {
                                                        (mp as TextBox).Font = new System.Drawing.Font(pfc.Families[0], 50);
                                                        (mp as TextBox).TextAlign = HorizontalAlignment.Center;
                                                    }
                                                }
                                                else if(mp is MetroTile)
                                                {
                                                    (mp as MetroTile).TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                                                    (mp as MetroTile).Font = new System.Drawing.Font(pfc.Families[0], 50);
                                                    (mp as MetroTile).TileTextFontWeight = MetroTileTextWeight.Bold;
                                                    (mp as MetroTile).TileTextFontSize = MetroTileTextSize.Tall;
                                                }

                                            }
                                        }
                                        else if (items is MetroTile)
                                        {
                                            (items as MetroTile).TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                                            (items as MetroTile).Font = new System.Drawing.Font(pfc.Families[0], 60);
                                            (items as MetroTile).TileTextFontWeight = MetroTileTextWeight.Bold;
                                            (items as MetroTile).TileTextFontSize = MetroTileTextSize.Tall;
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// ZMění barvu ovládacích prvků
        /// </summary>
        /// <param name="style">MetroColorStyle enumerator</param>
        private void ChangeColor(MetroColorStyle style)
        {
            MainStyle = style;
            Style = style; //Sets form color
            foreach (Control main in this.Controls)
            {
                if(main is MetroTile)
                {
                    (main as MetroTile).Style = style;
                }
                if(main is MetroTabControl)
                {
                    (main as MetroTabControl).Style = style;
                    foreach (Control item in main.Controls)
                    {
                        if(item is MetroTabPage)
                        {
                            foreach (Control button in item.Controls)
                            {
                                if(button is MetroTile)
                                {
                                    (button as MetroTile).Style = style;
                                }
                                else if(button is MetroPanel)
                                {
                                    foreach (Control content in button.Controls)
                                    {
                                        if(content is MetroTile)
                                        {
                                            (content as MetroTile).Style = style;
                                        }
                                    }
                                }
                                else if (button is Label)
                                {
                                    (button as Label).ForeColor = style.ToColor();
                                }
                                else if (button is MetroTile)
                                {
                                    (button as MetroTile).Style = style;
                                }
                                else if (button is MetroTextBox)
                                {
                                    (button as MetroTextBox).Style = style;
                                }
                                else if (button is TextBox)
                                {
                                    (button as TextBox).ForeColor = style.ToColor();
                                }
                                else if (button is FlowLayoutPanel)
                                {
                                    foreach (Control items in button.Controls)
                                    {
                                        if (items is MetroPanel)
                                        {
                                            foreach (var mp in items.Controls)
                                            {
                                                if (mp is TextBox)
                                                {
                                                    if ((mp as TextBox).Name.Contains("CustomValue"))
                                                    {
                                                        (mp as TextBox).ForeColor = style.ToColor();
                                                    }
                                                }
                                                else if (mp is MetroTile)
                                                {
                                                    (mp as MetroTile).Style = style;
                                                }
                                            }
                                        }
                                        else if (items is MetroTile)
                                        {
                                            (items as MetroTile).Style = style;
                                        }

                                    }
                                }
                            }
                            
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Zajišťuje animaci po stisku tlačítka
        /// </summary>
        private void NoHighlight()
        {
            Thread.Sleep(125);
            metroPanel1.Select();
        }

        /// <summary>
        /// Změna jazyka v runtime 
        /// </summary>
        /// <param name="language">Program.Language enumerator</param>
        private void ChangeLanguage(Language language)
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
                case Language.Default:

                    break;
                default:
                    break;
            }
            ApplyResources(resources, this.Controls);
            this.Text = resources.GetString($"{mainControl.SelectedTab.Name}.Text");
            FixTitle();
            ControlSetup();
            
        }

        /// <summary>
        /// Přenačte UI prvky a nastaví jazyk
        /// </summary>
        /// <param name="resources">Zdroje jazyka</param>
        /// <param name="controlCollections">Prvky pro změnu jazyka</param>
        private void ApplyResources(ComponentResourceManager resources, Control.ControlCollection controlCollections)
        {
            foreach (Control c in controlCollections)
            {
                resources.ApplyResources(c, c.Name);
                ApplyResources(resources, c.Controls);
            }
            ControlSetup();
        }

        /// <summary> 
        /// Záplata na chybu ve WFA, která způsobí že nelze změnit titulek aplikace
        /// </summary>
        private void FixTitle()
        {
            this.Size = new System.Drawing.Size(this.Size.Width + 1, this.Size.Height);
            this.Size = new System.Drawing.Size(this.Size.Width - 1, this.Size.Height);
        }

        /// <summary>
        /// Metoda pro animaci tlačítek volby jazyka a zavolání funkce pro změnu jazyka
        /// </summary>
        /// <param name="tile">Odkaz na tlačítko</param>
        /// <param name="language">Jazyk</param>
        private void LanguageSet(MetroTile tile, Language language)
        {
            tile.Size = new System.Drawing.Size(60,60);
            tile.BackColor = System.Drawing.Color.Gray;
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += (Object obj, EventArgs argas) =>
            {
                NoHighlight();
                ChangeLanguage(language);
                tile.Size = new System.Drawing.Size(64, 64);
                tile.BackColor = System.Drawing.Color.White;
                timer.Stop();
            };
            timer.Start();
        }

        /// <summary>
        /// Manipulátor prvku TabControl pro pohodlné zobrazování různých částí bankomatu
        /// </summary>
        /// <param name="page"></param>
        private void HideAllExcept(MetroTabPage page)
        {
            mainControl.ShowTab(page);
            mainControl.SelectTab(page);
            //this.Text = resources.GetString(page.Name + ".Text");
            foreach (MetroTabPage slide in mainControl.TabPages)
            {
                if(slide != page)
                {
                    mainControl.HideTab(slide);
                }
            }
            ChangeColor(MainStyle);
            ChangeLanguage(Language.Default);
            //FixTitle();
            page.Text = "";
        }
        #endregion 








        #region Debug

        private void consoleButton_Click(object sender, EventArgs e)
        {
            if (!console)
            {
                tip.SetToolTip(consoleButton, "Skrýt ladění");
                this.Size = new System.Drawing.Size(biggerWindowSizeW, this.Size.Height);
                console = true;
                consoleButton.Text = "<<";
                NoHighlight();
            }
            else
            {
                tip.SetToolTip(consoleButton,"Zobrazit ladění");
                this.Size = new System.Drawing.Size(defaultWindowSizeW, this.Size.Height);
                console = false;
                NoHighlight();
                consoleButton.Text = ">>";
            }
        }

        private bool isTooltip = false;
        private void consoleButton_Enter(object sender, EventArgs e)
        {
            if(!isTooltip)
            {
                tip.SetToolTip(consoleButton, "Zobrazit ladění");
                isTooltip = true;
            }
            NoHighlight();
        }

        private void exitSimulator_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comunicator.TestConnection();
        }

            #region contextStrip

        private void menuStripSignIn_Click(object sender, EventArgs e)
        {
            HideAllExcept(signInPage);
        }

        private void menuStripMainPage_Click(object sender, EventArgs e)
        {
            HideAllExcept(mainPage);
        }

        private void menuStripMOneyDeposit_Click(object sender, EventArgs e)
        {
            HideAllExcept(moneyIntakePage);
        }

        private void menuStripMoneyWithdrawl_Click(object sender, EventArgs e)
        {
            HideAllExcept(moneyWithdrawlPage);
        }

        private void menuStripTransactionHistory_Click(object sender, EventArgs e)
        {
            HideAllExcept(transactionHistoryPage);
        }

        private void menuStripNewTransaction_Click(object sender, EventArgs e)
        {
            HideAllExcept(newTransactionPage);
        }

        #endregion

        #endregion

        #region Sign in

        private void signInButton_Click(object sender, EventArgs e)
        {
            SecureString secureString = new SecureString();
            foreach (char item in BCrypt.Net.BCrypt.HashPassword(signInPassBox.Text, 11))
            {
                secureString.AppendChar(item);
            }
            Console.WriteLine(secureString.ToString());
            for (int i = 0; i < secureString.Length; i++)
            {
                Console.WriteLine(i);
            }
            NoHighlight();
        }

        private void signInNewUser_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Main page

        private void buttonIntake_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(moneyIntakePage);
        }

        private void buttonWith_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(moneyWithdrawlPage);
        }

        private void buttonNewTransaction_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(newTransactionPage);
        }

        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(transactionHistoryPage);
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(signInPage);
        }

        private void buttonCzech_Click(object sender, EventArgs e)
        {
            LanguageSet(buttonCzech, Language.Čeština);
            buttonEnglish.Enabled = true;
            buttonCzech.Enabled = false;
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            LanguageSet(buttonEnglish, Language.English);
            buttonEnglish.Enabled = false;
            buttonCzech.Enabled = true;

        }

        #endregion

        #region Money Deposit

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        } //Omezuje vstup do pole pro vlastní částku pouze na celá čísla

        private void moneyDeposit200Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyDeposit500Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyDeposit1000Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyDeposti5000Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyDepositCustomTile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyDepositBack_Click(object sender, EventArgs e)
        {
            NoHighlight();
            moneyDepositCustomValue.Text = null;
            HideAllExcept(mainPage);
        }

        #endregion

        #region Money Withdrawal

        private void moneyWithdrawlBack_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(mainPage);
        }

        private void moneyWithdrawl200Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyWithdrawl500Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyWithdrawl1000Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyWithdrawl5000Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }

        private void moneyWithdrawlCustomTile_Click(object sender, EventArgs e)
        {
            NoHighlight();
        }



        #endregion

    }
}
