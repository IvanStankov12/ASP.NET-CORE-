using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
using Microsoft.EntityFrameworkCore;

namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController : Controller
    {
        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId}")]

        public IActionResult Index(string asignaturaId)
        {
            if(!string.IsNullOrWhiteSpace(asignaturaId))
            {
            var asignatura = from asig in _context.Asignaturas
                             where asig.Id == asignaturaId
                             select asig; 
            return View(asignatura.SingleOrDefault());
            }else{
               return View("MultiAsignatura", _context.Asignaturas);
            }
        }

        public IActionResult MultiAsignatura()
        {
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura", _context.Asignaturas);
        }

        public IActionResult Create()
        {

            ViewBag.Fecha = DateTime.Now;

            return View();
        }
        [HttpPost]
        public IActionResult Create(Asignatura asignatura)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var db = _context.Cursos.FirstOrDefault();
                asignatura.CursoId = db.Id;
                _context.Asignaturas.Add(asignatura);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Vista Creada";

                return View("Index", asignatura);

            }
            else
            {
                return View(asignatura);
            }
        }
   
        public IActionResult Edit(string Id)
        {
            ViewBag.Fecha = DateTime.Now;
            Asignatura model = new Asignatura();
            using (var db = _context)
            {
                var dataAsignatura = db.Asignaturas.Find(Id);
                model.Nombre = dataAsignatura.Nombre;
                model.Id = dataAsignatura.Id;
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Asignatura model)
        {
            ViewBag.Fecha = DateTime.Now;
            if (!ModelState.IsValid)
            {
                return View(model);

            }
            using (var db = _context)
            {
                var dataAsignatura = db.Asignaturas.Find(model.Id);
                dataAsignatura.Nombre = model.Nombre;
                dataAsignatura.Id = model.Id;

                db.Asignaturas.Attach(dataAsignatura);
                db.Entry(dataAsignatura).State = EntityState.Modified;
                db.SaveChanges();
            }


            return Redirect(Url.Content("//localhost:5001/Asignatura/MultiAsignatura"));


        }

        public IActionResult Delete(string Id)
        {

            ViewBag.Fecha = DateTime.Now;
            ViewBag.MensajeExtra = "Todo se logra";
            Asignatura model = new Asignatura();
            using (var db = _context)
            {
                var dataAsignatura = db.Asignaturas.Find(Id);
                model.Nombre = dataAsignatura.Nombre;
                model.Id = dataAsignatura.Id;
            }


            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Asignatura model)
        {
            ViewBag.Fecha = DateTime.Now;
             
            using (var db = _context)
            {
                var dataAsignatura = (from asig in db.Asignaturas
                                  where asig.Id == model.Id
                                   select asig).Single();
                
                db.Asignaturas.Remove(dataAsignatura);
                db.SaveChanges();
            }


            return Redirect(Url.Content("//localhost:5001/Asignatura/MultiAsignatura"));


        }
        

        private EscuelaContext _context;
        public AsignaturaController (EscuelaContext context)
        {
            _context = context;
        }
    }
}