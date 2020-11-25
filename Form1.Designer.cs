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
            this.buttonIntake = new MetroFramework.Controls.MetroTile();
            this.buttonWith = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buttonTransactionHistory = new MetroFramework.Controls.MetroTile();
            this.buttonNewTransaction = new MetroFramework.Controls.MetroTile();
            this.buttonLeave = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIntake
            // 
            resources.ApplyResources(this.buttonIntake, "buttonIntake");
            this.buttonIntake.ActiveControl = null;
            this.buttonIntake.Name = "buttonIntake";
            this.buttonIntake.UseSelectable = true;
            this.buttonIntake.Click += new System.EventHandler(this.buttonIntake_Click);
            // 
            // buttonWith
            // 
            resources.ApplyResources(this.buttonWith, "buttonWith");
            this.buttonWith.ActiveControl = null;
            this.buttonWith.Name = "buttonWith";
            this.buttonWith.UseSelectable = true;
            this.buttonWith.Click += new System.EventHandler(this.buttonWith_Click);
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
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // buttonTransactionHistory
            // 
            resources.ApplyResources(this.buttonTransactionHistory, "buttonTransactionHistory");
            this.buttonTransactionHistory.ActiveControl = null;
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.UseSelectable = true;
            // 
            // buttonNewTransaction
            // 
            resources.ApplyResources(this.buttonNewTransaction, "buttonNewTransaction");
            this.buttonNewTransaction.ActiveControl = null;
            this.buttonNewTransaction.Name = "buttonNewTransaction";
            this.buttonNewTransaction.UseSelectable = true;
            this.buttonNewTransaction.Click += new System.EventHandler(this.buttonNewTransaction_Click);
            // 
            // buttonLeave
            // 
            resources.ApplyResources(this.buttonLeave, "buttonLeave");
            this.buttonLeave.ActiveControl = null;
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.UseSelectable = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile buttonIntake;
        private MetroFramework.Controls.MetroTile buttonWith;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile buttonNewTransaction;
        private MetroFramework.Controls.MetroTile buttonTransactionHistory;
        private MetroFramework.Controls.MetroTile buttonLeave;
    }
}

