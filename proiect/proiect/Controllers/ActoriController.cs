using Microsoft.AspNetCore.Mvc;
using proiect.Data;

namespace proiect.Controllers
{
    public class ActoriController : Controller
    {
        private readonly AppDbContext _context;
        public ActoriController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actori.ToList();
            return View();
        }
    }
}
