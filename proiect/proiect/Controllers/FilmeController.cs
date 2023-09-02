using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiect.Data;

namespace proiect.Controllers
{
    public class FilmeController : Controller
    {
        private readonly AppDbContext _context;
        public FilmeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allFilme= await _context.Filme.ToListAsync();
            return View();
        }
    }
}
