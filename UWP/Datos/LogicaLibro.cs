using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace UWP.Datos
{
    public class LogicaLibro
    {

        public enum FiltroQuery { CLASIFICACIONES, GENEROS, SINFILTRO };

        private static LogicaLibro logicaLibro = null;

        private LogicaLibro() { }

        public static LogicaLibro getInstance()
        {
            if (logicaLibro == null)
                logicaLibro = new LogicaLibro();
            return logicaLibro;
        }
        public ObservableCollection<Model.Libro> getLibros(int id, FiltroQuery filtro)
        {
            //Construimos la query SQL

            string GetLibrosQuery = "";

            if (filtro == FiltroQuery.SINFILTRO || id == -1)
            {
                GetLibrosQuery = "select LibroId, Imagen, Titulo, Descripción, Nombre, Apellidos, ClasificacionSet.Descripcion, GeneroSet.Descripcion from LibroSet inner join AutorSet on AutorSet.AutorId = LibroSet.AutorAutorId inner join ClasificacionSet on ClasificacionSet.ClasificacionId = LibroSet.ClasificacionClasificacionId inner join GeneroSet on GeneroSet.GeneroId = LibroSet.GeneroGeneroId";
            }
            else if (filtro == FiltroQuery.CLASIFICACIONES)
            {
                GetLibrosQuery = "select LibroId, Imagen, Titulo, Descripción, Nombre, Apellidos, ClasificacionSet.Descripcion, GeneroSet.Descripcion from LibroSet inner join AutorSet on AutorSet.AutorId = LibroSet.AutorAutorId inner join ClasificacionSet on ClasificacionSet.ClasificacionId = LibroSet.ClasificacionClasificacionId inner join GeneroSet on GeneroSet.GeneroId = LibroSet.GeneroGeneroId where ClasificacionClasificacionId = " + id;
            }
            else if (filtro == FiltroQuery.GENEROS)
            {
                GetLibrosQuery = "select LibroId, Imagen, Titulo, Descripción, Nombre, Apellidos, ClasificacionSet.Descripcion, GeneroSet.Descripcion from LibroSet inner join AutorSet on AutorSet.AutorId = LibroSet.AutorAutorId inner join ClasificacionSet on ClasificacionSet.ClasificacionId = LibroSet.ClasificacionClasificacionId inner join GeneroSet on GeneroSet.GeneroId = LibroSet.GeneroGeneroId where GeneroGeneroId = " + id;
            }


            var libros = new ObservableCollection<Model.Libro>();
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
                            cmd.CommandText = GetLibrosQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                //Leemos los datos y lo almacenamos en el modelo
                                while (reader.Read())
                                {
                                    var libro = new Model.Libro();
                                    libro.LibroId = reader.GetInt32(0);
                                    libro.Imagen = this.LoadImageAsync((byte[])reader[1]);
                                    libro.Titulo = reader.GetString(2);
                                    libro.Descripcion = reader.GetString(3);
                                    libro.Autor = reader.GetString(5) + ", " + reader.GetString(4);
                                    libro.DescGeneroAndClasificacion = reader.GetString(7) + "-" + reader.GetString(6);
                                    //Añadimos el objeto a la lista
                                    libros.Add(libro);
                                }
                            }
                        }
                    }
                }
                return libros;
            }
            catch (Exception eSql)
            {
                throw new Exception("Exception: " + eSql.Message);
            }
        }

        private ImageSource LoadImageAsync(byte[] buffer)
        {
            using (InMemoryRandomAccessStream ms = new InMemoryRandomAccessStream())
            {
                // Writes the image byte array in an InMemoryRandomAccessStream
                // that is needed to set the source of BitmapImage.
                using (DataWriter writer = new DataWriter(ms.GetOutputStreamAt(0)))
                {
                    writer.WriteBytes(buffer);
                    //await writer.StoreAsync();
                    Task.FromResult(writer.StoreAsync());
                }

                var image = new BitmapImage();
                //await image.SetSourceAsync(ms);
                Task.FromResult(image.SetSourceAsync(ms));
                return image;
            }
        }

    }
}
