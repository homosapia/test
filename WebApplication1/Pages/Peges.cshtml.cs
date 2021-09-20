using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages
{
    public class PegesModel : PageModel
    {
        public List<Person> persons { get; set; }

        public List<Person> DisplayedPerson { get; set; }

        public PegesModel()
        {
            persons = new List<Person>()
            {
                new Person{ Name = "Павел", Age = 20 },
                new Person{ Name = "dfadf", Age = 10 },
                new Person{ Name = "ftht", Age = 30 },
                new Person{ Name = "vbcvn", Age = 50 },
            };
        }

        public void OnGet(string name = null, int age = 0)
        {
            DisplayedPerson = persons;

            if (name != null)
                persons.Add(new Person { Name = name, Age = age });
        }

        public void OnGetByName(string name)
        {
            DisplayedPerson = persons.Where(p => p.Name.Contains(name)).ToList();
        }

        public void OnGetByAge(int age)
        {
            DisplayedPerson = persons.Where(p => p.Age==age).ToList();
        }

        public void OnPostGreaterThan(int age)
        {
            DisplayedPerson = persons.Where(p => p.Age > age).ToList();
        }
        public void OnPostLessThan(int age)
        {
            DisplayedPerson = persons.Where(p => p.Age < age).ToList();
        }

        public IActionResult OnPostNweUser()
        {
            return Redirect(Url.Page("Index"));
        }
    }
}
