using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Auxiliar;

namespace UWP.Model
{
    public class Clasificacion : NotifyBase
    {
        private int clasificacionId;
        private string descripcion;

        public int ClasificacionId { 
            get => clasificacionId; 
            set {clasificacionId = value; NotificarCambio("ClasificacionId"); } 
        }
        public string Descripcion { 
            get => descripcion; 
            set { descripcion = value; NotificarCambio("Descripcion"); } 
        }
    }
}
