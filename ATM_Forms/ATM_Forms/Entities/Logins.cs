using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Forms.Entities
{
    public class Logins
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string? Account { get; set; }


        public Logins(string name, string iD, string password, string address, string? account = null)
        {
            Name = name;
            ID = iD;
            Password = password;
            Address = address;
            Account = account;
        }

        public override string ToString()
        {
            return $"Name:{Name}/ID:{ID}/Password:{Password}/Address:{Address}/Account:{Account}";
        }
    }
}
