using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNET.Models
{
    public partial class PrestamoSet
    {
        public int PrestamoId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Fecha Préstamo")]
        public DateTime FechaInicio { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Fecha Máx. Dev.")]
        public DateTime FechaFin { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Fecha Devolución")]
        public DateTime? FechaDevolucion { get; set; }
        public string UsuarioDni { get; set; }
        public int LibroLibroId { get; set; }

        public virtual LibroSet LibroLibro { get; set; }
        public virtual UsuarioSet UsuarioDniNavigation { get; set; }
    }
}
