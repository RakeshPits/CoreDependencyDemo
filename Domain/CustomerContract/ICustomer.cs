using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.CustomerContract
{
    public interface ICustomer
    {
        string Name { get; set; }
    }
}
