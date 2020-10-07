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
    public class ClasificacionPageViewModel
    {

        private ObservableCollection<Clasificacion> clasificaciones;

        public ClasificacionPageViewModel() {
            Clasificaciones = LogicaClasificacion.getInstance().getClasificaciones();
        }

        public ObservableCollection<Clasificacion> Clasificaciones { get => clasificaciones; set => clasificaciones = value; }
    }
}
