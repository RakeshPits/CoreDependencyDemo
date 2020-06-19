using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Customers;

namespace Domain.CustomerContract
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<ICustomer>> Add(Customer customer);

        Task<IEnumerable<ICustomer>> GetAll();
    }
}
