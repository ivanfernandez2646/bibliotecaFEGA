using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class LogicaGenero
    {
        private static LogicaGenero logicaGenero;

        public static LogicaGenero getInstance()
        {
            if (logicaGenero == null)
                logicaGenero = new LogicaGenero();
            return logicaGenero;
        }

        public List<Genero> listadoGeneros()
        {

            using (var context = new BibliotecaContextContainer())
            {
                return context.GeneroSet.ToList();
            }
        }

        public void insertarGenero(Genero genero)
        {

            using (var context = new BibliotecaContextContainer())
            {
                context.GeneroSet.Add(genero);
                context.SaveChanges();
            }
        }

        public void borrarGenero(Genero genero)
        {

            using (var context = new BibliotecaContextContainer())
            {
                try
                {
                    context.Entry(genero).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error. Género está siendo utilizado en un préstamo", ex);
                }
            }
        }

        public void editarGenero(Genero genero)
        {

            using (var context = new BibliotecaContextContainer())
            {
                context.Entry(genero).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Genero getGenero(Genero genero)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.GeneroSet.FirstOrDefault(x => x.GeneroId == genero.GeneroId);
            }
        }
    }
}
