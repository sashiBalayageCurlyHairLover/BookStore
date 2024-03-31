using BookStore.Core.Models;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await _context.Books.Select(b => new BookViewModel()
            {
                AuthorName = b.Author.Name,
                BookId = b.BookId,
                ISBN = b.ISBN,
                Price = b.Price,
                Title = b.Title
            }).ToListAsync();

            return View(model);
        }
    }
}
