using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Destination
    {
        public string destinationName { get; set; }
        public int length { get; set; }

        public int price { get; set; }

        public int airportId { get; set; }



        public Destination(string destinationName, int length, int price)
        {
            this.destinationName = destinationName;
            this.length = length;
            this.price = price;
        }

        public Destination(int airportId) { 
            this.airportId = airportId;
        }
        
        public override string ToString()
        {
            return String.Format("{0}\t{1}km - {2} EUR", destinationName,length,price);

        }
    }
}
