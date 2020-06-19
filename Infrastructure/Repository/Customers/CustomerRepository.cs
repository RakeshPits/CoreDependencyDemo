using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.CustomerContract;
using Domain.Customers;

namespace Infrastructure.Repository.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        #region PRIVATE

        private readonly IList<Customer> _customers;

        #endregion

        #region CONSTRUCTOR

        public CustomerRepository()
        {
            _customers = new List<Customer>()
            {
                new Customer(){Name ="Customer1"},
                new Customer(){Name ="Customer2"},
                new Customer(){Name ="Customer3"}
            };
        }

        #endregion

        #region PUBLICMETHOD

        public async Task<IEnumerable<ICustomer>> Add(Customer customer)
        {
            await Task.Run(() => _customers.Add(customer));
            return await Task.Run(() => _customers);
        }

        public async Task<IEnumerable<ICustomer>> GetAll()
        {
            return await Task.Run(() => _customers);
        }

        #endregion
    }
}
