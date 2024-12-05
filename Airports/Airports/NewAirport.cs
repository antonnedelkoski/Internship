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

namespace Airports
{
    public partial class NewAirport : Form
    {
        public Airport airport { set; get; }
        public NewAirport()
        {
            InitializeComponent();
        }

        private void btnSaveAirport_Click(object sender, EventArgs e)
        {
            
            this.airport = new Airport(tbShort.Text, tbAirportName.Text, tbCityName.Text);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Anton\Documents\test_v1.mdf; Integrated Security = True; Connect Timeout = 30";

            string query = "INSERT INTO Airports (Code, AirportName, City) VALUES (@Code, @AirportName, @City)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                   
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AirportName", airport.Code);
                    cmd.Parameters.AddWithValue("@Code", airport.airpoprtName);
                    cmd.Parameters.AddWithValue("@City", airport.City);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Airport added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void tbCityName_Validating(object sender, CancelEventArgs e)
        {
            if (tbCityName.Text == ""){
                errorProvider1.SetError(tbCityName, "It's empty");
            }
            else
                errorProvider1.SetError(tbCityName, null);
        }

        private void tbAirportName_Validating(object sender, CancelEventArgs e)
        {
            if (tbAirportName.Text == ""){
                errorProvider1.SetError(tbAirportName, "It's empty");
            }
            else
                errorProvider1.SetError(tbAirportName, null);
        }

        private void tbShort_Validating(object sender, CancelEventArgs e)
        {

            if(tbShort.Text.Length == 3)
            {
                foreach(char c in tbShort.Text){

                    if(char.IsLower(c) || !char.IsLetter(c)){
                        errorProvider1.SetError(tbShort, "Invalid usage of letters and numbers ");
                        break;
                    }
                    else {
                        errorProvider1.SetError(tbShort, null);      
                    }
                }
            }
            else{
                errorProvider1.SetError(tbShort, "It's not the correct format");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void NewAirport_Load(object sender, EventArgs e)
        {

        }
    }
}
