using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LibrarySistem.Data;
using LibrarySistem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LibrarySistem.Controllers
{
    [Route("[controller]")] // Genera la ruta del controlador
    public class DocumentTypesController : Controller
    {
        private readonly ILogger<DocumentTypesController> _logger;

        public readonly AppDbContext _context;

        public DocumentTypesController(ILogger<DocumentTypesController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // _logger nos ayuda a imprimir en consola -> console.log de JS 
            /*  _logger.LogInformation("controlador");
             _logger.LogCritical("controlador");
             _logger.LogDebug("controlador");
             _logger.LogError("controlador");
             _logger.LogTrace("controlador");
             _logger.LogWarning("controlador"); */
            var documentTypes = _context.DocumentTypes.ToList(); // Esta variable almacena todos los datos de documentos de la DB
            return View(documentTypes);
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(DocumentType documentType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(documentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                _logger.LogError("Error saving");
                return View(documentType);
            }
        }

        /*  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

         [Route("Error")] // Por cada view debe existir un Route
         public IActionResult Error()
         {
             return View("Error!");
         } */
    }
}