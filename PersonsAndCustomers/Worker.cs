﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Worker : Person
    {
        public Worker(string name, string familyName, string email, int dataOfBirth
            , string phoneNo, string sity, string street, string streetNo, string postCode) 
            : base()
        { 
            Name = name;
            FamilyName = familyName;
            DataOfBirth = dataOfBirth; 
            Email=email;
            PhoneNo = phoneNo;  
            Sity= sity;
            Street= street;
            StreetNo= streetNo;
            PostCode= postCode;

        }

        public int MyProperty { get; set; }
    }
}
