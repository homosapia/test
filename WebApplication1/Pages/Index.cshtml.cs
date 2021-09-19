using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public string Messeng { get; set; }
        public void OnGet()
        {
            Messeng = "��������� ����";
        }

        public void OnPost(string name, int age)
        {
            Messeng = $"���: {name} �������: {age}";
        }
    }
}
