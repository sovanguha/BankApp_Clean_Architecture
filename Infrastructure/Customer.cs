using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Customer : Domain.Customers.Customer
    {
        public Customer()
        {

        }

        public Customer(string Name)
        {
            this.Id = Guid.NewGuid();
            this.Name = Name;
        }


    }
}
