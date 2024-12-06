using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladilnica
{
    public class Team
    {
        public string teamName { get; set; }
        public string teamCountry { get; set; }

        public Team(string teamName, string teamCountry)
        {
            this.teamName = teamName;
            this.teamCountry = teamCountry;
        }


        public override string ToString()
        {
            return $"{teamName}";
        }
    }
}
