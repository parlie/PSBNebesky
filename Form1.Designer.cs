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
            this.buttonLanguage = new MetroFramework.Controls.MetroTile();
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
            this.moneyWithdrawlLabel = new System.Windows.Forms.Label();
            this.transactionHistoryPage = new MetroFramework.Controls.MetroTabPage();
            this.moneyIntakePage = new MetroFramework.Controls.MetroTabPage();
            this.moneyDepositBack = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.moneyDeposit200Tile = new MetroFramework.Controls.MetroTile();
            this.moneyDeposit500Tile = new MetroFramework.Controls.MetroTile();
            this.moneyDeposit1000Tile = new MetroFramework.Controls.MetroTile();
            this.moneyDeposit5000Tile = new MetroFramework.Controls.MetroTile();
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
            this.buttonGoTo = new System.Windows.Forms.Button();
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
            this.moneyIntakePage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.signInPage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxLog
            // 
            this.boxLog.FormattingEnabled = true;
            resources.ApplyResources(this.boxLog, "boxLog");
            this.boxLog.Name = "boxLog";
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.buttonLeave);
            this.mainPage.Controls.Add(this.metroPanel1);
            this.mainPage.Controls.Add(this.buttonLanguage);
            this.mainPage.HorizontalScrollbarBarColor = true;
            this.mainPage.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.mainPage, "mainPage");
            this.mainPage.Name = "mainPage";
            this.mainPage.VerticalScrollbarBarColor = true;
            this.mainPage.VerticalScrollbarHighlightOnWheel = false;
            this.mainPage.VerticalScrollbarSize = 10;
            // 
            // buttonLeave
            // 
            this.buttonLeave.ActiveControl = null;
            resources.ApplyResources(this.buttonLeave, "buttonLeave");
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
            this.buttonTransactionHistory.ActiveControl = null;
            resources.ApplyResources(this.buttonTransactionHistory, "buttonTransactionHistory");
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.UseSelectable = true;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // buttonNewTransaction
            // 
            this.buttonNewTransaction.ActiveControl = null;
            resources.ApplyResources(this.buttonNewTransaction, "buttonNewTransaction");
            this.buttonNewTransaction.Name = "buttonNewTransaction";
            this.buttonNewTransaction.UseSelectable = true;
            this.buttonNewTransaction.Click += new System.EventHandler(this.buttonNewTransaction_Click);
            // 
            // buttonWith
            // 
            this.buttonWith.ActiveControl = null;
            resources.ApplyResources(this.buttonWith, "buttonWith");
            this.buttonWith.Name = "buttonWith";
            this.buttonWith.UseSelectable = true;
            this.buttonWith.Click += new System.EventHandler(this.buttonWith_Click);
            // 
            // buttonIntake
            // 
            this.buttonIntake.ActiveControl = null;
            resources.ApplyResources(this.buttonIntake, "buttonIntake");
            this.buttonIntake.Name = "buttonIntake";
            this.buttonIntake.UseSelectable = true;
            this.buttonIntake.Click += new System.EventHandler(this.buttonIntake_Click);
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.ActiveControl = null;
            resources.ApplyResources(this.buttonLanguage, "buttonLanguage");
            this.buttonLanguage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.TileImage = global::PSBNebesky.Properties.Resources.united_kingdom;
            this.buttonLanguage.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLanguage.UseCustomBackColor = true;
            this.buttonLanguage.UseSelectable = true;
            this.buttonLanguage.UseTileImage = true;
            this.buttonLanguage.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // mainControl
            // 
            this.mainControl.Controls.Add(this.transactionHistoryPage);
            this.mainControl.Controls.Add(this.moneyWithdrawlPage);
            this.mainControl.Controls.Add(this.mainPage);
            this.mainControl.Controls.Add(this.moneyIntakePage);
            this.mainControl.Controls.Add(this.signInPage);
            this.mainControl.Controls.Add(this.newTransactionPage);
            resources.ApplyResources(this.mainControl, "mainControl");
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 1;
            this.mainControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainControl.Style = MetroFramework.MetroColorStyle.Teal;
            this.mainControl.UseSelectable = true;
            // 
            // moneyWithdrawlPage
            // 
            this.moneyWithdrawlPage.Controls.Add(this.moneyWithdrawlBack);
            this.moneyWithdrawlPage.Controls.Add(this.flowLayoutPanel2);
            this.moneyWithdrawlPage.Controls.Add(this.moneyWithdrawlLabel);
            this.moneyWithdrawlPage.HorizontalScrollbarBarColor = true;
            this.moneyWithdrawlPage.HorizontalScrollbarHighlightOnWheel = false;
            this.moneyWithdrawlPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.moneyWithdrawlPage, "moneyWithdrawlPage");
            this.moneyWithdrawlPage.Name = "moneyWithdrawlPage";
            this.moneyWithdrawlPage.VerticalScrollbarBarColor = true;
            this.moneyWithdrawlPage.VerticalScrollbarHighlightOnWheel = false;
            this.moneyWithdrawlPage.VerticalScrollbarSize = 10;
            // 
            // moneyWithdrawlBack
            // 
            this.moneyWithdrawlBack.ActiveControl = null;
            resources.ApplyResources(this.moneyWithdrawlBack, "moneyWithdrawlBack");
            this.moneyWithdrawlBack.Name = "moneyWithdrawlBack";
            this.moneyWithdrawlBack.UseSelectable = true;
            this.moneyWithdrawlBack.Click += new System.EventHandler(this.moneyWithdrawlBack_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.moneyWithdrawl200Tile);
            this.flowLayoutPanel2.Controls.Add(this.moneyWithdrawl500Tile);
            this.flowLayoutPanel2.Controls.Add(this.moneyWithdrawl1000Tile);
            this.flowLayoutPanel2.Controls.Add(this.moneyWithdrawl5000Tile);
            this.flowLayoutPanel2.Controls.Add(this.metroPanel3);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // moneyWithdrawl200Tile
            // 
            this.moneyWithdrawl200Tile.ActiveControl = null;
            resources.ApplyResources(this.moneyWithdrawl200Tile, "moneyWithdrawl200Tile");
            this.moneyWithdrawl200Tile.Name = "moneyWithdrawl200Tile";
            this.moneyWithdrawl200Tile.UseSelectable = true;
            this.moneyWithdrawl200Tile.Click += new System.EventHandler(this.moneyWithdrawl200Tile_Click);
            // 
            // moneyWithdrawl500Tile
            // 
            this.moneyWithdrawl500Tile.ActiveControl = null;
            resources.ApplyResources(this.moneyWithdrawl500Tile, "moneyWithdrawl500Tile");
            this.moneyWithdrawl500Tile.Name = "moneyWithdrawl500Tile";
            this.moneyWithdrawl500Tile.UseSelectable = true;
            this.moneyWithdrawl500Tile.Click += new System.EventHandler(this.moneyWithdrawl500Tile_Click);
            // 
            // moneyWithdrawl1000Tile
            // 
            this.moneyWithdrawl1000Tile.ActiveControl = null;
            resources.ApplyResources(this.moneyWithdrawl1000Tile, "moneyWithdrawl1000Tile");
            this.moneyWithdrawl1000Tile.Name = "moneyWithdrawl1000Tile";
            this.moneyWithdrawl1000Tile.UseSelectable = true;
            this.moneyWithdrawl1000Tile.Click += new System.EventHandler(this.moneyWithdrawl1000Tile_Click);
            // 
            // moneyWithdrawl5000Tile
            // 
            this.moneyWithdrawl5000Tile.ActiveControl = null;
            resources.ApplyResources(this.moneyWithdrawl5000Tile, "moneyWithdrawl5000Tile");
            this.moneyWithdrawl5000Tile.Name = "moneyWithdrawl5000Tile";
            this.moneyWithdrawl5000Tile.UseSelectable = true;
            this.moneyWithdrawl5000Tile.Click += new System.EventHandler(this.moneyWithdrawl5000Tile_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.moneyWithdrawlCustomValue);
            this.metroPanel3.Controls.Add(this.moneyWithdrawlCustomTile);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel3, "metroPanel3");
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
            this.moneyWithdrawlCustomTile.ActiveControl = null;
            resources.ApplyResources(this.moneyWithdrawlCustomTile, "moneyWithdrawlCustomTile");
            this.moneyWithdrawlCustomTile.Name = "moneyWithdrawlCustomTile";
            this.moneyWithdrawlCustomTile.UseSelectable = true;
            this.moneyWithdrawlCustomTile.Click += new System.EventHandler(this.moneyWithdrawlCustomTile_Click);
            // 
            // moneyWithdrawlLabel
            // 
            resources.ApplyResources(this.moneyWithdrawlLabel, "moneyWithdrawlLabel");
            this.moneyWithdrawlLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyWithdrawlLabel.Name = "moneyWithdrawlLabel";
            // 
            // transactionHistoryPage
            // 
            resources.ApplyResources(this.transactionHistoryPage, "transactionHistoryPage");
            this.transactionHistoryPage.HorizontalScrollbarBarColor = true;
            this.transactionHistoryPage.HorizontalScrollbarHighlightOnWheel = false;
            this.transactionHistoryPage.HorizontalScrollbarSize = 10;
            this.transactionHistoryPage.Name = "transactionHistoryPage";
            this.transactionHistoryPage.VerticalScrollbarBarColor = true;
            this.transactionHistoryPage.VerticalScrollbarHighlightOnWheel = false;
            this.transactionHistoryPage.VerticalScrollbarSize = 10;
            // 
            // moneyIntakePage
            // 
            this.moneyIntakePage.Controls.Add(this.moneyDepositBack);
            this.moneyIntakePage.Controls.Add(this.flowLayoutPanel1);
            this.moneyIntakePage.Controls.Add(this.moneyDepositLabel);
            this.moneyIntakePage.HorizontalScrollbarBarColor = true;
            this.moneyIntakePage.HorizontalScrollbarHighlightOnWheel = false;
            this.moneyIntakePage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.moneyIntakePage, "moneyIntakePage");
            this.moneyIntakePage.Name = "moneyIntakePage";
            this.moneyIntakePage.VerticalScrollbarBarColor = true;
            this.moneyIntakePage.VerticalScrollbarHighlightOnWheel = false;
            this.moneyIntakePage.VerticalScrollbarSize = 10;
            // 
            // moneyDepositBack
            // 
            this.moneyDepositBack.ActiveControl = null;
            resources.ApplyResources(this.moneyDepositBack, "moneyDepositBack");
            this.moneyDepositBack.Name = "moneyDepositBack";
            this.moneyDepositBack.UseSelectable = true;
            this.moneyDepositBack.Click += new System.EventHandler(this.moneyDepositBack_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.moneyDeposit200Tile);
            this.flowLayoutPanel1.Controls.Add(this.moneyDeposit500Tile);
            this.flowLayoutPanel1.Controls.Add(this.moneyDeposit1000Tile);
            this.flowLayoutPanel1.Controls.Add(this.moneyDeposit5000Tile);
            this.flowLayoutPanel1.Controls.Add(this.metroPanel2);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // moneyDeposit200Tile
            // 
            this.moneyDeposit200Tile.ActiveControl = null;
            resources.ApplyResources(this.moneyDeposit200Tile, "moneyDeposit200Tile");
            this.moneyDeposit200Tile.Name = "moneyDeposit200Tile";
            this.moneyDeposit200Tile.UseSelectable = true;
            this.moneyDeposit200Tile.Click += new System.EventHandler(this.moneyDeposit200Tile_Click);
            // 
            // moneyDeposit500Tile
            // 
            this.moneyDeposit500Tile.ActiveControl = null;
            resources.ApplyResources(this.moneyDeposit500Tile, "moneyDeposit500Tile");
            this.moneyDeposit500Tile.Name = "moneyDeposit500Tile";
            this.moneyDeposit500Tile.UseSelectable = true;
            this.moneyDeposit500Tile.Click += new System.EventHandler(this.moneyDeposit500Tile_Click);
            // 
            // moneyDeposit1000Tile
            // 
            this.moneyDeposit1000Tile.ActiveControl = null;
            resources.ApplyResources(this.moneyDeposit1000Tile, "moneyDeposit1000Tile");
            this.moneyDeposit1000Tile.Name = "moneyDeposit1000Tile";
            this.moneyDeposit1000Tile.UseSelectable = true;
            this.moneyDeposit1000Tile.Click += new System.EventHandler(this.moneyDeposit1000Tile_Click);
            // 
            // moneyDeposit5000Tile
            // 
            this.moneyDeposit5000Tile.ActiveControl = null;
            resources.ApplyResources(this.moneyDeposit5000Tile, "moneyDeposit5000Tile");
            this.moneyDeposit5000Tile.Name = "moneyDeposit5000Tile";
            this.moneyDeposit5000Tile.UseSelectable = true;
            this.moneyDeposit5000Tile.Click += new System.EventHandler(this.moneyDeposti5000Tile_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.moneyDepositCustomValue);
            this.metroPanel2.Controls.Add(this.moneyDepositCustomTile);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel2, "metroPanel2");
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
            this.moneyDepositCustomTile.ActiveControl = null;
            resources.ApplyResources(this.moneyDepositCustomTile, "moneyDepositCustomTile");
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
            this.signInPage.Controls.Add(this.signInNewUser);
            this.signInPage.Controls.Add(this.signInUserBox);
            this.signInPage.Controls.Add(this.signInPassBox);
            this.signInPage.Controls.Add(this.signInButton);
            this.signInPage.Controls.Add(this.signInLabel);
            this.signInPage.HorizontalScrollbarBarColor = true;
            this.signInPage.HorizontalScrollbarHighlightOnWheel = false;
            this.signInPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.signInPage, "signInPage");
            this.signInPage.Name = "signInPage";
            this.signInPage.VerticalScrollbarBarColor = true;
            this.signInPage.VerticalScrollbarHighlightOnWheel = false;
            this.signInPage.VerticalScrollbarSize = 10;
            // 
            // signInNewUser
            // 
            this.signInNewUser.ActiveControl = null;
            resources.ApplyResources(this.signInNewUser, "signInNewUser");
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
            this.signInButton.ActiveControl = null;
            resources.ApplyResources(this.signInButton, "signInButton");
            this.signInButton.Name = "signInButton";
            this.signInButton.UseSelectable = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.signInLabel, "signInLabel");
            this.signInLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.signInLabel.Name = "signInLabel";
            // 
            // newTransactionPage
            // 
            this.newTransactionPage.HorizontalScrollbarBarColor = true;
            this.newTransactionPage.HorizontalScrollbarHighlightOnWheel = false;
            this.newTransactionPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.newTransactionPage, "newTransactionPage");
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
            // buttonGoTo
            // 
            this.buttonGoTo.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.buttonGoTo, "buttonGoTo");
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripSignIn,
            this.menuStripMainPage,
            this.menuStripMOneyDeposit,
            this.menuStripMoneyWithdrawl,
            this.menuStripTransactionHistory,
            this.menuStripNewTransaction});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // menuStripSignIn
            // 
            this.menuStripSignIn.Name = "menuStripSignIn";
            resources.ApplyResources(this.menuStripSignIn, "menuStripSignIn");
            this.menuStripSignIn.Click += new System.EventHandler(this.menuStripSignIn_Click);
            // 
            // menuStripMainPage
            // 
            this.menuStripMainPage.Name = "menuStripMainPage";
            resources.ApplyResources(this.menuStripMainPage, "menuStripMainPage");
            this.menuStripMainPage.Click += new System.EventHandler(this.menuStripMainPage_Click);
            // 
            // menuStripMOneyDeposit
            // 
            this.menuStripMOneyDeposit.Name = "menuStripMOneyDeposit";
            resources.ApplyResources(this.menuStripMOneyDeposit, "menuStripMOneyDeposit");
            this.menuStripMOneyDeposit.Click += new System.EventHandler(this.menuStripMOneyDeposit_Click);
            // 
            // menuStripMoneyWithdrawl
            // 
            this.menuStripMoneyWithdrawl.Name = "menuStripMoneyWithdrawl";
            resources.ApplyResources(this.menuStripMoneyWithdrawl, "menuStripMoneyWithdrawl");
            this.menuStripMoneyWithdrawl.Click += new System.EventHandler(this.menuStripMoneyWithdrawl_Click);
            // 
            // menuStripTransactionHistory
            // 
            this.menuStripTransactionHistory.Name = "menuStripTransactionHistory";
            resources.ApplyResources(this.menuStripTransactionHistory, "menuStripTransactionHistory");
            this.menuStripTransactionHistory.Click += new System.EventHandler(this.menuStripTransactionHistory_Click);
            // 
            // menuStripNewTransaction
            // 
            this.menuStripNewTransaction.Name = "menuStripNewTransaction";
            resources.ApplyResources(this.menuStripNewTransaction, "menuStripNewTransaction");
            this.menuStripNewTransaction.Click += new System.EventHandler(this.menuStripNewTransaction_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.buttonGoTo);
            this.Controls.Add(this.testServer);
            this.Controls.Add(this.exitSimulator);
            this.Controls.Add(this.consoleButton);
            this.Controls.Add(this.mainControl);
            this.Controls.Add(this.boxLog);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.mainPage.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.mainControl.ResumeLayout(false);
            this.moneyWithdrawlPage.ResumeLayout(false);
            this.moneyWithdrawlPage.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
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
        private MetroFramework.Controls.MetroTile buttonLanguage;
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
        private MetroFramework.Controls.MetroTile moneyDeposit5000Tile;
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
        private System.Windows.Forms.Label moneyWithdrawlLabel;
        private System.Windows.Forms.Button buttonGoTo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripSignIn;
        private System.Windows.Forms.ToolStripMenuItem menuStripMainPage;
        private System.Windows.Forms.ToolStripMenuItem menuStripMOneyDeposit;
        private System.Windows.Forms.ToolStripMenuItem menuStripMoneyWithdrawl;
        private System.Windows.Forms.ToolStripMenuItem menuStripTransactionHistory;
        private System.Windows.Forms.ToolStripMenuItem menuStripNewTransaction;
    }
}

