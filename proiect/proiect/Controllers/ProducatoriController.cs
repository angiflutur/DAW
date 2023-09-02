using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiect.Data;

namespace proiect.Controllers
{

    public class ProducatoriController : Controller
    {
        private readonly AppDbContext _context;
        public ProducatoriController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducatori = await _context.Producatori.ToListAsync();
            return View();
        }
    }
}
