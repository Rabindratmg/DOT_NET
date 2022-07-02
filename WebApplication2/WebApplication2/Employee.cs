namespace WebApplication2
{

    
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add( new Employee { Id = 1, Name = "Rabindra", Address = "ktm" });
            return employees;
        }

        
    }

    


}
