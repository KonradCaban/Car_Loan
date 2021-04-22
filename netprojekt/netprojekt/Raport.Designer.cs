namespace netprojekt
{
    partial class Raport
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
            this.labelBaza = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelStan = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBaza = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelUkonczone = new System.Windows.Forms.Label();
            this.labelWTrakcie = new System.Windows.Forms.Label();
            this.labelKwota = new System.Windows.Forms.Label();
            this.labelSamochod = new System.Windows.Forms.Label();
            this.labelPracownik = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMarka = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPensje = new System.Windows.Forms.Label();
            this.labelDochod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBaza
            // 
            this.labelBaza.AutoSize = true;
            this.labelBaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelBaza.Location = new System.Drawing.Point(274, 9);
            this.labelBaza.Name = "labelBaza";
            this.labelBaza.Size = new System.Drawing.Size(205, 17);
            this.labelBaza.TabIndex = 5;
            this.labelBaza.Text = "Brak połączenia z bazą danych";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(297, 48);
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
            this.labelStan.Location = new System.Drawing.Point(109, 9);
            this.labelStan.Name = "labelStan";
            this.labelStan.Size = new System.Drawing.Size(159, 17);
            this.labelStan.TabIndex = 7;
            this.labelStan.Text = "Stan połączenia z bazą:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(229, 515);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Powrót do menu głownego";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonBaza
            // 
            this.buttonBaza.Location = new System.Drawing.Point(145, 48);
            this.buttonBaza.Name = "buttonBaza";
            this.buttonBaza.Size = new System.Drawing.Size(106, 23);
            this.buttonBaza.TabIndex = 9;
            this.buttonBaza.Text = "Połącz z bazą";
            this.buttonBaza.UseVisualStyleBackColor = true;
            this.buttonBaza.Click += new System.EventHandler(this.buttonBaza_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(25, 111);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 10;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(355, 111);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 11;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data początkowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data końcowa";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(248, 142);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(75, 23);
            this.buttonGen.TabIndex = 14;
            this.buttonGen.Text = "Generuj";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 171);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.82609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.26087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.38835F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.30097F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.90291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 325);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liczba zakończonych transakcji:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Liczba transakcji w trakcie:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Łączna suma \r\nukończonych transakcji:\r\n";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Najpopularniejszy samochód:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pracownik z największą ilością\r\n przeprowadzonych transakcji:\r\n";
            this.label7.Visible = false;
            // 
            // labelUkonczone
            // 
            this.labelUkonczone.AutoSize = true;
            this.labelUkonczone.Location = new System.Drawing.Point(290, 185);
            this.labelUkonczone.Name = "labelUkonczone";
            this.labelUkonczone.Size = new System.Drawing.Size(0, 13);
            this.labelUkonczone.TabIndex = 20;
            // 
            // labelWTrakcie
            // 
            this.labelWTrakcie.AutoSize = true;
            this.labelWTrakcie.Location = new System.Drawing.Point(290, 225);
            this.labelWTrakcie.Name = "labelWTrakcie";
            this.labelWTrakcie.Size = new System.Drawing.Size(0, 13);
            this.labelWTrakcie.TabIndex = 21;
            // 
            // labelKwota
            // 
            this.labelKwota.AutoSize = true;
            this.labelKwota.Location = new System.Drawing.Point(290, 255);
            this.labelKwota.Name = "labelKwota";
            this.labelKwota.Size = new System.Drawing.Size(0, 13);
            this.labelKwota.TabIndex = 22;
            this.labelKwota.Visible = false;
            // 
            // labelSamochod
            // 
            this.labelSamochod.AutoSize = true;
            this.labelSamochod.Location = new System.Drawing.Point(290, 305);
            this.labelSamochod.Name = "labelSamochod";
            this.labelSamochod.Size = new System.Drawing.Size(0, 13);
            this.labelSamochod.TabIndex = 23;
            // 
            // labelPracownik
            // 
            this.labelPracownik.AutoSize = true;
            this.labelPracownik.Location = new System.Drawing.Point(290, 385);
            this.labelPracownik.Name = "labelPracownik";
            this.labelPracownik.Size = new System.Drawing.Size(0, 13);
            this.labelPracownik.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Najpopularniejszy typ:";
            this.label8.Visible = false;
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(290, 350);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(0, 13);
            this.labelMarka.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Pensje pracowników:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Dochód:";
            this.label10.Visible = false;
            // 
            // labelPensje
            // 
            this.labelPensje.AutoSize = true;
            this.labelPensje.Location = new System.Drawing.Point(290, 430);
            this.labelPensje.Name = "labelPensje";
            this.labelPensje.Size = new System.Drawing.Size(0, 13);
            this.labelPensje.TabIndex = 29;
            // 
            // labelDochod
            // 
            this.labelDochod.AutoSize = true;
            this.labelDochod.Location = new System.Drawing.Point(290, 470);
            this.labelDochod.Name = "labelDochod";
            this.labelDochod.Size = new System.Drawing.Size(0, 13);
            this.labelDochod.TabIndex = 30;
            // 
            // Raport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 550);
            this.Controls.Add(this.labelDochod);
            this.Controls.Add(this.labelPensje);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPracownik);
            this.Controls.Add(this.labelSamochod);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.labelKwota);
            this.Controls.Add(this.labelWTrakcie);
            this.Controls.Add(this.labelUkonczone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.buttonBaza);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelBaza);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.labelStan);
            this.Name = "Raport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Raport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBaza;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelStan;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonBaza;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelUkonczone;
        private System.Windows.Forms.Label labelWTrakcie;
        private System.Windows.Forms.Label labelKwota;
        private System.Windows.Forms.Label labelSamochod;
        private System.Windows.Forms.Label labelPracownik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPensje;
        private System.Windows.Forms.Label labelDochod;
    }
}