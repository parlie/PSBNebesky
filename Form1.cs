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

namespace PSBNebesky
{
    public partial class Form1 : MetroForm
    {
        MetroColorStyle MainStyle;
        public ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        ServerComunicator comunicator = new ServerComunicator();

        public Form1()
        {
            InitializeComponent();
            ButtonSetup();
            HideAllExcept(mainPage);
            OnStart();
            ChangeColor(MetroColorStyle.Teal);
            comunicator.InitializeConnectionToServer(this);
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
        /// Metoda nastaví velikost okna, znemožní uživateli měnit velikost okna a nastaví jazyk na češtinu
        /// </summary>
        private async void OnStart()
        {
            this.Size = new System.Drawing.Size(defaultWindowSizeW, this.Size.Height);
            this.SizeGripStyle = SizeGripStyle.Hide;
            buttonCzech.Enabled = false;
        }

        /// <summary>
        /// Metoda nastaví font, velikost fontu, barvu a pozici textu pro každý prvek na obrazovce
        /// </summary>
        public void ButtonSetup()
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
                                            (c as MetroTile).Font = new System.Drawing.Font("Coves", 18);
                                        }
                                    }
                                }
                                else if (item is MetroTile)
                                {
                                    (item as MetroTile).TileTextFontSize = MetroTileTextSize.Tall;
                                    (item as MetroTile).TileTextFontWeight = MetroTileTextWeight.Bold;
                                    (item as MetroTile).TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                                    (item as MetroTile).Font = new System.Drawing.Font("Coves", 18);
                                }
                                else if (item is TextBox)
                                {
                                    if ((item as TextBox).Name.Contains("signIn"))
                                    {
                                        if ((item as TextBox).Name.Contains("Pass"))
                                        {
                                            (item as TextBox).TextAlign = HorizontalAlignment.Center;
                                            (item as TextBox).Font = new System.Drawing.Font("Coves", 20);
                                        }
                                        else
                                        {
                                            (item as TextBox).TextAlign = HorizontalAlignment.Center;
                                            (item as TextBox).Font = new System.Drawing.Font("Coves", 20);
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
        /// Meto pro změnu barvy ovládacích prvků
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
            this.Text = resources.GetString("mainPage.Name");
            FixTitle();
            ButtonSetup();
            
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
            ButtonSetup();
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
            mainControl.ShowTab(mainPage);
            mainControl.ShowTab(signInPage);
            mainControl.ShowTab(transactionHistoryPage);
            mainControl.ShowTab(moneyIntakePage);
            foreach (MetroTabPage slide in mainControl.TabPages)
            {
                if(slide == page)
                {
                    mainControl.ShowTab(slide);
                    mainControl.SelectTab(slide);
                    this.Text = resources.GetString(slide.Name + ".Name");
                }
                else if(slide != page)
                {
                    mainControl.HideTab(slide);
                }
            }
            ChangeColor(MainStyle);
            ChangeLanguage(Language.Default);
            FixTitle();
            page.Text = "";
        }
        #endregion 

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

        private void exitSimulator_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comunicator.TestConnection();
        }
    }
}
