using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Android.Text.Style;

namespace Emailvalidator.Data
{
    internal class Flights
    {
        private string originatingAirport;
        private string destinationAirport;
        private string dayOfWeek;
        /// <summary>
        /// /
        /// </summary>
        private string airlineCode;
        private string airlineName;
        private string from;
        private string to;
        private DateTime time;
        private int seats;
        private double rate;

        /*
		 * flight constructor with flight code
		 */
        public Flights(string originAirport, string destinationAirport, string dayOfWeek)
        {
            this.originatingAirport = originAirport;
            this.destinationAirport = destinationAirport;
            this.dayOfWeek = dayOfWeek;
        }

        /*
		 * flight constructor with all data members
		 */

        public Flights(string airlineCode, string airlineName, string from, string to, string weekday, DateTime time, int seats, double rate)
        {
            this.airlineCode = airlineCode;
            this.airlineName = airlineName;
            this.from = from;
            this.to = to;
            this.dayOfWeek = weekday;
            this.time = time;
            this.seats = seats;
            this.rate = rate;
        }
        /*
		 * getter setter of all members
		 */

        public string OriginatingAirport
        {
            get { return originatingAirport; }
            set { originatingAirport = value; }
        }

        public string DestinationAirport
        {
            get { return destinationAirport; }
            set { destinationAirport = value; }
        }

        public string DayOfWeek
        {
            get { return dayOfWeek; }
            set { dayOfWeek = value; }
        }
        public string AirlineCode
        {
            get { return airlineCode; }
            set { airlineCode = value; }
        }
        public string AirlineName
        {
            get { return airlineName; }
            set { airlineName = value; }
        }
        public string From
        {
            get { return from; }
            set { from = value; }
        }
        public string To
        {
            get { return to; }
            set { to = value; }
        }
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }



        public override string ToString()
        {
            return
                AirlineCode + " " + AirlineName + " " +From + " " +To + " " + DayOfWeek + " " +Time.ToString("HH:mm") + " " + Seats + " " + Rate;
        }
    }
}
