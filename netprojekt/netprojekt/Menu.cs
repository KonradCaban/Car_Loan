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
    public partial class Menu : Form
    {
        readonly string connectionString = null;
        public SqlConnection cnn;
        public Menu(SqlConnection _cnn)
        {
            InitializeComponent();
            cnn = _cnn;
        }

        public Menu()
        {
            InitializeComponent();
            connectionString = @"Data Source=KOMPUTER;Initial Catalog=netprojekt;User ID=sa;Password=praktyka";
            cnn = new SqlConnection(connectionString);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        public void buttonstatus(bool tmp)
        {
            buttonCars.Enabled = tmp;
            buttonWorkers.Enabled = tmp;
            buttonTypes.Enabled = tmp;
            buttonTransaction.Enabled = tmp;
            buttonBaza.Enabled = !tmp;
            buttonDisconnect.Enabled = tmp;
            buttonWorkersStats.Enabled = tmp;
            buttonRaporty.Enabled = tmp;
        }

        public void ConnectToBase()
        {
            try
            {
                cnn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nie można się połączyć z bazą danych. Numer błędu: " + ex.Number);
            }
        }

            private void buttonBaza_Click(object sender, EventArgs e)
        {

            try
            {
                cnn.Open();
                labelBaza.Text = "Połączono z bazą "+ cnn.Database;
                buttonstatus(true);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nie można się połączyć z bazą danych. Numer błędu: " + ex.Number);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            cnn.Close();
            MessageBox.Show("Rozłączono z bazą danych!");
            buttonstatus(false);
            
            labelBaza.Text = "Brak połączenia z bazą!";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Close();
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            WorkerMenu w1 = new WorkerMenu(this);
            w1.Show();
            this.Hide();
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            CarsMenu c1 = new CarsMenu(this);
            c1.Show();
            this.Hide();
        }

        private void buttonTypes_Click(object sender, EventArgs e)
        {
            TypesMenu tm1 = new TypesMenu(this);
            tm1.Show();
            this.Hide();
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            TransactionMenu tr1 = new TransactionMenu(this);
            tr1.Show();
            this.Hide();
        }

        private void buttonWorkersStats_Click(object sender, EventArgs e)
        {
            WorkersStats ws1 = new WorkersStats(this);
            ws1.Show();
            this.Hide();
        }

        private void buttonRaporty_Click(object sender, EventArgs e)
        {
            Raport r1 = new Raport(this);
            r1.Show();
            this.Hide();
        }
    }
    
}
