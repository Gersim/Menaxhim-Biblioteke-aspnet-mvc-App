using MenaxhimBibliotekeMvcApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MenaxhimBibliotekeMvcApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContex _context;

        public BooksController(AppDbContex context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var getBooks = await _context.Books.ToListAsync();
            return View(getBooks);
        }
    }
}
