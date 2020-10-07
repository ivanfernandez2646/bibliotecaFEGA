using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Auxiliar;
using Windows.UI.Xaml.Media;

namespace UWP.Model
{
    public class Libro : NotifyBase
    {
        private int libroId;
        private ImageSource imagen;
        private string titulo;
        private string descripcion;
        private string autor;
        private string descGeneroAndClasificacion;

        public int LibroId
        {
            get => libroId;
            set { libroId = value; NotificarCambio("LibroId"); }
        }
        public ImageSource Imagen { get => imagen; set { imagen = value; NotificarCambio("Imagen"); } }
        public string Titulo { get => titulo; set { titulo = value; NotificarCambio("Titulo"); } }
        public string Descripcion { get => descripcion; set { descripcion = value; NotificarCambio("Descripción"); } }
        public string Autor { get => autor; set { autor = value; NotificarCambio("Autor"); } }
        public string DescGeneroAndClasificacion
        {
            get => descGeneroAndClasificacion;
            set { descGeneroAndClasificacion = value; NotificarCambio("DescGeneroAndClasificacion"); }
        }
    }
}