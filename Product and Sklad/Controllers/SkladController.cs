using Microsoft.AspNetCore.Mvc;
using Product_and_Sklad.Models;

namespace Product_and_Sklad.Controllers
{
    public class SkladController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var context = new ProductContext())
            {
                List<Sklad> skladove = context.Skladove.ToList();
                return View(skladove);
            }
        }
        [HttpGet]

        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(Sklad model)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ProductContext())
                {
                    Sklad sklad = new Sklad();
                    sklad.Name = model.Name;
                    sklad.Address = model.Address;
                    context.Skladove.Add(sklad);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Sklad");
                }
            }
            return this.View();
        }
    }
}

