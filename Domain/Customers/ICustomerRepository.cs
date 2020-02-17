using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public interface ICustomerRepository
    {
        Task Add(ICustomer customer);
        Task Update(ICustomer customer);
    }
}
