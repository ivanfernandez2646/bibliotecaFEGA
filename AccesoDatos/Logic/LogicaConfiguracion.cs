using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class LogicaConfiguracion
    {

        private static LogicaConfiguracion logicaConfiguracion;

        public static LogicaConfiguracion getInstance()
        {
            if (logicaConfiguracion == null)
                logicaConfiguracion = new LogicaConfiguracion();
            return logicaConfiguracion;
        }

        public Configuracion getConfiguracion()
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.ConfiguracionSet.ToList().FirstOrDefault();
            }

        }
        public void insertarConfiguracion(Configuracion configuracion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.ConfiguracionSet.Add(configuracion);
                context.SaveChanges();
            }
        }

        public void borrarConfiguracion(Configuracion configuracion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.Entry(configuracion).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void editarConfiguracion(Configuracion configuracion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.Entry(configuracion).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
