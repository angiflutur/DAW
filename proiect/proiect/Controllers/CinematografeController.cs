using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiect.Data;

namespace proiect.Controllers
{
    public class CinematografeController : Controller
    {
        private readonly AppDbContext _context;
        public CinematografeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinematografe = await _context.Cinematografe.ToListAsync();
            return View();
        }
    }
}
