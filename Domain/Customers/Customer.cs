using Domain.CustomerContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
    }
}
