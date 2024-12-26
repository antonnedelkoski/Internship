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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Stores_db_task
{
    public partial class nacinPlakjanje : Form
    {
        public int vid_naplata;
        public nacinPlakjanje(int id_naplata)
        {
            this.vid_naplata = id_naplata;
            InitializeComponent();
        }

        private void nacinPlakjanje_Load(object sender, EventArgs e)
        {
            loadNaplati();
        }

        private void loadNaplati()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";

            string vidNaplataQuery = "SELECT vid_naplata FROM Nacin_Naplata";
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(vidNaplataQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    lbNaplata.Items.Add(reader.GetString(0).ToUpper());
                }
            }
        }

        private void lbNaplata_DoubleClick(object sender, EventArgs e)
        {
            if (lbNaplata.SelectedItem != null) {
                
                this.vid_naplata = lbNaplata.SelectedIndex; 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void lbNaplata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13 && lbNaplata.SelectedItem != null) {
                
                this.vid_naplata = lbNaplata.SelectedIndex;

            }
            else if (Convert.ToInt32(e.KeyChar) == 27) {
                
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbNaplata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
