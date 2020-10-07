using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class LogicaEditorial
    {
        private static LogicaEditorial logicaEditorial;

        public static LogicaEditorial getInstance()
        {
            if (logicaEditorial == null)
                logicaEditorial = new LogicaEditorial();
            return logicaEditorial;
        }

        public List<Editorial> listadoEditorial()
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.EditorialSet.ToList();
            }

        }
        public void insertarEditorial(Editorial editorial)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.EditorialSet.Add(editorial);
                context.SaveChanges();
            }
        }

        public void borrarEditorial(Editorial editorial)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.Entry(editorial).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error. Editorial está siendo utilizada en un préstamo", ex);
                }
            }
        }

        public void editarEditorial(Editorial editorial)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.Entry(editorial).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Editorial getEditorial(Editorial editorial)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.EditorialSet.FirstOrDefault(x => x.EditorialId == editorial.EditorialId);
            }
        }
    }
}
