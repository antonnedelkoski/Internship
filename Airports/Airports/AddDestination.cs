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

    public partial class AddDestination : Form
    {
        public int AirportId { get; set; }
        public Destination CreatedDestination { set; get; }

        public AddDestination(int airportId)
        {
            InitializeComponent();
            this.AirportId = airportId;  
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            
            CreatedDestination = new Destination(tbDestinationName.Text, (int)nudLength.Value, (int)nudPrice.Value)
            {
                airportId = this.AirportId 
            };

            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Anton\Documents\test_v1.mdf; Integrated Security = True; Connect Timeout = 30";

            // SQL query to insert the new destination into the database
            string query = "INSERT INTO Destinations (destinationName, length, price, airportId) VALUES (@destinationName, @length, @price, @airportId)";

           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    
                    cmd.Parameters.AddWithValue("@destinationName", CreatedDestination.destinationName);
                    cmd.Parameters.AddWithValue("@length", CreatedDestination.length);
                    cmd.Parameters.AddWithValue("@price", CreatedDestination.price);
                    cmd.Parameters.AddWithValue("@airportId", CreatedDestination.airportId); 

                   
                    cmd.ExecuteNonQuery();

                    
                    MessageBox.Show("Destination added successfully.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

     
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
  
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddDestination_Load(object sender, EventArgs e)
        {
           
        }
    }
}
