using Microsoft.AspNetCore.Mvc;
using WebMVCLex1_GL.Data;
using WebMVCLex1_GL.Models;

namespace WebMVCLex1_GL.Controllers

{
    public class CustomersController : Controller
    {
        private readonly WebMVCLex1_GLContext _context;
        public CustomersController (WebMVCLex1_GLContext context) 
        {
            _context = context;        
        }

        public IActionResult Index()
        {
            List<Customer> Customers = _context.Customers.ToList();
            return View(Customers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,FirstName,LastName,SSN")] Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
