using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Emailvalidator.Data
{
    internal class ReservationManager
    {
        /*location of reservation
		 */
        public const string reservation_binary = "res/reservation.bin"; //reservation directory 

        private List<Reservation> reservations;

		private string name;
		private string citizenship;


		/*
		 * Make a reservation
		 * @param flight to book
		 * @param name of the person
		 * @citizenship of the person
		 * return created reservation
		 */
		
		public static string GenerateCode()
		{
			Random ran = new Random();

			String b = "abcdefghijklmnopqrstuvwxyz";
			String sc = "0123456789";

			int length = 4;

			String random = "";

			for (int i = 0; i < length; i++)
			{
				int a = ran.Next(sc.Length); //string.Lenght gets the size of string
				random = random + sc.ElementAt(a);
			}
			for (int j = 0; j < 1; j++)
			{
				int sz = ran.Next(b.Length);
				random = random + b.ElementAt(sz);
			}
			return random;
		}
		public static Reservation MakeReservation(Flights flights, string name, string citizenship)
		{
			string _name= name;
			string _citizenship=citizenship;
			Flights f = flights;

			Reservation reservation = new Reservation( f, name,  citizenship);
			return reservation;
		}

		/*
		 * find the reservation by airline or code
		 * @param reservation code
		 * @param airline
		 * @param name of traveler
		 * @return the reservation objects (need the ToString() method)
		 */



		/*
		 * find the reservation by code
		 * @param reservation code
		 * return  the reservation object
		 */
	}
}
