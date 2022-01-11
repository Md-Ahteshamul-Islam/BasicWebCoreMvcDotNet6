using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Domains.Customers;

namespace AppServices.Services.Customers
{
    public class CustomerService
    {
        //public async Task<List<Customer>> GetAllCustomer(int id)
        //{
        //    return AppDbContext.;
        //}
        public async Task<Customer> GetCustomerById(int id)
        {
            return new Customer();
        }
    }
}
