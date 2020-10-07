using System;
using System.Collections.Generic;

namespace ASPNET.Models
{
    public partial class ConfiguracionSet
    {
        public int ConfiguracionId { get; set; }
        public int? NumDiasPrestamo1 { get; set; }
        public int? NumDiasPrestamo2 { get; set; }
        public int? MaxPrestamoUsuario { get; set; }
    }
}
