using Persons.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Branch : IBranch
    {
        public Branch()
        {
        }
        public string Name { get; set; } = null!;
        public string Town { get; set; }=null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string ManagerName { get; set; } = null!;
    }
}
