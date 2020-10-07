using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNET.Data;
using ASPNET.Models;

namespace ASPNET.Controllers
{
    public class LibroSetController : Controller
    {
        private readonly ProyectoWinFormContext _context;

        public LibroSetController(ProyectoWinFormContext context)
        {
            _context = context;
        }

        // GET: LibroSet
        public async Task<IActionResult> Index(int? clasificacionId, int? generoId)
        {
            ViewData["ClasificacionId"] = new SelectList(_context.ClasificacionSet, "ClasificacionId", "Descripcion", clasificacionId);
            ViewData["GeneroId"] = new SelectList(_context.GeneroSet, "GeneroId", "Descripcion", generoId);

            if(clasificacionId == -1)
            {
                clasificacionId = null;
            }

            if(generoId == -1)
            {
                generoId = null;
            }

            if(clasificacionId != null && generoId != null)
            {
                var proyectoWinFormFiltradoTotal = _context.LibroSet.Include(l => l.AutorAutor).Include(l => l.ClasificacionClasificacion).Include(l => l.EditorialEditorial).Include(l => l.GeneroGenero)
                                                .Where((libro) => libro.ClasificacionClasificacionId == clasificacionId && libro.GeneroGeneroId == generoId);
                return View(await proyectoWinFormFiltradoTotal.ToListAsync());
            }
            else if(clasificacionId != null)
            {
                var proyectoWinFormFiltradoClasificacion = _context.LibroSet.Include(l => l.AutorAutor).Include(l => l.ClasificacionClasificacion).Include(l => l.EditorialEditorial).Include(l => l.GeneroGenero)
                                                .Where((libro) => libro.ClasificacionClasificacionId == clasificacionId);
                return View(await proyectoWinFormFiltradoClasificacion.ToListAsync());
            }else if (generoId != null)
            {
                var proyectoWinFormFiltradoGenero = _context.LibroSet.Include(l => l.AutorAutor).Include(l => l.ClasificacionClasificacion).Include(l => l.EditorialEditorial).Include(l => l.GeneroGenero)
                                                .Where((libro) => libro.GeneroGeneroId == generoId);
                return View(await proyectoWinFormFiltradoGenero.ToListAsync());
            }

                var proyectoWinFormContext = _context.LibroSet.Include(l => l.AutorAutor).Include(l => l.ClasificacionClasificacion).Include(l => l.EditorialEditorial).Include(l => l.GeneroGenero);
            return View(await proyectoWinFormContext.ToListAsync());
        }

        // GET: LibroSet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewModel.VMLibro vmLibro = new ViewModel.VMLibro();

            var libroSeleccionado = await _context.LibroSet
                .Include(l => l.AutorAutor)
                .Include(l => l.ClasificacionClasificacion)
                .Include(l => l.EditorialEditorial)
                .Include(l => l.GeneroGenero)
                .FirstOrDefaultAsync(m => m.LibroId == id);

            vmLibro.LibroSeleccionado = libroSeleccionado;

            List<LibroSet> librosMismoAutor = _context.LibroSet
                .Include(l => l.AutorAutor)
                .Include(l => l.ClasificacionClasificacion)
                .Include(l => l.EditorialEditorial)
                .Include(l => l.GeneroGenero)
                .Where(l => l.LibroId != libroSeleccionado.LibroId && l.AutorAutorId == libroSeleccionado.AutorAutorId)
                .ToList();
            
            vmLibro.LibrosMismoAutor = librosMismoAutor;

            if (libroSeleccionado == null)
            {
                return NotFound();
            }

            return View(vmLibro);
        }
    }
}
