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
        private const char Del = '¤';
        private const string administrator = "administrator";
        private const string lecturer = "lecturer";
        private static readonly string accountPath = FilePaths.GetFilePath("/Utilities/Resources/Account.txt");
        public Account(string firstName, string lastName, string email, string password, string role)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Password = password;
            Role = role;
        }
        public Account(string firstName, string lastName, string email, string password, string role, string course) : this(firstName, lastName, email, password, role)
        {
            Course = course;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Course { get; set; }

        public static List<Account> ParseAccount()
        {
            List<Account> list = new List<Account>();
            string[] lines = File.ReadAllLines(accountPath);
            foreach (string line in lines)
            {
                string[] details = line.Split(Del);
                list.Add(new Account(details[1], details[0], details[2], details[3], details[4], details[5]));
            }

            return list;
        }
        public static List<Account> GetLecturers()
        {
            List<Account> accounts = ParseAccount();
            List<Account> accounts_copy = new();

            foreach (Account account in accounts)
            {
                if (account.Role != administrator)
                {
                    accounts_copy.Add(account);
                }
            }
            return accounts_copy;
        }
        public static bool IsLecturer()
        {
            List<Account> accounts = ParseAccount();

            foreach (Account account in accounts)
            {
                if (account.Role == lecturer)
                {
                    return true;
                }
            }
            return false;
        }

        public static void StoreLecturer(Account lecturer)
        {
            string print = $"{lecturer.FirstName}{Del}{lecturer.LastName}{Del}{lecturer.Email}{Del}{lecturer.Password}{Del}{lecturer.Role}{Del}{lecturer.Course}";
            using (StreamWriter sw = new StreamWriter(accountPath, true))
            {
                sw.WriteLine(print);
            }
        }
        public override string ToString() => $"{LastName}  |  {FirstName}  |  {Course}";
        public static void StoreLecturers(List<Account> accounts)
        {
            using (StreamWriter sw = new StreamWriter(accountPath))
            {
                foreach (Account lecturer in accounts)
                {
                    string save = $"{lecturer.FirstName}{Del}{lecturer.LastName}{Del}{lecturer.Email}{Del}{lecturer.Password}{Del}{lecturer.Role}{Del}{lecturer.Course}";
                    sw.WriteLine(save);
                }
            }
        }
    }
}
