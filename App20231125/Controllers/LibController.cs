using App20231125.DataModels;
using App20231125.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App20231125.Controllers
{
    public class LibController : Controller
    {
        private readonly MyDBContext context;

        public LibController(MyDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var users = context.Users;
            return View(users);
        }
        public IActionResult Index2()
        {
            var shelfs = context.Shelfs;
            return View(shelfs);
        }
        public IActionResult Details(int id)
        {
            var data = new ShelfDetailViewModel
            {
                Shelf = context.Shelfs.FirstOrDefault(x => x.Id == id),
                Books = context.Books.Where(x => !x.Book2Shelfs.Select(y => y.BookId).Contains(x.Id))
            };
            return View(data);
        }
        public IActionResult RemoveBook(int id)
        {
            var book2Shelf = context.Books2Shelfs.FirstOrDefault(x => x.Id == id);
            context.Books2Shelfs.Remove(book2Shelf!);
            context.SaveChanges();
            return Redirect($"/Lib/Details/{book2Shelf!.ShelfId}");
        }
        public IActionResult AddBook(int id, int shelfId)
        {
            var book2Shelf = new Book2Shelf { BookId = id, ShelfId = shelfId };
            context.Books2Shelfs.Add(book2Shelf!);
            context.SaveChanges();
            return Redirect($"/Lib/Details/{shelfId}");
        }
    }
}
