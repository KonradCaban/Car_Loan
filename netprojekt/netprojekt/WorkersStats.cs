using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netprojekt
{

    //menu
    public partial class WorkersStats : Form
    {
        Menu m;
        public WorkersStats(Menu _m)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            InitializeComponent();
            m = _m;
            labelDatabase.Text = "Połączono z bazą: " + m.cnn.Database;
            load_workers();
        }

       

        private void WorkersStats_Load(object sender, EventArgs e)
        {

        }

        private void buttonBaza_Click(object sender, EventArgs e)
        {
            try
            {
                m.cnn.Open();
                m.buttonstatus(true);
                labelDatabase.Text = "Połączono z bazą " + m.cnn.Database;
                load_workers();
                buttonBaza.Enabled = false;
                buttonDisconnect.Enabled = true;
                listBox1.Enabled = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Brak połączenia z bazą danych. Numer błędu: "+ ex.Number);
                disconnect();
            }
        }

        private void disconnect()
        {
            buttonBaza.Enabled = true;
            buttonDisconnect.Enabled = false;
            m.cnn.Close();
            m.buttonstatus(false);
            labelDatabase.Text = "Brak połączenia z bazą!";
            listBox1.Enabled = false;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Close();
        }


        //load

        private void load_workers()
        {
            listBox1.Items.Clear();
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
                    BoxItem item = new BoxItem();
                    item.Text = row["PRACOWNIK"].ToString();
                    item.Value = row["ID"];
                    listBox1.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Brak połączenia z bazą danych. Numer błędu: " + ex.Number);
                disconnect();
            }
        }

        //zmiana indeksu
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = m.cnn.CreateCommand();
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select p.id_pracownika as ID, imie + ' ' + nazwisko as pracownik, count(w.id_wyp) as Ilosc, sum(ISNULL(koszt, 0 )) as suma from Pracownicy as p join Wypozyczenia as w on w.id_pracownika=p.id_pracownika where p.id_pracownika = @ID group by p.id_pracownika,imie + ' ' + nazwisko ";
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ((BoxItem)listBox1.SelectedItem).Value;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        richTextBox1.Text = "Pracownik: " + reader["pracownik"].ToString() + "." + Environment.NewLine + "Ilosc przeprowadzonych transakcji: " + reader["Ilosc"].ToString() + Environment.NewLine + "Łączna wartosc przeprowadzonych transakcji: " + Convert.ToDecimal(reader["suma"]).ToString("C2") + ".";
                    }
                    else
                    {
                        richTextBox1.Text = "Pracownik: " + ((BoxItem)listBox1.SelectedItem).Text + "." + Environment.NewLine + "Ilosc przeprowadzonych transakcji: 0" + Environment.NewLine + "Łączna wartosc przeprowadzonych transakcji: 0 zł.";
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Brak połączenia z bazą danych. Numer błędu: " + ex.Number);
                    disconnect();
                }
            }
            
            
        }
    }
}
