namespace ITExpertsEraEmpInfo.Models.Repository
{

    public class EmployeeRepository : IEmployeeRepository
    {
        public static List<Employee> Employees = new List<Employee>();
        static EmployeeRepository() 
        {
            Employees.Add(new Employee() { Id = 1, Name = "Shailja", Salary = 70000, City = "Dehradun" });
            Employees.Add(new Employee() { Id = 2, Name = "Ria", Salary = 25000, City = "Chandigarh" });
            Employees.Add(new Employee() { Id = 3, Name = "Abhinav", Salary = 55000, City = "Jaipur" });
            Employees.Add(new Employee() { Id = 4, Name = "Vaibhav", Salary = 65000, City = "Mumbai" });
            Employees.Add(new Employee() { Id = 5, Name = "Sweta", Salary = 65000, City = "Delhi" });

        }
        public void DeleteEmployee(int id)
        {
            Employee employee = Employees.First(item=> item.Id == id);
            Employees.Remove(employee);
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = Employees.First(item=> item.Id == id);
            return employee;
        }
        
        public void UpdateEmployee(Employee employee)
        {
            Employee emp = Employees.First(item=> item.Id == employee.Id);
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.City = employee.City;
        }

        public List<Employee> GetEmployee()
        {
            throw new NotImplementedException();
        }

        public void CreateEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
