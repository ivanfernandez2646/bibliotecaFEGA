using ASPNET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET.ViewModel
{
    public class VMLibro
    {
        private LibroSet libroSeleccionado;
        private List<LibroSet> librosMismoAutor;

        public LibroSet LibroSeleccionado { get => libroSeleccionado; set => libroSeleccionado = value; }
        public List<LibroSet> LibrosMismoAutor { get => librosMismoAutor; set => librosMismoAutor = value; }
    }
}
