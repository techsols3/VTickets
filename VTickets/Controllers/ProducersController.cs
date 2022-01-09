using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VTickets.Data;

namespace VTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProducersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var producers = await _db.Producers.ToListAsync();
            return View(producers);
        }
    }
}
