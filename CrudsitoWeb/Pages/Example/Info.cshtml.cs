using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CrudsitoWeb.Pages
{
    public class Info : PageModel
    {
        private readonly ILogger<Info> _logger;

        public Info(ILogger<Info> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}