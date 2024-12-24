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
        public int shifra;

        public selectArtikl(int marketId)
        {
            this.market = marketId;
            InitializeComponent();
        }

        public selectArtikl(int marketId, int shifraId)
        {
            this.market = marketId;
            this.shifra = shifraId;
            InitializeComponent();
        }

        private void selectArtikl_Load(object sender, EventArgs e)
        {
            LoadArtikli();
            
        }
        private void LoadArtikli()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";

            string loadEnterQuery = "SELECT a.shifra, a.ime_artikl " +
                            "FROM Produkti_vo_Market pm " +
                            "JOIN Artikl a ON pm.artikl = a.id_artikl " +
                            "JOIN Prodavnica p ON pm.prodavnica = p.id_prodavnica " +
                            "WHERE @market = p.id_prodavnica ";
                                //        +
                            //"AND a.shifra LIKE @shifra ";


                           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand(loadEnterQuery, connection);

                command.Parameters.AddWithValue("@market", market);
                command.Parameters.AddWithValue("@shifra", "%" + shifra + "%");

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()){
                    lbArtikli.Items.Add(reader.GetInt32(0) + " | " + reader.GetString(1));
                }
                
               
            }
        }

        private void lbArtikli_DoubleClick(object sender, EventArgs e)
        {
            if(lbArtikli.SelectedItem != null){
                string sentence = lbArtikli.SelectedItem.ToString();
                char[] charsToTrim = { '|'};
                string[] words = sentence.Split();
                foreach (string word in words){
                    word.TrimEnd(charsToTrim);
                }
                this.shifra = Convert.ToInt32(words[0].TrimEnd(charsToTrim));
             }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbArtikli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13 && lbArtikli.SelectedItem != null){
                string sentence = lbArtikli.SelectedItem.ToString();
                char[] charsToTrim = { '|' };
                string[] words = sentence.Split();

                foreach (string word in words){
                    word.TrimEnd(charsToTrim);
                }
                this.shifra = Convert.ToInt32(words[0].TrimEnd(charsToTrim));
            } else if (Convert.ToInt32(e.KeyChar) == 27){
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbArtikli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}


