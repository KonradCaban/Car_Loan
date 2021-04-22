namespace netprojekt
{
    partial class WorkersStats
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
            this.labelDatabase = new System.Windows.Forms.Label();
            this.buttonBaza = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelStan = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelDatabase.Location = new System.Drawing.Point(198, 21);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(205, 17);
            this.labelDatabase.TabIndex = 5;
            this.labelDatabase.Text = "Brak połączenia z bazą danych";
            // 
            // buttonBaza
            // 
            this.buttonBaza.Enabled = false;
            this.buttonBaza.Location = new System.Drawing.Point(428, 19);
            this.buttonBaza.Name = "buttonBaza";
            this.buttonBaza.Size = new System.Drawing.Size(112, 23);
            this.buttonBaza.TabIndex = 4;
            this.buttonBaza.Text = "Połącz z bazą";
            this.buttonBaza.UseVisualStyleBackColor = true;
            this.buttonBaza.Click += new System.EventHandler(this.buttonBaza_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(582, 19);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(142, 23);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Odłącz się od bazy danych";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelStan
            // 
            this.labelStan.AutoSize = true;
            this.labelStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelStan.Location = new System.Drawing.Point(33, 21);
            this.labelStan.Name = "labelStan";
            this.labelStan.Size = new System.Drawing.Size(159, 17);
            this.labelStan.TabIndex = 7;
            this.labelStan.Text = "Stan połączenia z bazą:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 212);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(242, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(331, 68);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(339, 243);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Powrót do menu głównego";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // WorkersStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 297);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.buttonBaza);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.labelStan);
            this.Name = "WorkersStats";
            this.Text = "WorkersStats";
            this.Load += new System.EventHandler(this.WorkersStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Button buttonBaza;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelStan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonBack;
    }
}