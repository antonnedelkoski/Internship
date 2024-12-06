using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladilnica
{
    public class Match
    {
        public Team Home { get; set; }
        public Team Away { get; set; }
        public string Code { get; set; }
        public int kec {  get; set; }

        public int dvojka { get; set; }
        public int iks {  get; set; }

        public Match(Team home, Team away, string code, int kec, int dvojka, int iks)
        {
            Home = home;
            Away = away;
            Code = code;
            this.kec = kec;
            this.dvojka = dvojka;
            this.iks = iks;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} vs. {2}", Code, Home, Away);
        }
    }
}
