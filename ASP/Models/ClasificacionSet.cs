using System;
using System.Collections.Generic;

namespace ASPNET.Models
{
    public partial class ClasificacionSet
    {
        public ClasificacionSet()
        {
            LibroSet = new HashSet<LibroSet>();
        }

        public int ClasificacionId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<LibroSet> LibroSet { get; set; }
    }
}
