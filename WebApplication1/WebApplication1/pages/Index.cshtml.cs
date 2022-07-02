using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.pages
{
    public class IndexModel : PageModel
    {
        public string address { get; set; }
        public List<string> emp { get; set; }
        public void OnGet()
        {
            
              address = "chabahil gangahi" +
                "ty";
              emp = new List<string>() { "Nini","Nitesh","yujan"};
        }
    }
}
