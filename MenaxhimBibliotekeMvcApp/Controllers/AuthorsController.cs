using MenaxhimBibliotekeMvcApp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MenaxhimBibliotekeMvcApp.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly AppDbContex _context;

        public AuthorsController(AppDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Authors.ToList();
            return View(data);
        }
    }
}
