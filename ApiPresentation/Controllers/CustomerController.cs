using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain.Customers;
using Domain.CustomerContract;

namespace ApiPresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ILogger<CustomerController> logger, ICustomerRepository customerRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        [HttpGet]
        public async Task<IEnumerable<ICustomer>> Get()
        {
            return await Task.Run(() => _customerRepository.GetAll());
        }

        [HttpPost]
        public async Task<IEnumerable<ICustomer>> Post(Customer customer)
        {
            return await Task.Run(() => _customerRepository.Add(customer));
        }
    }
}
