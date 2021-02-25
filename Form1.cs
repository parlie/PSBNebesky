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
using System.Drawing;
using PSBNebesky.Classes;
using System.Linq;
using Newtonsoft.Json;

namespace PSBNebesky
{
    public partial class Form1 : MetroForm
    {
        MetroColorStyle MainStyle;
        public ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        public ServerComunicator comunicator = new ServerComunicator();
        PrivateFontCollection pfc = new PrivateFontCollection();

        List<Control> controlsList = new List<Control>();

        public Form1()
        {
            InitializeComponent(); //Tvorba aplikace a prvků ovládání
            AddFontFromResource(pfc, "DejaVuSansMono.ttf"); //Načtení zabaleného fontu
            LoadControls(); //Optimalizace práce s ovládacími prvky - namísto načítání prvků při každě změně rozložení jsou prvky uloženy do seznamu ze kterého se dá libovolně číst
            ControlSetup();
            SetStyle(MetroColorStyle.Teal);
            HideAllExcept(mainPage); //Zobrazí pouze požadovanou stránku prostředí
            OnStart();
            comunicator.InitializeConnectionToServer(this);
            Thread t = new Thread(comunicator.Validate);
            t.Start(this);
        }

        #region Variables
        private bool console = false;
        private int defaultWindowSizeW = 1146;
        private int biggerWindowSizeW = 1497;
        private bool defaultLanguage = true;
        ToolTip tip = new ToolTip();
        private string cardNumber;

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
        /// Nastaví velikost okna, znemožní uživateli měnit velikost okna
        /// </summary>
        private void OnStart()
        {
            this.Size = new System.Drawing.Size(defaultWindowSizeW, this.Size.Height);
            this.SizeGripStyle = SizeGripStyle.Hide;
        }

