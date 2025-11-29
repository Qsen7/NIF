using System.Diagnostics;
using CatWeb.Data;
using CatWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatWeb.Controllers
{
    public class HomeController : Controller
    {
        private CatContext _context;
        public HomeController(CatContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var cats = this._context.Cats.Select(e => new Cat()
            {
                ID = e.ID,
                Name = e.Name
            }).ToList();
            return View(cats);
        }
    }
}