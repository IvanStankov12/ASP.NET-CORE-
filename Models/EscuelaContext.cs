using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace platzi_asp_net_core.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Avd Siempre viva";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            //Cargar Cursos
            var cursos = CargarCursos(escuela);
            // x cada curso cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);
            //x cada curso cargar alumnos
            var alumnos = CargarAlumnos(cursos);
            //x cada Evaluacion carga Alumnos y asignaturas

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());

        }

        
            private List<Alumno> CargarAlumnos(List<Curso> cursos)
            {
                var listaAlumnos = new List<Alumno>();
                Random rnd = new Random();
                foreach (var curso in cursos)
                {
                    int cantRandom = rnd.Next(5, 20);
                    var temp = GenerarAlumnosAlAzar(curso, cantRandom);
                    listaAlumnos.AddRange(temp);

                }
                return listaAlumnos;
            }

            private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
            {
                var listaCompleta = new List<Asignatura>();

                foreach (var curso in cursos)
                {
                    var temp = new List<Asignatura>(){
                    new Asignatura{
                        Id = Guid.NewGuid().ToString(),
                        CursoId = curso.Id,
                        Nombre = "Matematicas"
                    },
                    new Asignatura{Id = Guid.NewGuid().ToString(),CursoId = curso.Id,Nombre = "Educacion Fisica"},
                    new Asignatura{Id = Guid.NewGuid().ToString(),CursoId = curso.Id,Nombre = "Castellano"},
                    new Asignatura{Id = Guid.NewGuid().ToString(),CursoId = curso.Id,Nombre = "Ciencias Naturales"},
                    new Asignatura{Id = Guid.NewGuid().ToString(),CursoId = curso.Id,Nombre = "Programacion"},
                };
                    listaCompleta.AddRange(temp);

                }
                return listaCompleta;
            }

            private static List<Curso> CargarCursos(Escuela escuela)
            {
                return new List<Curso>(){
                        new Curso() {
                            Id = Guid.NewGuid().ToString(),
                            EscuelaId = escuela.Id,
                            Nombre = "101",
                            Jornada = TiposJornada.Mañana },
                        new Curso() {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "201", Jornada = TiposJornada.Mañana},
                        new Curso() {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "301", Jornada = TiposJornada.Mañana},
                        new Curso() {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "401", Jornada = TiposJornada.Tarde },
                        new Curso() {Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "501", Jornada = TiposJornada.Tarde}
                        };
            }

            private List<Alumno> GenerarAlumnosAlAzar(
                Curso curso,
                int cantidad
            )
            {
                string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
                string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
                string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

                var listaAlumnos = from n1 in nombre1
                                   from n2 in nombre2
                                   from a1 in apellido1
                                   select new Alumno
                                   {
                                       Nombre = $"{n1} {n2} {a1}",
                                       CursoId = curso.Id,
                                       Id = Guid.NewGuid().ToString()
                                   };

                return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }
}
    