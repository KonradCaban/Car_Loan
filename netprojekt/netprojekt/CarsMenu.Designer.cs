namespace netprojekt
{
    partial class CarsMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCarAdd = new System.Windows.Forms.Button();
            this.buttonCarEdit = new System.Windows.Forms.Button();
            this.buttonCarDelete = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxVIN = new System.Windows.Forms.TextBox();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxEditCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.comboBoxTypesEdit = new System.Windows.Forms.ComboBox();
            this.textBoxEditProducer = new System.Windows.Forms.TextBox();
            this.textBoxEditYear = new System.Windows.Forms.TextBox();
            this.textBoxEditID = new System.Windows.Forms.TextBox();
            this.textBoxEditVIN = new System.Windows.Forms.TextBox();
            this.textBoxEditModel = new System.Windows.Forms.TextBox();
            this.buttonEditCar = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.GridDelete = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.panelAdd.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDelete)).BeginInit();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stan połączenia z bazą:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(369, 11);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(108, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Połącz z bazą danych:";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(501, 12);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(221, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Odłącz się od bazy";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(319, 287);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Powrót do menu głownego";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCarAdd
            // 
            this.buttonCarAdd.Location = new System.Drawing.Point(28, 78);
            this.buttonCarAdd.Name = "buttonCarAdd";
            this.buttonCarAdd.Size = new System.Drawing.Size(146, 23);
            this.buttonCarAdd.TabIndex = 5;
            this.buttonCarAdd.Text = "Dodaj samochód";
            this.buttonCarAdd.UseVisualStyleBackColor = true;
            this.buttonCarAdd.Click += new System.EventHandler(this.buttonCarAdd_Click);
            // 
            // buttonCarEdit
            // 
            this.buttonCarEdit.Location = new System.Drawing.Point(28, 117);
            this.buttonCarEdit.Name = "buttonCarEdit";
            this.buttonCarEdit.Size = new System.Drawing.Size(146, 23);
            this.buttonCarEdit.TabIndex = 6;
            this.buttonCarEdit.Text = "Edytuj samochód";
            this.buttonCarEdit.UseVisualStyleBackColor = true;
            this.buttonCarEdit.Click += new System.EventHandler(this.buttonCarEdit_Click);
            // 
            // buttonCarDelete
            // 
            this.buttonCarDelete.Location = new System.Drawing.Point(28, 198);
            this.buttonCarDelete.Name = "buttonCarDelete";
            this.buttonCarDelete.Size = new System.Drawing.Size(146, 23);
            this.buttonCarDelete.TabIndex = 7;
            this.buttonCarDelete.Text = "Usuń samochód";
            this.buttonCarDelete.UseVisualStyleBackColor = true;
            this.buttonCarDelete.Click += new System.EventHandler(this.buttonCarDelete_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Silver;
            this.panelAdd.Controls.Add(this.label8);
            this.panelAdd.Controls.Add(this.textBoxCost);
            this.panelAdd.Controls.Add(this.textBoxVIN);
            this.panelAdd.Controls.Add(this.textBoxProducer);
            this.panelAdd.Controls.Add(this.textBoxModel);
            this.panelAdd.Controls.Add(this.textBoxYear);
            this.panelAdd.Controls.Add(this.comboBoxType);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.label7);
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Location = new System.Drawing.Point(205, 68);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(492, 182);
            this.panelAdd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Koszt wypożyczenia na dzień (w zł.)";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(209, 104);
            this.textBoxCost.MaxLength = 7;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 12;
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCost_KeyPress);
            // 
            // textBoxVIN
            // 
            this.textBoxVIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxVIN.Location = new System.Drawing.Point(372, 35);
            this.textBoxVIN.MaxLength = 17;
            this.textBoxVIN.Name = "textBoxVIN";
            this.textBoxVIN.Size = new System.Drawing.Size(100, 20);
            this.textBoxVIN.TabIndex = 4;
            this.textBoxVIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVIN_KeyPress);
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(21, 34);
            this.textBoxProducer.MaxLength = 35;
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(100, 20);
            this.textBoxProducer.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(21, 118);
            this.textBoxModel.MaxLength = 40;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 2;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(372, 122);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 3;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(193, 34);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rodzaj samochodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "VIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rok produkcji";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(209, 144);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Dodaj samochód";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Gray;
            this.panelEdit.Controls.Add(this.label14);
            this.panelEdit.Controls.Add(this.textBoxEditCost);
            this.panelEdit.Controls.Add(this.label13);
            this.panelEdit.Controls.Add(this.label12);
            this.panelEdit.Controls.Add(this.label11);
            this.panelEdit.Controls.Add(this.label10);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Controls.Add(this.labe);
            this.panelEdit.Controls.Add(this.comboBoxTypesEdit);
            this.panelEdit.Controls.Add(this.textBoxEditProducer);
            this.panelEdit.Controls.Add(this.textBoxEditYear);
            this.panelEdit.Controls.Add(this.textBoxEditID);
            this.panelEdit.Controls.Add(this.textBoxEditVIN);
            this.panelEdit.Controls.Add(this.textBoxEditModel);
            this.panelEdit.Controls.Add(this.buttonEditCar);
            this.panelEdit.Controls.Add(this.listBoxCars);
            this.panelEdit.Location = new System.Drawing.Point(205, 68);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(492, 182);
            this.panelEdit.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(197, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Koszt dniowy wypożyczenia (w zł.)";
            // 
            // textBoxEditCost
            // 
            this.textBoxEditCost.Location = new System.Drawing.Point(372, 148);
            this.textBoxEditCost.MaxLength = 7;
            this.textBoxEditCost.Name = "textBoxEditCost";
            this.textBoxEditCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditCost.TabIndex = 15;
            this.textBoxEditCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditCost_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Model";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Marka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Numer VIN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rok produkcji";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(158, 42);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(98, 13);
            this.labe.TabIndex = 9;
            this.labe.Text = "Rodzaj samochodu";
            // 
            // comboBoxTypesEdit
            // 
            this.comboBoxTypesEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypesEdit.FormattingEnabled = true;
            this.comboBoxTypesEdit.Location = new System.Drawing.Point(147, 61);
            this.comboBoxTypesEdit.Name = "comboBoxTypesEdit";
            this.comboBoxTypesEdit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypesEdit.TabIndex = 8;
            // 
            // textBoxEditProducer
            // 
            this.textBoxEditProducer.Location = new System.Drawing.Point(372, 42);
            this.textBoxEditProducer.MaxLength = 35;
            this.textBoxEditProducer.Name = "textBoxEditProducer";
            this.textBoxEditProducer.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditProducer.TabIndex = 7;
            this.textBoxEditProducer.Text = " ";
            // 
            // textBoxEditYear
            // 
            this.textBoxEditYear.Location = new System.Drawing.Point(372, 122);
            this.textBoxEditYear.MaxLength = 4;
            this.textBoxEditYear.Name = "textBoxEditYear";
            this.textBoxEditYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditYear.TabIndex = 6;
            this.textBoxEditYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // textBoxEditID
            // 
            this.textBoxEditID.Enabled = false;
            this.textBoxEditID.Location = new System.Drawing.Point(426, 16);
            this.textBoxEditID.Name = "textBoxEditID";
            this.textBoxEditID.Size = new System.Drawing.Size(46, 20);
            this.textBoxEditID.TabIndex = 5;
            // 
            // textBoxEditVIN
            // 
            this.textBoxEditVIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxEditVIN.Location = new System.Drawing.Point(372, 96);
            this.textBoxEditVIN.MaxLength = 17;
            this.textBoxEditVIN.Name = "textBoxEditVIN";
            this.textBoxEditVIN.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditVIN.TabIndex = 3;
            this.textBoxEditVIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVIN_KeyPress);
            // 
            // textBoxEditModel
            // 
            this.textBoxEditModel.Location = new System.Drawing.Point(372, 68);
            this.textBoxEditModel.MaxLength = 40;
            this.textBoxEditModel.Name = "textBoxEditModel";
            this.textBoxEditModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditModel.TabIndex = 2;
            // 
            // buttonEditCar
            // 
            this.buttonEditCar.Location = new System.Drawing.Point(66, 144);
            this.buttonEditCar.Name = "buttonEditCar";
            this.buttonEditCar.Size = new System.Drawing.Size(102, 23);
            this.buttonEditCar.TabIndex = 1;
            this.buttonEditCar.Text = "Edytuj samochód";
            this.buttonEditCar.UseVisualStyleBackColor = true;
            this.buttonEditCar.Click += new System.EventHandler(this.buttonEditCar_Click);
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(21, 21);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(120, 95);
            this.listBoxCars.TabIndex = 0;
            this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Gray;
            this.panelDelete.Controls.Add(this.buttonDelete);
            this.panelDelete.Controls.Add(this.GridDelete);
            this.panelDelete.Location = new System.Drawing.Point(205, 68);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(492, 182);
            this.panelDelete.TabIndex = 10;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(195, 156);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Usuń samochód";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // GridDelete
            // 
            this.GridDelete.AllowUserToAddRows = false;
            this.GridDelete.AllowUserToDeleteRows = false;
            this.GridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDelete.Location = new System.Drawing.Point(0, 3);
            this.GridDelete.MultiSelect = false;
            this.GridDelete.Name = "GridDelete";
            this.GridDelete.ReadOnly = true;
            this.GridDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDelete.Size = new System.Drawing.Size(492, 150);
            this.GridDelete.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(28, 161);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(146, 23);
            this.buttonShow.TabIndex = 11;
            this.buttonShow.Text = "Wyświetl samochody";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.Silver;
            this.panelShow.Controls.Add(this.dataGridViewShow);
            this.panelShow.Location = new System.Drawing.Point(205, 68);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(492, 182);
            this.panelShow.TabIndex = 12;
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AllowUserToAddRows = false;
            this.dataGridViewShow.AllowUserToDeleteRows = false;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.ReadOnly = true;
            this.dataGridViewShow.Size = new System.Drawing.Size(492, 182);
            this.dataGridViewShow.TabIndex = 0;
            this.dataGridViewShow.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewShow_CellFormatting);
            // 
            // CarsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 345);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.buttonCarAdd);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonCarDelete);
            this.Controls.Add(this.buttonCarEdit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarsMenu";
            this.Text = "Cars";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDelete)).EndInit();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCarAdd;
        private System.Windows.Forms.Button buttonCarEdit;
        private System.Windows.Forms.Button buttonCarDelete;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxVIN;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.DataGridView GridDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.ComboBox comboBoxTypesEdit;
        private System.Windows.Forms.TextBox textBoxEditProducer;
        private System.Windows.Forms.TextBox textBoxEditYear;
        private System.Windows.Forms.TextBox textBoxEditID;
        private System.Windows.Forms.TextBox textBoxEditVIN;
        private System.Windows.Forms.TextBox textBoxEditModel;
        private System.Windows.Forms.Button buttonEditCar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxEditCost;
    }
}