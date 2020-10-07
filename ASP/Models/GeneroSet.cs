using System;
using System.Collections.Generic;

namespace ASPNET.Models
{
    public partial class GeneroSet
    {
        public GeneroSet()
        {
            LibroSet = new HashSet<LibroSet>();
        }

        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<LibroSet> LibroSet { get; set; }
    }
}
