namespace netprojekt
{
    partial class WorkerMenu
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelStan = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPensja = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWorkerAdd = new System.Windows.Forms.Button();
            this.buttonWorkerEdit = new System.Windows.Forms.Button();
            this.buttonWorkerDelete = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.GridDelete = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelShow = new System.Windows.Forms.Panel();
            this.GridShowWorkers = new System.Windows.Forms.DataGridView();
            this.panelAdd.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDelete)).BeginInit();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridShowWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(371, 306);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(171, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Powrót do menu głównego";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(358, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(106, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Połącz z bazą";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(470, 13);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(150, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Odłącz z bazy";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelStan
            // 
            this.labelStan.AutoSize = true;
            this.labelStan.Location = new System.Drawing.Point(12, 18);
            this.labelStan.Name = "labelStan";
            this.labelStan.Size = new System.Drawing.Size(160, 13);
            this.labelStan.TabIndex = 4;
            this.labelStan.Text = "Stan połączenia z bazą danych:";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(201, 18);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(33, 13);
            this.labelDatabase.TabIndex = 5;
            this.labelDatabase.Text = "xXXX";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Silver;
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Controls.Add(this.textBoxPensja);
            this.panelAdd.Controls.Add(this.textBoxTelefon);
            this.panelAdd.Controls.Add(this.textBoxAdres);
            this.panelAdd.Controls.Add(this.textBoxNazwisko);
            this.panelAdd.Controls.Add(this.textBoxImie);
            this.panelAdd.Controls.Add(this.label7);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Location = new System.Drawing.Point(204, 56);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(651, 244);
            this.panelAdd.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(377, 134);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Dodaj nowego pracownika";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPensja
            // 
            this.textBoxPensja.Location = new System.Drawing.Point(140, 201);
            this.textBoxPensja.MaxLength = 8;
            this.textBoxPensja.Name = "textBoxPensja";
            this.textBoxPensja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPensja.TabIndex = 10;
            this.textBoxPensja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPensja_KeyPress);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(140, 161);
            this.textBoxTelefon.MaxLength = 9;
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 9;
            this.textBoxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefon_KeyPress);
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(140, 122);
            this.textBoxAdres.MaxLength = 120;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdres.TabIndex = 8;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(140, 83);
            this.textBoxNazwisko.MaxLength = 40;
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 7;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(140, 48);
            this.textBoxImie.MaxLength = 30;
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Adres zamieszkania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pensja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numer telefonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(236, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dodaj nowego pracownika";
            // 
            // buttonWorkerAdd
            // 
            this.buttonWorkerAdd.Location = new System.Drawing.Point(31, 72);
            this.buttonWorkerAdd.Name = "buttonWorkerAdd";
            this.buttonWorkerAdd.Size = new System.Drawing.Size(123, 23);
            this.buttonWorkerAdd.TabIndex = 7;
            this.buttonWorkerAdd.Text = "Dodaj pracownika";
            this.buttonWorkerAdd.UseVisualStyleBackColor = true;
            this.buttonWorkerAdd.Click += new System.EventHandler(this.buttonWorkerAdd_Click);
            // 
            // buttonWorkerEdit
            // 
            this.buttonWorkerEdit.Location = new System.Drawing.Point(31, 144);
            this.buttonWorkerEdit.Name = "buttonWorkerEdit";
            this.buttonWorkerEdit.Size = new System.Drawing.Size(123, 23);
            this.buttonWorkerEdit.TabIndex = 8;
            this.buttonWorkerEdit.Text = "Edytuj pracownika";
            this.buttonWorkerEdit.UseVisualStyleBackColor = true;
            this.buttonWorkerEdit.Click += new System.EventHandler(this.buttonWorkerEdit_Click);
            // 
            // buttonWorkerDelete
            // 
            this.buttonWorkerDelete.Location = new System.Drawing.Point(31, 192);
            this.buttonWorkerDelete.Name = "buttonWorkerDelete";
            this.buttonWorkerDelete.Size = new System.Drawing.Size(123, 23);
            this.buttonWorkerDelete.TabIndex = 9;
            this.buttonWorkerDelete.Text = "Usuń pracownika";
            this.buttonWorkerDelete.UseVisualStyleBackColor = true;
            this.buttonWorkerDelete.Click += new System.EventHandler(this.buttonWorkerDelete_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Silver;
            this.panelEdit.Controls.Add(this.buttonEdit);
            this.panelEdit.Controls.Add(this.textBoxSalary);
            this.panelEdit.Controls.Add(this.textBoxPhone);
            this.panelEdit.Controls.Add(this.textBoxAdress);
            this.panelEdit.Controls.Add(this.textBoxSurname);
            this.panelEdit.Controls.Add(this.textBoxName);
            this.panelEdit.Controls.Add(this.textBoxID);
            this.panelEdit.Controls.Add(this.label14);
            this.panelEdit.Controls.Add(this.label13);
            this.panelEdit.Controls.Add(this.label12);
            this.panelEdit.Controls.Add(this.label11);
            this.panelEdit.Controls.Add(this.label10);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Controls.Add(this.listBoxWorkers);
            this.panelEdit.Location = new System.Drawing.Point(204, 56);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(651, 244);
            this.panelEdit.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(508, 76);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 52);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edytuj pracownika";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(335, 188);
            this.textBoxSalary.MaxLength = 9;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 12;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalary_KeyPress);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(335, 158);
            this.textBoxPhone.MaxLength = 15;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 11;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(335, 123);
            this.textBoxAdress.MaxLength = 120;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdress.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(335, 90);
            this.textBoxSurname.MaxLength = 40;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(335, 62);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(335, 27);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Pensja";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(277, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Telefon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Adres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nazwisko";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Imie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ID";
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.Location = new System.Drawing.Point(33, 22);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.Size = new System.Drawing.Size(153, 160);
            this.listBoxWorkers.TabIndex = 0;
            this.listBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Silver;
            this.panelDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDelete.Controls.Add(this.label8);
            this.panelDelete.Controls.Add(this.GridDelete);
            this.panelDelete.Controls.Add(this.buttonDelete);
            this.panelDelete.Location = new System.Drawing.Point(204, 56);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(651, 244);
            this.panelDelete.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Panel usuwania pracowników";
            // 
            // GridDelete
            // 
            this.GridDelete.AllowUserToAddRows = false;
            this.GridDelete.AllowUserToDeleteRows = false;
            this.GridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDelete.Location = new System.Drawing.Point(32, 44);
            this.GridDelete.Name = "GridDelete";
            this.GridDelete.ReadOnly = true;
            this.GridDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDelete.Size = new System.Drawing.Size(584, 150);
            this.GridDelete.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(226, 205);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Usuń zaznaczonych pracowników";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(31, 241);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(123, 23);
            this.buttonShow.TabIndex = 11;
            this.buttonShow.Text = "Wyświetl pracowników";
            this.buttonShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(223, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wszyscy pracownicy";
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.Silver;
            this.panelShow.Controls.Add(this.GridShowWorkers);
            this.panelShow.Controls.Add(this.label1);
            this.panelShow.Location = new System.Drawing.Point(204, 56);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(651, 244);
            this.panelShow.TabIndex = 12;
            this.panelShow.Visible = false;
            // 
            // GridShowWorkers
            // 
            this.GridShowWorkers.AllowUserToAddRows = false;
            this.GridShowWorkers.AllowUserToDeleteRows = false;
            this.GridShowWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridShowWorkers.Location = new System.Drawing.Point(24, 39);
            this.GridShowWorkers.Name = "GridShowWorkers";
            this.GridShowWorkers.ReadOnly = true;
            this.GridShowWorkers.Size = new System.Drawing.Size(605, 169);
            this.GridShowWorkers.TabIndex = 1;
            this.GridShowWorkers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridShowWorkers_CellFormatting);
            // 
            // WorkerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 353);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonWorkerDelete);
            this.Controls.Add(this.buttonWorkerEdit);
            this.Controls.Add(this.buttonWorkerAdd);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.labelStan);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonBack);
            this.Name = "WorkerMenu";
            this.Text = "Form2";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDelete)).EndInit();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridShowWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelStan;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonWorkerAdd;
        private System.Windows.Forms.Button buttonWorkerEdit;
        private System.Windows.Forms.Button buttonWorkerDelete;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.DataGridView GridShowWorkers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPensja;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridDelete;
        private System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonEdit;
    }
}