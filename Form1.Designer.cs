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
            this.signInPage = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.signInPIN = new System.Windows.Forms.TextBox();
            this.pin7Button = new System.Windows.Forms.Button();
            this.pin8Button = new System.Windows.Forms.Button();
            this.pin9Button = new System.Windows.Forms.Button();
            this.pin4Button = new System.Windows.Forms.Button();
            this.pin5Button = new System.Windows.Forms.Button();
            this.pin6Button = new System.Windows.Forms.Button();
            this.pin1Button = new System.Windows.Forms.Button();
            this.pin2Button = new System.Windows.Forms.Button();
            this.pin3Button = new System.Windows.Forms.Button();
            this.pinClearButton = new System.Windows.Forms.Button();
            this.pin0Button = new System.Windows.Forms.Button();
            this.pinOKButton = new System.Windows.Forms.Button();
            this.signInDropDown = new MetroFramework.Controls.MetroTile();
            this.signInLabel = new System.Windows.Forms.Label();
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
            this.newTransactionPage = new MetroFramework.Controls.MetroTabPage();
            this.transactionNewBack = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.transactionSendNewTile = new MetroFramework.Controls.MetroTile();
            this.transactionAmountLabel = new System.Windows.Forms.Label();
            this.transactionAccountLabel = new System.Windows.Forms.Label();
            this.transactionAmountTextBox = new System.Windows.Forms.TextBox();
            this.transactionAccountTextBox = new System.Windows.Forms.TextBox();
            this.moneyIntakePage = new MetroFramework.Controls.MetroTabPage();
            this.moneyDepositDropDown = new MetroFramework.Controls.MetroTile();
            this.moneyDepositBack = new MetroFramework.Controls.MetroTile();
            this.moneyDepositLabel = new System.Windows.Forms.Label();
            this.transactionHistoryPage = new MetroFramework.Controls.MetroTabPage();
            this.transactionHistoryList = new System.Windows.Forms.ListView();
            this.transactionHistoryTableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionHistoryTableSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionHistoryTableReceiver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionHistoryTableAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionHistoryTableTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionHistoryTableSuccess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionHistoryBack = new MetroFramework.Controls.MetroTile();
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
            this.debugCleanWallet = new System.Windows.Forms.Button();
            this.mainPage.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mainControl.SuspendLayout();
            this.signInPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.moneyWithdrawlPage.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.newTransactionPage.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.moneyIntakePage.SuspendLayout();
            this.transactionHistoryPage.SuspendLayout();
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
            this.mainControl.Controls.Add(this.moneyIntakePage);
            this.mainControl.Controls.Add(this.signInPage);
            this.mainControl.Controls.Add(this.moneyWithdrawlPage);
            this.mainControl.Controls.Add(this.newTransactionPage);
            this.mainControl.Controls.Add(this.mainPage);
            this.mainControl.Controls.Add(this.transactionHistoryPage);
            resources.ApplyResources(this.mainControl, "mainControl");
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 3;
            this.mainControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainControl.Style = MetroFramework.MetroColorStyle.Teal;
            this.mainControl.UseSelectable = true;
            // 
            // signInPage
            // 
            this.signInPage.Controls.Add(this.flowLayoutPanel1);
            this.signInPage.Controls.Add(this.signInDropDown);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.signInPIN);
            this.flowLayoutPanel1.Controls.Add(this.pin7Button);
            this.flowLayoutPanel1.Controls.Add(this.pin8Button);
            this.flowLayoutPanel1.Controls.Add(this.pin9Button);
            this.flowLayoutPanel1.Controls.Add(this.pin4Button);
            this.flowLayoutPanel1.Controls.Add(this.pin5Button);
            this.flowLayoutPanel1.Controls.Add(this.pin6Button);
            this.flowLayoutPanel1.Controls.Add(this.pin1Button);
            this.flowLayoutPanel1.Controls.Add(this.pin2Button);
            this.flowLayoutPanel1.Controls.Add(this.pin3Button);
            this.flowLayoutPanel1.Controls.Add(this.pinClearButton);
            this.flowLayoutPanel1.Controls.Add(this.pin0Button);
            this.flowLayoutPanel1.Controls.Add(this.pinOKButton);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // signInPIN
            // 
            resources.ApplyResources(this.signInPIN, "signInPIN");
            this.signInPIN.Name = "signInPIN";
            this.signInPIN.UseSystemPasswordChar = true;
            this.signInPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // pin7Button
            // 
            resources.ApplyResources(this.pin7Button, "pin7Button");
            this.pin7Button.Name = "pin7Button";
            this.pin7Button.UseVisualStyleBackColor = true;
            this.pin7Button.Click += new System.EventHandler(this.pin7Button_Click);
            // 
            // pin8Button
            // 
            resources.ApplyResources(this.pin8Button, "pin8Button");
            this.pin8Button.Name = "pin8Button";
            this.pin8Button.UseVisualStyleBackColor = true;
            this.pin8Button.Click += new System.EventHandler(this.pin8Button_Click);
            // 
            // pin9Button
            // 
            resources.ApplyResources(this.pin9Button, "pin9Button");
            this.pin9Button.Name = "pin9Button";
            this.pin9Button.UseVisualStyleBackColor = true;
            this.pin9Button.Click += new System.EventHandler(this.pin9Button_Click);
            // 
            // pin4Button
            // 
            resources.ApplyResources(this.pin4Button, "pin4Button");
            this.pin4Button.Name = "pin4Button";
            this.pin4Button.UseVisualStyleBackColor = true;
            this.pin4Button.Click += new System.EventHandler(this.pin4Button_Click);
            // 
            // pin5Button
            // 
            resources.ApplyResources(this.pin5Button, "pin5Button");
            this.pin5Button.Name = "pin5Button";
            this.pin5Button.UseVisualStyleBackColor = true;
            this.pin5Button.Click += new System.EventHandler(this.pin5Button_Click);
            // 
            // pin6Button
            // 
            resources.ApplyResources(this.pin6Button, "pin6Button");
            this.pin6Button.Name = "pin6Button";
            this.pin6Button.UseVisualStyleBackColor = true;
            this.pin6Button.Click += new System.EventHandler(this.pin6Button_Click);
            // 
            // pin1Button
            // 
            resources.ApplyResources(this.pin1Button, "pin1Button");
            this.pin1Button.Name = "pin1Button";
            this.pin1Button.UseVisualStyleBackColor = true;
            this.pin1Button.Click += new System.EventHandler(this.pin1Button_Click);
            // 
            // pin2Button
            // 
            resources.ApplyResources(this.pin2Button, "pin2Button");
            this.pin2Button.Name = "pin2Button";
            this.pin2Button.UseVisualStyleBackColor = true;
            this.pin2Button.Click += new System.EventHandler(this.pin2Button_Click);
            // 
            // pin3Button
            // 
            resources.ApplyResources(this.pin3Button, "pin3Button");
            this.pin3Button.Name = "pin3Button";
            this.pin3Button.UseVisualStyleBackColor = true;
            this.pin3Button.Click += new System.EventHandler(this.pin3Button_Click);
            // 
            // pinClearButton
            // 
            resources.ApplyResources(this.pinClearButton, "pinClearButton");
            this.pinClearButton.Name = "pinClearButton";
            this.pinClearButton.UseVisualStyleBackColor = true;
            this.pinClearButton.Click += new System.EventHandler(this.pinClearButton_Click);
            // 
            // pin0Button
            // 
            resources.ApplyResources(this.pin0Button, "pin0Button");
            this.pin0Button.Name = "pin0Button";
            this.pin0Button.UseVisualStyleBackColor = true;
            this.pin0Button.Click += new System.EventHandler(this.pin0Button_Click);
            // 
            // pinOKButton
            // 
            resources.ApplyResources(this.pinOKButton, "pinOKButton");
            this.pinOKButton.Name = "pinOKButton";
            this.pinOKButton.UseVisualStyleBackColor = true;
            this.pinOKButton.Click += new System.EventHandler(this.pinOKButton_Click);
            // 
            // signInDropDown
            // 
            this.signInDropDown.ActiveControl = null;
            this.signInDropDown.AllowDrop = true;
            resources.ApplyResources(this.signInDropDown, "signInDropDown");
            this.signInDropDown.Name = "signInDropDown";
            this.signInDropDown.UseSelectable = true;
            this.signInDropDown.DragDrop += new System.Windows.Forms.DragEventHandler(this.signInDropDown_DragDrop);
            this.signInDropDown.DragEnter += new System.Windows.Forms.DragEventHandler(this.signInDropDown_DragEnter);
            // 
            // signInLabel
            // 
            this.signInLabel.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.signInLabel, "signInLabel");
            this.signInLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.signInLabel.Name = "signInLabel";
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
            this.moneyWithdrawlPage.Click += new System.EventHandler(this.moneyWithdrawlPage_Click);
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
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
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
            this.moneyWithdrawlCustomValue.Leave += new System.EventHandler(this.moneyWithdrawlCustomValue_Leave);
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
            // newTransactionPage
            // 
            this.newTransactionPage.Controls.Add(this.transactionNewBack);
            this.newTransactionPage.Controls.Add(this.metroPanel2);
            this.newTransactionPage.Controls.Add(this.transactionAmountLabel);
            this.newTransactionPage.Controls.Add(this.transactionAccountLabel);
            this.newTransactionPage.Controls.Add(this.transactionAmountTextBox);
            this.newTransactionPage.Controls.Add(this.transactionAccountTextBox);
            this.newTransactionPage.HorizontalScrollbarBarColor = true;
            this.newTransactionPage.HorizontalScrollbarHighlightOnWheel = false;
            this.newTransactionPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.newTransactionPage, "newTransactionPage");
            this.newTransactionPage.Name = "newTransactionPage";
            this.newTransactionPage.VerticalScrollbarBarColor = true;
            this.newTransactionPage.VerticalScrollbarHighlightOnWheel = false;
            this.newTransactionPage.VerticalScrollbarSize = 10;
            // 
            // transactionNewBack
            // 
            this.transactionNewBack.ActiveControl = null;
            resources.ApplyResources(this.transactionNewBack, "transactionNewBack");
            this.transactionNewBack.Name = "transactionNewBack";
            this.transactionNewBack.TabStop = false;
            this.transactionNewBack.UseSelectable = true;
            this.transactionNewBack.Click += new System.EventHandler(this.transactionNewBack_Click);
            // 
            // metroPanel2
            // 
            resources.ApplyResources(this.metroPanel2, "metroPanel2");
            this.metroPanel2.Controls.Add(this.transactionSendNewTile);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 14;
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 14;
            // 
            // transactionSendNewTile
            // 
            this.transactionSendNewTile.ActiveControl = null;
            resources.ApplyResources(this.transactionSendNewTile, "transactionSendNewTile");
            this.transactionSendNewTile.Name = "transactionSendNewTile";
            this.transactionSendNewTile.TabStop = false;
            this.transactionSendNewTile.UseSelectable = true;
            this.transactionSendNewTile.Click += new System.EventHandler(this.transactionSendNewTile_Click);
            // 
            // transactionAmountLabel
            // 
            this.transactionAmountLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.transactionAmountLabel, "transactionAmountLabel");
            this.transactionAmountLabel.Name = "transactionAmountLabel";
            // 
            // transactionAccountLabel
            // 
            this.transactionAccountLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.transactionAccountLabel, "transactionAccountLabel");
            this.transactionAccountLabel.Name = "transactionAccountLabel";
            // 
            // transactionAmountTextBox
            // 
            this.transactionAmountTextBox.BackColor = System.Drawing.Color.White;
            this.transactionAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.transactionAmountTextBox, "transactionAmountTextBox");
            this.transactionAmountTextBox.Name = "transactionAmountTextBox";
            this.transactionAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // transactionAccountTextBox
            // 
            this.transactionAccountTextBox.BackColor = System.Drawing.Color.White;
            this.transactionAccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.transactionAccountTextBox, "transactionAccountTextBox");
            this.transactionAccountTextBox.Name = "transactionAccountTextBox";
            this.transactionAccountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // moneyIntakePage
            // 
            this.moneyIntakePage.Controls.Add(this.moneyDepositDropDown);
            this.moneyIntakePage.Controls.Add(this.moneyDepositBack);
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
            // moneyDepositDropDown
            // 
            this.moneyDepositDropDown.ActiveControl = null;
            this.moneyDepositDropDown.AllowDrop = true;
            resources.ApplyResources(this.moneyDepositDropDown, "moneyDepositDropDown");
            this.moneyDepositDropDown.Name = "moneyDepositDropDown";
            this.moneyDepositDropDown.UseSelectable = true;
            this.moneyDepositDropDown.Click += new System.EventHandler(this.metroTile1_Click);
            this.moneyDepositDropDown.DragDrop += new System.Windows.Forms.DragEventHandler(this.moneyDepositDropDown_DragDrop);
            this.moneyDepositDropDown.DragEnter += new System.Windows.Forms.DragEventHandler(this.moneyDepositDropDown_DragEnter);
            // 
            // moneyDepositBack
            // 
            this.moneyDepositBack.ActiveControl = null;
            resources.ApplyResources(this.moneyDepositBack, "moneyDepositBack");
            this.moneyDepositBack.Name = "moneyDepositBack";
            this.moneyDepositBack.UseSelectable = true;
            this.moneyDepositBack.Click += new System.EventHandler(this.moneyDepositBack_Click);
            // 
            // moneyDepositLabel
            // 
            resources.ApplyResources(this.moneyDepositLabel, "moneyDepositLabel");
            this.moneyDepositLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyDepositLabel.Name = "moneyDepositLabel";
            // 
            // transactionHistoryPage
            // 
            this.transactionHistoryPage.Controls.Add(this.transactionHistoryList);
            this.transactionHistoryPage.Controls.Add(this.transactionHistoryBack);
            resources.ApplyResources(this.transactionHistoryPage, "transactionHistoryPage");
            this.transactionHistoryPage.HorizontalScrollbarBarColor = true;
            this.transactionHistoryPage.HorizontalScrollbarHighlightOnWheel = false;
            this.transactionHistoryPage.HorizontalScrollbarSize = 10;
            this.transactionHistoryPage.Name = "transactionHistoryPage";
            this.transactionHistoryPage.VerticalScrollbarBarColor = true;
            this.transactionHistoryPage.VerticalScrollbarHighlightOnWheel = false;
            this.transactionHistoryPage.VerticalScrollbarSize = 10;
            // 
            // transactionHistoryList
            // 
            this.transactionHistoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transactionHistoryTableName,
            this.transactionHistoryTableSender,
            this.transactionHistoryTableReceiver,
            this.transactionHistoryTableAmount,
            this.transactionHistoryTableTime,
            this.transactionHistoryTableSuccess});
            this.transactionHistoryList.HideSelection = false;
            resources.ApplyResources(this.transactionHistoryList, "transactionHistoryList");
            this.transactionHistoryList.Name = "transactionHistoryList";
            this.transactionHistoryList.UseCompatibleStateImageBehavior = false;
            this.transactionHistoryList.View = System.Windows.Forms.View.Details;
            // 
            // transactionHistoryTableName
            // 
            resources.ApplyResources(this.transactionHistoryTableName, "transactionHistoryTableName");
            // 
            // transactionHistoryTableSender
            // 
            resources.ApplyResources(this.transactionHistoryTableSender, "transactionHistoryTableSender");
            // 
            // transactionHistoryTableReceiver
            // 
            resources.ApplyResources(this.transactionHistoryTableReceiver, "transactionHistoryTableReceiver");
            // 
            // transactionHistoryTableAmount
            // 
            resources.ApplyResources(this.transactionHistoryTableAmount, "transactionHistoryTableAmount");
            // 
            // transactionHistoryTableTime
            // 
            resources.ApplyResources(this.transactionHistoryTableTime, "transactionHistoryTableTime");
            // 
            // transactionHistoryTableSuccess
            // 
            resources.ApplyResources(this.transactionHistoryTableSuccess, "transactionHistoryTableSuccess");
            // 
            // transactionHistoryBack
            // 
            this.transactionHistoryBack.ActiveControl = null;
            resources.ApplyResources(this.transactionHistoryBack, "transactionHistoryBack");
            this.transactionHistoryBack.Name = "transactionHistoryBack";
            this.transactionHistoryBack.UseSelectable = true;
            this.transactionHistoryBack.Click += new System.EventHandler(this.transactionHistoryBack_Click);
            // 
            // consoleButton
            // 
            resources.ApplyResources(this.consoleButton, "consoleButton");
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.TabStop = false;
            this.consoleButton.UseSelectable = true;
            this.consoleButton.Click += new System.EventHandler(this.consoleButton_Click);
            // 
            // exitSimulator
            // 
            resources.ApplyResources(this.exitSimulator, "exitSimulator");
            this.exitSimulator.Name = "exitSimulator";
            this.exitSimulator.TabStop = false;
            this.exitSimulator.UseVisualStyleBackColor = true;
            this.exitSimulator.Click += new System.EventHandler(this.exitSimulator_Click);
            // 
            // testServer
            // 
            resources.ApplyResources(this.testServer, "testServer");
            this.testServer.Name = "testServer";
            this.testServer.TabStop = false;
            this.testServer.UseVisualStyleBackColor = true;
            this.testServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.buttonGoTo, "buttonGoTo");
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.TabStop = false;
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
            // debugCleanWallet
            // 
            resources.ApplyResources(this.debugCleanWallet, "debugCleanWallet");
            this.debugCleanWallet.Name = "debugCleanWallet";
            this.debugCleanWallet.TabStop = false;
            this.debugCleanWallet.UseVisualStyleBackColor = true;
            this.debugCleanWallet.Click += new System.EventHandler(this.debugCleanWallet_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.debugCleanWallet);
            this.Controls.Add(this.buttonGoTo);
            this.Controls.Add(this.testServer);
            this.Controls.Add(this.exitSimulator);
            this.Controls.Add(this.consoleButton);
            this.Controls.Add(this.mainControl);
            this.Controls.Add(this.boxLog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.mainPage.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.mainControl.ResumeLayout(false);
            this.signInPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.moneyWithdrawlPage.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.newTransactionPage.ResumeLayout(false);
            this.newTransactionPage.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.moneyIntakePage.ResumeLayout(false);
            this.transactionHistoryPage.ResumeLayout(false);
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
        private System.Windows.Forms.Button testServer;
        private System.Windows.Forms.Label moneyDepositLabel;
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
        private MetroFramework.Controls.MetroTile moneyDepositDropDown;
        private MetroFramework.Controls.MetroTile signInDropDown;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox signInPIN;
        private System.Windows.Forms.Button pin7Button;
        private System.Windows.Forms.Button pin8Button;
        private System.Windows.Forms.Button pin9Button;
        private System.Windows.Forms.Button pin4Button;
        private System.Windows.Forms.Button pin5Button;
        private System.Windows.Forms.Button pin6Button;
        private System.Windows.Forms.Button pin1Button;
        private System.Windows.Forms.Button pin3Button;
        private System.Windows.Forms.Button pinClearButton;
        private System.Windows.Forms.Button pin0Button;
        private System.Windows.Forms.Button pinOKButton;
        private System.Windows.Forms.Button pin2Button;
        private System.Windows.Forms.TextBox transactionAmountTextBox;
        private System.Windows.Forms.TextBox transactionAccountTextBox;
        private System.Windows.Forms.Label transactionAmountLabel;
        private System.Windows.Forms.Label transactionAccountLabel;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile transactionSendNewTile;
        private MetroFramework.Controls.MetroTile transactionNewBack;
        private MetroFramework.Controls.MetroTile transactionHistoryBack;
        private System.Windows.Forms.ColumnHeader transactionHistoryTableName;
        private System.Windows.Forms.ColumnHeader transactionHistoryTableSender;
        private System.Windows.Forms.ColumnHeader transactionHistoryTableReceiver;
        private System.Windows.Forms.ColumnHeader transactionHistoryTableAmount;
        private System.Windows.Forms.ColumnHeader transactionHistoryTableTime;
        private System.Windows.Forms.ColumnHeader transactionHistoryTableSuccess;
        private System.Windows.Forms.ListView transactionHistoryList;
        private System.Windows.Forms.Button debugCleanWallet;
    }
}

