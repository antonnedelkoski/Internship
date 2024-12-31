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

namespace Stores_db_task
{
    public partial class Izvestaj : Form
    {
      


        public Izvestaj()
        {
            InitializeComponent();
        }

        private void Izvestaj_Load(object sender, EventArgs e)
        {
            tbPrice.ReadOnly = true;
            dataGridIzvestaj.ReadOnly = true;
            LoadIzvestaj();
        }

        private void tbMarket_Validating(object sender, CancelEventArgs e)
        {
            if (tbMarket.Text == "") {
                MessageBox.Show("Внеси маркет");
                tbMarket.Enabled = true;
                tbMarket.Focus();
            } else {
                    int marketId = Convert.ToInt32(tbMarket.Text);

                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";

                    string findMarketQuery = "SELECT raboti_na_kasa FROM Rabotnik " +
                                        "JOIN Kasa ON Rabotnik.raboti_na_kasa = Kasa.id_kasa " +
                                        "JOIN Prodavnica ON Kasa.prodavnica_id = Prodavnica.id_prodavnica " +
                                        "WHERE @marketId = Prodavnica.id_prodavnica";

                    string getImeProdavnicaKveri = "SELECT Prodavnica.ime_prodavnica FROM Prodavnica " +
                                        "WHERE @marketId = Prodavnica.id_prodavnica";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand marketCmd = new SqlCommand(findMarketQuery, connection);
                        marketCmd.Parameters.AddWithValue("@marketId", marketId);

                        SqlCommand vcitajMarket = new SqlCommand(getImeProdavnicaKveri, connection);
                        vcitajMarket.Parameters.AddWithValue("@marketId", marketId);

                        connection.Open();
                        object postoiMarket = marketCmd.ExecuteScalar();

                        if (postoiMarket == null) {
                            tbMarket.Enabled = true;
                            MessageBox.Show("Mapкетот не постои");
                            tbMarket.Text = string.Empty;
                            tbMarket.Focus();
                        } else {
                            SqlDataReader pronajdiIme = vcitajMarket.ExecuteReader();
                            while (pronajdiIme.Read()) {
                                labelMarketName.Text = pronajdiIme.GetValue(0).ToString().ToUpper();

                            }
                        }
                    }
            }
        }

