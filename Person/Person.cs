using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
   public class Person : IPerson
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
        List<Person> personList;
       
        public Person(string name, string familyName, int dataOfBirth)
        {
            Name = name;
            FamilyName = familyName;
            DataOfBirth = dataOfBirth;
            personList = new List<Person>();
        }

        public string Name { get => name; set => name = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public int DataOfBirth { get => dataOfBirth; set => dataOfBirth = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string Email { get => email; set => email = value; }
        public int PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Sity { get => sity; set => sity = value; }
        public string Street { get => street; set => street = value; }
        public string StreetNo { get => streetNo; set => streetNo = value; }
        public string SecondLineAddress { get => secondLineAddress; set => secondLineAddress = value; }
        public string ThirdLineAddress { get => thirdLineAddress; set => thirdLineAddress = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public void FindByNameAndDOB(string name, string family, int DOB)
        {
            throw new NotImplementedException();
        }
        List<int> uniqueNum = new List<int>();
        public int PersonUniqueNumber(Person person)
        {
            int zoneA = person.name.Length;
            int zoneB = person.familyName.Length;
            int zoneC = person.GetHashCode();
            int zoneD = person.dataOfBirth + 99999;

            int uniNum = zoneA + zoneB + zoneC + zoneD + 200000000;
            if ( uniqueNum.Any().Equals(uniNum))
            {
                uniNum += 100000000;
                uniqueNum.Add(uniNum);
            }
            else
            {
                uniqueNum.Add(uniNum);
            }
            return uniNum;
        }

    }
}
