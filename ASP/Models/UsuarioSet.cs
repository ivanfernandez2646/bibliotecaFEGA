using System;
using System.Collections.Generic;

namespace ASPNET.Models
{
    public partial class UsuarioSet
    {
        public UsuarioSet()
        {
            PrestamoSet = new HashSet<PrestamoSet>();
        }

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string CodigoPostal { get; set; }
        public string Provincia { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public bool? InicioSesion { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }

        public virtual ICollection<PrestamoSet> PrestamoSet { get; set; }
    }
}
