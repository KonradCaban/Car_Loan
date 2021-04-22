namespace netprojekt
{
    partial class TypesMenu
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
            this.buttonTypeAdd = new System.Windows.Forms.Button();
            this.buttonTypeEdit = new System.Windows.Forms.Button();
            this.buttonTypeDelete = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.textBoxPriceDay = new System.Windows.Forms.TextBox();
            this.textBoxTypeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxEditName = new System.Windows.Forms.TextBox();
            this.textBoxEditCost = new System.Windows.Forms.TextBox();
            this.textBoxEditId = new System.Windows.Forms.TextBox();
            this.listBoxEdit = new System.Windows.Forms.ListBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.buttonDeleteTypes = new System.Windows.Forms.Button();
            this.GridDeleteTypes = new System.Windows.Forms.DataGridView();
            this.buttonTypesShow = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.GridShowTypes = new System.Windows.Forms.DataGridView();
            this.panelAdd.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDeleteTypes)).BeginInit();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridShowTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(387, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(106, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Połącz z bazą danych";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(545, 12);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Odłącz się od bazy danych";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stan połączenia z bazą danych:";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(205, 13);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(35, 13);
            this.labelDatabase.TabIndex = 3;
            this.labelDatabase.Text = "label2";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(315, 289);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(146, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Powrót do menu głównego";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonTypeAdd
            // 
            this.buttonTypeAdd.Location = new System.Drawing.Point(42, 75);
            this.buttonTypeAdd.Name = "buttonTypeAdd";
            this.buttonTypeAdd.Size = new System.Drawing.Size(139, 23);
            this.buttonTypeAdd.TabIndex = 5;
            this.buttonTypeAdd.Text = "Dodaj rodzaj";
            this.buttonTypeAdd.UseVisualStyleBackColor = true;
            this.buttonTypeAdd.Click += new System.EventHandler(this.buttonTypeAdd_Click);
            // 
            // buttonTypeEdit
            // 
            this.buttonTypeEdit.Location = new System.Drawing.Point(42, 133);
            this.buttonTypeEdit.Name = "buttonTypeEdit";
            this.buttonTypeEdit.Size = new System.Drawing.Size(139, 23);
            this.buttonTypeEdit.TabIndex = 6;
            this.buttonTypeEdit.Text = "Edytuj rodzaj";
            this.buttonTypeEdit.UseVisualStyleBackColor = true;
            this.buttonTypeEdit.Click += new System.EventHandler(this.buttonTypeEdit_Click);
            // 
            // buttonTypeDelete
            // 
            this.buttonTypeDelete.Location = new System.Drawing.Point(42, 193);
            this.buttonTypeDelete.Name = "buttonTypeDelete";
            this.buttonTypeDelete.Size = new System.Drawing.Size(139, 23);
            this.buttonTypeDelete.TabIndex = 7;
            this.buttonTypeDelete.Text = "Usuń rodzaj";
            this.buttonTypeDelete.UseVisualStyleBackColor = true;
            this.buttonTypeDelete.Click += new System.EventHandler(this.buttonTypeDelete_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Silver;
            this.panelAdd.Controls.Add(this.textBoxPriceDay);
            this.panelAdd.Controls.Add(this.textBoxTypeName);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.buttonAddType);
            this.panelAdd.Location = new System.Drawing.Point(208, 63);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(559, 182);
            this.panelAdd.TabIndex = 8;
            // 
            // textBoxPriceDay
            // 
            this.textBoxPriceDay.Location = new System.Drawing.Point(387, 41);
            this.textBoxPriceDay.MaxLength = 7;
            this.textBoxPriceDay.Name = "textBoxPriceDay";
            this.textBoxPriceDay.Size = new System.Drawing.Size(108, 20);
            this.textBoxPriceDay.TabIndex = 4;
            this.textBoxPriceDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceDay_KeyPress);
            // 
            // textBoxTypeName
            // 
            this.textBoxTypeName.Location = new System.Drawing.Point(34, 41);
            this.textBoxTypeName.MaxLength = 50;
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(160, 20);
            this.textBoxTypeName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Koszt wypożyczenia za dzień (w zł.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa nowego rodzaju";
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(191, 130);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(137, 32);
            this.buttonAddType.TabIndex = 0;
            this.buttonAddType.Text = "Dodaj";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Silver;
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.buttonEdit);
            this.panelEdit.Controls.Add(this.textBoxEditName);
            this.panelEdit.Controls.Add(this.textBoxEditCost);
            this.panelEdit.Controls.Add(this.textBoxEditId);
            this.panelEdit.Controls.Add(this.listBoxEdit);
            this.panelEdit.Location = new System.Drawing.Point(208, 63);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(559, 182);
            this.panelEdit.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Koszt wypożyczenia za dzień (w zł.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(346, 131);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(76, 31);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxEditName
            // 
            this.textBoxEditName.Location = new System.Drawing.Point(228, 82);
            this.textBoxEditName.MaxLength = 50;
            this.textBoxEditName.Name = "textBoxEditName";
            this.textBoxEditName.Size = new System.Drawing.Size(124, 20);
            this.textBoxEditName.TabIndex = 3;
            // 
            // textBoxEditCost
            // 
            this.textBoxEditCost.Location = new System.Drawing.Point(407, 82);
            this.textBoxEditCost.MaxLength = 12;
            this.textBoxEditCost.Name = "textBoxEditCost";
            this.textBoxEditCost.Size = new System.Drawing.Size(112, 20);
            this.textBoxEditCost.TabIndex = 2;
            this.textBoxEditCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditCost_KeyPress);
            // 
            // textBoxEditId
            // 
            this.textBoxEditId.Enabled = false;
            this.textBoxEditId.Location = new System.Drawing.Point(471, 10);
            this.textBoxEditId.Name = "textBoxEditId";
            this.textBoxEditId.Size = new System.Drawing.Size(73, 20);
            this.textBoxEditId.TabIndex = 1;
            // 
            // listBoxEdit
            // 
            this.listBoxEdit.FormattingEnabled = true;
            this.listBoxEdit.Location = new System.Drawing.Point(22, 21);
            this.listBoxEdit.Name = "listBoxEdit";
            this.listBoxEdit.Size = new System.Drawing.Size(172, 134);
            this.listBoxEdit.TabIndex = 0;
            this.listBoxEdit.SelectedIndexChanged += new System.EventHandler(this.ListBoxEdit_SelectedIndexChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Gray;
            this.panelDelete.Controls.Add(this.buttonDeleteTypes);
            this.panelDelete.Controls.Add(this.GridDeleteTypes);
            this.panelDelete.Location = new System.Drawing.Point(208, 63);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(559, 182);
            this.panelDelete.TabIndex = 10;
            // 
            // buttonDeleteTypes
            // 
            this.buttonDeleteTypes.Location = new System.Drawing.Point(222, 147);
            this.buttonDeleteTypes.Name = "buttonDeleteTypes";
            this.buttonDeleteTypes.Size = new System.Drawing.Size(130, 23);
            this.buttonDeleteTypes.TabIndex = 1;
            this.buttonDeleteTypes.Text = "Usuń wybrane typy";
            this.buttonDeleteTypes.UseVisualStyleBackColor = true;
            this.buttonDeleteTypes.Click += new System.EventHandler(this.buttonDeleteTypes_Click);
            // 
            // GridDeleteTypes
            // 
            this.GridDeleteTypes.AllowUserToAddRows = false;
            this.GridDeleteTypes.AllowUserToDeleteRows = false;
            this.GridDeleteTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDeleteTypes.Location = new System.Drawing.Point(34, 12);
            this.GridDeleteTypes.Name = "GridDeleteTypes";
            this.GridDeleteTypes.ReadOnly = true;
            this.GridDeleteTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDeleteTypes.Size = new System.Drawing.Size(499, 128);
            this.GridDeleteTypes.TabIndex = 0;
            this.GridDeleteTypes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridShowTypes_CellFormatting);
            // 
            // buttonTypesShow
            // 
            this.buttonTypesShow.Location = new System.Drawing.Point(42, 104);
            this.buttonTypesShow.Name = "buttonTypesShow";
            this.buttonTypesShow.Size = new System.Drawing.Size(139, 23);
            this.buttonTypesShow.TabIndex = 11;
            this.buttonTypesShow.Text = "Wyświetl wszystkie typy";
            this.buttonTypesShow.UseVisualStyleBackColor = true;
            this.buttonTypesShow.Click += new System.EventHandler(this.buttonTypesShow_Click);
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.Gray;
            this.panelShow.Controls.Add(this.GridShowTypes);
            this.panelShow.Location = new System.Drawing.Point(208, 63);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(559, 182);
            this.panelShow.TabIndex = 12;
            // 
            // GridShowTypes
            // 
            this.GridShowTypes.AllowUserToAddRows = false;
            this.GridShowTypes.AllowUserToDeleteRows = false;
            this.GridShowTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridShowTypes.Location = new System.Drawing.Point(22, 12);
            this.GridShowTypes.Name = "GridShowTypes";
            this.GridShowTypes.ReadOnly = true;
            this.GridShowTypes.Size = new System.Drawing.Size(522, 150);
            this.GridShowTypes.TabIndex = 0;
            this.GridShowTypes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridShowTypes_CellFormatting);
            // 
            // TypesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 338);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.buttonTypesShow);
            this.Controls.Add(this.buttonTypeEdit);
            this.Controls.Add(this.buttonTypeDelete);
            this.Controls.Add(this.buttonTypeAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "TypesMenu";
            this.Text = "Form1";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDeleteTypes)).EndInit();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridShowTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTypeAdd;
        private System.Windows.Forms.Button buttonTypeEdit;
        private System.Windows.Forms.Button buttonTypeDelete;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button buttonTypesShow;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.DataGridView GridShowTypes;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.TextBox textBoxPriceDay;
        private System.Windows.Forms.TextBox textBoxTypeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteTypes;
        private System.Windows.Forms.DataGridView GridDeleteTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxEditName;
        private System.Windows.Forms.TextBox textBoxEditCost;
        private System.Windows.Forms.TextBox textBoxEditId;
        private System.Windows.Forms.ListBox listBoxEdit;
    }
}