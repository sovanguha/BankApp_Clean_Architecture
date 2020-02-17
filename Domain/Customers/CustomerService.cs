using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public class CustomerService
    {
        private readonly ICustomerFactory customerFactory;
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerFactory customerFactory, ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
            this.customerFactory = customerFactory;
        }

        public async Task<ICustomer> CreateCustomer(string Name)
        {
            var customer = this.customerFactory.NewCustomer(Name);
            await this.customerRepository.Add(customer).ConfigureAwait(false);
            return customer;
        } 

    }
}
