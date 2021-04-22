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
    public partial class Raport : Form
    {

        //menu
        public Raport()
        {
            InitializeComponent();

        }
        Menu m;
        public Raport(Menu _m)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            InitializeComponent();
            buttonBaza.Enabled = false;
            m = _m;
            labelBaza.Text = "Połączono z bazą: " + m.cnn.Database;
            startDate.MaxDate = endDate.Value;
            endDate.MinDate = startDate.Value;


        }

        private void Disconnect()
        {
            buttonDisconnect.Enabled = false;
            buttonBaza.Enabled = true;
            m.cnn.Close();
            m.buttonstatus(false);
            labelBaza.Text = "Brak połączenia z bazą!";
            buttonGen.Enabled = false;
        }

        private void buttonBaza_Click(object sender, EventArgs e)
        {
            try
            {
                m.cnn.Open();
                m.buttonstatus(true);
                buttonDisconnect.Enabled = true;
                buttonBaza.Enabled = false;
                labelBaza.Text = "Połączono z bazą " + m.cnn.Database;
                buttonGen.Enabled = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nie udało połączyć się z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Close();
        }

        //generowanie
        private void buttonGen_Click(object sender, EventArgs e)
        {
            labelKwota.Text = "0,00";
            SqlCommand cmd = m.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DateTime dateStart = startDate.Value.Date;
            int miesiace = 0;
            DateTime dateEnd = endDate.Value.Date;
            DateTime dt = new DateTime(dateStart.Year, dateStart.Month, 10);
            while (dt <= dateEnd)
            {
                if (dt >= dateStart && dt <= dateEnd)
                    miesiace += 1;
                dt=dt.AddMonths(1);
            }
            try
            {

                cmd.CommandText = "select count(id_wyp) as [l_wyp], sum(koszt) as [Suma] from Wypozyczenia where data_zwrotu is not null and data_wypozyczenia BETWEEN @start AND @end ";
                cmd.Parameters.Add("@start", SqlDbType.Date).Value = startDate.Value.Date;
                cmd.Parameters.Add("@end", SqlDbType.Date).Value = endDate.Value.Date;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    labelUkonczone.Text = reader["l_wyp"].ToString();
                    if (!labelUkonczone.Text.Equals("0"))
                    {
                        Decimal d = Convert.ToDecimal(reader["Suma"]);
                        labelKwota.Text = d.ToString("C2");
                    }
                }
                reader.Close();
                cmd.Parameters.Clear();
                cmd.CommandText = "select count(id_wyp) as [l_wyp] from Wypozyczenia where data_zwrotu is null and data_wypozyczenia BETWEEN @start AND @end";
                cmd.Parameters.Add("@start", SqlDbType.Date).Value = startDate.Value.Date;
                cmd.Parameters.Add("@end", SqlDbType.Date).Value = endDate.Value.Date;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    labelWTrakcie.Text = reader["l_wyp"].ToString();
                }
                else
                {
                    labelWTrakcie.Text = " ";
                }
                reader.Close();
                cmd.Parameters.Clear();
                cmd.CommandText = "select p.marka + ' ' +  p.model as [Samochod],count(p.marka + ' ' + p.model) as [Ilosc] from Wypozyczenia as w join Produkty as p on p.id_produktu=w.id_produktu where data_wypozyczenia BETWEEN @start AND @end  group by marka,model,p.id_produktu order by 2 desc";
                cmd.Parameters.Add("@start", SqlDbType.Date).Value = startDate.Value.Date;
                cmd.Parameters.Add("@end", SqlDbType.Date).Value = endDate.Value.Date;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    labelSamochod.Text = reader["Samochod"].ToString() + " (Ilość wypożyczeń: " + reader["Ilosc"].ToString() + ")";
                }
                else
                {
                    labelSamochod.Text = "Brak wypożyczeń";
                }
                reader.Close();
                cmd.Parameters.Clear();
                cmd.CommandText = "select count(nazwa) as [Ilosc],nazwa from Wypozyczenia as w join Produkty as p on p.id_produktu = w.id_produktu join Kategorie k on k.id_kat = p.rodzaj_poj  where data_wypozyczenia BETWEEN @start AND @end group by nazwa,k.id_kat order by 1 desc";
                cmd.Parameters.Add("@start", SqlDbType.Date).Value = startDate.Value.Date;
                cmd.Parameters.Add("@end", SqlDbType.Date).Value = endDate.Value.Date;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    labelMarka.Text = reader["nazwa"].ToString() + " (Ilość wypożyczeń: " + reader["Ilosc"].ToString() + ")";
                }
                else
                {
                    labelMarka.Text = "Brak wypożyczeń";
                }
                reader.Close();
                cmd.Parameters.Clear();

                cmd.CommandText = "select count(imie + ' ' + nazwisko ) as [Ilosc], imie + ' ' + nazwisko as [Pracownik]  from Wypozyczenia as w join Pracownicy as  p on p.id_pracownika=w.id_pracownika  where data_wypozyczenia BETWEEN @start AND @end group by imie + ' ' + nazwisko,p.id_pracownika order by 1 desc";
                cmd.Parameters.Add("@start", SqlDbType.Date).Value = startDate.Value.Date;
                cmd.Parameters.Add("@end", SqlDbType.Date).Value = endDate.Value.Date;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    labelPracownik.Text = reader["Pracownik"].ToString() + " (Ilość wypożyczeń: " + reader["Ilosc"].ToString() + ")";
                }
                else
                {
                    labelPracownik.Text = "Brak wypożyczeń";
                }
                reader.Close();
                cmd.Parameters.Clear();
                cmd.CommandText = "select isnull(sum(wyplata),0) as Wyplata from pracownicy";
                int pensja = Convert.ToInt32(cmd.ExecuteScalar())*miesiace;
                labelPensje.Text = pensja.ToString() + " zł.";
                cmd.CommandText = "select isnull(sum(koszt),0) as przychod from Wypozyczenia";
                int przychod = Convert.ToInt32(cmd.ExecuteScalar());
                labelDochod.Text = (przychod - pensja).ToString() + " zł.";
                labelKwota.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                tableLayoutPanel1.Visible = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Utracono połączenie z bazą danych. Numer błędu: " + ex.Number);
                Disconnect();
            }
        }



        //formatowanie

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            endDate.MinDate = startDate.Value;
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            startDate.MaxDate = endDate.Value;
        }

        private void Raport_Load(object sender, EventArgs e)
        {

        }
    }
}
