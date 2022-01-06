using PersonsAndCustomers.interfacePersonsAndCustomers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAndCustomers
{
    public abstract class Person : IPerson
    {
        private string name;
        private string secondName;
        private string familyName;
        private int dataOfBirth;
        private string email;
        private int phoneNo;
        private string sity;
        private string street;
        private string streetNo;
        private string secondLineAddress;
        private string thirdLineAddress;
        private string postCode;

        public Person(string name, string familyName)
        {
            Name = name;
            FamilyName = familyName;

            int zoneA = this.Name.Length;
            int zoneB = this.FamilyName.Length;
            int uniNum = zoneA + zoneB + 200000000;
            PersonalID = uniNum;
        }

        public string Name { get => name; set => name = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string Email { get => email; set => email = value; }
        public int DataOfBirth { get => dataOfBirth; set => dataOfBirth = value; }
        public string SecondName { get => secondName; set => secondName = value; }

        public int PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Sity { get => sity; set => sity = value; }
        public string Street { get => street; set => street = value; }
        public string StreetNo { get => streetNo; set => streetNo = value; }
        public string SecondLineAddress { get => secondLineAddress; set => secondLineAddress = value; }
        public string ThirdLineAddress { get => thirdLineAddress; set => thirdLineAddress = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public int PersonalID { get; }

    }
}








// public int PersonID(Person person)
// {
//     int zoneA = person.name.Length;
//     int zoneB = person.familyName.Length;
//     int zoneC = person.GetHashCode();
//     int zoneD = person.dataOfBirth + 99999;
//
//     int uniNum = zoneA + zoneB + zoneC + zoneD + 200000000;
//     if (uniqueNum.Any().Equals(uniNum))
//     {
//         uniNum += 100000000;
//         uniqueNum.Add(uniNum);
//     }
//     else
//     {
//         uniqueNum.Add(uniNum);
//     }
//     return uniNum;
//
// }
// public void AddPerson(int UnqeNo, Person person)
// {
//     if (person == null)
//     {
//         Console.WriteLine("Fill valid person");
//     }
//     else
//     {
//         persons.Add(UnqeNo, person);
//         Console.WriteLine("You ADD new peson in Dictionary - ");
//     }
// }
// public string dictonaryPrint()
// {
//     StringBuilder sb = new StringBuilder();
//     foreach (var item in persons.Keys)
//     {
//         sb.AppendLine("==========================");
//         sb.AppendLine(persons[item].Name);
//         sb.AppendLine("==========================");
//         sb.AppendLine();
//         sb.Append(persons[item].FamilyName);
//         sb.Append(FamilyName);
//         sb.Append(item);
//         sb.AppendLine("------------------");
//     }
//     return sb.ToString().TrimEnd();
// }
//

