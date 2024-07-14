using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CustomerDAO
    {
        public static Customer CheckLogin(string Email, string Password)
        {
            using var db = new DiamondContext();
            return db.Customers.SingleOrDefault(c => c.EmailAddress.Equals(Email) && c.Password.Equals(Password));
        }
    }
}
