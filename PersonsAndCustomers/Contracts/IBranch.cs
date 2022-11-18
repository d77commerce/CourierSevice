using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts
{
    internal interface IBranch
    {
         string Name { get; set; }
        string Town { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        string ManagerName { get; set; }
    }
}
