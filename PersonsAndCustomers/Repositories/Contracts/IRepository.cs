using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAndCustomers.Repositories.Contracts
{
    public interface IRepository<T>
    {
        IReadOnlyCollection<T> Models { get; }  
        void Add(T model);  
        bool Remuve (T model);
        T GetT (int id);
    }
}
