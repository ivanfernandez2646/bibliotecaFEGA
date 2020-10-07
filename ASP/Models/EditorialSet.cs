using System;
using System.Collections.Generic;

namespace ASPNET.Models
{
    public partial class EditorialSet
    {
        public EditorialSet()
        {
            LibroSet = new HashSet<LibroSet>();
        }

        public int EditorialId { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string CodigoPostal { get; set; }
        public string Provincia { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string PersonaContacto { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<LibroSet> LibroSet { get; set; }
    }
}
