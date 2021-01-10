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
            this.signInPage = new MetroFramework.Controls.MetroTabPage();
            this.signInUserBox = new System.Windows.Forms.TextBox();
            this.signInPassBox = new System.Windows.Forms.TextBox();
            this.signInButton = new MetroFramework.Controls.MetroTile();
            this.signInLabel = new System.Windows.Forms.Label();
            this.transactionHistoryPage = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.moneyIntakePage = new MetroFramework.Controls.MetroTabPage();
            this.moneyWithdrawlPage = new MetroFramework.Controls.MetroTabPage();
            this.newTransactionPage = new MetroFramework.Controls.MetroTabPage();
            this.consoleButton = new MetroFramework.Controls.MetroButton();
            this.exitSimulator = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mainPage.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mainControl.SuspendLayout();
            this.signInPage.SuspendLayout();
            this.transactionHistoryPage.SuspendLayout();
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
            this.mainPage.Controls.Add(this.buttonEnglish);
            this.mainPage.Controls.Add(this.buttonCzech);
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
            // buttonEnglish
            // 
            this.buttonEnglish.ActiveControl = null;
            resources.ApplyResources(this.buttonEnglish, "buttonEnglish");
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
            this.buttonCzech.ActiveControl = null;
            resources.ApplyResources(this.buttonCzech, "buttonCzech");
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
            this.mainControl.Controls.Add(this.signInPage);
            this.mainControl.Controls.Add(this.mainPage);
            this.mainControl.Controls.Add(this.transactionHistoryPage);
            this.mainControl.Controls.Add(this.moneyIntakePage);
            this.mainControl.Controls.Add(this.moneyWithdrawlPage);
            this.mainControl.Controls.Add(this.newTransactionPage);
            resources.ApplyResources(this.mainControl, "mainControl");
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 1;
            this.mainControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainControl.UseSelectable = true;
            // 
            // signInPage
            // 
            this.signInPage.Controls.Add(this.metroTile1);
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
            // transactionHistoryPage
            // 
            this.transactionHistoryPage.Controls.Add(this.button2);
            resources.ApplyResources(this.transactionHistoryPage, "transactionHistoryPage");
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
            this.moneyIntakePage.HorizontalScrollbarBarColor = true;
            this.moneyIntakePage.HorizontalScrollbarHighlightOnWheel = false;
            this.moneyIntakePage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.moneyIntakePage, "moneyIntakePage");
            this.moneyIntakePage.Name = "moneyIntakePage";
            this.moneyIntakePage.VerticalScrollbarBarColor = true;
            this.moneyIntakePage.VerticalScrollbarHighlightOnWheel = false;
            this.moneyIntakePage.VerticalScrollbarSize = 10;
            // 
            // moneyWithdrawlPage
            // 
            this.moneyWithdrawlPage.HorizontalScrollbarBarColor = true;
            this.moneyWithdrawlPage.HorizontalScrollbarHighlightOnWheel = false;
            this.moneyWithdrawlPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.moneyWithdrawlPage, "moneyWithdrawlPage");
            this.moneyWithdrawlPage.Name = "moneyWithdrawlPage";
            this.moneyWithdrawlPage.VerticalScrollbarBarColor = true;
            this.moneyWithdrawlPage.VerticalScrollbarHighlightOnWheel = false;
            this.moneyWithdrawlPage.VerticalScrollbarSize = 10;
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
            this.consoleButton.MouseHover += new System.EventHandler(this.consoleButton_Enter);
            // 
            // exitSimulator
            // 
            resources.ApplyResources(this.exitSimulator, "exitSimulator");
            this.exitSimulator.Name = "exitSimulator";
            this.exitSimulator.UseVisualStyleBackColor = true;
            this.exitSimulator.Click += new System.EventHandler(this.exitSimulator_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            resources.ApplyResources(this.metroTile1, "metroTile1");
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.exitSimulator);
            this.Controls.Add(this.consoleButton);
            this.Controls.Add(this.mainControl);
            this.Controls.Add(this.boxLog);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.mainPage.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.mainControl.ResumeLayout(false);
            this.signInPage.ResumeLayout(false);
            this.signInPage.PerformLayout();
            this.transactionHistoryPage.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

