using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailvalidator.Data
{
    class Register
    {
        private int id;
        private string email;
        private string firstName;
        private string lastName;
        private string userName;
        private string password;

        public Register(int id, string email, string firstName, string lastName, string userName, string password)
        {
            this.Id = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.UserName = userName;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
