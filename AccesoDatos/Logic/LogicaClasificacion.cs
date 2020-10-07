using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class LogicaClasificacion
    {

        private static LogicaClasificacion logicaClasificacion;


        public static LogicaClasificacion getInstance()
        {
            if (logicaClasificacion == null)
                logicaClasificacion = new LogicaClasificacion();
            return logicaClasificacion;
        }

        public List<Clasificacion> listadoClasificaciones()
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.ClasificacionSet.ToList();
            }

        }
        public void insertarClasificacion(Clasificacion clasificacion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.ClasificacionSet.Add(clasificacion);
                context.SaveChanges();
            }
        }

        public void borrarClasificacion(Clasificacion clasificacion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.Entry(clasificacion).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error. Clasificación está siendo utilizada en un préstamo", ex);
                }
            }
        }

        public void editarClasificacion(Clasificacion clasificacion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.Entry(clasificacion).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Clasificacion getClasificacion(Clasificacion clasificacion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.ClasificacionSet.FirstOrDefault(x => x.ClasificacionId == clasificacion.ClasificacionId);
            }
        }
    }
}
