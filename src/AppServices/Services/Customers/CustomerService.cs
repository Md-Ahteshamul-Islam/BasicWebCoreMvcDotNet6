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
            return _context.Customers.ToList();
        }
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }
        public async Task<Customer> InsertCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            var _customer = await _context.Customers.FindAsync(customer.Id);
            _customer.Name = customer.Name;
            _customer.Email = customer.Email;
            _customer.Contact = customer.Contact;
            await _context.SaveChangesAsync();
            return _customer;
        }

        public async Task<bool> DeleteCustomer(int id)
        {

            var _customer = await _context.Customers.FindAsync(id);
            if (_customer == null) return false;

            _context.Customers.Remove(_customer);
            await _context.SaveChangesAsync();
            return true;
        }

        #endregion
    }
}
