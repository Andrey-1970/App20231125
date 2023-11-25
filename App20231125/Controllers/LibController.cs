using App20231125.DataModels;
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
            var users = context.Users.Include("Roles");
            return View(users);
        }
        public IActionResult Index2()
        {
            var shelfs = context.Shelfs.Include("Book2Shelfs");
            return View(shelfs);
        }
    }
}
