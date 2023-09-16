using EgeUmutTali_Ödev1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EgeUmutTali_Ödev1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly NorthwndContext _northwndContext;

		public HomeController(ILogger<HomeController> logger, NorthwndContext northwndContext)
		{
			_logger = logger;
			_northwndContext = northwndContext;
		}

		public IActionResult Index()
		{
			var employees = _northwndContext.Employees.ToList();
			return View(employees);
		}
        [Route("EmployeeOrders/{id:int}")]
        public IActionResult EmployeeOrders(int id)
		{
			var ListofOrders = _northwndContext.Orders.Where(p=>p.EmployeeId == id).Include(o => o.Employee).ToList();
			return View(ListofOrders);
		}


        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}