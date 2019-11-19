using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Skork.Web.Views.Skork
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
            Message = "Welcome to the SkorkEngine";
        }

        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Welcome to the SkorkEngine";
        }
    }
}
