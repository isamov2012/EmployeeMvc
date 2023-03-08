using EmployeeMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMvc.Controllers
{
	public class EmployeesController : Controller
	{
		static DataService dataService = new DataService();

		[HttpGet("")]
		public IActionResult Index()
		{
			Employee[] model = dataService.GetAll();
			return View(model);
		}
		
		[HttpGet("/create")]
		public IActionResult Create()
		{
			return View();
		}

        [HttpPost("/create")]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
                return View();

            dataService.Add(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
