using MenaxhimBibliotekeMvcApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MenaxhimBibliotekeMvcApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly AppDbContex _context;

        public ClientController(AppDbContex context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var getClients = await _context.Clients.ToListAsync();
            return View(getClients);
        }
    }
}
