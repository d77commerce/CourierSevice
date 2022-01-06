using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAndCustomers.interfacePersonsAndCustomers
{
    public interface IPerson
    {
        string Name { get; set; }
        string SecondName { get; set; }
        string FamilyName { get; set; }
        int DataOfBirth { get; set; }
        string Email { get; set; }
        int PhoneNo { get; set; }
        string Sity { get; set; }
        string Street { get; set; }
        string StreetNo { get; set; }
        string SecondLineAddress { get; set; }
        string ThirdLineAddress { get; set; }
        string PostCode { get; set; }
        int PersonalID { get; }

    }
}
