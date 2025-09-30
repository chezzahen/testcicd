using Microsoft.AspNetCore.Mvc;
using TestCiCd.Models;

namespace TestCiCd.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // This will be "api/books"
    public class BooksController : ControllerBase
    {
        [HttpGet("GetBooks")]
        public ActionResult<List<BookItem>> GetBooks()
        {
            var books = new List<Book>
        {
            new Book { Id = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien" },
            new Book { Id = 2, Title = "1984", Author = "George Orwell" },
            new Book { Id = 3, Title = "Clean Code", Author = "Robert C. Martin" }
        };

            return Ok(books);
        }
    }
}
