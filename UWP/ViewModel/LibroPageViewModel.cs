using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Auxiliar;
using UWP.Datos;
using UWP.Model;

namespace UWP.ViewModel
{
    public class LibroPageViewModel : NotifyBase
    {

        private ObservableCollection<Model.Libro> libros;
        private String textoFiltro;

        public LibroPageViewModel(Object objetoFiltro)
        {
            if (objetoFiltro.GetType() == typeof(Clasificacion))
            {
                int idClasificacion = ((Clasificacion)objetoFiltro).ClasificacionId;

                if (idClasificacion == -1)
                {
                    textoFiltro = "Todos los libros";
                }
                else
                {
                    textoFiltro = "Libros clasificados para " + ((Clasificacion)objetoFiltro).Descripcion;
                }
                libros = LogicaLibro.getInstance().getLibros(((Clasificacion)objetoFiltro).ClasificacionId, LogicaLibro.FiltroQuery.CLASIFICACIONES);
            }
            else if (objetoFiltro.GetType() == typeof(Genero))
            {
                int idGenero = ((Genero)objetoFiltro).GeneroId;

                if (idGenero == -1)
                {
                    textoFiltro = "Todos los libros";
                }
                else
                {
                    textoFiltro = "Libros del género " + ((Genero)objetoFiltro).Descripcion;
                }
                libros = LogicaLibro.getInstance().getLibros(((Genero)objetoFiltro).GeneroId, LogicaLibro.FiltroQuery.GENEROS);
            }
            else
            {
                textoFiltro = "Todos los libros";
                libros = LogicaLibro.getInstance().getLibros(-1,LogicaLibro.FiltroQuery.SINFILTRO);
            }
        }

        public ObservableCollection<Libro> Libros { get => libros; set => libros = value; }
        public string TextoFiltro
        {
            get => textoFiltro;
            set { textoFiltro = value; NotificarCambio("TextoFiltro"); }
        }
    }
}
