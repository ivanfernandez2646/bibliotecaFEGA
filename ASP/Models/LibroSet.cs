using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNET.Models
{
    public partial class LibroSet
    {
        public LibroSet()
        {
            PrestamoSet = new HashSet<PrestamoSet>();
        }

        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Descripción { get; set; }
        public int? Stock { get; set; }
        public int? StockDisponible { get; set; }
        public byte[] Imagen { get; set; }


        public int AutorAutorId { get; set; }
        public int ClasificacionClasificacionId { get; set; }
        public int GeneroGeneroId { get; set; }
        public int EditorialEditorialId { get; set; }


        [Display(Name = "Autor")]
        public virtual AutorSet AutorAutor { get; set; }
        [Display(Name = "Clasificación")]
        public virtual ClasificacionSet ClasificacionClasificacion { get; set; }
        public virtual EditorialSet EditorialEditorial { get; set; }
        [Display(Name = "Género")]
        public virtual GeneroSet GeneroGenero { get; set; }
        public virtual ICollection<PrestamoSet> PrestamoSet { get; set; }
        public string DescripcionCorta
        {
            get
            {
                if (Descripción.Length > 20)
                {
                    return Descripción.Substring(0, 20) + "...";
                }
                return Descripción.Substring(0, Descripción.Length) + "...";
            }
        }
        public string NombreCompletoAutor
        {
            get
            {
                return AutorAutor.Apellidos + ", " + AutorAutor.Nombre;
            }
        }
    }
}
