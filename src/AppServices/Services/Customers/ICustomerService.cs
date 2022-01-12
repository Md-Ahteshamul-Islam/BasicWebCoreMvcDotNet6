using AppCore.Domains.Customers;
using AppData.Contexts;

namespace AppServices.Services.Customers
{
    public interface ICustomerService
    {
        AppDbContext Context { get; }

        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerById(int id);
    }
}