        private void kasierTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (kasierTextBox.Text == "" && tbMarket.Text != "") {
                MessageBox.Show("Внеси касиер");
                kasierTextBox.Enabled = true;
                kasierTextBox.Focus();
            } else if (kasierTextBox.Text == "" && tbMarket.Text == "") {
                MessageBox.Show("Внеси прво маркет");
                kasierTextBox.Enabled = true;
                tbMarket.Focus();
            } else {
                int kasierId = Convert.ToInt32(kasierTextBox.Text);
                int marketId = Convert.ToInt32(tbMarket.Text);

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";


                string checkKasierQuery = "SELECT rabotnik_id FROM Rabotnik " +
                                    "JOIN Kasa ON Rabotnik.raboti_na_kasa = Kasa.id_kasa " +
                                    "JOIN Prodavnica ON Kasa.prodavnica_id = Prodavnica.id_prodavnica " +
                                    "WHERE @marketId = Prodavnica.id_prodavnica " +
                                    "AND @kasierId = Rabotnik.raboti_na_kasa";

                string imePrezimeKasier = "SELECT rabotnik.ime_rabotnik, rabotnik.prezime_rabotnik FROM Rabotnik " +
                                          "JOIN Kasa ON Rabotnik.raboti_na_kasa = Kasa.id_kasa " +
                                          "JOIN Prodavnica ON Kasa.prodavnica_id = Prodavnica.id_prodavnica " +
                                          "WHERE @kasierId = Rabotnik.rabotnik_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand kasierCmd = new SqlCommand(checkKasierQuery, connection);

                    kasierCmd.Parameters.AddWithValue("@kasierId", kasierId);
                    kasierCmd.Parameters.AddWithValue("@marketId", marketId);

                    SqlCommand vcitajKasier = new SqlCommand(imePrezimeKasier, connection);
                    vcitajKasier.Parameters.AddWithValue("@kasierId", kasierId);

                    connection.Open();

                    object postoiKasier = kasierCmd.ExecuteScalar();

                    if (postoiKasier == null) {
                        kasierTextBox.Enabled = true;
                        MessageBox.Show("Касиерот не постои / Касиерот не работи во тој маркет");
                        kasierTextBox.Text = string.Empty;
                        kasierTextBox.Focus();
                    } else {

                        SqlDataReader pronajdiImePrezime = vcitajKasier.ExecuteReader();

                        while (pronajdiImePrezime.Read()) {
                            labelKasier.Text = pronajdiImePrezime.GetValue(0).ToString().ToUpper() + " " + pronajdiImePrezime.GetValue(1).ToString().ToUpper();
                            LoadIzvestaj();
                            calculatePrice();
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbDatumDo.Text = string.Empty;
            tbDatumDo.Enabled = true;

            tbDatumOd.Text = string.Empty;
            tbDatumOd.Enabled = true;

            tbMarket.Text = string.Empty;
            tbMarket.Enabled = true;

            kasierTextBox.Text = string.Empty;
            kasierTextBox.Enabled = true;

            tbDatumOd.Focus();
            tbPrice.Text = string.Empty;

            labelKasier.Text= string.Empty;
            labelMarketName.Text= string.Empty;

            dataGridIzvestaj.Rows.Clear();
        }

        private void LoadIzvestaj()
        {

            if (string.IsNullOrWhiteSpace(tbMarket.Text) || !int.TryParse(tbMarket.Text, out int marketId)) {
                return;
            }


            if (string.IsNullOrWhiteSpace(kasierTextBox.Text) || !int.TryParse(kasierTextBox.Text, out int kasierId)) {
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30"; ;

            
            string query = @"SELECT p.id_smetka,a.shifra, a.ime_artikl, p.datum_prodazba, pa.kolicina, pa.cena_po_ed, pa.procent_popust 
                            FROM Prodazba_Artikli pa
                            JOIN Artikl a ON pa.id_artikl = a.id_artikl
                            JOIN Prodazba p ON pa.id_smetka = p.id_smetka
                            JOIN Prodavnica pr on p.market_id = pr.id_prodavnica
                            WHERE p.datum_prodazba BETWEEN @DatumOd AND DATEADD(DAY, 1, @DatumDo) 
                            AND p.market_id = @marketId 
                            AND p.kasier_id = @KasierId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                

                    cmd.Parameters.AddWithValue("@DatumOd", DateTime.Parse(tbDatumOd.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@DatumDo", DateTime.Parse(tbDatumDo.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@marketId", marketId);  
                    cmd.Parameters.AddWithValue("@kasierId", kasierId);


                    try {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dataGridIzvestaj.Rows.Clear();

                            while (reader.Read()) {
                            dataGridIzvestaj.Rows.Add(
                                    reader["id_smetka"],
                                    reader["shifra"],
                                    reader["ime_artikl"],
                                    reader["datum_prodazba"],
                                    reader["kolicina"],
                                    reader["cena_po_ed"],
                                    reader["procent_popust"]
                                    
                                );
                            }
                        
                            //20,28,03.02//
                        reader.Close();
                    } catch (Exception ex) {
                        MessageBox.Show("Грешка: " + ex.Message);
                    }
                
            }
        }

        private void tbDatumOd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab) {
                tbDatumOd.Enabled = false;
                tbDatumDo.Focus();

            }
        }

        private void kasierTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab) {
                kasierTextBox.Enabled = false;
            }
        }

        private void tbMarket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab) {
                tbMarket.Enabled = false;
            }
        }

        private void tbDatumDo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab) {
                tbDatumDo.Enabled = false;
                tbMarket.Focus();
            }
        }

        private void calculatePrice()
        {
            try {
                double suma = 0;

                foreach (DataGridViewRow row in dataGridIzvestaj.Rows) {

                    if (!row.IsNewRow && row.Cells["price"].Value != null && row.Cells["kolicina"].Value != null) { 
                        decimal cena = Convert.ToDecimal(row.Cells["price"].Value);
                        int kolicina = Convert.ToInt32(row.Cells["kolicina"].Value);
                        double kolCena = (double)(kolicina * cena);
                        
                        decimal popust = Convert.ToDecimal(row.Cells["procent"].Value);

                        if (popust > 0) {
                            popust = popust / 100;
                            row.Cells["vkupnoCena"].Value = (int)(kolicina * cena) - (int)(kolicina * cena * popust);
                        } else {
                            row.Cells["vkupnoCena"].Value = (int)(kolicina * cena);
                        }
                        suma += kolCena;
                    }
                }

                tbPrice.Text = Convert.ToInt32(suma).ToString(".00 ден");

            } catch (Exception ex) {
                MessageBox.Show($"Грешка: {ex.Message}");
            }
        }

        private void dataGridIzvestaj_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calculatePrice();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("УСПЕШНО ПЕЧАТЕЊЕ!");
            this.Close();
        }
    }
}

