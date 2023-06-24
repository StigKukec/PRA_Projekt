using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Account
    {
        private const char Del = ',';
        private static readonly string direktorij = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory())
      .Parent.FullName).Parent.FullName;
        private static readonly string accountPath = Path.Join(direktorij, @"/Utilities/Resources/Account.txt") ;
        public Account(string lastName, string firstName, string email, string password, string role)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Password = password;
            Role = role;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public static List<Account> ParseAccount()
        {
            List<Account> list = new List<Account>();
            string[] lines = File.ReadAllLines(accountPath);
            foreach (string line in lines)
            {
                string[] details = line.Split(Del);
                list.Add(new Account( details[1], details[0], details[2],details[3],details[4]));
            }

            return list;
        }

    }
}
