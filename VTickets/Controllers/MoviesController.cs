using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VTickets.Data;

namespace VTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MoviesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _db.Movies.Include(n=>n.Cinema)
                .OrderBy(m=>m.Name).ToListAsync();
            return View(movies);
        }
    }
}