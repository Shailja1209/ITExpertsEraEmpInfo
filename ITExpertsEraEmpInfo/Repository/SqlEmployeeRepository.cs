using ITExpertsEraEmpInfo.Data;
using ITExpertsEraEmpInfo.Models;
using ITExpertsEraEmpInfo.Models.Repository;

namespace ITExpertsEraEmpInfo.Repository
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public SqlEmployeeRepository(AppDbContext context) 
        {
            _context = context;
        }
        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
           Employee employee = _context.Employees.First(item => item.Id == id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetEmployee()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = _context.Employees.First(item => item.Id == id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee emp = _context.Employees.First(item => item.Id == employee.Id);
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.City = employee.City;
            _context.Employees.Update(emp);
            _context.SaveChanges();
        }
    }
}
