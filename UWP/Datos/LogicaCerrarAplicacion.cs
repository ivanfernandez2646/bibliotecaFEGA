using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Datos
{
    public class LogicaCerrarAplicacion
    {
        public static string getActualPasswordAdministrador()
        {
            //Construimos la query SQL
            const string GetPasswordQuery = "select Salt from UsuarioSet where DNI='12345678Z' ";

            string password = "";
            try
            {
                //Obtenemos la cadena de conexión
                var cadenaConex = (App.Current as App).ConnectionString;

                using (var conn = new SqlConnection(cadenaConex))
                {
                    //Abrimos la conexión a la base de datos
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            //Ejecutamos la consulta
                            cmd.CommandText = GetPasswordQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                //Leemos los datos y lo almacenamos en el modelo
                                while (reader.Read())
                                {
                                    password = reader.GetString(0);
                                }
                            }
                        }
                    }
                }
                return password;
            }
            catch (Exception eSql)
            {
                throw new Exception("Exception: " + eSql.Message);
            }
        }

        public static string getPassword(string dni, string pass)
        {
            HashAlgorithm hash = new SHA512Managed();
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(dni + pass);
            byte[] hashBytes = hash.ComputeHash(plainTextBytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
