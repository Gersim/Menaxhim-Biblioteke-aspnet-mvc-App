using MenaxhimBibliotekeMvcApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MenaxhimBibliotekeMvcApp.Controllers
{
    public class ContratsController : Controller
    {
        private readonly AppDbContex _context;

        public ContratsController(AppDbContex context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var getContrats = await _context.Contracts.ToListAsync();
            return View(getContrats);
        }
    }
}
