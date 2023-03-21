using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailvalidator.Data
{
    internal class Reservation
    {
        private string flight_code;
        private string reserve_airline;
        private string name;
        private string citizenship;
        private double cost;
        private string reservationCode;
        private Flights flight;

        public Reservation(Flights flights, string name, string citizenship)
        {
            this.flight = flights;
            this.name = name;
            this.citizenship = citizenship;
        }

        /*
		 * constructor for the reservation
		 */
        public Reservation(string flight_code, string reserve_airline, string name, string citizenship, double cost, string reservationCode)
        {
            this.flight_code = flight_code;
            this.reserve_airline = reserve_airline;
            this.name = name;
            this.citizenship= citizenship;
            this.cost = cost;
            this.reservationCode = reservationCode;
        }

        public Reservation(string flight_code, string reserve_airline, string name)
        {

        }

        /* 
		 * getter and setters
		 */
        public string FlightCode
        {
            get { return flight_code; }
            set { flight_code = value; }
        }
        public string ReserveAirline
        {
            get { return reserve_airline; }
            set { reserve_airline = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Citizenship
        {
            get { return citizenship; }
            set { citizenship = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public string ReservationCode
        {
            get { return reservationCode; }
            set { reservationCode = value; }
        }

        public Flights Flight
        {
            get { return flight; }
            set { flight = value; }
        }
    }
}
