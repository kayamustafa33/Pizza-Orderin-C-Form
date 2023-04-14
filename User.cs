using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    internal class User
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public User(string Name,String Address) {
            this.Name = Name;
            this.Address = Address;
        }
    }
}
