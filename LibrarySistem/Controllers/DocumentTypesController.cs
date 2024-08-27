using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LibrarySistem.Controllers
{
    [Route("[controller]")] // Genera la ruta del controlador
    public class DocumentTypesController : Controller
    {
        private readonly ILogger<DocumentTypesController> _logger;

        public DocumentTypesController(ILogger<DocumentTypesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // _logger nos ayuda a imprimir en consola -> console.log de JS 
            _logger.LogInformation("controlador");
            _logger.LogCritical("controlador");
            _logger.LogDebug("controlador");
            _logger.LogError("controlador");
            _logger.LogTrace("controlador");
            _logger.LogWarning("controlador");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        [Route("Error")] // Por cada view debe existir un Route
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}