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
    public partial class CarsMenu : Form
    {

    //menu

        private void buttonstatus(bool tmp)
        {
            buttonConnect.Enabled = !tmp;
            buttonDisconnect.Enabled = tmp;
            buttonCarAdd.Enabled = tmp;
            buttonCarEdit.Enabled = tmp;
            buttonCarDelete.Enabled = tmp;
            buttonShow.Enabled = tmp;
            buttonAdd.Enabled = tmp;
            comboBoxType.Enabled = tmp;
            buttonDelete.Enabled = tmp;
            if (tmp == false)
            {
                buttonEditCar.Enabled = tmp;
                
            }
            listBoxCars.Enabled = tmp;
        }

        Menu m;
        public CarsMenu()
        {
            InitializeComponent();
        }

        public CarsMenu(Menu _m)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            InitializeComponent();
            m = _m;
            label2.Text = "Połączono z bazą: " + m.cnn.Database;
            Load_cars(dataGridViewShow);
            panelShow.BringToFront();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Close();
        }

            private void Disconnect()
        {
            m.cnn.Close();
            m.buttonstatus(false);
            buttonstatus(false);
            clearEdit();
            label2.Text = "Brak połączenia z bazą!";
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
                label2.Text = "Połączono z bazą " + m.cnn.Database;
                buttonstatus(true);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: "+ ex.Number);
            }
        }


        //load

        private void Load_cars(DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand("select id_produktu as [ID],marka + ' ' + model as [Samochód],k.nazwa as [Kategoria],numer_vin as [VIN], rok_produkcji as [Rok produkcji], koszt_wyp_dn as [Koszt wypożyczenia] from Produkty as p join Kategorie as k on k.id_kat=p.rodzaj_poj")
            {
                Connection = m.cnn,
                CommandType = CommandType.Text
            };
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtrecord = new DataTable();
            sda.Fill(dtrecord);
            dgv.DataSource = dtrecord;
        }
        //add

        private void buttonCarAdd_Click(object sender, EventArgs e)
        {
            textBoxCost.Clear();
            textBoxProducer.Clear();
            textBoxModel.Clear();
            textBoxVIN.Clear();
            textBoxYear.Clear();

            comboBoxType.Items.Clear();
            SqlCommand cmd = m.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "select id_kat as ID,nazwa as Name from Kategorie";
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
                    comboBoxType.Items.Add(item);
                }
                panelAdd.BringToFront();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();

            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxProducer.Text) || String.IsNullOrWhiteSpace(textBoxModel.Text) || String.IsNullOrWhiteSpace(textBoxVIN.Text) || String.IsNullOrWhiteSpace(textBoxYear.Text) || comboBoxType.SelectedIndex <= -1 || String.IsNullOrWhiteSpace(textBoxCost.Text))
            {
                MessageBox.Show("Nie uzupełniłeś wszystkich pól!");
            }
            else
            {
                int act_year = DateTime.Now.Year;
                if (textBoxVIN.Text.Length != 17)
                {
                    MessageBox.Show("Numer VIN musi mieć dokładnie 17 znaków!");
                }
                else
                {
                    if (Int32.Parse(textBoxYear.Text) > 1900 && Int32.Parse(textBoxYear.Text) <= act_year)
                    {
                        SqlCommand cmd = m.cnn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        try
                        {


                            cmd.CommandText = "insert into [Produkty] values (@kat,@model,@marka,@rok,@vin,@koszt)";
                            cmd.Parameters.Add("@kat", SqlDbType.Int).Value = ((BoxItem)comboBoxType.SelectedItem).Value;
                            cmd.Parameters.Add("@model", SqlDbType.VarChar, 40).Value = textBoxModel.Text;
                            cmd.Parameters.Add("@marka", SqlDbType.VarChar, 35).Value = textBoxProducer.Text;
                            cmd.Parameters.Add("@rok", SqlDbType.Int).Value = Int32.Parse(textBoxYear.Text);
                            cmd.Parameters.Add("@vin", SqlDbType.VarChar, 18).Value = textBoxVIN.Text;
                            cmd.Parameters.Add("@koszt", SqlDbType.Money).Value = textBoxCost.Text;
                            int success = cmd.ExecuteNonQuery();
                            if (success == 1)
                                MessageBox.Show("Dodano nowy samochod!");
                            else
                                MessageBox.Show("Blad podczas dodawania samochodu!");
                            textBoxCost.Clear();
                            textBoxProducer.Clear();
                            textBoxModel.Clear();
                            textBoxVIN.Clear();
                            textBoxYear.Clear();

                            comboBoxType.Items.Clear();

                            cmd.CommandText = "select id_kat as ID,nazwa as Name from Kategorie";
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
                                comboBoxType.Items.Add(item);
                            }
                            panelAdd.BringToFront();


                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                            Disconnect();

                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Wprowadziłeś niepoprawnie zapisaną kwotę.");
                            textBoxCost.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podałeś niepoprawny rok produkcji!");
                    }
                }

            }
        }



        //show
        private void buttonShow_Click(object sender, EventArgs e)
        {

            Load_cars(dataGridViewShow);
            panelShow.BringToFront();
        }

        //edit

        private void buttonCarEdit_Click(object sender, EventArgs e)
        {
            textBoxEditCost.Clear();
            textBoxEditID.Clear();
            textBoxEditModel.Clear();
            textBoxEditProducer.Clear();
            textBoxEditVIN.Clear();
            textBoxEditYear.Clear();

            buttonEditCar.Enabled = false;
            comboBoxTypesEdit.Items.Clear();
            listBoxCars.Items.Clear();
            SqlCommand cmd = m.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try

            {
                cmd.CommandText = "select id_kat as ID,nazwa as Name from Kategorie";
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
                    comboBoxTypesEdit.Items.Add(item);
                }
                cmd.CommandText = "select id_produktu as ID,marka + ' ' + model as Samochod from Produkty";
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                da = sqlDataAdapter;
                dt.Clear();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    BoxItem item = new BoxItem
                    {
                        Text = row["Samochod"].ToString(),
                        Value = row["ID"]
                    };
                    listBoxCars.Items.Add(item);
                }
                panelEdit.BringToFront();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();

            }

        }


        private void buttonEditCar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = m.cnn.CreateCommand();
            if (String.IsNullOrWhiteSpace(textBoxEditProducer.Text) || String.IsNullOrWhiteSpace(textBoxEditCost.Text) || String.IsNullOrWhiteSpace(textBoxEditModel.Text) || String.IsNullOrWhiteSpace(textBoxEditVIN.Text) || String.IsNullOrWhiteSpace(textBoxEditYear.Text))
            {
                MessageBox.Show("Nie uzupełniłeś wszystkich pól!");
            }
            else
            {
                int act_year = DateTime.Now.Year;
                if (textBoxEditVIN.Text.Length != 17)
                {
                    MessageBox.Show("Numer VIN musi mieć dokładnie 17 znaków!");
                }
                else
                {
                    try
                    {
                        if (Int32.Parse(textBoxEditYear.Text) > 1900 && Int32.Parse(textBoxEditYear.Text) <= act_year)
                        {

                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = "update [Produkty] set marka = @marka, model = @model, rok_produkcji = @rok, numer_vin = @vin, rodzaj_poj = @cat_id, koszt_wyp_dn=@koszt where id_produktu = @id";
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(textBoxEditID.Text);
                            cmd.Parameters.Add("@cat_id", SqlDbType.Int).Value = ((BoxItem)comboBoxTypesEdit.SelectedItem).Value;
                            cmd.Parameters.Add("@model", SqlDbType.VarChar, 40).Value = textBoxEditModel.Text;
                            cmd.Parameters.Add("@marka", SqlDbType.VarChar, 35).Value = textBoxEditProducer.Text;
                            cmd.Parameters.Add("@rok", SqlDbType.Int).Value = Int32.Parse(textBoxEditYear.Text);
                            cmd.Parameters.Add("@vin", SqlDbType.VarChar, 18).Value = textBoxEditVIN.Text;
                            cmd.Parameters.Add("@koszt", SqlDbType.Money).Value = textBoxEditCost.Text;
                            int success = cmd.ExecuteNonQuery();
                            if (success == 1)
                                MessageBox.Show("Edytowano samochód!");
                            else
                                MessageBox.Show("Blad podczas edytowania samochodu!");
                            textBoxEditCost.Clear();
                            textBoxEditID.Clear();
                            textBoxEditModel.Clear();
                            textBoxEditProducer.Clear();
                            textBoxEditVIN.Clear();
                            textBoxEditYear.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Podałeś niepoprawny rok produkcji!");
                        }
                        cmd = m.cnn.CreateCommand();
                        cmd.CommandText = "select id_produktu as ID,marka + ' ' + model as Samochod from Produkty";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        listBoxCars.Items.Clear();
                        da.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            BoxItem item = new BoxItem
                            {
                                Text = row["Samochod"].ToString(),
                                Value = row["ID"]
                            };
                            listBoxCars.Items.Add(item);
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
                        textBoxEditCost.Clear();
                    }


                }

            }
        }




        private void clearEdit()
        {
            textBoxEditCost.Clear();
            textBoxEditID.Clear();
            textBoxEditModel.Clear();
            textBoxEditProducer.Clear();
            textBoxEditVIN.Clear();
            textBoxEditYear.Clear();
            listBoxCars.ClearSelected();

        }


        //delete

        private void buttonCarDelete_Click(object sender, EventArgs e)
        {
            Load_cars(GridDelete);
            panelDelete.BringToFront();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = GridDelete.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Nie zaznaczyłeś żadnego samochodu!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony samochody?", "Dialog", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = m.cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        cmd.CommandText = "delete from Produkty where id_produktu = @ID";
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(GridDelete.SelectedRows[0].Cells[0].Value);
                        int success = cmd.ExecuteNonQuery();
                        if (success == 1)
                            MessageBox.Show("Usunięto samochód o numerze ID: " + GridDelete.SelectedRows[0].Cells[0].Value);
                        else
                            MessageBox.Show("Blad podczas usuwania samochodu!");
                        Load_cars(GridDelete);
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 0)
                        {
                            MessageBox.Show("Utracono połączenie z bazą danych.");
                            Disconnect();
                        }
                        else
                            MessageBox.Show("Nie można usunąć samochodu: aby to zrobić należy najpierw usunąć wszystkie transakcje związane z tym samochodem." + ex.Number);

                    }

                }
            }
        }



        // zmiana w liscie/gridzie
        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxTypesEdit.Items.Clear();
            int selected_id = 0;
            if (listBoxCars.SelectedItem != null)
            {
                buttonEditCar.Enabled = true;
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                BoxItem item = (BoxItem)listBoxCars.SelectedItem;
                try
                {
                    cmd.CommandText = "select id_produktu,model,marka,numer_vin,rok_produkcji,id_kat,koszt_wyp_dn from Produkty as p join Kategorie as k on k.id_kat=p.rodzaj_poj where id_produktu ='" + item.Value + " ' ";
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        textBoxEditID.Text = Reader["id_produktu"].ToString();
                        textBoxEditModel.Text = Reader["model"].ToString();
                        textBoxEditProducer.Text = Reader["marka"].ToString();
                        textBoxEditVIN.Text = Reader["numer_vin"].ToString();
                        textBoxEditYear.Text = Reader["rok_produkcji"].ToString();
                        textBoxEditCost.Text = Convert.ToDecimal(Reader["koszt_wyp_dn"]).ToString("C2");
                        selected_id = (int)Reader["id_kat"];

                    }
                    Reader.Close();
                    cmd.CommandText = "select id_kat as ID,nazwa as Name from Kategorie";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        item = new BoxItem
                        {
                            Text = row["Name"].ToString(),
                            Value = row["ID"]
                        };
                        comboBoxTypesEdit.Items.Add(item);
                        if (selected_id == (int)item.Value)
                            comboBoxTypesEdit.SelectedIndex = i;
                        i++;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();

                }
            }
        }

        //formatowanie
        private void textBoxVIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'I' || e.KeyChar == 'O' || e.KeyChar == 'Q' || e.KeyChar == 'i' || e.KeyChar == 'q' || e.KeyChar == 'o')
                e.Handled = true;

        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(textBoxCost.Text, @"\,\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            var box = (TextBox)sender;
            if (box.Text.StartsWith(",")) box.Text = "";
        }

        private void textBoxEditCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(textBoxEditCost.Text, @"\,\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            var box = (TextBox)sender;
            if (box.Text.StartsWith(",")) box.Text = "";
        }

        private void dataGridViewShow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
                e.CellStyle.Format = "N2";
        }
    }
}
