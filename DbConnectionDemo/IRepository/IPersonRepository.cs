using DbConnectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbConnectionDemo.IRepository
{
    public interface IPersonRepository
    {
        IEnumerable<Customer> Get();

        Customer Get(int id);       
    }
}
