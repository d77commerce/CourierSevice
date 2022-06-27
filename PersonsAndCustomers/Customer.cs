using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAndCustomers
{
    public class Customer : Person
    {
        public Customer(string name, string familyName, string email, int phoneNo)
            : base(name, familyName)
        {
            Email = email;
            PhoneNo = phoneNo;
           
        }

    
    }
}
