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
        public int smetkaId;
        public double suma;


        public nacinPlakjanje(double iznos, int smetkaId)
        {
            this.suma = iznos;
            this.smetkaId = smetkaId;
            InitializeComponent();
        }

        private void nacinPlakjanje_Load(object sender, EventArgs e)
        {
            this.nacin_NaplataTableAdapter.Fill(this.lastTryDataSet.Nacin_Naplata);
            tbDisplayPrice.ReadOnly = true;
            tbDisplayPrice.Text = Convert.ToInt32(suma).ToString("");
        }

        private void dataGridPlakjanje_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridPlakjanje.Columns["iznos"] != null && e.ColumnIndex == dataGridPlakjanje.Columns["iznos"].Index) {
                presmetajOstatok();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\Stores_db_task\Stores_db_task\lastTry.mdf;Integrated Security=True;Connect Timeout=30";

            bool kesKarticka = false;
            bool faktura = false;
            bool reprezentacija = false;

            double totalPlateno = 0; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridPlakjanje.Rows) {

                    if (!row.IsNewRow && row.Cells["iznos"].Value != null) {

                        if (double.TryParse(row.Cells["iznos"].Value.ToString(), out double iznos) && iznos > 0) {

                            string nacinNaplata = row.Cells["vidnaplataDataGridViewTextBoxColumn"].Value.ToString();

                            
                            string getIdNaplata = "SELECT id_nacin FROM Nacin_Naplata WHERE vid_naplata = @nacinNaplata";
                            SqlCommand getIdNaplataCommand = new SqlCommand(getIdNaplata, connection);
                            getIdNaplataCommand.Parameters.AddWithValue("@nacinNaplata", nacinNaplata);

                            object result = getIdNaplataCommand.ExecuteScalar();

                            if (result == null) {
                                MessageBox.Show("Не постои методот за наплата!");
                                continue;
                            }

                            int nacinNaplataId = Convert.ToInt32(result);

                            if (nacinNaplataId == 0 || nacinNaplataId == 1) {
                                kesKarticka = true;
                            } else if (nacinNaplataId == 2) {
                                faktura = true;
                            } else if (nacinNaplataId == 3) {
                                reprezentacija = true;
                            }
                      
                            totalPlateno += iznos;

                        }
                    }
                }
                double test = suma;
                
                if (totalPlateno > test) {
                    MessageBox.Show("Вкупната наплата не смее да биде поголема од износот на сметката!");
                    tbDisplayPrice.Text = Convert.ToInt32(suma) + "";
                    this.nacin_NaplataTableAdapter.Fill(this.lastTryDataSet.Nacin_Naplata);
                    return;
                }

                
                if ((kesKarticka && faktura && reprezentacija) || (faktura && reprezentacija)) {
                    MessageBox.Show("Не можете да комбинирате кеш/картичка со фактура и репрезентација!");
                    tbDisplayPrice.Text = Convert.ToInt32(suma) + "";
                    this.nacin_NaplataTableAdapter.Fill(this.lastTryDataSet.Nacin_Naplata);
                    return;
                } 

                
                if ((kesKarticka && faktura) || (kesKarticka && reprezentacija) || (faktura && reprezentacija)) {
                    MessageBox.Show("Фактура и репрезентација се наплаќет посебно!");
                    tbDisplayPrice.Text = Convert.ToInt32(suma) + "";
                    this.nacin_NaplataTableAdapter.Fill(this.lastTryDataSet.Nacin_Naplata);
                    return;
                }

                if (suma - totalPlateno > 0) {
                    MessageBox.Show("Платете го вкупниот износ!");
                    tbDisplayPrice.Text = Convert.ToInt32(suma) + "";
                    this.nacin_NaplataTableAdapter.Fill(this.lastTryDataSet.Nacin_Naplata);
                    return;
                }


                foreach (DataGridViewRow row in dataGridPlakjanje.Rows) {
                    if (!row.IsNewRow && row.Cells["iznos"].Value != null) {
                        
                        if (double.TryParse(row.Cells["iznos"].Value.ToString(), out double iznos) && iznos > 0) {

                            string insertPartPayment = "INSERT INTO Part_Payment (id_smetka, nacin_plakjanje_id, iznos) " +
                                                       "VALUES (@smetkaId, @nacinNaplataId, @iznos)";

                            string nacinNaplata = row.Cells["vidnaplataDataGridViewTextBoxColumn"].Value.ToString();
                            string getIdNaplata = "SELECT id_nacin FROM Nacin_Naplata WHERE vid_naplata = @nacinNaplata";

                            SqlCommand getIdNaplataCommand = new SqlCommand(getIdNaplata, connection);

                            getIdNaplataCommand.Parameters.AddWithValue("@nacinNaplata", nacinNaplata);

                            object result = getIdNaplataCommand.ExecuteScalar();

                            int nacinNaplataId = Convert.ToInt32(result);

                            SqlCommand insertPartPaymentCommand = new SqlCommand(insertPartPayment, connection);

                            insertPartPaymentCommand.Parameters.AddWithValue("@smetkaId", smetkaId);
                            insertPartPaymentCommand.Parameters.AddWithValue("@nacinNaplataId", nacinNaplataId);
                            insertPartPaymentCommand.Parameters.AddWithValue("@iznos", iznos);

                            insertPartPaymentCommand.ExecuteNonQuery();
                        }
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void presmetajOstatok()
        {
            double ostatok = suma;

            foreach (DataGridViewRow row in dataGridPlakjanje.Rows) {

                if (!row.IsNewRow && row.Cells["iznos"].Value != null) {

                    if (double.TryParse(row.Cells["iznos"].Value.ToString(), out double platenIznos)) {

                        ostatok -= platenIznos;
                    }   
                }
            }

            tbDisplayPrice.Text = Convert.ToInt32(ostatok).ToString("");
        }
    }
}


