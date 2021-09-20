using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public string Messeng { get; set; }

        public void OnGet()
        {
            Messeng = "��������� ����";
        }

        public IActionResult OnPost(string name, int age)
        {
            string url = Url.Page("User", new Person { Name = name, Age = age });
            return Redirect(url);
        }
    }
}
