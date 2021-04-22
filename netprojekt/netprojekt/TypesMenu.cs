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
    public partial class TypesMenu : Form
    {

        //menu
        private void Disconnect()
        {
            textBoxEditCost.Clear();
            textBoxEditId.Clear();
            textBoxEditName.Clear();
            m.cnn.Close();
            m.buttonstatus(false);
            buttonstatus(false);
            labelDatabase.Text = "Brak połączenia z bazą!";
        }

        private void buttonstatus(bool tmp)
        {
            buttonConnect.Enabled = !tmp;
            buttonDisconnect.Enabled = tmp;
            buttonTypeAdd.Enabled = tmp;
            buttonTypeDelete.Enabled = tmp;
            buttonTypeEdit.Enabled = tmp;
            buttonTypesShow.Enabled = tmp;
            buttonAddType.Enabled = tmp;
            if (tmp == false)
            {
                buttonEdit.Enabled = tmp;
                listBoxEdit.SelectedIndex = -1;
            }
            buttonDeleteTypes.Enabled = tmp;
            listBoxEdit.Enabled = tmp;
            textBoxEditName.Enabled = tmp;
            textBoxEditCost.Enabled = tmp;
            
        }

        Menu m;
        public TypesMenu()
        {
            InitializeComponent();
        }


        public TypesMenu(Menu _m)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            InitializeComponent();
            m = _m;
            labelDatabase.Text = "Połączono z bazą: " + m.cnn.Database;

            try
            {
                load_types(GridShowTypes);
                panelShow.BringToFront();
            }
            catch(SqlException ex)
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
                MessageBox.Show("Brak połączenia z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }



        //load

        private void load_types(DataGridView dgv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select id_kat as [ID],nazwa as [Nazwa kategorii], cennik_wyp_dn as [Koszt wypożyczenia na dzień] from Kategorie ")
                {
                    Connection = m.cnn,
                    CommandType = CommandType.Text
                };
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtrecord = new DataTable();
                sda.Fill(dtrecord);
                dgv.DataSource = dtrecord;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }

        //buttons
        //add


        private void buttonTypeAdd_Click(object sender, EventArgs e)
        {
            panelAdd.BringToFront();
            textBoxTypeName.Clear();
            textBoxPriceDay.Clear();
        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPriceDay.Text) || String.IsNullOrWhiteSpace(textBoxTypeName.Text))
            {

                MessageBox.Show("Nie uzupełniłeś wszystkich pól!");
            }
            else
            {
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.CommandText = "insert into [Kategorie] values (@nazwa,@koszt)";
                    cmd.Parameters.Add("@nazwa", SqlDbType.VarChar, 50).Value = textBoxTypeName.Text;
                    cmd.Parameters.Add("@koszt", SqlDbType.Money).Value = Decimal.Parse(textBoxPriceDay.Text);
                    int success = cmd.ExecuteNonQuery();
                    if (success == 1)
                    {
                        MessageBox.Show("Dodano nowy rodzaj!");
                        textBoxTypeName.Clear();
                        textBoxPriceDay.Clear();

                    }
                    else
                        MessageBox.Show("Blad podczas dodawania!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                    Disconnect();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wprowadziłeś niepoprawnie zapisaną kwotę.");
                    textBoxPriceDay.Clear();
                }

            }
        }


        //show

        private void buttonTypesShow_Click(object sender, EventArgs e)
        {
            load_types(GridShowTypes);
            panelShow.BringToFront();
        }



        //edit

        private void buttonTypeEdit_Click(object sender, EventArgs e)
        {
            textBoxEditCost.Clear();
            textBoxEditId.Clear();
            textBoxEditName.Clear();
            buttonEdit.Enabled = false;
            listBoxEdit.Items.Clear();
            panelEdit.BringToFront();
            SqlCommand cmd = m.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "select id_kat as ID,nazwa as Nazwa from Kategorie";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    BoxItem item = new BoxItem
                    {
                        Text = row["Nazwa"].ToString(),
                        Value = row["ID"]
                    };
                    listBoxEdit.Items.Add(item);
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
            if (String.IsNullOrWhiteSpace(textBoxEditCost.Text) || String.IsNullOrWhiteSpace(textBoxEditName.Text))
            {
                MessageBox.Show("Nie uzupełniłeś wszystkich pól!");
            }
            else
            {
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.CommandText = "update [Kategorie] set nazwa = @nazwa , cennik_wyp_dn = @koszt where id_kat = @id";
                    cmd.Parameters.Add("@nazwa", SqlDbType.VarChar, 50).Value = textBoxEditName.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(textBoxEditId.Text);
                    cmd.Parameters.Add("@koszt", SqlDbType.Money).Value = Decimal.Parse(textBoxEditCost.Text);
                    int success = cmd.ExecuteNonQuery();
                    if (success == 1)
                        MessageBox.Show("Edytowano kategorię!");
                    else
                        MessageBox.Show("Blad podczas edytowania kategorii!");
                    textBoxEditCost.Clear();
                    textBoxEditId.Clear();
                    textBoxEditName.Clear();
                    listBoxEdit.Items.Clear();
                    cmd = m.cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select id_kat as ID,nazwa as Nazwa from Kategorie";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        BoxItem item = new BoxItem
                        {
                            Text = row["Nazwa"].ToString(),
                            Value = row["ID"]
                        };
                        listBoxEdit.Items.Add(item);
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

        //delete


        private void buttonTypeDelete_Click(object sender, EventArgs e)
        {
            panelDelete.BringToFront();
            load_types(GridDeleteTypes);

        }

        private void buttonDeleteTypes_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = GridDeleteTypes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Nie zaznaczyłeś żadnych rekordów!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone rekordy?", "Dialog", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = m.cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        for (int i = 0; i < selectedRowsCount; i++)
                        {

                            cmd.Parameters.Clear();
                            cmd.CommandText = "delete from Kategorie where id_kat = @ID";
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(GridDeleteTypes.SelectedRows[i].Cells[0].Value);
                            int success = cmd.ExecuteNonQuery();
                            if (success == 1)
                                MessageBox.Show("Usunięto typ o numerze ID: " + GridDeleteTypes.SelectedRows[i].Cells[0].Value);
                            else
                                MessageBox.Show("Blad podczas usuwania typu!");
                        }
                        load_types(GridDeleteTypes);
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Aby wykasować ten rodzaj należy przed tym usunąć wszystkie samochody tego typu. Numer błędu: " + ex.Number);
                            load_types(GridDeleteTypes);
                        }
                        else
                        {
                            MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                            Disconnect();
                        }
                    }

                }
            }
        }

      

        //zmiana w liscie/gridzie
        private void ListBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEdit.SelectedItem != null)
            {
                buttonEdit.Enabled = true;
                SqlCommand cmd = m.cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                BoxItem item = (BoxItem)listBoxEdit.SelectedItem;
                try
                {
                    cmd.CommandText = "select * from Kategorie where id_kat ='" + item.Value + " ' ";
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        textBoxEditId.Text = Reader["id_kat"].ToString();
                        textBoxEditName.Text = Reader["nazwa"].ToString();
                        textBoxEditCost.Text = Reader["cennik_wyp_dn"].ToString();
                        textBoxEditCost.Text = String.Format("{0:N}", Double.Parse(textBoxEditCost.Text));
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

        private void textBoxPriceDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(textBoxPriceDay.Text, @"\,\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            var box = (TextBox)sender;
            if (box.Text.StartsWith(",")) box.Text = "";
        }

        private void GridShowTypes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
                e.CellStyle.Format = "N2";
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

    }
}
