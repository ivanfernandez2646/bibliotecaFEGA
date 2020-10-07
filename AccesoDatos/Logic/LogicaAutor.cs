using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class LogicaAutor
    {
        private static LogicaAutor logicaAutor;


        public static LogicaAutor getInstance()
        {
            if (logicaAutor == null)
                logicaAutor = new LogicaAutor();
            return logicaAutor;
        }

        public List<Autor> listadoAutores()
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.AutorSet.ToList();
            }
        }

        public void insertarAutor(Autor autor)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.AutorSet.Add(autor);
                context.SaveChanges();
            }
        }

        public void borrarAutor(Autor autor)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.Entry(autor).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error. Autor está siendo utilizado en un préstamo", ex);
                }
            }
        }

        public void editarAutor(Autor autor)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.Entry(autor).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Autor getAutor(Autor autor)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.AutorSet.FirstOrDefault(x => x.AutorId == autor.AutorId);
            }
        }
    }
}
