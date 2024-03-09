using ITExpertsEraEmpInfo.Models;
using ITExpertsEraEmpInfo.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITExpertsEraEmpInfo.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository EmployeesRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            EmployeesRepository = employeeRepository;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            List<Employee> lstEmployee = EmployeesRepository.GetEmployees();
            return View(lstEmployee);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var employee = EmployeesRepository.GetEmployeeById(id);
            return View(employee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
                EmployeesRepository.CreateEmployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
