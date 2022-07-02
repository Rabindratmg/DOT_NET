using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }


        public void  GetAllEmployee()
        {
            List<Employee> employeeList = new List<Employee>  { new Employee { Id = 1, Name = "Rabindra", Salary = 2000, Department = "Techinical"},
                                                               new Employee { Id = 2, Name = "Nitesh", Salary = 1000, Department = "Marketing"},
                                                               new Employee { Id = 3, Name = "Nini", Salary = 2050, Department = "Analysis" },
                                                               new Employee { Id = 4, Name = "Yujanbot", Salary = 2400, Department = "Business" },
                                                               new Employee { Id = 5, Name = "Kabita", Salary = 1200, Department = "Techincal" },
                                                               new Employee { Id = 6, Name = "Sunita", Salary = 2160, Department = "Business" },
                                                               new Employee { Id = 7, Name = "Monita", Salary = 3400, Department = "Marketing" } };
                
                                                                                        
        }
    }


    
}
