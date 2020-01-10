using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult Create()
        {

            ViewBag.Fecha = DateTime.Now;

            return View();
        }
        [HttpPost]
        public IActionResult Create(Alumno alumno)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var db = _context.Cursos.FirstOrDefault();
                alumno.CursoId = db.Id;
                _context.Alumnos.Add(alumno);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Vista Creada";

                return View("Index", alumno);

            }
            else
            {
                return View(alumno);
            }
        }
   
        public IActionResult Edit(string Id)
        {
            ViewBag.Fecha = DateTime.Now;
            Alumno model = new Alumno();
            using (var db = _context)
            {
                var dataAlumno = db.Alumnos.Find(Id);
                model.Nombre = dataAlumno.Nombre;
                model.Id = dataAlumno.Id;
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Alumno model)
        {
            ViewBag.Fecha = DateTime.Now;
            if (!ModelState.IsValid)
            {
                return View(model);

            }
            using (var db = _context)
            {
                var dataAlumno = db.Alumnos.Find(model.Id);
                dataAlumno.Nombre = model.Nombre;
                dataAlumno.Id = model.Id;

                
                db.Entry(dataAlumno).State = EntityState.Modified;
                db.SaveChanges();
            }


            return Redirect(Url.Content("//localhost:5001/Alumno/MultiAlumno"));


        }

        public IActionResult Delete(string Id)
        {

            ViewBag.Fecha = DateTime.Now;
            ViewBag.MensajeExtra = "Todo se logra";
            Alumno model = new Alumno();
            using (var db = _context)
            {
                var dataAlumno = db.Alumnos.Find(Id);
                model.Nombre = dataAlumno.Nombre;
                model.Id = dataAlumno.Id;
            }


            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Alumno model)
        {
            ViewBag.Fecha = DateTime.Now;
             
            using (var db = _context)
            {
                var dataAlumno = (from alum in db.Alumnos
                                  where alum.Id == model.Id
                                   select alum).Single();
                
                db.Alumnos.Remove(dataAlumno);
                db.SaveChanges();
            }


            return Redirect(Url.Content("//localhost:5001/Alumno/MultiAlumno"));


        }

        private EscuelaContext _context;

        public AlumnoController (EscuelaContext context)
        {
            _context = context;
        }

    }
}