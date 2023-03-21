//using Intents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailvalidator.Data
{
    internal class userManager
    {
        public static string Any = "Any";
        //
        //public static string mon = "Monday";
        
        // reading a text file
        private const string USERS_TEXT = @"C:\Users\markm\source\repos\Emailvalidator\Resources\Files\userdata.txt";
        public static List<User> users = new List<User>();

        public userManager() {
            populateUsers();


        }
        /*
         * method to pupulate the user information
         * @param -  no peramaeters
         * @return - no return
         */
        private void populateUsers()
        {
            User user;
            foreach(string line in System.IO.File.ReadAllLines(USERS_TEXT))
            {
                string[] parts = line.Split(",");

                string id = parts[0];
                string email = parts[1];
                string firstname = parts[2];
                string lastname = parts[3];
                string username = parts[4];
      
                try
                {
                    user = new User(id, email, firstname, lastname, username);
                    users.Add(user);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            }

        }

        /*
         * getuser return the list of users
         * @param - no parameters
         * @return list of users
         */
        public static List<User> GetUsers()
        {
            return users;
        }


        public static User finduserbyid(string id)
        {
            foreach(User user in users)
            {
                if(user.Equals(id)) 
                    return user;
            }
            return null;
        }

        public static List<User> finduser(string id, string email)
        {
            List<User> found = new List<User>();

            foreach(User user in users)
            {
                string userId = user.Id;
                string userEmail = user.Email;

                if (userId.Equals(id) && userEmail.Equals(email))
                {
                    found.Add(user);
                }
            }

            return found;
        }
    }
}
