using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Auxiliar;

namespace UWP.Model
{
    public class Genero : NotifyBase
    {

        private int generoId;
        private string descripcion;

        public int GeneroId
        {
            get => generoId;
            set { generoId = value; NotificarCambio("GeneroId"); }
        }

        public string Descripcion
        {
            get => descripcion;
            set { descripcion = value; NotificarCambio("Descripcion"); }
        }
    }
}