        public void LoadControls()
        {
            foreach(Control item in this.Controls)
            {
               if(item is MetroTabControl)
                {
                    foreach (Control tab in item.Controls)
                    {
                        foreach (Control c in tab.Controls)
                        {
                            if (!(c is MetroScrollBar))
                            {
                                if(c is MetroPanel)
                                {
                                    foreach (Control panelC in c.Controls)
                                    {
                                        if (!(panelC is MetroScrollBar))
                                        {
                                            Console.WriteLine("Panel: ".PadRight(11) + panelC.Name.PadRight(30) + " | ".PadRight(8) + panelC.GetType());
                                            controlsList.Add(panelC);
                                        }
                                    }
                                }
                                else if(c is FlowLayoutPanel)
                                {
                                    foreach (Control flowC in c.Controls)
                                    {
                                        if(!(flowC is MetroPanel))
                                        {
                                            if (!(flowC is MetroScrollBar))
                                            {
                                                Console.WriteLine("Flow: ".PadRight(11) + flowC.Name.PadRight(30) + " | ".PadRight(8) + flowC.GetType());
                                                controlsList.Add(flowC);
                                            }
                                        }
                                        else if(flowC is FlowLayoutPanel)
                                        {
                                            controlsList.Add(flowC);
                                        }
                                        else
                                        {
                                            foreach (Control flowPanelC in flowC.Controls)
                                            {
                                                if(!(flowPanelC is MetroScrollBar))
                                                {
                                                    Console.WriteLine("FlowPanel: " + flowPanelC.Name.PadRight(30) + " | ".PadRight(8) + flowPanelC.GetType());
                                                    controlsList.Add(flowPanelC);
                                                }
                                            }
                                        }
                                        
                                    }
                                }
                                else if (c is ListView)
                                {
                                    controlsList.Add(c);
                                    Console.WriteLine("------------------------------------------");
                                    foreach (Control t in c.Controls)
                                    {
                                        Console.WriteLine(t.Name.PadRight(60));
                                        controlsList.Add(t);
                                    }
                                    Console.WriteLine("--------------------------------------------");
                                }
                                else
                                {
                                    Console.WriteLine("Page: ".PadRight(11) + c.Name.PadRight(30) + " | ".PadRight(8) + c.GetType());
                                    controlsList.Add(c);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Nastaví font, velikost fontu, barvu a pozici textu pro každý prvek na obrazovce
        /// </summary>
        public void ControlSetup()
        {
            metroPanel1.Select();
            foreach (Control item in controlsList)
            {
                if(item is MetroTile)
                {
                    if(item.Name.Contains("Deposit") || item.Name.Contains("Withdrawl") || item.Name.Contains("Leave"))
                    {
                        (item as MetroTile).TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        (item as MetroTile).Font = new System.Drawing.Font(pfc.Families[0], 50);
                        (item as MetroTile).TileTextFontWeight = MetroTileTextWeight.Bold;
                        (item as MetroTile).TileTextFontSize = MetroTileTextSize.Tall;
                    }
                    else
                    {
                        (item as MetroTile).TileTextFontSize = MetroTileTextSize.Tall;
                        (item as MetroTile).TileTextFontWeight = MetroTileTextWeight.Bold;
                        (item as MetroTile).TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                        (item as MetroTile).Font = new System.Drawing.Font(pfc.Families[0], 18);
                    }
                }
                else if(item is Label)
                {
                    if(item.Name.Contains("transaction"))
                    {
                        (item as Label).Font = new System.Drawing.Font(pfc.Families[0], 40);
                        (item as Label).TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    }
                    else
                    {
                        (item as Label).Font = new System.Drawing.Font(pfc.Families[0], 40);
                        (item as Label).TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    }
                }
                else if(item is TextBox)
                {
                    if (item.Name.Contains("signIn"))
                    {
                        (item as TextBox).TextAlign = HorizontalAlignment.Center;
                        (item as TextBox).Font = new System.Drawing.Font(pfc.Families[0], 45);
                        (item as TextBox).UseSystemPasswordChar = true;
                    }
                    else /* if (item.Name.Contains("CustomValue"))*/
                    {
                        (item as TextBox).Font = new System.Drawing.Font(pfc.Families[0], 50);
                        (item as TextBox).TextAlign = HorizontalAlignment.Center;
                    }
                }
            }
            #region old-unoptimised
            /*foreach (Control main in this.Controls)
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
            }*/
            #endregion
        }

        /// <summary>
        /// ZMění barvu ovládacích prvků
        /// </summary>
        /// <param name="style">MetroColorStyle enumerator</param>
        private void SetStyle(MetroColorStyle style)
        {
            MainStyle = style;
            Style = style; //Sets form color
            foreach (Control item in controlsList)
            {
                if(item is MetroTile)
                {
                    (item as MetroTile).Style = style;
                }
                else if(item is Label)
                {
                    (item as Label).ForeColor = style.ToColor();
                }
                else if(item is TextBox)
                {
                    (item as TextBox).ForeColor = style.ToColor();
                }
            }
            #region old-unoptimised
              /* foreach (Control main in this.Controls)
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
               }*/
            #endregion
        }

        /// <summary>
        /// Zajišťuje animaci po stisku tlačítka
        /// </summary>
        private void NoHighlight()
        {
            Thread.Sleep(125);
            mainControl.Select();
        }

        private void MoneyWithdrawlSuccess()
        {
            DialogResult dr = MetroMessageBox.Show(this, resources.GetString("WithdrawlSuccessMessage"),
                resources.GetString("WithdrawlSuccessMessageTitle"),MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                moneyWithdrawlCustomValue.Text = "";
                HideAllExcept(mainPage);
            }
        }

        private void NewTransactionSuccess()
        {
            DialogResult dr = MetroMessageBox.Show(this, resources.GetString("TransactionSuccessMessage"),
                resources.GetString("TransactionSuccessMessageTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dr == DialogResult.OK)
            {
                transactionAccountTextBox.Text = "";
                transactionAmountTextBox.Text = "";
                HideAllExcept(mainPage);
            }
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
            ApplyResources(resources, controlsList);
        }

        /// <summary>
        /// Přenačte UI prvky a nastaví jazyk
        /// </summary>
        /// <param name="resources">Zdroje jazyka</param>
        /// <param name="controlCollections">Prvky pro změnu jazyka</param>
        private void ApplyResources(ComponentResourceManager resources, List<Control> controlCollections)
        {
            foreach (Control c in controlCollections)
            {
                resources.ApplyResources(c, c.Name);
                Console.WriteLine(c.ToString().PadRight(70) + "|" + c.Name.PadRight(70)+"|"+c.Text.PadRight(70));
               // ApplyResources(resources, c.Controls);
            }
            transactionHistoryTableAmount.Text = resources.GetString("transactionHistoryTableAmount.Text");
            transactionHistoryTableName.Text = resources.GetString("transactionHistoryTableName.Text");
            transactionHistoryTableReceiver.Text = resources.GetString("transactionHistoryTableReceiver.Text");
            transactionHistoryTableSender.Text = resources.GetString("transactionHistoryTableSender.Text");
            transactionHistoryTableSuccess.Text = resources.GetString("transactionHistoryTableSuccess.Text");
            transactionHistoryTableTime.Text = resources.GetString("transactionHistoryTableTime.Text");
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
            foreach (MetroTabPage slide in mainControl.TabPages)
            {
                if(slide != page)
                {
                    mainControl.HideTab(slide);
                }
            }
            mainControl.SelectTab(page);
            ChangeLanguage(Language.Default);
            page.Text = "";
            mainControl.Select();
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

        private void PINAddNumber(int number)
        {
            if(signInPIN.Text.Length < 4)
            {
                signInPIN.Text = signInPIN.Text + number.ToString();
            }
        }

        private void pinClearButton_Click(object sender, EventArgs e)
        {
            signInPIN.Clear();
        }

        private void pin0Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(0);
        }

        private void pinOKButton_Click(object sender, EventArgs e)
        {
            comunicator.HandleCommandRequest(ServerComunicator.Command.GetUserValidation, new List<string>() { cardNumber, signInPIN.Text });
            signInPIN.Clear();
            cardNumber = string.Empty;
            signInDropDown.Text = resources.GetString("signInDropDown.Text");
            comunicator.HandleCommandRequest(ServerComunicator.Command.GetMoneyAmount, new List<string>() { }); 
        }

        private void signInDropDown_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (JsonConvert.DeserializeObject(File.ReadAllText(data[0])).GetObjectType() == Classes.Type.Card)
            {
                string s = File.ReadAllText(data[0]);
                Console.WriteLine(s);
                Card c = JsonConvert.DeserializeObject<Card>(s);
                cardNumber = Convert.ToInt64(c.number, 16).ToString();
                signInDropDown.Text = resources.GetString("signInDropDown.Text.Alternative");
            }
        }

        private void signInDropDown_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pin1Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(1);
        }

        private void pin2Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(2);
        }

        private void pin3Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(3);
        }

        private void pin4Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(4);
        }

        private void pin5Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(5);
        }

        private void pin6Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(6);
        }

        private void pin7Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(7);
        }

        private void pin8Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(8);
        }

