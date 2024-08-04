using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD
{
    internal class User : ICloneable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }

        public User()
        {
            
        }

        public User(int id, string name, string email, long phonenumber)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phonenumber;
        }

        public object Clone()
        {
            User U = new User();

            U.ID = this.ID;
            U.Name = new string(this.Name);
            U.Email = new string(this.Email);
            U.PhoneNumber = this.PhoneNumber;

            return U;
        }

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
