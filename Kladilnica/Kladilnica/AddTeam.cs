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
    public partial class AddTeam : Form
    {
        public Team team { get; set; }
        
        public AddTeam()
        {
            InitializeComponent();
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTeamConfirm_Click(object sender, EventArgs e)
        {
            this.team = new Team(tbAddTeamName.Text,tbAddTeamCountry.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
