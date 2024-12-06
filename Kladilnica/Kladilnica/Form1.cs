using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kladilnica
{
    public partial class Form1 : Form
    {
        public Match match { get; set; }
        public Ticket ticket { get; set; }
        public Team team { get; set; }

        public Form1()
        {
            InitializeComponent();
        }


        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            AddTeam addTeam = new AddTeam();
            if (addTeam.ShowDialog() == DialogResult.OK)
            {
                lbTeams.Items.Add(addTeam.team);
            }
        }

        private void btnAddToBilten_Click(object sender, EventArgs e)
        {
            checkIfCodeIsTheSame();
            if (lbTeams.SelectedItems.Count >= 2)
            {
                Team team1 = lbTeams.SelectedItems[0] as Team;
                Team team2 = lbTeams.SelectedItems[1] as Team;

                if (team1 != null && team2 != null && team1 != team2)
                {
                    if (team1.teamCountry == team2.teamCountry)
                    {
                        MessageBox.Show("Два тима не можат да бидат од иста држава!");
                        return; 
                    }
                    this.match = new Match(team1, team2, tbCode.Text, (int)nudKec.Value, (int)nudDvojka.Value, (int)nudNereseno.Value);
                    lbBilten.Items.Add(this.match);
                }
                else
                {
                    MessageBox.Show("Одберете два тима за да можат да играат едни против други");
                }
            }
            else
            {
                MessageBox.Show("Please select two teams.");
            }
            

        }
        private void btnAddNewMatch_Click(object sender, EventArgs e)
        {

            this.match = lbBilten.SelectedItem as Match;
            Ticket ticket = new Ticket(match, (int)cbSelectTip.SelectedIndex);
            lbTicket.Items.Add(ticket);

            CalculateCoef();
            


        }

        public void checkIfCodeIsTheSame() 
        {
            string toTest = tbCode.Text;

            foreach (Match match in lbBilten.Items)
            {
                if (match.Code == toTest)
                {
                    MessageBox.Show("Постои веќе шифрата."); 
                    return;
                }
            }
        }


        public void CalculateCoef()
        {
            
            decimal totalCoeff = 1;
            foreach (Ticket t in lbTicket.Items)
            {
                double sum = 0;
                Match match = t.match;
                if( t.tip == 0)
                {
                    decimal localCoef = match.kec;
                    totalCoeff *= localCoef;
                } else if (t.tip == 1)
                {
                    decimal localCoef = match.iks;
                    totalCoeff *= localCoef;
                }
                else{
                    decimal localCoef = match.dvojka;
                    totalCoeff *= localCoef;
                }

                sum += ((double)totalCoeff * (double)nudStake.Value);
                tbIncome.Text = sum.ToString() + "\t денари";
            }

            tbCoef.Text = totalCoeff.ToString(".00");
            
        }

        private void nudStake_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateCoef();
        }

        private void nudStake_KeyDown(object sender, KeyEventArgs e)
        {
            CalculateCoef();
        }
    }

    


}
