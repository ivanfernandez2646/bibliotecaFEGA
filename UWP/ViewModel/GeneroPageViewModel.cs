using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Datos;
using UWP.Model;

namespace UWP.ViewModel
{
    public class GeneroPageViewModel
    {

        private ObservableCollection<Model.Genero> generos;

        public GeneroPageViewModel()
        {
            Generos = LogicaGenero.getInstance().getGeneros();
        }

        public ObservableCollection<Genero> Generos { get => generos; set => generos = value; }
    }
}
