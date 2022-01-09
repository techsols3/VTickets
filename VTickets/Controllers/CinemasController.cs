using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VTickets.Data;

namespace VTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CinemasController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var cinemas = await _db.Cinemas.ToListAsync();
            return View(cinemas);
        }
    }
}