        private void pin9Button_Click(object sender, EventArgs e)
        {
            PINAddNumber(9);
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
            comunicator.HandleCommandRequest(ServerComunicator.Command.UserTransactionHistory,new List<string> { });
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(signInPage);
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            if(defaultLanguage)
            {
                LanguageSet(buttonLanguage, Language.English);
                buttonLanguage.TileImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("czech-republic");
                defaultLanguage = false;
            }
            else
            {
                LanguageSet(buttonLanguage, Language.Čeština);
                buttonLanguage.TileImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("united-kingdom");
                defaultLanguage = true;
            }
        }

        #endregion

        #region Money Deposit
        private void metroTile1_Click(object sender, EventArgs e)
        {
            moneyDepositDropDown.Select();
        }

        private void moneyDepositDropDown_DragDrop(object sender, DragEventArgs e)
        {
            decimal value = 0.00m;
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            value =  DnDHandler.MoneyHandler(data);
            DialogResult dr = MetroMessageBox.Show(this,
                resources.GetString("MoneyDepositMessage") + Environment.NewLine + Environment.NewLine + value.ToString(),
                resources.GetString("MoeyDepositMessageTitle"),
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                comunicator.HandleCommandRequest(ServerComunicator.Command.UserMoneyDeposit,new List<string>() { value.ToString() });
                DialogResult drr = MetroMessageBox.Show(this, resources.GetString("MoneyDepositSuccess"), 
                    resources.GetString("MoneyDepositSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                HideAllExcept(mainPage);
            }
        }

        private void moneyDepositDropDown_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
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
            MoneyManipulator.Withdrawl(200m, comunicator);
            MoneyWithdrawlSuccess();
        }

        private void moneyWithdrawl500Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
            MoneyManipulator.Withdrawl(500m, comunicator);
            MoneyWithdrawlSuccess();
        }

