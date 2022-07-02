using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class StudentModel : PageModel
    {
        public List<Student> Students { get; set; }
        public void OnGet()
        {
            Student s = new Student();
            Students = s.GetStudentInfo() ;
        }
    }
}
