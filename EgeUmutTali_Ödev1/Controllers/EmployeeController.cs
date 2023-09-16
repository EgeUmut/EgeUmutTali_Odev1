using EgeUmutTali_Ödev1.Models;
using Microsoft.AspNetCore.Mvc;

namespace EgeUmutTali_Ödev1.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly NorthwndContext _context;

        public EmployeeController(NorthwndContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployee() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid) 
            {
                _context.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }

            return View();
        }
    }
}
