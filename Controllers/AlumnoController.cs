using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class AlumnoController : Controller
    {
         public IActionResult Index(string Id)
        {
            if(!string.IsNullOrWhiteSpace(Id))
            {
            var alumno = from alum in _context.Alumnos
                             where alum.Id == Id
                             select alum; 
            return View(alumno.SingleOrDefault());
            }else{
               return View("MultiAlumno", _context.Alumnos);
            }
        }

        public IActionResult MultiAlumno()
        {

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", _context.Alumnos);
        }

        private EscuelaContext _context;

        public AlumnoController (EscuelaContext context)
        {
            _context = context;
        }

    }
}