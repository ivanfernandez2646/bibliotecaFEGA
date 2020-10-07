using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Datos
{
    public class LogicaGenero
    {
        private LogicaGenero()
        {
        }

        private static LogicaGenero logicaGenero = null;
        public static LogicaGenero getInstance()
        {
            if (logicaGenero == null)
                logicaGenero = new LogicaGenero();
            return logicaGenero;
        }

        public ObservableCollection<Model.Genero> getGeneros()
        {
            
            const string GetGenerosQuery = "select GeneroId, Descripcion from GeneroSet ";

            var generos = new ObservableCollection<Model.Genero>();
            try
            {
                var cadenaConex = (App.Current as App).ConnectionString;

                using (var conn = new SqlConnection(cadenaConex))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetGenerosQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                var generoInicial = new Model.Genero();
                                generoInicial.GeneroId = -1;
                                generoInicial.Descripcion = "Todos los libros";
                                generos.Add(generoInicial);

                                while (reader.Read())
                                {
                                    var genero = new Model.Genero();
                                    genero.GeneroId = reader.GetInt32(0);
                                    genero.Descripcion = reader.GetString(1);
                                    generos.Add(genero);
                                }
                            }
                        }
                    }
                }
                return generos;
            }
            catch (Exception eSql)
            {
                throw new Exception("Exception: " + eSql.Message);
            }
        }
    }
}
