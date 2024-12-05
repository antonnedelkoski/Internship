using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Airport
    {
        public  string airpoprtName { get; set; }

        public string Code { get; set; }

        public  string City { get; set; }
        
        public int idAirpot { get; set; }

        public List<Destination> Destinations { get; set; } = new List<Destination>();

        
        public Airport(string airpoprtName, string code, string city)
        {
            this.airpoprtName = airpoprtName;
            Code = code;
            City = city;
        }

        public override string ToString()
        {
            return String.Format("{1}-{0} - {2}", Code, airpoprtName, City);
        }
    }
    

}
