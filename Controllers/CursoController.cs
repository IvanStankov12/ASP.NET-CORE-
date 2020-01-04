using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class CursoController : Controller
    {

         
        public IActionResult Index(string Id)
        {
            if (!string.IsNullOrWhiteSpace(Id))
            {
                var curso = from cur in _context.Cursos
                            where cur.Id == Id
                            select cur;
                return View(curso.SingleOrDefault());
            }
            else
            {
                return View("MultiCurso", _context.Cursos);

            }
        }

        public IActionResult MultiCurso()
        {

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiCurso", _context.Cursos);
        }

   
        public IActionResult Create()
        {

            ViewBag.Fecha = DateTime.Now;

            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var school = _context.Escuelas.FirstOrDefault();
                curso.EscuelaId = school.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Vista Creada";

                return View("Index", curso);

            }
            else
            {
                return View(curso);
            }
        }

        private EscuelaContext _context;

        public CursoController(EscuelaContext context)
        {
            _context = context;
        }

    }
}