using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Model;

namespace AccesoDatos.Logic
{
    public class LogicaPrestamo
    {
        private static LogicaPrestamo logicaPrestamo;

        public static LogicaPrestamo getInstance()
        {
            if (logicaPrestamo == null)
                logicaPrestamo = new LogicaPrestamo();
            return logicaPrestamo;
        }

        public List<Prestamo> listadoPrestamos()
        {

            using (var context = new BibliotecaContextContainer())
            {
                return context.PrestamoSet.Include("Usuario").Include("Libro").ToList();
            }
        }

        public void insertarPrestamo(Prestamo prestamo)
        {

            using (var context = new BibliotecaContextContainer())
            {
                context.PrestamoSet.Add(prestamo);
                context.SaveChanges();
            }
        }

        public void borrarPrestamo(Prestamo prestamo)
        {

            using (var context = new BibliotecaContextContainer())
            {
                context.Entry(prestamo).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void editarPrestamo(Prestamo prestamo)
        {

            using (var context = new BibliotecaContextContainer())
            {
                context.Entry(prestamo).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Prestamo getPrestamo(Prestamo prestamo)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.PrestamoSet.FirstOrDefault(x => x.PrestamoId == prestamo.PrestamoId);
            }
        }
    }
}
