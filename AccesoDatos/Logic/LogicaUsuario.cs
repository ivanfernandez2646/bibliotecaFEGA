using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class LogicaUsuario
    {
        private static LogicaUsuario logicaUsuario;


        public static LogicaUsuario getInstance()
        {
            if (logicaUsuario == null)
                logicaUsuario = new LogicaUsuario();
            return logicaUsuario;
        }

        public List<Usuario> listadoUsuario()
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.UsuarioSet.ToList();
            }

        }
        public void insertarUsuario(Usuario usuario)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.UsuarioSet.Add(usuario);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error. Usuario ya existe!!", ex);
                }
            }
        }

        public void borrarUsuario(Usuario usuario)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.Entry(usuario).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error. Usuario está siendo utilizada en un préstamo", ex);
                }
            }
        }

        public void editarUsuario(Usuario usuario)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Usuario getUsuario(Usuario usuario)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                return context.UsuarioSet.FirstOrDefault(x => x.DNI == usuario.DNI);
            }
        }
    }
}
