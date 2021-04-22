using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netprojekt
{
    public partial class TransactionMenu : Form
    {

        //menu
        private void buttonstatus(bool tmp)
        {
            buttonConnect.Enabled = !tmp;
            buttonDisconnect.Enabled = tmp;
            buttonShowTransactions.Enabled = tmp;
            buttonTransactionAdd.Enabled = tmp;
            buttonTransactionEdit.Enabled = tmp;
            buttonTransactionDelete.Enabled = tmp;
            comboBoxCars.Enabled = tmp;
            comboBoxWorkers.Enabled = tmp;
            
            buttonZwroty.Enabled = tmp;
            numericKM.Value = 0;
            GridEdit.Enabled = tmp;
            numericRabat.Value = 0;
           
            buttonDelete.Enabled = tmp;
            if (tmp == false)
            {
                comboBoxCars.SelectedIndex = -1;
                comboBoxWorkers.SelectedIndex = -1;
                buttonAddTrans.Enabled = tmp;
                buttonEdytuj.Enabled = tmp;
                buttonZwrot.Enabled = tmp;
            }

            }
        Decimal type_mon;
        Decimal car_mon;
        int limit;
        Boolean gps;
        Boolean seat;

        Menu m;
        public TransactionMenu()
        {
            InitializeComponent();
        }


        public TransactionMenu(Menu _m)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            InitializeComponent();
            m = _m;
            try
            {

                load_transactions();
                labelDatabase.Text = "Połączono z bazą: " + m.cnn.Database;
                panelShow.Visible = true;
                panelShow.BringToFront();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                m.cnn.Open();
                m.buttonstatus(true);
                labelDatabase.Text = "Połączono z bazą " + m.cnn.Database;

                buttonstatus(true);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nie udało się połączyć z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }

        private void Disconnect()
        {
            m.cnn.Close();
            m.buttonstatus(false);
            buttonstatus(false);
            labelDatabase.Text = "Brak połączenia z bazą!";
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        //load

        private void load_transactions()
        {
            DateTime today = DateTime.Today;
            try
            {
                SqlCommand cmd = new SqlCommand("select imie + ' ' + nazwisko  as [Dane pracownika], marka + ' ' + model as [Samochód], data_wypozyczenia as [Data wypożyczenia], data_zwrotu as [Data zwrotu], limit_km_dzien as [Maksymalna średnia przebytych kilometrów na dzień], dod_fotel as [Fotelik], dod_gps as [GPS] from Wypozyczenia as w join Produkty as p on p.id_produktu=w.id_produktu join Pracownicy as pr on pr.id_pracownika=w.id_pracownika join Wypozyczenia_Szczegoly as ws on ws.id_wyp_dt=w.id_wyp Where data_zwrotu IS NULL ");
                cmd.Parameters.Add("@data", SqlDbType.Date).Value = today;
                cmd.Connection = m.cnn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtrecord = new DataTable();
                sda.Fill(dtrecord);
                GridNotEnded.DataSource = dtrecord;
                cmd.Parameters.Clear();
                cmd = new SqlCommand("select imie + ' ' + nazwisko  as [Dane pracownika], marka + ' ' + model as [Samochód], data_wypozyczenia as [Data wypożyczenia], data_zwrotu as [Data zwrotu],koszt as Koszt, limit_km_dzien as [Maksymalna średnia przebytych kilometrów na dzień], dod_fotel as [Fotelik], dod_gps as [GPS]  from Wypozyczenia as w join Produkty as p on p.id_produktu=w.id_produktu join Pracownicy as pr on pr.id_pracownika=w.id_pracownika join Wypozyczenia_Szczegoly as ws on ws.id_wyp_dt=w.id_wyp where data_zwrotu IS NOT NULL  ");
                cmd.Parameters.Add("@data", SqlDbType.Date).Value = today;
                cmd.Connection = m.cnn;
                cmd.CommandType = CommandType.Text;
                sda = new SqlDataAdapter(cmd);
                dtrecord = new DataTable();
                sda.Fill(dtrecord);
                GridEnded.DataSource = dtrecord;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }

        private void load_delete_transactions()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select id_wyp As ID, imie + ' ' + nazwisko  as [Dane pracownika], marka + ' ' + model as [Samochód], data_wypozyczenia as [Data wypożyczenia], data_zwrotu as [Data zwrotu],koszt as [Koszt]  from Wypozyczenia as w join Produkty as p on p.id_produktu=w.id_produktu join Pracownicy as pr on pr.id_pracownika=w.id_pracownika")
                {
                    Connection = m.cnn,
                    CommandType = CommandType.Text
                };
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtrecord = new DataTable();
                sda.Fill(dtrecord);
                GridDelete.DataSource = dtrecord;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }


        private void load_add_transactions()
        {
            comboBoxCars.SelectedIndex = -1;
            comboBoxWorkers.SelectedIndex = -1;
            numericUpDown1.Value = numericUpDown1.Minimum;
            CheckGPS.Checked = false;
            CheckSeat.Checked = false;
            buttonAddTrans.Enabled = false;
            comboBoxCars.Items.Clear();
            comboBoxWorkers.Items.Clear();
            SqlCommand cmd = m.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {


                cmd.CommandText = "select id_produktu as ID, marka + ' '+ model as Samochod from Produkty Except select p.id_produktu as ID, marka + ' ' + model from Produkty as p join Wypozyczenia as w on w.id_produktu = p.id_produktu where data_zwrotu IS NULL";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    BoxItem item =
                        new BoxItem
                        {
                            Text = row["Samochod"].ToString(),
                            Value = row["ID"]
                        };
                    comboBoxCars.Items.Add(item);
                }
                cmd.CommandText = "select id_pracownika as ID,imie + ' ' + nazwisko as PRACOWNIK from Pracownicy";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    BoxItem item = new BoxItem
                    {
                        Text = row["PRACOWNIK"].ToString(),
                        Value = row["ID"]
                    };
                    comboBoxWorkers.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }

        }


        private void load_edit_transactions()
        {
            if (comboBox1.Items.Count > 0)
                comboBox1.Items.Clear();
            if (comboBox2.Items.Count > 0)
                comboBox2.Items.Clear();
            SqlCommand cmd = m.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "select w.id_wyp as [ID],imie + ' ' + nazwisko as [Pracownik], marka + ' ' + model as [Samochód], data_wypozyczenia as [Data wypożyczenia], data_zwrotu as [Data zwrotu]  from Wypozyczenia as w join wypozyczenia_szczegoly as ws on ws.id_wyp_dt=w.id_wyp join Pracownicy as p on p.id_pracownika=w.id_pracownika join Produkty as pr on pr.id_produktu=w.id_produktu";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtrecord = new DataTable();
                sda.Fill(dtrecord);
                GridEdit.DataSource = dtrecord;

                cmd.CommandText = "select id_pracownika as ID,imie + ' ' + nazwisko as Name from Pracownicy";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    BoxItem item = new BoxItem
                    {
                        Text = row["Name"].ToString(),
                        Value = row["ID"]
                    };
                    comboBox1.Items.Add(item);
                }
                cmd.CommandText = "select id_produktu as ID,marka + ' ' + model as Samochod from Produkty";
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    BoxItem item = new BoxItem
                    {
                        Text = row["Samochod"].ToString(),
                        Value = row["ID"]
                    };
                    comboBox2.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }


        private void load_zwroty()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select id_wyp as [ID], imie + ' ' + nazwisko  as [Dane pracownika], marka + ' ' + model as [Samochód], data_wypozyczenia as [Data wypożyczenia] from Wypozyczenia as w join Produkty as p on p.id_produktu=w.id_produktu join Pracownicy as pr on pr.id_pracownika=w.id_pracownika join Wypozyczenia_Szczegoly as ws on ws.id_wyp_dt=w.id_wyp where data_zwrotu is null")
                {
                    Connection = m.cnn,
                    CommandType = CommandType.Text
                };
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtrecord = new DataTable();
                sda.Fill(dtrecord);
                GridZwroty.DataSource = dtrecord;


                foreach (DataGridViewColumn column in GridZwroty.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }




        //add

        private void buttonTransactionAdd_Click(object sender, EventArgs e)
        {
            try
            {
                load_add_transactions();
                panelAdd.BringToFront();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }


        private void buttonAddTrans_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = m.cnn.CreateCommand();
            try
            {
                SqlTransaction tr = m.cnn.BeginTransaction();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into [Wypozyczenia](id_pracownika,id_produktu) values (@worker,@product)";
                cmd.Parameters.Add("@worker", SqlDbType.Int).Value = ((BoxItem)comboBoxWorkers.SelectedItem).Value;
                cmd.Parameters.Add("@product", SqlDbType.Int).Value = ((BoxItem)comboBoxCars.SelectedItem).Value;
                cmd.Transaction = tr;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = "insert into [Wypozyczenia_Szczegoly](dod_fotel,dod_gps,limit_km_dzien,l_przejechanych,rabat) values (@fotel,@gps,@limit,0,0)";
                cmd.Parameters.Add("@fotel", SqlDbType.Bit).Value = (CheckSeat.Checked ? 1 : 0);
                cmd.Parameters.Add("@gps", SqlDbType.Bit).Value = (CheckGPS.Checked ? 1 : 0);
                cmd.Parameters.Add("@limit", SqlDbType.Int).Value = numericUpDown1.Value;
                cmd.ExecuteNonQuery();
                tr.Commit();
                MessageBox.Show("Dodano nową transakcję!");
                comboBoxCars.SelectedIndex = -1;
                comboBoxWorkers.SelectedIndex = -1;
                numericKM.Value = 0;
                CheckGPS.Checked = false;
                CheckSeat.Checked = false;
                load_add_transactions();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }


        }


        //show
        private void buttonShowTransactions_Click(object sender, EventArgs e)
        {
            try
            {
                load_transactions();
                panelShow.BringToFront();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }

        }

        //edit

        private void buttonTransactionEdit_Click(object sender, EventArgs e)
        {

            buttonEdytuj.Enabled = false;
            try
            {
                load_edit_transactions();
                if (GridEdit.RowCount != 0)
                    GridEdit.Rows[0].Selected = false;
                panelEdit.BringToFront();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }


        }


        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxZwrot.Checked == true)
                {
                    SqlCommand cmd = m.cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "select * from Wypozyczenia where( ((data_wypozyczenia <= @dp) AND ((data_zwrotu is null) OR (data_zwrotu > @dp))) OR (data_wypozyczenia > @dp AND data_wypozyczenia < @dz) ) AND id_produktu =@idp AND id_wyp != @idw";
                    cmd.Parameters.Add("@idp", SqlDbType.Int).Value = ((BoxItem)comboBox2.SelectedItem).Value;
                    cmd.Parameters.Add("@idw", SqlDbType.Int).Value = GridEdit.SelectedRows[0].Cells[0].Value;
                    cmd.Parameters.Add("@dp", SqlDbType.Date).Value = dateTimePickerWyp.Value.Date;
                    cmd.Parameters.Add("@dz", SqlDbType.Date).Value = dateTimePickerZwrot.Value.Date;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Nie można wprowadzić edycji - podany okres wypożyczenia nachodzi się z innymi.");
                    }
                    else
                    {
                        reader.Close();
                        DialogResult dialogResult = MessageBox.Show("Czy policzyć koszt na podstawie zaktualizowanych danych?", "Obliczanie", MessageBoxButtons.YesNoCancel);
                        decimal koszt;
                        if (dialogResult == DialogResult.Yes)
                        {

                            cmd.Parameters.Clear();
                            cmd.CommandText = "select rodzaj_poj,koszt_wyp_dn from Produkty where id_produktu = @ID";
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ((BoxItem)comboBox2.SelectedItem).Value;
                            reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                car_mon = (decimal)reader["koszt_wyp_dn"];
                                int tmp = (int)reader["rodzaj_poj"];

                                reader.Close();
                                cmd.Parameters.Clear();
                                cmd.CommandText = "select cennik_wyp_dn from Kategorie where id_kat = @ID";
                                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tmp;
                                reader = cmd.ExecuteReader();
                                if (reader.Read())
                                {
                                    type_mon = (decimal)reader["cennik_wyp_dn"];
                                }
                                reader.Close();
                            }
                            int ile_dni = (dateTimePickerZwrot.Value - dateTimePickerWyp.Value).Days + 1;
                            koszt = car_mon * ile_dni + type_mon * ile_dni + 20;
                            if (checkBox1.Checked == true)
                                koszt += 30;
                            if (checkBox2.Checked == true)
                                koszt += 10;
                            int przekroczono = Decimal.ToInt32(numericKMdriven.Value) - (ile_dni * Convert.ToInt32(numericLimit.Value));
                            if (przekroczono > 0)
                                koszt += (decimal)(przekroczono * 0.75);
                            if (checkBoxRabat.Checked == true)
                            {
                                koszt *= 1 - (numericUpDown3.Value / 100);
                            }
                            MessageBox.Show("Koszt wypożyczenia wynosi: " + koszt.ToString("N2"));

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            if (!String.IsNullOrWhiteSpace(textBox1.Text))
                                koszt = Convert.ToDecimal(textBox1.Text);
                            else
                                koszt = 0;
                            MessageBox.Show("Koszt wypożyczenia wynosi:" + koszt.ToString("N2"));
                        }
                        else
                        {
                            return;
                        }
                        cmd = m.cnn.CreateCommand();
                        SqlTransaction tr = m.cnn.BeginTransaction();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "update wypozyczenia set id_produktu = @idp, id_pracownika = @pracownik, data_wypozyczenia = @data_wyp, data_zwrotu = @zwrot, koszt = @koszt where id_wyp = @idwyp";
                        cmd.Parameters.Add("@idwyp", SqlDbType.Int).Value = GridEdit.SelectedRows[0].Cells[0].Value;
                        cmd.Parameters.Add("@pracownik", SqlDbType.Int).Value = ((BoxItem)comboBox1.SelectedItem).Value;
                        cmd.Parameters.Add("@idp", SqlDbType.Int).Value = ((BoxItem)comboBox2.SelectedItem).Value;
                        cmd.Parameters.Add("@data_wyp", SqlDbType.Date).Value = dateTimePickerWyp.Value.Date;
                        cmd.Parameters.Add("@koszt", SqlDbType.Money).Value = koszt;
                        cmd.Parameters.Add("@zwrot", SqlDbType.Date).Value = dateTimePickerZwrot.Value.Date;
                        cmd.Transaction = tr;

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "Update wypozyczenia_szczegoly set dod_fotel = @fotel, dod_gps = @gps, limit_km_dzien = @limit, rabat = @rabat, l_przejechanych = @l_przejechanych where id_wyp_dt=@ID";
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = GridEdit.SelectedRows[0].Cells[0].Value;
                        cmd.Parameters.Add("@fotel", SqlDbType.Bit).Value = (checkBox2.Checked ? 1 : 0);
                        cmd.Parameters.Add("@gps", SqlDbType.Bit).Value = (checkBox1.Checked ? 1 : 0);
                        cmd.Parameters.Add("@limit", SqlDbType.Int).Value = numericLimit.Value;
                        cmd.Parameters.Add("@rabat", SqlDbType.Float).Value = ((float)numericUpDown3.Value) / 100;
                        cmd.Parameters.Add("@l_przejechanych", SqlDbType.Int).Value = numericKMdriven.Value;
                        cmd.ExecuteNonQuery();
                        tr.Commit();
                        MessageBox.Show("Edytowano transakcję!");

                    }
                    reader.Close();
                }
                else
                {
                    SqlCommand cmd = m.cnn.CreateCommand();
                    cmd.CommandText = "select * from Wypozyczenia where ((data_wypozyczenia <= @data AND  data_zwrotu >  @data ) OR data_wypozyczenia > @data) AND id_produktu =@idp AND id_wyp != @idw";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@idp", SqlDbType.Int).Value = ((BoxItem)comboBox2.SelectedItem).Value;
                    cmd.Parameters.Add("@idw", SqlDbType.Int).Value = GridEdit.SelectedRows[0].Cells[0].Value;
                    cmd.Parameters.Add("@data", SqlDbType.Date).Value = dateTimePickerWyp.Value.Date;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Nie można wprowadzić edycji - podany okres wypożyczenia nachodzi się z innymi.");
                    }
                    else
                    {
                        reader.Close();
                        SqlTransaction tr = m.cnn.BeginTransaction();
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.CommandText = "update wypozyczenia set id_produktu = @idp, id_pracownika = @pracownik, data_wypozyczenia = @data_wyp, data_zwrotu = NULL ,  koszt = NULL where id_wyp = @idwyp";
                        cmd.Parameters.Add("@idwyp", SqlDbType.Int).Value = GridEdit.SelectedRows[0].Cells[0].Value;
                        cmd.Parameters.Add("@pracownik", SqlDbType.Int).Value = ((BoxItem)comboBox1.SelectedItem).Value;
                        cmd.Parameters.Add("@idp", SqlDbType.Int).Value = ((BoxItem)comboBox2.SelectedItem).Value;
                        cmd.Parameters.Add("@data_wyp", SqlDbType.Date).Value = dateTimePickerWyp.Value.Date;
                        cmd.Transaction = tr;

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "Update wypozyczenia_szczegoly set dod_fotel = @fotel, dod_gps = @gps, limit_km_dzien = @limit, rabat = 0, l_przejechanych = 0 where id_wyp_dt=@ID";
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = GridEdit.SelectedRows[0].Cells[0].Value;
                        cmd.Parameters.Add("@fotel", SqlDbType.Bit).Value = (checkBox2.Checked ? 1 : 0);
                        cmd.Parameters.Add("@gps", SqlDbType.Bit).Value = (checkBox1.Checked ? 1 : 0);
                        cmd.Parameters.Add("@limit", SqlDbType.Int).Value = numericLimit.Value;
                        cmd.ExecuteNonQuery();
                        tr.Commit();
                        MessageBox.Show("Edytowano transakcję!");




                    }

                }
                load_edit_transactions();
                GridEdit.Rows[0].Selected = false;
                buttonEdytuj.Enabled = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadziłeś niepoprawnie zapisaną kwotę.");
                textBox1.Clear();
            }
        }



        //zwrot

        private void buttonEditZwroty_Click(object sender, EventArgs e)
        {
            try
            {
                load_zwroty();


                panelZwroty.BringToFront();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }


        private void buttonZwrot_Click(object sender, EventArgs e)
        {
            if (GridZwroty.SelectedRows.Count != 0)
            {
                int ile_dni = (dateTimePicker1.Value - dateTimePicker1.MinDate).Days + 1;
                Decimal koszt = car_mon * ile_dni + type_mon * ile_dni + 20;
                if (gps == true)
                    koszt += 30;
                if (seat == true)
                    koszt += 10;
                int przekroczono = Decimal.ToInt32(numericKM.Value) - (ile_dni * limit);
                if (przekroczono > 0)
                    koszt += (decimal)(przekroczono * 0.75);
                if (checkRabat.Checked == false)
                {
                    if (ile_dni > 6 && ile_dni < 14)
                    {
                        koszt *= (Decimal)0.90;
                    }
                    if (ile_dni >= 14)
                        koszt *= (Decimal)0.85;
                }
                else
                    koszt *= (Decimal)(1 - (numericRabat.Value / 100));
                SqlCommand cmd = m.cnn.CreateCommand();
                try
                {
                    SqlTransaction tr = m.cnn.BeginTransaction();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "update [Wypozyczenia] SET data_zwrotu = @data, koszt = @koszt where id_wyp = @id";
                    cmd.Parameters.Add("@data", SqlDbType.Date).Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("@koszt", SqlDbType.Money).Value = Decimal.Round(koszt, 2);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = GridZwroty.SelectedRows[0].Cells[0].Value;
                    cmd.Transaction = tr;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "update [Wypozyczenia_Szczegoly] set rabat=@rabat , l_przejechanych = @kl  where id_wyp_dt = @id";
                    if (checkBoxRabat.Checked == true)
                        cmd.Parameters.Add("@rabat", SqlDbType.Float).Value = (numericRabat.Value / 100);
                    else
                    {
                        if (ile_dni >= 14)
                            cmd.Parameters.Add("@rabat", SqlDbType.Float).Value = (0.10);
                        if (ile_dni < 14 && ile_dni > 6)
                            cmd.Parameters.Add("@rabat", SqlDbType.Float).Value = (0.05);
                        if (ile_dni < 7)
                            cmd.Parameters.Add("@rabat", SqlDbType.Float).Value = 0;
                    }


                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = GridZwroty.SelectedRows[0].Cells[0].Value;

                    cmd.Parameters.Add("@kl", SqlDbType.Int).Value = numericKM.Value;
                    cmd.ExecuteNonQuery();
                    tr.Commit();
                    MessageBox.Show("Zwrócono pomyślnie samochód! Łączny koszt: " + Decimal.Round(koszt, 2) + " zł.");
                    numericKM.Value = 0;
                    numericRabat.Value = 0;
                    load_zwroty();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczyłeś żadnego auta do zwrotu!");
            }



        }


        //delete
        private void buttonTransactionDelete_Click(object sender, EventArgs e)
        {
            try
            {
                load_delete_transactions();
                panelDelete.BringToFront();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = GridDelete.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Nie zaznaczyłeś żadnej transakcji!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone transakcje?", "Dialog", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = m.cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;


                    try
                    {
                        for (int i = 0; i < selectedRowsCount; i++)
                        {
                            SqlTransaction tr = m.cnn.BeginTransaction();

                            cmd.Parameters.Clear();
                            cmd.Transaction = tr;
                            cmd.CommandText = "delete from Wypozyczenia where id_wyp = @ID";
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(GridDelete.SelectedRows[i].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "delete from Wypozyczenia_Szczegoly where id_wyp_dt = @ID";
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(GridDelete.SelectedRows[i].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            tr.Commit();
                            MessageBox.Show("Usunięto pomyślnie rekord !");




                        }

                        load_delete_transactions();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                        Disconnect();
                    }

                }
            }
        }


        //zmiana indeksu

        private void comboBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWorkers.SelectedIndex != -1 && comboBoxCars.SelectedIndex != -1)
                buttonAddTrans.Enabled = true;
        }

        private void comboBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWorkers.SelectedIndex != -1 && comboBoxCars.SelectedIndex != -1)
                buttonAddTrans.Enabled = true;
        }


        private void GridZwroty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime today = DateTime.Today;

            if (sender is DataGridView dgv && dgv.CurrentCell.RowIndex >= 0)
            {
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                try
                {


                    cmd.CommandText = "select data_wypozyczenia,ws.dod_fotel as fotelik,ws.dod_gps as gps,ws.limit_km_dzien as limit,k.cennik_wyp_dn as rc,p.koszt_wyp_dn as pc from Wypozyczenia as w join Wypozyczenia_Szczegoly as ws on ws.id_wyp_dt=w.id_wyp join Produkty p on p.id_produktu=w.id_produktu join Kategorie k on k.id_kat=p.rodzaj_poj where w.id_wyp = @ID";
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = GridZwroty.SelectedRows[0].Cells[0].Value;
                    SqlDataReader Reader = cmd.ExecuteReader();
                    if (Reader.Read())
                    {
                        dateTimePicker1.MinDate = DateTime.Parse(Reader["data_wypozyczenia"].ToString());
                        dateTimePicker1.MaxDate = today;
                        seat = ((Boolean)Reader["fotelik"]);
                        gps = ((Boolean)Reader["gps"]);
                        limit = (Int32)Reader["limit"];
                        type_mon = (Decimal)Reader["rc"];
                        car_mon = (Decimal)Reader["pc"];
                    }
                    dateTimePicker1.Enabled = true;
                    Reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();
                }
            }
        }

        private void checkRabat_CheckedChanged(object sender, EventArgs e)
        {
            numericRabat.Enabled = checkRabat.Checked;
        }


        private void checkBoxZwrot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxZwrot.Checked)
                dateTimePickerWyp.MaxDate = dateTimePickerZwrot.Value;
            else
                dateTimePickerWyp.MaxDate = DateTime.Today;
            dateTimePickerZwrot.Enabled = checkBoxZwrot.Checked;
            numericUpDown3.Enabled = checkBoxZwrot.Checked;
            checkBoxRabat.Enabled = checkBoxZwrot.Checked;
            numericKMdriven.Enabled = checkBoxZwrot.Checked;
            textBox1.Enabled = checkBoxZwrot.Checked;
        }

        private void checkBoxRabat_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = checkBoxRabat.Checked;
        }



        private void GridZwroty_SelectionChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            buttonZwrot.Enabled = true;
            if (sender is DataGridView dgv && GridZwroty.CurrentRow.Index > -1 && GridZwroty.SelectedRows.Count > 0)
            {
                try
                {
                    SqlCommand cmd = m.cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select data_wypozyczenia,ws.dod_fotel as fotelik,ws.dod_gps as gps,ws.limit_km_dzien as limit,k.cennik_wyp_dn as rc,p.koszt_wyp_dn as pc from Wypozyczenia as w join Wypozyczenia_Szczegoly as ws on ws.id_wyp_dt=w.id_wyp join Produkty p on p.id_produktu=w.id_produktu join Kategorie k on k.id_kat=p.rodzaj_poj where w.id_wyp = @ID";
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = GridZwroty.SelectedRows[0].Cells[0].Value;
                    SqlDataReader Reader = cmd.ExecuteReader();
                    if (Reader.Read())
                    {
                        dateTimePicker1.MinDate = DateTime.Parse(Reader["data_wypozyczenia"].ToString());
                        dateTimePicker1.MaxDate = today;
                        seat = ((Boolean)Reader["fotelik"]);
                        gps = ((Boolean)Reader["gps"]);
                        limit = (Int32)Reader["limit"];
                        type_mon = (Decimal)Reader["rc"];
                        car_mon = (Decimal)Reader["pc"];
                    }
                    dateTimePicker1.Enabled = true;
                    Reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();
                }
            }
        }

        private void GridEdit_SelectionChanged(object sender, EventArgs e)
        {

            if (GridEdit.CurrentRow != null && GridEdit.SelectedRows.Count > 0 && comboBox1.Items.Count > 0 && comboBox2.Items.Count > 0)
            {
                dateTimePickerWyp.MinDate = new DateTime(2019, 9, 1);
                dateTimePickerWyp.MaxDate = new DateTime(2040, 1, 1);
                DateTime today = DateTime.Today;
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Wypozyczenia as w join wypozyczenia_szczegoly as ws on ws.id_wyp_dt=w.id_wyp  where w.id_wyp = @ID";
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = GridEdit.SelectedRows[0].Cells[0].Value;
                try
                {
                    SqlDataReader Reader = cmd.ExecuteReader();
                    if (Reader.Read())
                    {
                        if (Reader["data_zwrotu"] != DBNull.Value)
                        {
                            dateTimePickerWyp.MaxDate = DateTime.Parse(Reader["data_zwrotu"].ToString());
                            dateTimePickerZwrot.Value = DateTime.Parse(Reader["data_zwrotu"].ToString());

                            checkBoxZwrot.Checked = true;
                        }
                        else
                        {
                            dateTimePickerWyp.MaxDate = today;
                            checkBoxZwrot.Checked = false;
                        }
                        dateTimePickerWyp.Value = DateTime.Parse(Reader["data_wypozyczenia"].ToString());
                        dateTimePickerZwrot.MinDate = dateTimePickerWyp.Value;
                        dateTimePickerZwrot.MaxDate = today;
                        if (Convert.ToBoolean(Reader["dod_gps"].ToString()) == true)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        if (Convert.ToBoolean(Reader["dod_fotel"].ToString()) == true)
                            checkBox2.Checked = true;
                        else
                            checkBox2.Checked = false;
                        numericKMdriven.Value = Decimal.Parse(Reader["l_przejechanych"].ToString());
                        numericLimit.Value = Decimal.Parse(Reader["limit_km_dzien"].ToString());
                        Decimal tmp = Decimal.Parse(Reader["rabat"].ToString());
                        numericUpDown3.Value = tmp * 100;
                        if (Reader["koszt"] != DBNull.Value)
                            textBox1.Text = Convert.ToDecimal(Reader["koszt"].ToString()).ToString("N2");
                        else
                            textBox1.Text = "";

                        int i = 0;
                        foreach (BoxItem item in comboBox1.Items)
                        {
                            if (Int32.Parse(Reader["id_pracownika"].ToString()) == (int)(item.Value))
                            {
                                comboBox1.SelectedIndex = i;
                            }
                            i++;
                        }
                        i = 0;
                        foreach (BoxItem item in comboBox2.Items)
                        {
                            if (Int32.Parse(Reader["id_produktu"].ToString()) == (int)(item.Value))
                            {
                                comboBox2.SelectedIndex = i;
                            }
                            i++;
                        }
                    }
                    dateTimePicker1.Enabled = true;
                    Reader.Close();
                    buttonEdytuj.Enabled = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();
                }
            }
        }


        //formatowanie

         void dateTimePickerWyp_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerZwrot.MinDate = dateTimePickerWyp.Value;
        }

        private void dateTimePickerZwrot_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerWyp.MaxDate = dateTimePickerZwrot.Value;
        }

        private void GridEnded_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
                e.CellStyle.Format = "N2";
        }

        private void GridDelete_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
                e.CellStyle.Format = "N2";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(textBox1.Text, @"\,\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            var box = (TextBox)sender;
            if (box.Text.StartsWith(",")) box.Text = "";
        }

    }
}
