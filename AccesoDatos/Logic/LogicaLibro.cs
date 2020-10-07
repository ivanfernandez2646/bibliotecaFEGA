using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class LogicaLibro
    {
        private static LogicaLibro logicaLibro;

        public static LogicaLibro getInstance()
        {
            if (logicaLibro == null)
                logicaLibro = new LogicaLibro();
            return logicaLibro;
        }

        public List<Libro> listadoLibros()
        {

            using (var context = new BibliotecaContextContainer())
            {
                return context.LibroSet.ToList();
            }
        }

        public void insertarLibro(Libro libro)
        {

            using (var context = new BibliotecaContextContainer())
            {
                context.LibroSet.Add(libro);
                context.SaveChanges();
            }
        }

        public void borrarLibro(Libro libro)
        {

            using (var context = new BibliotecaContextContainer())
            {
                try
                {
                    context.Entry(libro).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error. Libro está siendo utilizado en un préstamo");
                }
            }
        }

        public void editarLibro(Libro libro)
        {

            using (var context = new BibliotecaContextContainer())
            {
                context.Entry(libro).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Libro getLibro(Libro libro)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.LibroSet.FirstOrDefault(x => x.LibroId == libro.LibroId);
            }
        }
    }
}
