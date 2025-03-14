﻿using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stores_db_task
{
    public partial class Form1 : Form
    {
        
        double discount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            datumTextBox.Text = currentDate.ToString("dd-MM-yyyy");
            datumTextBox.ReadOnly = true;
            tbPrice.ReadOnly = true;
            dataGridTest.Enabled = false;
            dataGridTest.Columns["price"].ReadOnly = true;
            tbPopust.Text = "0";
        }

        private void dataGridTest_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {    //PREBARUVANJA I ZEMANJA NA SHIFRI
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) {
                int rowIndex = e.RowIndex;
                string shifra = dataGridTest.Rows[rowIndex].Cells["Shifra"].Value?.ToString();
                int prodavnica = Convert.ToInt32(tbMarket.Text);
                string artikl = dataGridTest.Rows[rowIndex].Cells["articleName"].Value?.ToString();
                

                if (!string.IsNullOrEmpty(shifra) && string.IsNullOrEmpty(artikl)) {

                    if (shifra.Length < 4) {

                        selectArtikl searchForm = new selectArtikl(prodavnica, Convert.ToInt32(shifra));
                        if (searchForm.ShowDialog() == DialogResult.OK) {

                            string selectedShifra = Convert.ToString(searchForm.shifra);
                            bool shifraExists = false;

                            foreach (DataGridViewRow row in dataGridTest.Rows) {

                                if (row.Cells["Shifra"].Value != null && row.Cells["Shifra"].Value.ToString() == selectedShifra && row.Index != rowIndex) {

                                    int currentQuantity = Convert.ToInt32(row.Cells["kolicina"].Value);
                                    row.Cells["kolicina"].Value = currentQuantity + 1;
                                    dataGridTest.Rows[rowIndex].Cells["Shifra"].Value = "";
                                    calculatePrice();
                                    shifraExists = true;
                                    break;
                                }
                            }

                            if (!shifraExists) {
                                dataGridTest.Rows[rowIndex].Cells["Shifra"].Value = selectedShifra;
                                calculatePrice();
                            }

                        }
                    } else {
                            foreach (DataGridViewRow row in dataGridTest.Rows){

                                if (row.Cells["Shifra"].Value != null && row.Cells["Shifra"].Value.ToString() == shifra && row.Index != rowIndex) { 
                                
                                    int currentQuantity = Convert.ToInt32(row.Cells["kolicina"].Value);
                                    row.Cells["kolicina"].Value = currentQuantity + 1;
                                    dataGridTest.Rows[rowIndex].Cells["Shifra"].Value = "";
                                    calculatePrice();
                                    return;
                                }
                            }


                        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";

                        string query = "SELECT ime_artikl FROM Artikl " +
                                       "JOIN Produkti_vo_Market ON Artikl.id_artikl = Produkti_vo_Market.artikl " +
                                       "WHERE shifra = @shifra ";

                        string queryPrice = "SELECT cena_vo_market FROM Produkti_vo_Market " +
                                            "JOIN Prodavnica ON Produkti_vo_Market.prodavnica = Prodavnica.id_prodavnica " +
                                            "JOIN Artikl ON Produkti_vo_Market.artikl = Artikl.id_artikl " +
                                            "WHERE id_prodavnica = @prodavnica AND Artikl.shifra = @shifra";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand priceCommand = new SqlCommand(queryPrice, connection);
                            priceCommand.Parameters.AddWithValue("@prodavnica", prodavnica);
                            priceCommand.Parameters.AddWithValue("@shifra", shifra);

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@shifra", shifra);

                            connection.Open();

                            object result = command.ExecuteScalar();
                            object result1 = priceCommand.ExecuteScalar();

                            if (result != null && result1 != null) {
                                dataGridTest.Rows[rowIndex].Cells["articleName"].Value = result.ToString();
                                dataGridTest.Rows[rowIndex].Cells["price"].Value = result1.ToString();
                            } else {
                                MessageBox.Show("Не постои артиклот");
                                dataGridTest.Rows[rowIndex].Cells["Shifra"].Value = "";
                            }
                        }
                    }
                }
            } //PREBARUVANJA I ZEMANJA NA ARTIKLI
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0) {

                int rowIndex = e.RowIndex;
                string artikl = dataGridTest.Rows[rowIndex].Cells["articleName"].Value?.ToString();
                string shifra = dataGridTest.Rows[rowIndex].Cells["Shifra"].Value?.ToString();
                int prodavnica = Convert.ToInt32(tbMarket.Text);
                
                
                if (!string.IsNullOrEmpty(artikl) && string.IsNullOrEmpty(shifra)) {

                    if (artikl.Length <= 7) {

                        selectArtikl searchForm = new selectArtikl(prodavnica, artikl);

                        if (searchForm.ShowDialog() == DialogResult.OK) {

                            string selectedArtikl = Convert.ToString(searchForm.artikl);
                            bool artiklExists = false;

                            foreach (DataGridViewRow row in dataGridTest.Rows) {

                                if (row.Cells["articleName"].Value != null && row.Cells["articleName"].Value.ToString() == selectedArtikl && row.Index != rowIndex) {

                                    int currentQuantity = Convert.ToInt32(row.Cells["kolicina"].Value);
                                    row.Cells["kolicina"].Value = currentQuantity + 1;
                                    dataGridTest.Rows[rowIndex].Cells["articleName"].Value = "";
                                    calculatePrice();
                                    artiklExists = true;
                                    break;
                                }
                            }

                            if (!artiklExists) {
                                dataGridTest.Rows[rowIndex].Cells["articleName"].Value = selectedArtikl;
                                calculatePrice();
                            }

                        }
                    } else {
                        foreach (DataGridViewRow row in dataGridTest.Rows) {

                            if (row.Cells["articleName"].Value != null && row.Cells["articleName"].Value.ToString() == artikl && row.Index != rowIndex) {

                                int currentQuantity = Convert.ToInt32(row.Cells["kolicina"].Value);
                                row.Cells["kolicina"].Value = currentQuantity + 1;
                                dataGridTest.Rows[rowIndex].Cells["articleName"].Value = "";
                                calculatePrice();
                                return;

                            }
                        }
                        //priprema izvestaj so period od do i totalen promet po artikli za kasier i market koj prodal i sho prodal od do!!!!!!!

                        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";

                        string query = "SELECT shifra FROM Artikl " +
                                       "JOIN Produkti_vo_Market ON Artikl.id_artikl = Produkti_vo_Market.artikl " +
                                       "WHERE ime_artikl = @artikl ";

                        string queryPrice = "SELECT cena_vo_market FROM Produkti_vo_Market " +
                                            "JOIN Prodavnica ON Produkti_vo_Market.prodavnica = Prodavnica.id_prodavnica " +
                                            "JOIN Artikl ON Produkti_vo_Market.artikl = Artikl.id_artikl " +
                                            "WHERE id_prodavnica = @prodavnica AND Artikl.ime_artikl = @artikl";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand priceCommand = new SqlCommand(queryPrice, connection);
                            priceCommand.Parameters.AddWithValue("@prodavnica", prodavnica);
                            priceCommand.Parameters.AddWithValue("@artikl", artikl);

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@artikl", artikl);

                            connection.Open();

                            object result = command.ExecuteScalar();
                            object result1 = priceCommand.ExecuteScalar();

                            if (result != null && result1 != null) {
                                dataGridTest.Rows[rowIndex].Cells["shifra"].Value = result.ToString();
                                dataGridTest.Rows[rowIndex].Cells["price"].Value = result1.ToString();
                            } else {
                                MessageBox.Show("Не постои артиклот");
                                dataGridTest.Rows[rowIndex].Cells["articleName"].Value = "";
                            }
                        }
                    }
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool imaArtikli = false;

            foreach (DataGridViewRow row in dataGridTest.Rows) {
                if (!row.IsNewRow && row.Cells["Shifra"].Value != null && row.Cells["kolicina"].Value != null && row.Cells["price"].Value != null) {
                    imaArtikli = true;
                    break;
                }
            }

            if (!imaArtikli) {
                MessageBox.Show("Внеси артикли и сите полиња за нив!");
                return;
            }


            try {
                int id_naplata = 0;
                int kasierId = Convert.ToInt32(kasierTextBox.Text);
                int marketId = Convert.ToInt32(tbMarket.Text);
                int kasaId;
                int smetkaPA;
                int smetkaPP;


                DateTime currentDate = DateTime.Now;
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";


                string kasaQuery = "SELECT raboti_na_kasa FROM Rabotnik " +
                                    "JOIN Kasa ON Rabotnik.raboti_na_kasa = Kasa.id_kasa " +
                                    "JOIN Prodavnica ON Kasa.prodavnica_id = Prodavnica.id_prodavnica " +
                                    "WHERE @kasierId = rabotnik_id " +
                                    "AND @marketId = Prodavnica.id_prodavnica";

                string insertProdazbaQuery = "INSERT INTO Prodazba (kasier_id, kasa_id, datum_prodazba, market_id,iznos) " +
                                             "VALUES (@kasierId, @kasaId, @datum, @marketId, @iznos);SELECT SCOPE_IDENTITY();";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    double iznos = 0;
                    SqlCommand kasaKveri = new SqlCommand(kasaQuery, connection);

                    kasaKveri.Parameters.AddWithValue("@kasierId", kasierId);
                    kasaKveri.Parameters.AddWithValue("@marketId", marketId);

                    SqlCommand command = new SqlCommand(insertProdazbaQuery, connection);

                    connection.Open();

                    object kasaNaogjanje = kasaKveri.ExecuteScalar();

                    if (kasaNaogjanje != null) {
                        kasaId = Convert.ToInt32(kasaNaogjanje);
                        command.Parameters.AddWithValue("@kasaId", kasaId);
                    }

                    command.Parameters.AddWithValue("@marketId", marketId);
                    command.Parameters.AddWithValue("@kasierId", kasierId);
                    command.Parameters.AddWithValue("@datum", currentDate);
                    command.Parameters.AddWithValue("@id_naplata", id_naplata);
                    

                    foreach (DataGridViewRow row in dataGridTest.Rows) {

                        if (row.IsNewRow) continue;

                        string shifra = row.Cells["Shifra"].Value.ToString();
                        int kolicina = Convert.ToInt32(row.Cells["kolicina"].Value);
                        decimal cena = Convert.ToDecimal(row.Cells["price"].Value);

                        double popustStavka = Convert.ToDouble(row.Cells["popust"].Value);
                        popustStavka /= 100;

                        iznos += (kolicina * (int)cena) - ((kolicina * (int)cena) * popustStavka);
                    }

                    command.Parameters.AddWithValue("@iznos", iznos);

                    object result = command.ExecuteScalar();

                    if (result != null) {
                        int smetkaId = Convert.ToInt32(result);
                        smetkaPA = smetkaId;
                        smetkaPP = smetkaId;

                        foreach (DataGridViewRow row in dataGridTest.Rows) {
                            if (row.IsNewRow) continue;

                            int popustStavka = row.Cells["popust"].Value != null ? Convert.ToInt32(row.Cells["popust"].Value) : 0;
                            string shifra = row.Cells["Shifra"].Value.ToString();
                            int kolicina = Convert.ToInt32(row.Cells["kolicina"].Value);
                            decimal cena = Convert.ToDecimal(row.Cells["price"].Value);

                            string artiklQuery = "SELECT id_artikl FROM Artikl WHERE shifra = @shifra";
                            SqlCommand artiklCommand = new SqlCommand(artiklQuery, connection);
                            artiklCommand.Parameters.AddWithValue("@shifra", shifra);

                            object artiklResult = artiklCommand.ExecuteScalar();

                            if (artiklResult != null) {
                                int artiklId = Convert.ToInt32(artiklResult);

                                string insertProdazbaArtikliQuery = "INSERT INTO Prodazba_Artikli (id_smetka, id_artikl, kolicina, cena_po_ed, procent_popust) " +
                                                                    "VALUES (@smetkaId, @artiklId, @kolicina, @cena, @popustStavka)";

                                SqlCommand insertArtikliCommand = new SqlCommand(insertProdazbaArtikliQuery, connection);

                                insertArtikliCommand.Parameters.AddWithValue("@smetkaId", smetkaPA);
                                insertArtikliCommand.Parameters.AddWithValue("@artiklId", artiklId);
                                insertArtikliCommand.Parameters.AddWithValue("@kolicina", kolicina);
                                insertArtikliCommand.Parameters.AddWithValue("@cena", cena);
                                insertArtikliCommand.Parameters.AddWithValue("@popustStavka", popustStavka);

                                if (tbPopust.Text != null) {
                                    int popust = Convert.ToInt32(tbPopust.Text);
                                    insertArtikliCommand.Parameters.AddWithValue("@popust", popust);
                                }

                                insertArtikliCommand.ExecuteNonQuery();

                            } else {
                                MessageBox.Show($"Артикл со шифра {shifra} не постои.");
                            }
                        }
                        //////////////////////////////PART PRICE
                        double iznosPrikaz = 0;

                        foreach (DataGridViewRow row in dataGridTest.Rows){

                            if (row.IsNewRow) continue;

                            string shifra = row.Cells["Shifra"].Value.ToString();
                            int kolicina = Convert.ToInt32(row.Cells["kolicina"].Value);
                            decimal cena = Convert.ToDecimal(row.Cells["price"].Value);

                            double popustStavka = Convert.ToDouble(row.Cells["popust"].Value);
                            popustStavka /= 100;

                            iznosPrikaz += (kolicina * (int)cena) - ((kolicina * (int)cena) * popustStavka);
                        }

                        nacinPlakjanje test = new nacinPlakjanje(iznosPrikaz,smetkaPP);

                        if (test.ShowDialog() != DialogResult.OK) {
                            MessageBox.Show("Не е избран метод на наплта!");
                            return;
                        }
                        

                            ///////////////////////////////////////////////////////////////////OVA MI E ZA PART SALE

                            MessageBox.Show($"Сметката е внесена успешно!");
                        afterInsertion();

                    } else {
                        MessageBox.Show("Неуспешно внесување");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"Грешка: {ex.Message}");
            }
        }

        private void dataGridTest_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            calculatePrice();
        }

        private void tbMarket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab) {
                tbMarket.Enabled = false;
            }
        }

        private void kasierTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab) {
                kasierTextBox.Enabled = false;
            }
        }


        private void tbPopust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab) {
                tbPopust.Enabled = false;
            }
        }

        private void tbMarket_Validating(object sender, CancelEventArgs e)
        {
            if (tbMarket.Text == "") {
               // MessageBox.Show("Внеси маркет");
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
                            dataGridTest.Enabled = true;
                            dataGridTest.Focus();
                        }
                    }
                }
            }
        }


        private void dataGridTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) {

                try {
                    int rowIndex = e.RowIndex;
                    int marketId = Convert.ToInt32(tbMarket.Text);

                    selectArtikl lbShifri = new selectArtikl(marketId);
                    if (lbShifri.ShowDialog() == DialogResult.OK){

                        string selectedShifra = Convert.ToString(lbShifri.shifra);
                        dataGridTest.Rows[rowIndex].Cells["Shifra"].Value = selectedShifra;
                    }
                } catch (Exception ex){
                    MessageBox.Show($"Грешка: {ex.Message}");
                }
            }
            
            if (e.ColumnIndex == 1 && e.RowIndex >= 0){
               
                try {
                    int rowIndex = e.RowIndex;
                    int marketId = Convert.ToInt32(tbMarket.Text);

                    selectArtikl lbArtikli = new selectArtikl(marketId);
                    if (lbArtikli.ShowDialog() == DialogResult.OK) {

                        string selectedArtikl = Convert.ToString(lbArtikli.artikl);
                        dataGridTest.Rows[rowIndex].Cells["articleName"].Value = selectedArtikl;
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Грешка: {ex.Message}");
                }
            }
        }

        private void dataGridTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13 || Convert.ToInt32(e.KeyChar) == 10){
                try {
                    int marketId = Convert.ToInt32(tbMarket.Text);
                    selectArtikl lbShifri = new selectArtikl(marketId);

                   if (lbShifri.ShowDialog() == DialogResult.OK) {

                        int rowIndex = dataGridTest.CurrentCell.RowIndex;
                        string selectedShifra = Convert.ToString(lbShifri.shifra);

                        dataGridTest.Rows[rowIndex].Cells["Shifra"].Value = selectedShifra;
                        calculatePrice();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Грешка: {ex.Message}");
                }
            }
        }

        private void calculatePrice()
        {
            try {
                double suma = 0;

                foreach (DataGridViewRow row in dataGridTest.Rows) {

                    if (!row.IsNewRow && row.Cells["price"].Value != null && row.Cells["kolicina"].Value != null) {

                        if (Convert.ToInt32(tbPopust.Text) > 0) {

                            decimal cena = Convert.ToDecimal(row.Cells["price"].Value);
                            int kolicina = Convert.ToInt32(row.Cells["kolicina"].Value);
                            double kolCena = (double)(kolicina * cena);

                            double iznosPopust = kolCena * discount;
                            kolCena -= iznosPopust;
                            suma += kolCena;

                            row.Cells["popust"].Value = tbPopust.Text;

                        } else {

                                tbPopust.Enabled = false;
                                decimal cena = Convert.ToDecimal(row.Cells["price"].Value);
                                int kolicina = Convert.ToInt32(row.Cells["kolicina"].Value);


                                double popust = 0;
                                if (row.Cells["popust"].Value != null && !string.IsNullOrEmpty(row.Cells["popust"].Value.ToString())) {

                                    popust = Convert.ToDouble(row.Cells["popust"].Value);
                                    popust /= 100;
                                } else {

                                tbPopust.Enabled = true;

                                }

                                double kolCena = (double)(kolicina * cena);
                                double iznosPopust = kolCena * popust;
                                kolCena -= iznosPopust;
                            
                                suma += kolCena;
                        }
                    }
                }

                tbPrice.Text = Convert.ToInt32(suma).ToString(".00 ден");

            } catch (Exception ex) {
                MessageBox.Show($"Грешка: {ex.Message}");
            }
        }


        private void tbPopust_Validating(object sender, CancelEventArgs e)
        {
            if (tbPopust.Text == " ") {
                tbPopust.Enabled = true;
            } else {
                discount = Convert.ToInt32((string)tbPopust.Text);
                discount = discount / 100;
            }
        }

        private void afterInsertion(){

            dataGridTest.Rows.Clear();
            kasierTextBox.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbMarket.Text = string.Empty;
            kasierTextBox.Enabled = true;
            tbMarket.Enabled = true;
            labelKasier.Text = string.Empty;
            labelMarketName.Text = string.Empty;
            tbPopust.Enabled = true;
            tbPopust.Text = "0";
            discount = 0;
            
        }


        private void izvestajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaj izvestajForm = new Izvestaj();
            izvestajForm.Show();
        }
    }
}

