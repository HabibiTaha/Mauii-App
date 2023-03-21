using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailvalidator.Data
{
    internal class User
    {
        private string id;
        private string email;
        private string firstName;
        private string lastName;
        private string userName;
        


        public string Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserName { get => userName; set => userName = value; }

        public User() {
        }

        public User(string id, string email)
        {
            Email = email;
            Id = id;
        }

        public User(string id, string email, string firstName, string lastName, string userName)
        {
            this.Id = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                id == user.id &&
                email == user.email &&
                firstName == user.firstName &&
                lastName == user.lastName &&
                userName == user.userName;


        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
