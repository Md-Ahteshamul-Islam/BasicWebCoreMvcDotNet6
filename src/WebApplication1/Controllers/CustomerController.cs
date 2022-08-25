using App.Models;
using AppCore.Domains.Customers;
using AppServices.Services.Customers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CustomerController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> GetCustomer()
        {
            var customerService = new CustomerService();
            var model = await customerService.GetAllCustomersAsync();
            return Json(model);
        }
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customerService = new CustomerService();
            var model = await customerService.GetCustomerById(id);
            return Json(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            var customerService = new CustomerService();
            var model = await customerService.InsertCustomer(customer);
            return Json(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCustomer([FromBody]Customer customer)
        {
            var customerService = new CustomerService();
            var model = await customerService.UpdateCustomer(customer);
            return Json(model);
        }
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customerService = new CustomerService();
            var model = await customerService.DeleteCustomer(id);
            return Json(model);
        }
    }
}