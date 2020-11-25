using System;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Threading;
using System.Resources;
using System.ComponentModel;

namespace PSBNebesky
{
    public partial class Form1 : MetroForm
    {
        private MetroColorStyle colorStyle;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

        public Form1()
        {
            InitializeComponent();
            OnStart();
            ChangeColor(MetroColorStyle.Teal);
            SetUsername("Lukáš");
        }


        public void OnStart()
        {
            metroPanel1.Select();
            foreach (Control main in this.Controls)
            {
                if(main is MetroPanel)
                {
                    foreach(Control c in main.Controls)
                    {
                        if(c is MetroTile)
                        {
                            (c as MetroTile).TileTextFontSize = MetroTileTextSize.Tall;
                            (c as MetroTile).TileTextFontWeight = MetroTileTextWeight.Bold;
                            (c as MetroTile).TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                        }
                    }
                }
            }
        } //Method called on start of program that sets font size and weight as well as some other stuff

        private void ChangeColor(MetroColorStyle style) //Method called on start and on user induced action, that changes style (color) of application
        {
            Style = style; //Sets form color
            foreach (Control main in this.Controls)
            {
                if(main is MetroPanel)
                {
                    foreach(Control c in main.Controls)
                    {
                        if(c is MetroTile)
                        {
                            (c as MetroTile).Style = style;
                        }
                    }
                }
                else if(main is MetroTile)
                {
                    (main as MetroTile).Style = style;
                }
            }
            colorStyle = style;
        }

        private void NoHighlight()
        {
            Thread.Sleep(125);
            metroPanel1.Select();
        } //Removes highlighting from button after click, also provides some sleep time to make it feel natural

        private void buttonIntake_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Program.Language.Čeština);
            NoHighlight();
        }

        private void buttonWith_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Program.Language.English);
            NoHighlight();
        }

        private void SetUsername(string user)
        {
            //resources

        }

        private void ChangeLanguage(Program.Language language)
        {
            System.Globalization.CultureInfo cultureInfo;
            switch (language)
            {
                case Program.Language.Čeština:
                    cultureInfo = new System.Globalization.CultureInfo("cs");
                    System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                    System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
                    break;
                case Program.Language.English:
                    cultureInfo = new System.Globalization.CultureInfo("en");
                    System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
                    System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                    break;
                default:
                    break;
            }
            //resources.ApplyResources(this, "$this");
            ApplyResources(resources, this.Controls);
            this.Text = resources.GetString("$this.Text");
            Console.WriteLine(this.Text);
            FixTitle();
        }

        private void ApplyResources(ComponentResourceManager resources, Control.ControlCollection controlCollections)
        {
            foreach (Control c in controlCollections)
            {
                resources.ApplyResources(c, c.Name);
                ApplyResources(resources, c.Controls);
            }
            OnStart();
        }

        private void buttonNewTransaction_Click(object sender, EventArgs e)
        {
        }

        private void FixTitle()
        {
            this.Size = new System.Drawing.Size(this.Size.Width + 1, this.Size.Height);
            this.Size = new System.Drawing.Size(this.Size.Width - 1, this.Size.Height);
        }
    }
}
