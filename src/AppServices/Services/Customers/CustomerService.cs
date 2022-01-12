using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Domains.Customers;
using AppData.Contexts;

namespace AppServices.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        #region fields

        private readonly AppDbContext _context;

        #endregion

        #region ctor

        //public CustomerService(AppDbContext context)
        public CustomerService()
        {
            _context = new AppDbContext();
        }

        #endregion

        #region methods

        public AppDbContext Context { get; }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            //var context = new AppDbContext();
            return _context.Customers.ToList();
        }
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        #endregion
    }
}
