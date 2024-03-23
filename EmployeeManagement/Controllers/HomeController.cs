using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        // Constructor Injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Employee Index()
        {
            return _employeeRepository.GetEmployee(2);
        }
        public ViewResult Details()
        {
            Employee employee = _employeeRepository.GetEmployee(1);

            // to view this o/p => url - http://localhost:36244/home/details

            //return View(employee);
            //return View("Test");    // Test.cshtml from views/Home
            //return View("MyViews/Test.cshtml");     // Test.cshtml from MyViews folder
            //return View("../Test/Update");      // Update.cshtml from Views/Test
            return View("../../MyViews/Test");  // by using relative file path    // Test.cshtml from MyViews folder
        }
    }
}
