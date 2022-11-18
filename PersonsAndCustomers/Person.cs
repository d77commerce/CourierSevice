using Persons.interfacePersonsAndCustomers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public abstract class Person : IPerson
    {
      
        private string name = null!;
        private string secondName = null!;
        private string familyName = null!;
        private int dataOfBirth ;
        private string email = null!;
        private string phoneNo = null!;
        private string city = null!;
        private string street = null!;
        private string streetNo = null!;
        private string secondLineAddress = null!;
        private string thirdLineAddress = null!;
        private string postCode = null!;

        public Person()
        {

        }
        public int Id { get; set; }
        public string Name { get => name; set => name = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string Email { get => email; set => email = value; }
        public int DataOfBirth { get => dataOfBirth; set => dataOfBirth = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Sity { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string StreetNo { get => streetNo; set => streetNo = value; }
        public string SecondLineAddress { get => secondLineAddress; set => secondLineAddress = value; }
        public string ThirdLineAddress { get => thirdLineAddress; set => thirdLineAddress = value; }
        public string PostCode { get => postCode; set => postCode = value; }
     
        
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

