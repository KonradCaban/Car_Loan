namespace netprojekt
{
    partial class TransactionMenu
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckGPS = new System.Windows.Forms.CheckBox();
            this.CheckSeat = new System.Windows.Forms.CheckBox();
            this.buttonAddTrans = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.buttonTransactionAdd = new System.Windows.Forms.Button();
            this.buttonTransactionEdit = new System.Windows.Forms.Button();
            this.buttonTransactionDelete = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.numericLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRabat = new System.Windows.Forms.CheckBox();
            this.checkBoxZwrot = new System.Windows.Forms.CheckBox();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.labelNumberofKM = new System.Windows.Forms.Label();
            this.numericKMdriven = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerZwrot = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerWyp = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GridEdit = new System.Windows.Forms.DataGridView();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.GridDelete = new System.Windows.Forms.DataGridView();
            this.buttonShowTransactions = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridEnded = new System.Windows.Forms.DataGridView();
            this.GridNotEnded = new System.Windows.Forms.DataGridView();
            this.buttonZwroty = new System.Windows.Forms.Button();
            this.panelZwroty = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericKM = new System.Windows.Forms.NumericUpDown();
            this.checkRabat = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonZwrot = new System.Windows.Forms.Button();
            this.numericRabat = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GridZwroty = new System.Windows.Forms.DataGridView();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKMdriven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEdit)).BeginInit();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDelete)).BeginInit();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNotEnded)).BeginInit();
            this.panelZwroty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRabat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridZwroty)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(325, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(133, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Połącz z bazą danych";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(502, 12);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(133, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Odłącz się od bazy danych";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stan połączenia z bazą danych:";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(178, 18);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(0, 13);
            this.labelDatabase.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(430, 446);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Powrót do menu głównego";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Silver;
            this.panelAdd.Controls.Add(this.label16);
            this.panelAdd.Controls.Add(this.numericUpDown1);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.CheckGPS);
            this.panelAdd.Controls.Add(this.CheckSeat);
            this.panelAdd.Controls.Add(this.buttonAddTrans);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.comboBoxWorkers);
            this.panelAdd.Controls.Add(this.comboBoxCars);
            this.panelAdd.Location = new System.Drawing.Point(181, 57);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(716, 383);
            this.panelAdd.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(270, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(231, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Dodawanie nowej transakcji";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(321, 160);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Limit kilometrów na dzień (przekroczenie => 1km = +0.75 zł)";
            // 
            // CheckGPS
            // 
            this.CheckGPS.AutoSize = true;
            this.CheckGPS.Location = new System.Drawing.Point(405, 196);
            this.CheckGPS.Name = "CheckGPS";
            this.CheckGPS.Size = new System.Drawing.Size(181, 17);
            this.CheckGPS.TabIndex = 9;
            this.CheckGPS.Text = "Wypożyczenie nawigacji (+30 zł)";
            this.CheckGPS.UseVisualStyleBackColor = true;
            // 
            // CheckSeat
            // 
            this.CheckSeat.AutoSize = true;
            this.CheckSeat.Location = new System.Drawing.Point(182, 196);
            this.CheckSeat.Name = "CheckSeat";
            this.CheckSeat.Size = new System.Drawing.Size(171, 17);
            this.CheckSeat.TabIndex = 8;
            this.CheckSeat.Text = "Wypożyczenie fotelika (+10 zł)";
            this.CheckSeat.UseVisualStyleBackColor = true;
            // 
            // buttonAddTrans
            // 
            this.buttonAddTrans.Location = new System.Drawing.Point(313, 238);
            this.buttonAddTrans.Name = "buttonAddTrans";
            this.buttonAddTrans.Size = new System.Drawing.Size(141, 42);
            this.buttonAddTrans.TabIndex = 7;
            this.buttonAddTrans.Text = "Dodaj nową transakcję";
            this.buttonAddTrans.UseVisualStyleBackColor = true;
            this.buttonAddTrans.Click += new System.EventHandler(this.buttonAddTrans_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lista pracowników";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lista samochodów";
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(457, 75);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWorkers.TabIndex = 1;
            this.comboBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkers_SelectedIndexChanged);
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.Location = new System.Drawing.Point(151, 75);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCars.TabIndex = 0;
            this.comboBoxCars.SelectedIndexChanged += new System.EventHandler(this.comboBoxCars_SelectedIndexChanged);
            // 
            // buttonTransactionAdd
            // 
            this.buttonTransactionAdd.Location = new System.Drawing.Point(30, 66);
            this.buttonTransactionAdd.Name = "buttonTransactionAdd";
            this.buttonTransactionAdd.Size = new System.Drawing.Size(114, 23);
            this.buttonTransactionAdd.TabIndex = 6;
            this.buttonTransactionAdd.Text = "Dodaj transakcje";
            this.buttonTransactionAdd.UseVisualStyleBackColor = true;
            this.buttonTransactionAdd.Click += new System.EventHandler(this.buttonTransactionAdd_Click);
            // 
            // buttonTransactionEdit
            // 
            this.buttonTransactionEdit.Location = new System.Drawing.Point(30, 116);
            this.buttonTransactionEdit.Name = "buttonTransactionEdit";
            this.buttonTransactionEdit.Size = new System.Drawing.Size(114, 37);
            this.buttonTransactionEdit.TabIndex = 7;
            this.buttonTransactionEdit.Text = "Edytuj wypożyczenia";
            this.buttonTransactionEdit.UseVisualStyleBackColor = true;
            this.buttonTransactionEdit.Click += new System.EventHandler(this.buttonTransactionEdit_Click);
            // 
            // buttonTransactionDelete
            // 
            this.buttonTransactionDelete.Location = new System.Drawing.Point(30, 247);
            this.buttonTransactionDelete.Name = "buttonTransactionDelete";
            this.buttonTransactionDelete.Size = new System.Drawing.Size(114, 23);
            this.buttonTransactionDelete.TabIndex = 8;
            this.buttonTransactionDelete.Text = "Usuń transakcję";
            this.buttonTransactionDelete.UseVisualStyleBackColor = true;
            this.buttonTransactionDelete.Click += new System.EventHandler(this.buttonTransactionDelete_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Silver;
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Controls.Add(this.numericLimit);
            this.panelEdit.Controls.Add(this.checkBoxRabat);
            this.panelEdit.Controls.Add(this.checkBoxZwrot);
            this.panelEdit.Controls.Add(this.buttonEdytuj);
            this.panelEdit.Controls.Add(this.numericUpDown3);
            this.panelEdit.Controls.Add(this.labelNumberofKM);
            this.panelEdit.Controls.Add(this.numericKMdriven);
            this.panelEdit.Controls.Add(this.label14);
            this.panelEdit.Controls.Add(this.textBox1);
            this.panelEdit.Controls.Add(this.checkBox2);
            this.panelEdit.Controls.Add(this.checkBox1);
            this.panelEdit.Controls.Add(this.label10);
            this.panelEdit.Controls.Add(this.label8);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.dateTimePickerZwrot);
            this.panelEdit.Controls.Add(this.dateTimePickerWyp);
            this.panelEdit.Controls.Add(this.comboBox2);
            this.panelEdit.Controls.Add(this.comboBox1);
            this.panelEdit.Controls.Add(this.GridEdit);
            this.panelEdit.Location = new System.Drawing.Point(181, 57);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(716, 383);
            this.panelEdit.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Limit kilometrów na dzień";
            // 
            // numericLimit
            // 
            this.numericLimit.Location = new System.Drawing.Point(253, 286);
            this.numericLimit.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericLimit.Name = "numericLimit";
            this.numericLimit.Size = new System.Drawing.Size(120, 20);
            this.numericLimit.TabIndex = 20;
            // 
            // checkBoxRabat
            // 
            this.checkBoxRabat.AutoSize = true;
            this.checkBoxRabat.Location = new System.Drawing.Point(433, 269);
            this.checkBoxRabat.Name = "checkBoxRabat";
            this.checkBoxRabat.Size = new System.Drawing.Size(55, 17);
            this.checkBoxRabat.TabIndex = 19;
            this.checkBoxRabat.Text = "Rabat";
            this.checkBoxRabat.UseVisualStyleBackColor = true;
            this.checkBoxRabat.CheckedChanged += new System.EventHandler(this.checkBoxRabat_CheckedChanged);
            // 
            // checkBoxZwrot
            // 
            this.checkBoxZwrot.AutoSize = true;
            this.checkBoxZwrot.Location = new System.Drawing.Point(433, 245);
            this.checkBoxZwrot.Name = "checkBoxZwrot";
            this.checkBoxZwrot.Size = new System.Drawing.Size(59, 17);
            this.checkBoxZwrot.TabIndex = 18;
            this.checkBoxZwrot.Text = "Zwrot?";
            this.checkBoxZwrot.UseVisualStyleBackColor = true;
            this.checkBoxZwrot.CheckedChanged += new System.EventHandler(this.checkBoxZwrot_CheckedChanged);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(278, 324);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(75, 43);
            this.buttonEdytuj.TabIndex = 17;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(508, 269);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown3.TabIndex = 15;
            // 
            // labelNumberofKM
            // 
            this.labelNumberofKM.AutoSize = true;
            this.labelNumberofKM.Location = new System.Drawing.Point(230, 224);
            this.labelNumberofKM.Name = "labelNumberofKM";
            this.labelNumberofKM.Size = new System.Drawing.Size(166, 13);
            this.labelNumberofKM.TabIndex = 14;
            this.labelNumberofKM.Text = "Liczba przejechanych kilometrów:";
            // 
            // numericKMdriven
            // 
            this.numericKMdriven.Location = new System.Drawing.Point(253, 240);
            this.numericKMdriven.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericKMdriven.Name = "numericKMdriven";
            this.numericKMdriven.Size = new System.Drawing.Size(120, 20);
            this.numericKMdriven.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(568, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Kwota";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(540, 347);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(71, 337);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Fotelik";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(153, 337);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "GPS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Auto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data wypożyczenia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pracownik";
            // 
            // dateTimePickerZwrot
            // 
            this.dateTimePickerZwrot.Enabled = false;
            this.dateTimePickerZwrot.Location = new System.Drawing.Point(508, 243);
            this.dateTimePickerZwrot.Name = "dateTimePickerZwrot";
            this.dateTimePickerZwrot.Size = new System.Drawing.Size(132, 20);
            this.dateTimePickerZwrot.TabIndex = 4;
            this.dateTimePickerZwrot.ValueChanged += new System.EventHandler(this.dateTimePickerZwrot_ValueChanged);
            // 
            // dateTimePickerWyp
            // 
            this.dateTimePickerWyp.Location = new System.Drawing.Point(507, 217);
            this.dateTimePickerWyp.Name = "dateTimePickerWyp";
            this.dateTimePickerWyp.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerWyp.TabIndex = 3;
            this.dateTimePickerWyp.ValueChanged += new System.EventHandler(this.dateTimePickerWyp_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 286);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // GridEdit
            // 
            this.GridEdit.AllowUserToAddRows = false;
            this.GridEdit.AllowUserToDeleteRows = false;
            this.GridEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEdit.Location = new System.Drawing.Point(14, 6);
            this.GridEdit.MultiSelect = false;
            this.GridEdit.Name = "GridEdit";
            this.GridEdit.ReadOnly = true;
            this.GridEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEdit.Size = new System.Drawing.Size(681, 202);
            this.GridEdit.TabIndex = 0;
            this.GridEdit.SelectionChanged += new System.EventHandler(this.GridEdit_SelectionChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Gray;
            this.panelDelete.Controls.Add(this.label15);
            this.panelDelete.Controls.Add(this.buttonDelete);
            this.panelDelete.Controls.Add(this.GridDelete);
            this.panelDelete.Location = new System.Drawing.Point(181, 57);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(716, 383);
            this.panelDelete.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(285, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Usuwanie transakcji";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(307, 309);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 40);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Usuń zaznaczone transakcje";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // GridDelete
            // 
            this.GridDelete.AllowUserToAddRows = false;
            this.GridDelete.AllowUserToDeleteRows = false;
            this.GridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDelete.Location = new System.Drawing.Point(27, 43);
            this.GridDelete.Name = "GridDelete";
            this.GridDelete.ReadOnly = true;
            this.GridDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDelete.Size = new System.Drawing.Size(668, 250);
            this.GridDelete.TabIndex = 0;
            this.GridDelete.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridDelete_CellFormatting);
            // 
            // buttonShowTransactions
            // 
            this.buttonShowTransactions.Location = new System.Drawing.Point(30, 214);
            this.buttonShowTransactions.Name = "buttonShowTransactions";
            this.buttonShowTransactions.Size = new System.Drawing.Size(114, 23);
            this.buttonShowTransactions.TabIndex = 11;
            this.buttonShowTransactions.Text = "Wyświetl transakcje";
            this.buttonShowTransactions.UseVisualStyleBackColor = true;
            this.buttonShowTransactions.Click += new System.EventHandler(this.buttonShowTransactions_Click);
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.Silver;
            this.panelShow.Controls.Add(this.label3);
            this.panelShow.Controls.Add(this.label2);
            this.panelShow.Controls.Add(this.GridEnded);
            this.panelShow.Controls.Add(this.GridNotEnded);
            this.panelShow.Location = new System.Drawing.Point(181, 57);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(716, 383);
            this.panelShow.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(229, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wszystkie ukończone wypożyczenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(234, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wszystkie aktualne wypożyczenia";
            // 
            // GridEnded
            // 
            this.GridEnded.AllowUserToAddRows = false;
            this.GridEnded.AllowUserToDeleteRows = false;
            this.GridEnded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEnded.Location = new System.Drawing.Point(14, 211);
            this.GridEnded.Name = "GridEnded";
            this.GridEnded.ReadOnly = true;
            this.GridEnded.Size = new System.Drawing.Size(681, 169);
            this.GridEnded.TabIndex = 2;
            this.GridEnded.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridEnded_CellFormatting);
            // 
            // GridNotEnded
            // 
            this.GridNotEnded.AllowUserToAddRows = false;
            this.GridNotEnded.AllowUserToDeleteRows = false;
            this.GridNotEnded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNotEnded.Location = new System.Drawing.Point(14, 24);
            this.GridNotEnded.Name = "GridNotEnded";
            this.GridNotEnded.ReadOnly = true;
            this.GridNotEnded.Size = new System.Drawing.Size(681, 156);
            this.GridNotEnded.TabIndex = 1;
            // 
            // buttonZwroty
            // 
            this.buttonZwroty.Location = new System.Drawing.Point(30, 159);
            this.buttonZwroty.Name = "buttonZwroty";
            this.buttonZwroty.Size = new System.Drawing.Size(114, 49);
            this.buttonZwroty.TabIndex = 12;
            this.buttonZwroty.Text = "Zwroty";
            this.buttonZwroty.UseVisualStyleBackColor = true;
            this.buttonZwroty.Click += new System.EventHandler(this.buttonEditZwroty_Click);
            // 
            // panelZwroty
            // 
            this.panelZwroty.BackColor = System.Drawing.Color.Silver;
            this.panelZwroty.Controls.Add(this.richTextBox1);
            this.panelZwroty.Controls.Add(this.label13);
            this.panelZwroty.Controls.Add(this.numericKM);
            this.panelZwroty.Controls.Add(this.checkRabat);
            this.panelZwroty.Controls.Add(this.label12);
            this.panelZwroty.Controls.Add(this.label11);
            this.panelZwroty.Controls.Add(this.buttonZwrot);
            this.panelZwroty.Controls.Add(this.numericRabat);
            this.panelZwroty.Controls.Add(this.dateTimePicker1);
            this.panelZwroty.Controls.Add(this.GridZwroty);
            this.panelZwroty.Location = new System.Drawing.Point(181, 58);
            this.panelZwroty.Name = "panelZwroty";
            this.panelZwroty.Size = new System.Drawing.Size(716, 382);
            this.panelZwroty.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gray;
            this.richTextBox1.Location = new System.Drawing.Point(444, 285);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(217, 68);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "Jeśli samochód został wypożyczony na więcej niż 7 dni, to zostaje naliczony rabat" +
    " w wysokości 5% natomiast jeśli powyżej 13 dni - 10 %";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Łączna liczba przejechanych kilometrów";
            // 
            // numericKM
            // 
            this.numericKM.Location = new System.Drawing.Point(263, 228);
            this.numericKM.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericKM.Name = "numericKM";
            this.numericKM.Size = new System.Drawing.Size(120, 20);
            this.numericKM.TabIndex = 7;
            // 
            // checkRabat
            // 
            this.checkRabat.AutoSize = true;
            this.checkRabat.Location = new System.Drawing.Point(488, 247);
            this.checkRabat.Name = "checkRabat";
            this.checkRabat.Size = new System.Drawing.Size(90, 17);
            this.checkRabat.TabIndex = 6;
            this.checkRabat.Text = "Własny rabat";
            this.checkRabat.UseVisualStyleBackColor = true;
            this.checkRabat.CheckedChanged += new System.EventHandler(this.checkRabat_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(488, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Wysokość rabatu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Data zwrotu";
            // 
            // buttonZwrot
            // 
            this.buttonZwrot.Enabled = false;
            this.buttonZwrot.Location = new System.Drawing.Point(238, 298);
            this.buttonZwrot.Name = "buttonZwrot";
            this.buttonZwrot.Size = new System.Drawing.Size(152, 23);
            this.buttonZwrot.TabIndex = 3;
            this.buttonZwrot.Text = "Zwróć i oblicz koszt";
            this.buttonZwrot.UseVisualStyleBackColor = true;
            this.buttonZwrot.Click += new System.EventHandler(this.buttonZwrot_Click);
            // 
            // numericRabat
            // 
            this.numericRabat.Enabled = false;
            this.numericRabat.Location = new System.Drawing.Point(479, 221);
            this.numericRabat.Name = "numericRabat";
            this.numericRabat.Size = new System.Drawing.Size(120, 20);
            this.numericRabat.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // GridZwroty
            // 
            this.GridZwroty.AllowUserToAddRows = false;
            this.GridZwroty.AllowUserToDeleteRows = false;
            this.GridZwroty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridZwroty.Location = new System.Drawing.Point(129, 8);
            this.GridZwroty.MultiSelect = false;
            this.GridZwroty.Name = "GridZwroty";
            this.GridZwroty.ReadOnly = true;
            this.GridZwroty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridZwroty.Size = new System.Drawing.Size(476, 188);
            this.GridZwroty.TabIndex = 0;
            this.GridZwroty.SelectionChanged += new System.EventHandler(this.GridZwroty_SelectionChanged);
            // 
            // TransactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 491);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelZwroty);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.buttonTransactionDelete);
            this.Controls.Add(this.buttonZwroty);
            this.Controls.Add(this.buttonTransactionAdd);
            this.Controls.Add(this.buttonShowTransactions);
            this.Controls.Add(this.buttonTransactionEdit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "TransactionMenu";
            this.Text = "TransactionMenu";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKMdriven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEdit)).EndInit();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDelete)).EndInit();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNotEnded)).EndInit();
            this.panelZwroty.ResumeLayout(false);
            this.panelZwroty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRabat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridZwroty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonTransactionAdd;
        private System.Windows.Forms.Button buttonTransactionEdit;
        private System.Windows.Forms.Button buttonTransactionDelete;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button buttonShowTransactions;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridEnded;
        private System.Windows.Forms.DataGridView GridNotEnded;
        private System.Windows.Forms.DataGridView GridDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddTrans;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerZwrot;
        private System.Windows.Forms.DateTimePicker dateTimePickerWyp;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView GridEdit;
        private System.Windows.Forms.Button buttonZwroty;
        private System.Windows.Forms.CheckBox CheckGPS;
        private System.Windows.Forms.CheckBox CheckSeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panelZwroty;
        private System.Windows.Forms.CheckBox checkRabat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonZwrot;
        private System.Windows.Forms.NumericUpDown numericRabat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView GridZwroty;
        private System.Windows.Forms.NumericUpDown numericKM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label labelNumberofKM;
        private System.Windows.Forms.NumericUpDown numericKMdriven;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxRabat;
        private System.Windows.Forms.CheckBox checkBoxZwrot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericLimit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}