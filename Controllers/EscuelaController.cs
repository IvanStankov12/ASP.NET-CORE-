using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            ViewBag.CosaDinamica = "La Monja";
            return View(_context.Escuelas.FirstOrDefault());
        }

        public EscuelaController(EscuelaContext context)
        {
           _context = context; 
        }
    }
}