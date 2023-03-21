using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Windows.System;

namespace Emailvalidator.Data
{

    internal class FlightManager
    {
        public static string Any = "Any";
        public static List<string> days = new List<string>()
        { "Sunday","Monday","Tuesday","Wednesday","Thurday","Friday","Saturday"};

        public const string FLIGHTS_TEXT = @"C:\Users\markm\source\repos\Emailvalidator\Resources\Files\flights.csv";

        public const string AIRPORTS_TEXT = @"C:\Users\markm\source\repos\Emailvalidator\Resources\Files\airports.csv";

		public static List<Airports> AirportsList = new List<Airports>();
		//this is for list of all the flights extracted from the CSV file
		public static List<Flights> FlightsList = new List<Flights>();
		//search the exiting list of all flights
		public static List<Flights> SearchedFlights = new List<Flights>();
		public FlightManager()
        {
            populateFlights();
            populateAirports();
        }

        /// <summary>
        /// populate airport from csv file
        /// </summary>
        public void populateAirports()
        {           
            try
            {
                foreach (string line in System.IO.File.ReadLines(AIRPORTS_TEXT))
                {
                    string[] airports = line.Split(',');
                    AirportsList.Add(new Airports(airports[0], airports[1]));
                }
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// extract data from the csv file
        /// </summary>
        public void populateFlights()
        {
            Flights flight;
            try
            {
                foreach (string line in System.IO.File.ReadLines(FLIGHTS_TEXT))
                {
                    string[] flights = line.Split(',');
                    flight = new Flights(flights[0], flights[1], flights[2], flights[3], flights[4]
                        , DateTime.Parse(flights[5]), int.Parse(flights[6]), double.Parse(flights[7]));
                    FlightsList.Add(flight);
                }
            }
            catch (Exception e)
            {

            }
        }

        /// <summary>
        /// Return the searched flights available based on the provided data
        /// </summary>
        /// <param name="originAirport"></param>
        /// <param name="destinationAirport"></param>
        /// <param name="dayofweek"></param>
        /// <returns></returns>
        public static List<Flights> FindFlights(string originAirport, string destinationAirport, string dayofweek)
        {
            List<Flights> found = new List<Flights>();
            foreach (Flights f in FlightsList)
            {
                string from = f.From;
                string to = f.To;
                string day = f.DayOfWeek;
                if (from.Equals(originAirport)&&to.Equals(destinationAirport)&&day.Equals(dayofweek))
                {
                    found.Add(f);
                    SearchedFlights.Add(f);
                }
            }
            //make sure to clear all the lists to avoid duplicates
            if(found.Count<=0)
            {
				FlightsList.Clear();
				AirportsList.Clear();
				return null;
            }
            //same here clear lists right after finding the searched flights
			FlightsList.Clear();
			AirportsList.Clear();
			return found;

		}

        public static void ClearList()
        {
            SearchedFlights.Clear();
        }

    }
}
