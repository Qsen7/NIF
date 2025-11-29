using CatWeb.Data;
using CatWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatWeb.Controllers
{
    public class CatsController : Controller
    {
        private CatContext context;
        public CatsController(CatContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Add(Cat model)
        {
            if(this.ModelState.IsValid)
            {
                var cat = new Cat
                {
                    Age = model.Age,
                    Breed = model.Breed,
                    ImageUrl = model.ImageUrl,
                    Name = model.Name
                };
                this.context.Cats.Add(cat);
                this.context.SaveChanges();
                return RedirectToAction("Details", "Cats", new { id = cat.ID });
            }
            return this.View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var cat = context.Cats.Find(id);
            if(cat != null)
            {
                var model = new Cat
                {
                    Name = cat.Name,
                    Breed = cat.Breed,
                    ImageUrl = cat.ImageUrl,
                    Age = cat.Age
                };

                return this.View(model);
            }
            return NotFound();
        }
    }
}
