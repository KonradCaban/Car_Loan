namespace netprojekt
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBaza = new System.Windows.Forms.Button();
            this.labelBaza = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelStan = new System.Windows.Forms.Label();
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.buttonTypes = new System.Windows.Forms.Button();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonRaporty = new System.Windows.Forms.Button();
            this.buttonWorkersStats = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBaza
            // 
            this.buttonBaza.Location = new System.Drawing.Point(59, 70);
            this.buttonBaza.Name = "buttonBaza";
            this.buttonBaza.Size = new System.Drawing.Size(135, 23);
            this.buttonBaza.TabIndex = 0;
            this.buttonBaza.Text = "Połącz z bazą";
            this.buttonBaza.UseVisualStyleBackColor = true;
            this.buttonBaza.Click += new System.EventHandler(this.buttonBaza_Click);
            // 
            // labelBaza
            // 
            this.labelBaza.AutoSize = true;
            this.labelBaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelBaza.Location = new System.Drawing.Point(177, 21);
            this.labelBaza.Name = "labelBaza";
            this.labelBaza.Size = new System.Drawing.Size(205, 17);
            this.labelBaza.TabIndex = 1;
            this.labelBaza.Text = "Brak połączenia z bazą danych";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(196, 70);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(135, 23);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Odłącz się od bazy danych";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelStan
            // 
            this.labelStan.AutoSize = true;
            this.labelStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelStan.Location = new System.Drawing.Point(12, 21);
            this.labelStan.Name = "labelStan";
            this.labelStan.Size = new System.Drawing.Size(159, 17);
            this.labelStan.TabIndex = 3;
            this.labelStan.Text = "Stan połączenia z bazą:";
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.Enabled = false;
            this.buttonWorkers.Location = new System.Drawing.Point(196, 185);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(135, 51);
            this.buttonWorkers.TabIndex = 4;
            this.buttonWorkers.Text = "Edycja pracowników";
            this.buttonWorkers.UseVisualStyleBackColor = true;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // buttonCars
            // 
            this.buttonCars.Enabled = false;
            this.buttonCars.Location = new System.Drawing.Point(196, 128);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(135, 51);
            this.buttonCars.TabIndex = 5;
            this.buttonCars.Text = "Edycja samochodów";
            this.buttonCars.UseVisualStyleBackColor = true;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // buttonTypes
            // 
            this.buttonTypes.Enabled = false;
            this.buttonTypes.Location = new System.Drawing.Point(59, 128);
            this.buttonTypes.Name = "buttonTypes";
            this.buttonTypes.Size = new System.Drawing.Size(135, 51);
            this.buttonTypes.TabIndex = 6;
            this.buttonTypes.Text = "Edycja rodzajów samochodów";
            this.buttonTypes.UseVisualStyleBackColor = true;
            this.buttonTypes.Click += new System.EventHandler(this.buttonTypes_Click);
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.Enabled = false;
            this.buttonTransaction.Location = new System.Drawing.Point(59, 185);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(135, 51);
            this.buttonTransaction.TabIndex = 7;
            this.buttonTransaction.Text = "Edycja transakcji";
            this.buttonTransaction.UseVisualStyleBackColor = true;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(157, 337);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonRaporty);
            this.panelMain.Controls.Add(this.buttonWorkersStats);
            this.panelMain.Controls.Add(this.labelBaza);
            this.panelMain.Controls.Add(this.buttonBaza);
            this.panelMain.Controls.Add(this.buttonDisconnect);
            this.panelMain.Controls.Add(this.labelStan);
            this.panelMain.Controls.Add(this.buttonWorkers);
            this.panelMain.Controls.Add(this.buttonCars);
            this.panelMain.Controls.Add(this.buttonTransaction);
            this.panelMain.Controls.Add(this.buttonTypes);
            this.panelMain.Controls.Add(this.buttonExit);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(779, 373);
            this.panelMain.TabIndex = 9;
            // 
            // buttonRaporty
            // 
            this.buttonRaporty.Enabled = false;
            this.buttonRaporty.Location = new System.Drawing.Point(59, 242);
            this.buttonRaporty.Name = "buttonRaporty";
            this.buttonRaporty.Size = new System.Drawing.Size(135, 51);
            this.buttonRaporty.TabIndex = 10;
            this.buttonRaporty.Text = "Tabela raportu";
            this.buttonRaporty.UseVisualStyleBackColor = true;
            this.buttonRaporty.Click += new System.EventHandler(this.buttonRaporty_Click);
            // 
            // buttonWorkersStats
            // 
            this.buttonWorkersStats.Enabled = false;
            this.buttonWorkersStats.Location = new System.Drawing.Point(196, 242);
            this.buttonWorkersStats.Name = "buttonWorkersStats";
            this.buttonWorkersStats.Size = new System.Drawing.Size(135, 51);
            this.buttonWorkersStats.TabIndex = 9;
            this.buttonWorkersStats.Text = "Statystyki pracowników";
            this.buttonWorkersStats.UseVisualStyleBackColor = true;
            this.buttonWorkersStats.Click += new System.EventHandler(this.buttonWorkersStats_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 372);
            this.Controls.Add(this.panelMain);
            this.Name = "Menu";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBaza;
        private System.Windows.Forms.Label labelBaza;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelStan;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button buttonTypes;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonWorkersStats;
        private System.Windows.Forms.Button buttonRaporty;
    }
}

