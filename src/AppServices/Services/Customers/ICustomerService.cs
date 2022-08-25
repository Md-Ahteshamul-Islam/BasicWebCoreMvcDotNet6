using AppCore.Domains.Customers;
using AppData.Contexts;

namespace AppServices.Services.Customers
{
    public interface ICustomerService
    {
        AppDbContext Context { get; }

        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> InsertCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<bool> DeleteCustomer(int id);
    }
}