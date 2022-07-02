using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class EmployeeModel : PageModel
    {

        public List<Employee> emplist {get; set;}
          public void OnGet()
        {
            Employee employee = new Employee();
            emplist = employee.GetAllEmployee(); 

        }
    }
}
