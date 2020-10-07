using System;
using System.Collections.Generic;

namespace ASPNET.Models
{
    public partial class AutorSet
    {
        public AutorSet()
        {
            LibroSet = new HashSet<LibroSet>();
        }

        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public virtual ICollection<LibroSet> LibroSet { get; set; }
    }
}
