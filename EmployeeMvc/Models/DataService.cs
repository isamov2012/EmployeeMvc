namespace EmployeeMvc.Models
{
    public class DataService
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name="Maria Gustavsson", Email ="maria.gustavsson@gmail.com"},
            new Employee { Id = 2, Name="Julia Petersson", Email ="julia.petersson@gmail.com"},
            new Employee { Id = 3, Name="Anna Johansson", Email ="anna.johansson@gmail.com"},
        };

        public void Add(Employee employee)
        {
            employee.Id = employees.Count == 0? 1: employees.Max(x=>x.Id)+1;
            employees.Add(employee);
        }

        public Employee[] GetAll()
        {
            return employees.ToArray();
        }

        public Employee GetById(int id)
        {
            return employees.SingleOrDefault(e =>e.Id==id); 
        }
    }
}
