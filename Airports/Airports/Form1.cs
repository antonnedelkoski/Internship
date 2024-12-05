using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        } 

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            NewAirport addAirport = new NewAirport();
            if (addAirport.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(addAirport.airport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex == -1)
            {
                return;
            }
            DialogResult dg = MessageBox.Show("Are you sure you want to delete?", "You sure?", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK)
            {
                int selectedIndex = lbAirports.SelectedIndex;
                lbAirports.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if(lbAirports.SelectedIndex != -1)
            {
                AddDestination AddDestinationForm = new AddDestination();
                if(AddDestinationForm.ShowDialog() == DialogResult.OK)
                {
                    Airport SelectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                    SelectedAirport.Destinations.Add(AddDestinationForm.CreatedDestination);
                    LoadDestinations();
                }
            }
        }

        private void lbAirports_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDestinations();
        }


        private void LoadDestinations()
        {
            lbDestinations.Items.Clear();
            if (lbAirports.SelectedIndex >= 0)
            {
                Airport SelectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                
                foreach (Destination destination in SelectedAirport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                }

                double sum = 0;
                foreach (Destination destination in SelectedAirport.Destinations)
                {
                    sum += destination.length;
                }

                if (SelectedAirport.Destinations.Count != 0)
                {
                    double average = sum / SelectedAirport.Destinations.Count;
                    tbAvgLengthDest.Text = $"{average}";
                }
                else
                {
                    tbAvgLengthDest.Text = "0";
                }
                if (SelectedAirport.Destinations.Count == 0) 
                {
                    tbMostExpensiveDest.Text = "0";
                }
                else
                {
                    Destination max = SelectedAirport.Destinations[0];
                    for (int i = 0; i < SelectedAirport.Destinations.Count; i++)
                    {
                        if (SelectedAirport.Destinations[i].price > max.price)
                        {
                            max = SelectedAirport.Destinations[i];
                        }
                    }
                    tbMostExpensiveDest.Text = max.ToString();
                }

            }
            
            
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDestinations();
            
        }

        
    }
}

