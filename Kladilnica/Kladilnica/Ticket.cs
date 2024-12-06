using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladilnica
{
    public class Ticket
    {
        
        public Match match { get; set; }
        public int tip { get; set; }
        public Ticket(Match match, int tip)
        {
            this.match = match;
            this.tip = tip;
        }

        public override string ToString()
        {
            return string.Format("{0} vs {1}: {2}", match.Home.teamName, match.Away.teamName,tip);
        }
    }
}
