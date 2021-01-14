namespace PSBNebesky
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boxLog = new System.Windows.Forms.ListBox();
            this.mainPage = new MetroFramework.Controls.MetroTabPage();
            this.buttonLeave = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buttonTransactionHistory = new MetroFramework.Controls.MetroTile();
            this.buttonNewTransaction = new MetroFramework.Controls.MetroTile();
            this.buttonWith = new MetroFramework.Controls.MetroTile();
            this.buttonIntake = new MetroFramework.Controls.MetroTile();
            this.buttonEnglish = new MetroFramework.Controls.MetroTile();
            this.buttonCzech = new MetroFramework.Controls.MetroTile();
            this.mainControl = new MetroFramework.Controls.MetroTabControl();
            this.moneyWithdrawlPage = new MetroFramework.Controls.MetroTabPage();
            this.moneyWithdrawlBack = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.moneyWithdrawl200Tile = new MetroFramework.Controls.MetroTile();
            this.moneyWithdrawl500Tile = new MetroFramework.Controls.MetroTile();
            this.moneyWithdrawl1000Tile = new MetroFramework.Controls.MetroTile();
            this.moneyWithdrawl5000Tile = new MetroFramework.Controls.MetroTile();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.moneyWithdrawlCustomValue = new System.Windows.Forms.TextBox();
            this.moneyWithdrawlCustomTile = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionHistoryPage = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.moneyIntakePage = new MetroFramework.Controls.MetroTabPage();
            this.moneyDepositBack = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.moneyDeposit200Tile = new MetroFramework.Controls.MetroTile();
            this.moneyDeposit500Tile = new MetroFramework.Controls.MetroTile();
            this.moneyDeposit1000Tile = new MetroFramework.Controls.MetroTile();
            this.moneyDeposti5000Tile = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.moneyDepositCustomValue = new System.Windows.Forms.TextBox();
            this.moneyDepositCustomTile = new MetroFramework.Controls.MetroTile();
            this.moneyDepositLabel = new System.Windows.Forms.Label();
            this.signInPage = new MetroFramework.Controls.MetroTabPage();
            this.signInNewUser = new MetroFramework.Controls.MetroTile();
            this.signInUserBox = new System.Windows.Forms.TextBox();
            this.signInPassBox = new System.Windows.Forms.TextBox();
            this.signInButton = new MetroFramework.Controls.MetroTile();
            this.signInLabel = new System.Windows.Forms.Label();
            this.newTransactionPage = new MetroFramework.Controls.MetroTabPage();
            this.consoleButton = new MetroFramework.Controls.MetroButton();
            this.exitSimulator = new System.Windows.Forms.Button();
            this.testServer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMOneyDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMoneyWithdrawl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTransactionHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNewTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPage.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mainControl.SuspendLayout();
            this.moneyWithdrawlPage.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.transactionHistoryPage.SuspendLayout();
            this.moneyIntakePage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.signInPage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxLog
            // 
            resources.ApplyResources(this.boxLog, "boxLog");
            this.boxLog.FormattingEnabled = true;
            this.boxLog.Name = "boxLog";
            // 
            // mainPage
            // 
            resources.ApplyResources(this.mainPage, "mainPage");
            this.mainPage.Controls.Add(this.buttonLeave);
            this.mainPage.Controls.Add(this.metroPanel1);
            this.mainPage.Controls.Add(this.buttonEnglish);
            this.mainPage.Controls.Add(this.buttonCzech);
            this.mainPage.HorizontalScrollbarBarColor = true;
            this.mainPage.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPage.HorizontalScrollbarSize = 10;
            this.mainPage.Name = "mainPage";
            this.mainPage.VerticalScrollbarBarColor = true;
            this.mainPage.VerticalScrollbarHighlightOnWheel = false;
            this.mainPage.VerticalScrollbarSize = 10;
            // 
            // buttonLeave
            // 
            resources.ApplyResources(this.buttonLeave, "buttonLeave");
            this.buttonLeave.ActiveControl = null;
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.UseSelectable = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // metroPanel1
            // 
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.Controls.Add(this.buttonTransactionHistory);
            this.metroPanel1.Controls.Add(this.buttonNewTransaction);
            this.metroPanel1.Controls.Add(this.buttonWith);
            this.metroPanel1.Controls.Add(this.buttonIntake);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 14;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 14;
            // 
            // buttonTransactionHistory
            // 
            resources.ApplyResources(this.buttonTransactionHistory, "buttonTransactionHistory");
            this.buttonTransactionHistory.ActiveControl = null;
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.UseSelectable = true;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // buttonNewTransaction
            // 
            resources.ApplyResources(this.buttonNewTransaction, "buttonNewTransaction");
            this.buttonNewTransaction.ActiveControl = null;
            this.buttonNewTransaction.Name = "buttonNewTransaction";
            this.buttonNewTransaction.UseSelectable = true;
            this.buttonNewTransaction.Click += new System.EventHandler(this.buttonNewTransaction_Click);
            // 
            // buttonWith
            // 
            resources.ApplyResources(this.buttonWith, "buttonWith");
            this.buttonWith.ActiveControl = null;
            this.buttonWith.Name = "buttonWith";
            this.buttonWith.UseSelectable = true;
            this.buttonWith.Click += new System.EventHandler(this.buttonWith_Click);
            // 
            // buttonIntake
            // 
            resources.ApplyResources(this.buttonIntake, "buttonIntake");
            this.buttonIntake.ActiveControl = null;
            this.buttonIntake.Name = "buttonIntake";
            this.buttonIntake.UseSelectable = true;
            this.buttonIntake.Click += new System.EventHandler(this.buttonIntake_Click);
            // 
            // buttonEnglish
            // 
            resources.ApplyResources(this.buttonEnglish, "buttonEnglish");
            this.buttonEnglish.ActiveControl = null;
            this.buttonEnglish.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.TileImage = global::PSBNebesky.Properties.Resources.united_kingdom;
            this.buttonEnglish.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEnglish.UseCustomBackColor = true;
            this.buttonEnglish.UseSelectable = true;
            this.buttonEnglish.UseTileImage = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // buttonCzech
            // 
            resources.ApplyResources(this.buttonCzech, "buttonCzech");
            this.buttonCzech.ActiveControl = null;
            this.buttonCzech.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCzech.Name = "buttonCzech";
            this.buttonCzech.TileImage = global::PSBNebesky.Properties.Resources.czech_republic1;
            this.buttonCzech.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCzech.UseCustomBackColor = true;
            this.buttonCzech.UseSelectable = true;
            this.buttonCzech.UseTileImage = true;
            this.buttonCzech.Click += new System.EventHandler(this.buttonCzech_Click);
            // 
            // mainControl
            // 
            resources.ApplyResources(this.mainControl, "mainControl");
            this.mainControl.Controls.Add(this.mainPage);
            this.mainControl.Controls.Add(this.moneyWithdrawlPage);
            this.mainControl.Controls.Add(this.transactionHistoryPage);
            this.mainControl.Controls.Add(this.moneyIntakePage);
            this.mainControl.Controls.Add(this.signInPage);
            this.mainControl.Controls.Add(this.newTransactionPage);
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 0;
            this.mainControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainControl.UseSelectable = true;
            // 
            // moneyWithdrawlPage
            // 
            resources.ApplyResources(this.moneyWithdrawlPage, "moneyWithdrawlPage");
            this.moneyWithdrawlPage.Controls.Add(this.moneyWithdrawlBack);
            this.moneyWithdrawlPage.Controls.Add(this.flowLayoutPanel2);
            this.moneyWithdrawlPage.Controls.Add(this.label1);
            this.moneyWithdrawlPage.HorizontalScrollbarBarColor = true;
            this.moneyWithdrawlPage.HorizontalScrollbarHighlightOnWheel = false;
            this.moneyWithdrawlPage.HorizontalScrollbarSize = 10;
            this.moneyWithdrawlPage.Name = "moneyWithdrawlPage";
            this.moneyWithdrawlPage.VerticalScrollbarBarColor = true;
            this.moneyWithdrawlPage.VerticalScrollbarHighlightOnWheel = false;
            this.moneyWithdrawlPage.VerticalScrollbarSize = 10;
            // 
            // moneyWithdrawlBack
            // 
            resources.ApplyResources(this.moneyWithdrawlBack, "moneyWithdrawlBack");
            this.moneyWithdrawlBack.ActiveControl = null;
            this.moneyWithdrawlBack.Name = "moneyWithdrawlBack";
            this.moneyWithdrawlBack.UseSelectable = true;
            this.moneyWithdrawlBack.Click += new System.EventHandler(this.moneyWithdrawlBack_Click);
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.moneyWithdrawl200Tile);
            this.flowLayoutPanel2.Controls.Add(this.moneyWithdrawl500Tile);
            this.flowLayoutPanel2.Controls.Add(this.moneyWithdrawl1000Tile);
            this.flowLayoutPanel2.Controls.Add(this.moneyWithdrawl5000Tile);
            this.flowLayoutPanel2.Controls.Add(this.metroPanel3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // moneyWithdrawl200Tile
            // 
            resources.ApplyResources(this.moneyWithdrawl200Tile, "moneyWithdrawl200Tile");
            this.moneyWithdrawl200Tile.ActiveControl = null;
            this.moneyWithdrawl200Tile.Name = "moneyWithdrawl200Tile";
            this.moneyWithdrawl200Tile.UseSelectable = true;
            this.moneyWithdrawl200Tile.Click += new System.EventHandler(this.moneyWithdrawl200Tile_Click);
            // 
            // moneyWithdrawl500Tile
            // 
            resources.ApplyResources(this.moneyWithdrawl500Tile, "moneyWithdrawl500Tile");
            this.moneyWithdrawl500Tile.ActiveControl = null;
            this.moneyWithdrawl500Tile.Name = "moneyWithdrawl500Tile";
            this.moneyWithdrawl500Tile.UseSelectable = true;
            this.moneyWithdrawl500Tile.Click += new System.EventHandler(this.moneyWithdrawl500Tile_Click);
            // 
            // moneyWithdrawl1000Tile
            // 
            resources.ApplyResources(this.moneyWithdrawl1000Tile, "moneyWithdrawl1000Tile");
            this.moneyWithdrawl1000Tile.ActiveControl = null;
            this.moneyWithdrawl1000Tile.Name = "moneyWithdrawl1000Tile";
            this.moneyWithdrawl1000Tile.UseSelectable = true;
            this.moneyWithdrawl1000Tile.Click += new System.EventHandler(this.moneyWithdrawl1000Tile_Click);
            // 
            // moneyWithdrawl5000Tile
            // 
            resources.ApplyResources(this.moneyWithdrawl5000Tile, "moneyWithdrawl5000Tile");
            this.moneyWithdrawl5000Tile.ActiveControl = null;
            this.moneyWithdrawl5000Tile.Name = "moneyWithdrawl5000Tile";
            this.moneyWithdrawl5000Tile.UseSelectable = true;
            this.moneyWithdrawl5000Tile.Click += new System.EventHandler(this.moneyWithdrawl5000Tile_Click);
            // 
            // metroPanel3
            // 
            resources.ApplyResources(this.metroPanel3, "metroPanel3");
            this.metroPanel3.Controls.Add(this.moneyWithdrawlCustomValue);
            this.metroPanel3.Controls.Add(this.moneyWithdrawlCustomTile);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // moneyWithdrawlCustomValue
            // 
            resources.ApplyResources(this.moneyWithdrawlCustomValue, "moneyWithdrawlCustomValue");
            this.moneyWithdrawlCustomValue.Name = "moneyWithdrawlCustomValue";
            this.moneyWithdrawlCustomValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // moneyWithdrawlCustomTile
            // 
            resources.ApplyResources(this.moneyWithdrawlCustomTile, "moneyWithdrawlCustomTile");
            this.moneyWithdrawlCustomTile.ActiveControl = null;
            this.moneyWithdrawlCustomTile.Name = "moneyWithdrawlCustomTile";
            this.moneyWithdrawlCustomTile.UseSelectable = true;
            this.moneyWithdrawlCustomTile.Click += new System.EventHandler(this.moneyWithdrawlCustomTile_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // transactionHistoryPage
            // 
            resources.ApplyResources(this.transactionHistoryPage, "transactionHistoryPage");
            this.transactionHistoryPage.Controls.Add(this.button2);
            this.transactionHistoryPage.HorizontalScrollbarBarColor = true;
            this.transactionHistoryPage.HorizontalScrollbarHighlightOnWheel = false;
            this.transactionHistoryPage.HorizontalScrollbarSize = 10;
            this.transactionHistoryPage.Name = "transactionHistoryPage";
            this.transactionHistoryPage.VerticalScrollbarBarColor = true;
            this.transactionHistoryPage.VerticalScrollbarHighlightOnWheel = false;
            this.transactionHistoryPage.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // moneyIntakePage
            // 
            resources.ApplyResources(this.moneyIntakePage, "moneyIntakePage");
            this.moneyIntakePage.Controls.Add(this.moneyDepositBack);
            this.moneyIntakePage.Controls.Add(this.flowLayoutPanel1);
            this.moneyIntakePage.Controls.Add(this.moneyDepositLabel);
            this.moneyIntakePage.HorizontalScrollbarBarColor = true;
            this.moneyIntakePage.HorizontalScrollbarHighlightOnWheel = false;
            this.moneyIntakePage.HorizontalScrollbarSize = 10;
            this.moneyIntakePage.Name = "moneyIntakePage";
            this.moneyIntakePage.VerticalScrollbarBarColor = true;
            this.moneyIntakePage.VerticalScrollbarHighlightOnWheel = false;
            this.moneyIntakePage.VerticalScrollbarSize = 10;
            // 
            // moneyDepositBack
            // 
            resources.ApplyResources(this.moneyDepositBack, "moneyDepositBack");
            this.moneyDepositBack.ActiveControl = null;
            this.moneyDepositBack.Name = "moneyDepositBack";
            this.moneyDepositBack.UseSelectable = true;
            this.moneyDepositBack.Click += new System.EventHandler(this.moneyDepositBack_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.moneyDeposit200Tile);
            this.flowLayoutPanel1.Controls.Add(this.moneyDeposit500Tile);
            this.flowLayoutPanel1.Controls.Add(this.moneyDeposit1000Tile);
            this.flowLayoutPanel1.Controls.Add(this.moneyDeposti5000Tile);
            this.flowLayoutPanel1.Controls.Add(this.metroPanel2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // moneyDeposit200Tile
            // 
            resources.ApplyResources(this.moneyDeposit200Tile, "moneyDeposit200Tile");
            this.moneyDeposit200Tile.ActiveControl = null;
            this.moneyDeposit200Tile.Name = "moneyDeposit200Tile";
            this.moneyDeposit200Tile.UseSelectable = true;
            this.moneyDeposit200Tile.Click += new System.EventHandler(this.moneyDeposit200Tile_Click);
            // 
            // moneyDeposit500Tile
            // 
            resources.ApplyResources(this.moneyDeposit500Tile, "moneyDeposit500Tile");
            this.moneyDeposit500Tile.ActiveControl = null;
            this.moneyDeposit500Tile.Name = "moneyDeposit500Tile";
            this.moneyDeposit500Tile.UseSelectable = true;
            this.moneyDeposit500Tile.Click += new System.EventHandler(this.moneyDeposit500Tile_Click);
            // 
            // moneyDeposit1000Tile
            // 
            resources.ApplyResources(this.moneyDeposit1000Tile, "moneyDeposit1000Tile");
            this.moneyDeposit1000Tile.ActiveControl = null;
            this.moneyDeposit1000Tile.Name = "moneyDeposit1000Tile";
            this.moneyDeposit1000Tile.UseSelectable = true;
            this.moneyDeposit1000Tile.Click += new System.EventHandler(this.moneyDeposit1000Tile_Click);
            // 
            // moneyDeposti5000Tile
            // 
            resources.ApplyResources(this.moneyDeposti5000Tile, "moneyDeposti5000Tile");
            this.moneyDeposti5000Tile.ActiveControl = null;
            this.moneyDeposti5000Tile.Name = "moneyDeposti5000Tile";
            this.moneyDeposti5000Tile.UseSelectable = true;
            this.moneyDeposti5000Tile.Click += new System.EventHandler(this.moneyDeposti5000Tile_Click);
            // 
            // metroPanel2
            // 
            resources.ApplyResources(this.metroPanel2, "metroPanel2");
            this.metroPanel2.Controls.Add(this.moneyDepositCustomValue);
            this.metroPanel2.Controls.Add(this.moneyDepositCustomTile);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // moneyDepositCustomValue
            // 
            resources.ApplyResources(this.moneyDepositCustomValue, "moneyDepositCustomValue");
            this.moneyDepositCustomValue.Name = "moneyDepositCustomValue";
            this.moneyDepositCustomValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // moneyDepositCustomTile
            // 
            resources.ApplyResources(this.moneyDepositCustomTile, "moneyDepositCustomTile");
            this.moneyDepositCustomTile.ActiveControl = null;
            this.moneyDepositCustomTile.Name = "moneyDepositCustomTile";
            this.moneyDepositCustomTile.UseSelectable = true;
            this.moneyDepositCustomTile.Click += new System.EventHandler(this.moneyDepositCustomTile_Click);
            // 
            // moneyDepositLabel
            // 
            resources.ApplyResources(this.moneyDepositLabel, "moneyDepositLabel");
            this.moneyDepositLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyDepositLabel.Name = "moneyDepositLabel";
            // 
            // signInPage
            // 
            resources.ApplyResources(this.signInPage, "signInPage");
            this.signInPage.Controls.Add(this.signInNewUser);
            this.signInPage.Controls.Add(this.signInUserBox);
            this.signInPage.Controls.Add(this.signInPassBox);
            this.signInPage.Controls.Add(this.signInButton);
            this.signInPage.Controls.Add(this.signInLabel);
            this.signInPage.HorizontalScrollbarBarColor = true;
            this.signInPage.HorizontalScrollbarHighlightOnWheel = false;
            this.signInPage.HorizontalScrollbarSize = 10;
            this.signInPage.Name = "signInPage";
            this.signInPage.VerticalScrollbarBarColor = true;
            this.signInPage.VerticalScrollbarHighlightOnWheel = false;
            this.signInPage.VerticalScrollbarSize = 10;
            // 
            // signInNewUser
            // 
            resources.ApplyResources(this.signInNewUser, "signInNewUser");
            this.signInNewUser.ActiveControl = null;
            this.signInNewUser.Name = "signInNewUser";
            this.signInNewUser.UseSelectable = true;
            this.signInNewUser.Click += new System.EventHandler(this.signInNewUser_Click);
            // 
            // signInUserBox
            // 
            resources.ApplyResources(this.signInUserBox, "signInUserBox");
            this.signInUserBox.Name = "signInUserBox";
            // 
            // signInPassBox
            // 
            resources.ApplyResources(this.signInPassBox, "signInPassBox");
            this.signInPassBox.Name = "signInPassBox";
            this.signInPassBox.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            resources.ApplyResources(this.signInButton, "signInButton");
            this.signInButton.ActiveControl = null;
            this.signInButton.Name = "signInButton";
            this.signInButton.UseSelectable = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signInLabel
            // 
            resources.ApplyResources(this.signInLabel, "signInLabel");
            this.signInLabel.BackColor = System.Drawing.Color.White;
            this.signInLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.signInLabel.Name = "signInLabel";
            // 
            // newTransactionPage
            // 
            resources.ApplyResources(this.newTransactionPage, "newTransactionPage");
            this.newTransactionPage.HorizontalScrollbarBarColor = true;
            this.newTransactionPage.HorizontalScrollbarHighlightOnWheel = false;
            this.newTransactionPage.HorizontalScrollbarSize = 10;
            this.newTransactionPage.Name = "newTransactionPage";
            this.newTransactionPage.VerticalScrollbarBarColor = true;
            this.newTransactionPage.VerticalScrollbarHighlightOnWheel = false;
            this.newTransactionPage.VerticalScrollbarSize = 10;
            // 
            // consoleButton
            // 
            resources.ApplyResources(this.consoleButton, "consoleButton");
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.UseSelectable = true;
            this.consoleButton.Click += new System.EventHandler(this.consoleButton_Click);
            this.consoleButton.MouseHover += new System.EventHandler(this.consoleButton_Enter);
            // 
            // exitSimulator
            // 
            resources.ApplyResources(this.exitSimulator, "exitSimulator");
            this.exitSimulator.Name = "exitSimulator";
            this.exitSimulator.UseVisualStyleBackColor = true;
            this.exitSimulator.Click += new System.EventHandler(this.exitSimulator_Click);
            // 
            // testServer
            // 
            resources.ApplyResources(this.testServer, "testServer");
            this.testServer.Name = "testServer";
            this.testServer.UseVisualStyleBackColor = true;
            this.testServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripSignIn,
            this.menuStripMainPage,
            this.menuStripMOneyDeposit,
            this.menuStripMoneyWithdrawl,
            this.menuStripTransactionHistory,
            this.menuStripNewTransaction});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // menuStripSignIn
            // 
            resources.ApplyResources(this.menuStripSignIn, "menuStripSignIn");
            this.menuStripSignIn.Name = "menuStripSignIn";
            this.menuStripSignIn.Click += new System.EventHandler(this.menuStripSignIn_Click);
            // 
            // menuStripMainPage
            // 
            resources.ApplyResources(this.menuStripMainPage, "menuStripMainPage");
            this.menuStripMainPage.Name = "menuStripMainPage";
            this.menuStripMainPage.Click += new System.EventHandler(this.menuStripMainPage_Click);
            // 
            // menuStripMOneyDeposit
            // 
            resources.ApplyResources(this.menuStripMOneyDeposit, "menuStripMOneyDeposit");
            this.menuStripMOneyDeposit.Name = "menuStripMOneyDeposit";
            this.menuStripMOneyDeposit.Click += new System.EventHandler(this.menuStripMOneyDeposit_Click);
            // 
            // menuStripMoneyWithdrawl
            // 
            resources.ApplyResources(this.menuStripMoneyWithdrawl, "menuStripMoneyWithdrawl");
            this.menuStripMoneyWithdrawl.Name = "menuStripMoneyWithdrawl";
            this.menuStripMoneyWithdrawl.Click += new System.EventHandler(this.menuStripMoneyWithdrawl_Click);
            // 
            // menuStripTransactionHistory
            // 
            resources.ApplyResources(this.menuStripTransactionHistory, "menuStripTransactionHistory");
            this.menuStripTransactionHistory.Name = "menuStripTransactionHistory";
            this.menuStripTransactionHistory.Click += new System.EventHandler(this.menuStripTransactionHistory_Click);
            // 
            // menuStripNewTransaction
            // 
            resources.ApplyResources(this.menuStripNewTransaction, "menuStripNewTransaction");
            this.menuStripNewTransaction.Name = "menuStripNewTransaction";
            this.menuStripNewTransaction.Click += new System.EventHandler(this.menuStripNewTransaction_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testServer);
            this.Controls.Add(this.exitSimulator);
            this.Controls.Add(this.consoleButton);
            this.Controls.Add(this.mainControl);
            this.Controls.Add(this.boxLog);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.mainPage.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.mainControl.ResumeLayout(false);
            this.moneyWithdrawlPage.ResumeLayout(false);
            this.moneyWithdrawlPage.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.transactionHistoryPage.ResumeLayout(false);
            this.moneyIntakePage.ResumeLayout(false);
            this.moneyIntakePage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.signInPage.ResumeLayout(false);
            this.signInPage.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox boxLog;
        private MetroFramework.Controls.MetroTabPage mainPage;
        private MetroFramework.Controls.MetroTile buttonEnglish;
        private MetroFramework.Controls.MetroTile buttonCzech;
        private MetroFramework.Controls.MetroTile buttonLeave;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile buttonTransactionHistory;
        private MetroFramework.Controls.MetroTile buttonNewTransaction;
        private MetroFramework.Controls.MetroTile buttonWith;
        private MetroFramework.Controls.MetroTile buttonIntake;
        private MetroFramework.Controls.MetroTabControl mainControl;
        private MetroFramework.Controls.MetroTabPage signInPage;
        private MetroFramework.Controls.MetroTabPage transactionHistoryPage;
        private MetroFramework.Controls.MetroButton consoleButton;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTabPage moneyIntakePage;
        private MetroFramework.Controls.MetroTabPage moneyWithdrawlPage;
        private MetroFramework.Controls.MetroTabPage newTransactionPage;
        private System.Windows.Forms.Button exitSimulator;
        private System.Windows.Forms.Label signInLabel;
        private MetroFramework.Controls.MetroTile signInButton;
        private System.Windows.Forms.TextBox signInPassBox;
        private System.Windows.Forms.TextBox signInUserBox;
        private MetroFramework.Controls.MetroTile signInNewUser;
        private System.Windows.Forms.Button testServer;
        private System.Windows.Forms.Label moneyDepositLabel;
        private MetroFramework.Controls.MetroTile moneyDeposit200Tile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile moneyDeposit500Tile;
        private MetroFramework.Controls.MetroTile moneyDeposit1000Tile;
        private MetroFramework.Controls.MetroTile moneyDeposti5000Tile;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile moneyDepositCustomTile;
        private System.Windows.Forms.TextBox moneyDepositCustomValue;
        private MetroFramework.Controls.MetroTile moneyDepositBack;
        private MetroFramework.Controls.MetroTile moneyWithdrawlBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroTile moneyWithdrawl200Tile;
        private MetroFramework.Controls.MetroTile moneyWithdrawl500Tile;
        private MetroFramework.Controls.MetroTile moneyWithdrawl1000Tile;
        private MetroFramework.Controls.MetroTile moneyWithdrawl5000Tile;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.TextBox moneyWithdrawlCustomValue;
        private MetroFramework.Controls.MetroTile moneyWithdrawlCustomTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripSignIn;
        private System.Windows.Forms.ToolStripMenuItem menuStripMainPage;
        private System.Windows.Forms.ToolStripMenuItem menuStripMOneyDeposit;
        private System.Windows.Forms.ToolStripMenuItem menuStripMoneyWithdrawl;
        private System.Windows.Forms.ToolStripMenuItem menuStripTransactionHistory;
        private System.Windows.Forms.ToolStripMenuItem menuStripNewTransaction;
    }
}

