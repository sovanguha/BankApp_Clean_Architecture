using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public interface ICustomerFactory
    {
        ICustomer NewCustomer(string Name);
    }
}
