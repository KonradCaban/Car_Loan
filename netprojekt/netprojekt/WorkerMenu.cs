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
    public partial class WorkerMenu : Form
    {
        
       // menu
        private void Hidepanels()
        {
            panelShow.Visible = false;
            panelAdd.Visible = false;
            panelDelete.Visible = false;
            panelEdit.Visible = false;
        }

        private void buttonstatus(bool tmp)
        {
            buttonConnect.Enabled = !tmp;
            buttonDisconnect.Enabled = tmp;
            buttonShow.Enabled = tmp;
            buttonWorkerAdd.Enabled = tmp;
            buttonWorkerDelete.Enabled = tmp;
            buttonWorkerEdit.Enabled = tmp;
            buttonAdd.Enabled = tmp;
            buttonDelete.Enabled = tmp;
            buttonEdit.Enabled = tmp;
            listBoxWorkers.Enabled = tmp;
        }

        Menu m;

        public WorkerMenu(Menu _m)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            m = _m;
            InitializeComponent();
            labelDatabase.Text = "Połączono z bazą: " + m.cnn.Database;
            try
            {
                load_workers(GridShowWorkers);
                Hidepanels();
                panelShow.Visible = true;
               
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Close();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
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

        //load


        private void load_workers(DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand("select id_pracownika as [ID], imie + ' ' + nazwisko as [Pracownik], adres as [Adres], telefon as [Telefon], wyplata as [Wypłata] from Pracownicy ")
            {
                Connection = m.cnn,
                CommandType = CommandType.Text
            };
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtrecord = new DataTable();
            sda.Fill(dtrecord);
            dgv.DataSource = dtrecord;
        }

        //buttons
        //add


        private void buttonWorkerAdd_Click(object sender, EventArgs e)
        {
            Hidepanels();
            textBoxImie.Clear();
            textBoxNazwisko.Clear();
            textBoxAdres.Clear();
            textBoxTelefon.Clear();
            textBoxPensja.Clear();
            panelAdd.Visible = true;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxAdres.Text) || String.IsNullOrWhiteSpace(textBoxImie.Text) || String.IsNullOrWhiteSpace(textBoxNazwisko.Text) || String.IsNullOrWhiteSpace(textBoxTelefon.Text) || String.IsNullOrWhiteSpace(textBoxPensja.Text))
            {
                MessageBox.Show("Nie uzupełniłeś wszystkich pól!");
            }
            else
            {
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.CommandText = "insert into [Pracownicy] values (@imie,@nazwisko,@adres,@telefon,@pensja)";
                    cmd.Parameters.Add("@imie", SqlDbType.VarChar, 30).Value = textBoxImie.Text;
                    cmd.Parameters.Add("@nazwisko", SqlDbType.VarChar, 40).Value = textBoxNazwisko.Text;
                    cmd.Parameters.Add("@adres", SqlDbType.VarChar, 120).Value = textBoxAdres.Text;
                    cmd.Parameters.Add("@telefon", SqlDbType.VarChar, 10).Value = textBoxTelefon.Text;
                    cmd.Parameters.Add("@pensja", SqlDbType.Money).Value = Decimal.Parse(textBoxPensja.Text);
                    int success = cmd.ExecuteNonQuery();
                    if (success == 1)
                        MessageBox.Show("Dodano nowego pracownika!");
                    else
                        MessageBox.Show("Blad podczas dodawania pracownika!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wprowadziłeś niepoprawnie zapisaną kwotę.");
                }
                textBoxImie.Clear();
                textBoxNazwisko.Clear();
                textBoxAdres.Clear();
                textBoxTelefon.Clear();
                textBoxPensja.Clear();
            }
        }

        //show
        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                load_workers(GridShowWorkers);
                Hidepanels();
                panelShow.Visible = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nie udało się połączyć z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }
        //edit


        private void buttonWorkerEdit_Click(object sender, EventArgs e)
        {
            buttonEdit.Enabled = false;
            listBoxWorkers.Items.Clear();
            Hidepanels();
            panelEdit.Visible = true;
            SqlCommand cmd = m.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "select id_pracownika as ID,imie + ' ' + nazwisko as PRACOWNIK from Pracownicy";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    BoxItem item = new BoxItem
                    {
                        Text = row["PRACOWNIK"].ToString(),
                        Value = row["ID"]
                    };
                    listBoxWorkers.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }

        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text) || String.IsNullOrWhiteSpace(textBoxSurname.Text) || String.IsNullOrWhiteSpace(textBoxPhone.Text) || String.IsNullOrWhiteSpace(textBoxAdress.Text) || String.IsNullOrWhiteSpace(textBoxSalary.Text))
            {
                MessageBox.Show("Nie uzupełniłeś wszystkich pól!");
            }
            else
            {
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.CommandText = "update [Pracownicy] set imie = @imie, nazwisko = @nazwisko, adres = @adres, telefon = @telefon, wyplata = @pensja where id_pracownika = @id";
                    cmd.Parameters.Add("@imie", SqlDbType.VarChar, 30).Value = textBoxName.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(textBoxID.Text);
                    cmd.Parameters.Add("@nazwisko", SqlDbType.VarChar, 40).Value = textBoxSurname.Text;
                    cmd.Parameters.Add("@adres", SqlDbType.VarChar, 120).Value = textBoxAdress.Text;
                    cmd.Parameters.Add("@telefon", SqlDbType.VarChar, 10).Value = textBoxPhone.Text;
                    cmd.Parameters.Add("@pensja", SqlDbType.Money).Value = Decimal.Parse(textBoxSalary.Text);
                    int success = cmd.ExecuteNonQuery();
                    if (success == 1)
                        MessageBox.Show("Edytowano pracownika!");
                    else
                        MessageBox.Show("Blad podczas edytowania pracownika!");
                    textBoxName.Clear();
                    textBoxID.Clear();
                    textBoxSurname.Clear();
                    textBoxAdress.Clear();
                    textBoxPhone.Clear();
                    textBoxSalary.Clear();
                    listBoxWorkers.Items.Clear();
                    cmd = m.cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select id_pracownika as ID,imie + ' ' + nazwisko as PRACOWNIK from Pracownicy";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        BoxItem item = new BoxItem
                        {
                            Text = row["PRACOWNIK"].ToString(),
                            Value = row["ID"]
                        };
                        listBoxWorkers.Items.Add(item);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wprowadziłeś niepoprawnie zapisaną kwotę.");
                    textBoxSalary.Clear();
                }
            }
        }

        //delete



        private void buttonWorkerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                load_workers(GridDelete);
                Hidepanels();
                panelDelete.Visible = true;
                
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
            if(selectedRowsCount == 0 )
            {
                MessageBox.Show("Nie zaznaczyłeś żadnego pracownika!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczonych pracowników?", "Dialog", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    SqlCommand cmd = m.cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "delete from Pracownicy where id_pracownika = @ID";
                    
                    for (int i = 0; i < selectedRowsCount; i++)
                    {
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "delete from Pracownicy where id_pracownika = @ID";
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(GridDelete.SelectedRows[i].Cells[0].Value);
                            int success = cmd.ExecuteNonQuery();
                            if (success == 1)
                                MessageBox.Show("Usunięto pracownika o numerze ID: " + GridDelete.SelectedRows[i].Cells[0].Value);
                            else
                                MessageBox.Show("Blad podczas usuwania pracownika!");
                          
                        }
                        catch(SqlException ex)
                        {
                            if (ex.Number == 547)
                                MessageBox.Show("Aby wykasować tego pracownika należy przed tym usunąć wszystkie transakcje wykonane przez niego.");
                            else
                            {
                                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                                return;
                            }
                        }

                    }
                    try
                    {
                        load_workers(GridDelete);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Nie udało się połączyć z bazą danych. Numer błędu: " + ex.Number);
                        Disconnect();
                    }

                }
            }
        }





        //zmiany w listach/gridach

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem != null)
            {
                buttonEdit.Enabled = true;
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                BoxItem item = (BoxItem)listBoxWorkers.SelectedItem;
                try
                {
                    cmd.CommandText = "select * from pracownicy where id_pracownika ='" + item.Value + " ' ";
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        textBoxID.Text = Reader["id_pracownika"].ToString();
                        textBoxName.Text = Reader["imie"].ToString();
                        textBoxSurname.Text = Reader["nazwisko"].ToString();
                        textBoxAdress.Text = Reader["adres"].ToString();
                        textBoxPhone.Text = Reader["telefon"].ToString();

                        textBoxSalary.Text = Reader["wyplata"].ToString();
                        textBoxSalary.Text = String.Format("{0:N}", Double.Parse(textBoxSalary.Text));
                    }
                    Reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();
                }
            }
        }



        //formatowanie



        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(textBoxSalary.Text, @"\,\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            var box = (TextBox)sender;
            if (box.Text.StartsWith(",")) box.Text = "";
        }


        private void textBoxPensja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(textBoxPensja.Text, @"\,\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            var box = (TextBox)sender;
            if (box.Text.StartsWith(",")) box.Text = "";
        }



        private void textBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void GridShowWorkers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
                e.CellStyle.Format = "N2";
        }
    }






}

