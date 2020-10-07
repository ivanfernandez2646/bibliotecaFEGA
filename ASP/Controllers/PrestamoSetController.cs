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
    public class PrestamoSetController : Controller
    {
        private readonly ProyectoWinFormContext _context;

        public PrestamoSetController(ProyectoWinFormContext context)
        {
            _context = context;
        }

        // GET: PrestamoSet
        public async Task<IActionResult> Index()
        {
            string currentUser = User.Identity.Name;
            var proyectoWinFormContext = _context.PrestamoSet.Include(p => p.LibroLibro).Include(p => p.UsuarioDniNavigation).Where(p => p.UsuarioDniNavigation.Email == currentUser)
                .OrderByDescending(p => p.FechaDevolucion == null)
                    .ThenByDescending(p => p.FechaFin <= DateTime.Now);
            return View(await proyectoWinFormContext.ToListAsync());
        }
    }
}
