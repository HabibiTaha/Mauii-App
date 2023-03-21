using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailvalidator.Data
{
    internal class Airports
    {
        private string airport_code;
        private string airport_name;

        public Airports(string airportcode, string airportname)
        {
            this.airport_code = airportcode;
            this.airport_name = airportname;
        }
        public string AirportCode
        {
            get { return airport_code; }
            set { airport_code = value; }
        }
        public string AirportName
        {
            get { return airport_name; }
            set { airport_name = value; }
        }
    }
}