        private void moneyWithdrawl1000Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
            MoneyManipulator.Withdrawl(1000m, comunicator);
            MoneyWithdrawlSuccess();
        }

        private void moneyWithdrawl5000Tile_Click(object sender, EventArgs e)
        {
            NoHighlight();
            MoneyManipulator.Withdrawl(5000m, comunicator);
            MoneyWithdrawlSuccess();
        }

        private void moneyWithdrawlCustomTile_Click(object sender, EventArgs e)
        {
            NoHighlight();
            MoneyManipulator.Withdrawl(MoneyManipulator.DivideByNotes(Convert.ToDecimal(moneyWithdrawlCustomValue.Text)),
                Convert.ToDecimal(moneyWithdrawlCustomValue.Text), comunicator);
            MoneyWithdrawlSuccess();
        }

        private void moneyWithdrawlCustomValue_Leave(object sender, EventArgs e)
        {
            if (moneyWithdrawlCustomValue.Text.Length > 0)
            {
                decimal val = Convert.ToDecimal(moneyWithdrawlCustomValue.Text);
                moneyWithdrawlCustomValue.Text = MoneyManipulator.RoundToHundreds(val).ToString();
            }
        }

        private void moneyWithdrawlPage_Click(object sender, EventArgs e)
        {
            moneyWithdrawlPage.Select();
        }


        #endregion

        #region Transaction History
        private void transactionHistoryBack_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(mainPage);
        }

        #endregion

        #region New Transaction

        private void transactionNewBack_Click(object sender, EventArgs e)
        {
            NoHighlight();
            HideAllExcept(mainPage);
        }
        private void transactionSendNewTile_Click(object sender, EventArgs e)
        {
            if (transactionAccountTextBox.Text.Length == 10 && transactionAmountTextBox.Text.Length > 0)
            {
                comunicator.HandleCommandRequest(ServerComunicator.Command.UserNewTransaction,new List<string>() {transactionAccountTextBox.Text, transactionAmountTextBox.Text });
                NewTransactionSuccess();
            }
            else if(transactionAccountTextBox.Text.Length < 10)
            {
                DialogResult dr = MetroMessageBox.Show(this, resources.GetString("TransactionErrorMissingAccount"),
                    resources.GetString("TransactionErrorMissingAccountTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(transactionAmountTextBox.Text.Length < 1)
            {
                DialogResult dr = MetroMessageBox.Show(this, resources.GetString("TransactionErrorMissingAmount"),
                    resources.GetString("TransactionErrorMissingAmountTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MetroMessageBox.Show(this, resources.GetString("TransactionErrorMissingBoth"),
                    resources.GetString("TransactionErrorMissingBoth"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void debugCleanWallet_Click(object sender, EventArgs e)
        {

            System.IO.DirectoryInfo di = new DirectoryInfo("./Money/");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

    }
}
