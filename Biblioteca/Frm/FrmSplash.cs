using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Logic;
using System.Windows.Forms;
using AccesoDatos.Model;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Xml;

namespace Biblioteca.Frm
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void runSqlScriptFile(string connectionString, string scriptPath)
        {
            try
            {
                string script = File.ReadAllText(@scriptPath);

                // split script on GO command
                System.Collections.Generic.IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                         RegexOptions.Multiline | RegexOptions.IgnoreCase);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (string commandString in commandStrings)
                    {
                        if (commandString.Trim() != "")
                        {
                            using (var command = new SqlCommand(commandString, connection))
                            {
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (SqlException ex)
                                {
                                    //ESTAS EXCEPCIONES DAN CUANDO YA EXISTE LA BBDD HAY QUE CONTROLARLO
                                    //SIGUE DANDO EL ERROR AÚN CON LA NUEVA FORMA, LO DEJAMOS ASÍ
                                    //MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarClasificaciones()
        {
            List<Clasificacion> tClasificaciones = LogicaClasificacion.getInstance().listadoClasificaciones();


            if (tClasificaciones.Count() == 0)
            {

                Clasificacion c = new Clasificacion();
                c.Descripcion = "Todos los públicos";
                LogicaClasificacion.getInstance().insertarClasificacion(c);

                c = new Clasificacion();
                c.Descripcion = "Entre 1 y 3 años";
                LogicaClasificacion.getInstance().insertarClasificacion(c);

                c = new Clasificacion();
                c.Descripcion = "Entre 4 y 5 años";
                LogicaClasificacion.getInstance().insertarClasificacion(c);

                c = new Clasificacion();
                c.Descripcion = "Entre 6 y 10 años";
                LogicaClasificacion.getInstance().insertarClasificacion(c);

                c = new Clasificacion();
                c.Descripcion = "Entre 11 y 16 años";
                LogicaClasificacion.getInstance().insertarClasificacion(c);

                c = new Clasificacion();
                c.Descripcion = "Entre 17 y 18 años";
                LogicaClasificacion.getInstance().insertarClasificacion(c);
            }
        }

        private void cargarUsuario()
        {
            List<Usuario> tUsuarios = LogicaUsuario.getInstance().listadoUsuario();


            if (tUsuarios.Count() == 0)
            {
                Usuario u = new Usuario();
                u.DNI = "12345678Z";
                u.Nombre = "Administrador";
                u.Apellidos = "Administrador";
                u.Direccion = "C/ Tres Ministros";
                u.Poblacion = "Bullas";
                u.CodigoPostal = "30180";
                u.Provincia = "Murcia";
                u.Telefono1 = "657485625";
                u.InicioSesion = true;
                u.Salt = Password.getPassword(u.DNI, "123456");
                LogicaUsuario.getInstance().insertarUsuario(u);
            }
        }

        private void cargarGeneros()
        {
            List<Genero> tGeneros = LogicaGenero.getInstance().listadoGeneros();


            if (tGeneros.Count() == 0)
            {
                Genero gen = new Genero();
                gen.Descripcion = "Acción";
                LogicaGenero.getInstance().insertarGenero(gen);

                gen = new Genero();
                gen.Descripcion = "Cuentos infantiles";
                LogicaGenero.getInstance().insertarGenero(gen);

                gen = new Genero();
                gen.Descripcion = "Policiaca";
                LogicaGenero.getInstance().insertarGenero(gen);

                gen = new Genero();
                gen.Descripcion = "Romántica";
                LogicaGenero.getInstance().insertarGenero(gen);
            }
        }

        private void cargarConfiguracion()
        {
            Configuracion config = AccesoDatos.Logic.LogicaConfiguracion.getInstance().getConfiguracion();

            if (config == null)
            {
                config = new Configuracion();
                config.NumDiasPrestamo1 = 15;
                config.NumDiasPrestamo2 = 30;
                config.MaxPrestamoUsuario = 3;
                LogicaConfiguracion.getInstance().insertarConfiguracion(config);
            }
        }

        private async void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            await Task.Run(() =>
            {
                string sqlConnectionString = null;
                string scriptPath = null;
                string bibliotecaContext = null;

                ConnectionStringSettingsCollection connection = ConfigurationManager.ConnectionStrings;

                foreach(ConnectionStringSettings item in connection)
                {
                    if (item.Name.Equals("BibliotecaContextContainer"))
                    {
                        bibliotecaContext = item.ConnectionString;
                    }
                    if (item.Name.Equals("BBDD")) {
                        sqlConnectionString = item.ConnectionString;                    
                    }
                    if (item.Name.Equals("sql"))
                    {
                        scriptPath = item.ConnectionString;
                    }
                }
                if (!comprobarConexionBBDD(bibliotecaContext))
                {
                    runSqlScriptFile(sqlConnectionString, scriptPath);
                }
                cargarClasificaciones();
                cargarUsuario();
                cargarGeneros();
                cargarConfiguracion();

                Thread.Sleep(1000);
            });
            this.Close();
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pbProgreso.Value < pbProgreso.Maximum)
            {
                pbProgreso.Value = pbProgreso.Value + 20;
            }
            else
            {
                pbProgreso.Value = 0;
            }
        }

        private bool comprobarConexionBBDD(String sql)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql))
                {
                    connection.Open();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
