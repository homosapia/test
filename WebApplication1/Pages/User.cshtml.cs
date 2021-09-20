using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;
using WebApplication1.Pages;

namespace WebApplication1.Pages
{
    public class UserModel : PageModel
    {
        public Person person = new();
        public void OnGet(string name, int age)
        {
            person.Name = name;
            person.Age = age;
        }

        public IActionResult OnPost(string name, int age)
        {
            string url = Url.Page("Peges", new Person { Name = name, Age = age });
            return Redirect(url);
        }
    }
}
