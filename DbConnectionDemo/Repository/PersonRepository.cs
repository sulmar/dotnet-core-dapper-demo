using Dapper;
using DbConnectionDemo.IRepository;
using DbConnectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DbConnectionDemo.Repository
{
    

    public class PersonRepository : IPersonRepository
    {
        private IDbConnection _connection;

        public PersonRepository(IDbConnection connection)
        {
            _connection = connection;
        }



        public IEnumerable<Customer> Get()
        {
           const string sql = "SELECT [customer_id] as Id, [first_name] as FirstName, [last_name] as LastName FROM customer";

            // Install-Package Dapper
            return _connection.Query<Customer>(sql);
        }

        public Customer Get(int id)
        {
            const string sql = "SELECT [customer_id] as Id, [first_name] as FirstName, [last_name] as LastName FROM customer WHERE customer_id = @CustomerId";

            // Install-Package Dapper
            return _connection.QuerySingle<Customer>(sql, new { CustomerId = id });
        }
    }
}
