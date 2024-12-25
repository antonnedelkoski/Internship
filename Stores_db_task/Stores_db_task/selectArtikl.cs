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
    public partial class selectArtikl : Form
    {
        public int market;
        public string shifra; 

        public selectArtikl(int marketId)
        {
            this.market = marketId;
            this.shifra = ""; 
            InitializeComponent();
        }

        public selectArtikl(int marketId, int shifraId)
        {
            this.market = marketId;
            this.shifra = shifraId > 0 ? shifraId.ToString() : ""; 
            InitializeComponent();
        }

        private void selectArtikl_Load(object sender, EventArgs e)
        {
            LoadArtikli(shifra);
        }

        private void LoadArtikli(string shifra)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";

            string findMatchingArtikli = "SELECT a.shifra, a.ime_artikl " +
                            "FROM Artikl a " +
                            "JOIN Produkti_vo_Market pm ON a.id_artikl = pm.artikl " +
                            "JOIN Prodavnica p ON pm.prodavnica = p.id_prodavnica " +
                            "WHERE p.id_prodavnica = @market ";

            if (!string.IsNullOrEmpty(shifra)){

                findMatchingArtikli += "AND a.shifra LIKE @shifra";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(findMatchingArtikli, connection);
                command.Parameters.AddWithValue("@market", market);

                if (!string.IsNullOrEmpty(shifra)) {
                    command.Parameters.AddWithValue("@shifra", "%" + shifra + "%");
                }

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    lbArtikli.Items.Add(reader.GetInt32(0) + " | " + reader.GetString(1));
                }
            }
        }

        private void lbArtikli_DoubleClick(object sender, EventArgs e)
        {
            if (lbArtikli.SelectedItem != null) {
                string sentence = lbArtikli.SelectedItem.ToString();
                string[] words = sentence.Split('|');
                this.shifra = words[0].Trim();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbArtikli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13 && lbArtikli.SelectedItem != null) {
                string sentence = lbArtikli.SelectedItem.ToString();
                string[] words = sentence.Split('|');
                this.shifra = words[0].Trim();
            }
            else if (Convert.ToInt32(e.KeyChar) == 27) {
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
