using Microsoft.AspNetCore.Mvc;
using SKCatalog.Models;

namespace SKCatalog.Controllers
{
    public class SKClassesController : Controller
    {
        private SKCatalogContext context { get; set; }

        public SKClassesController(SKCatalogContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index()
        {
            var classes = context.SKClasses.ToList();
            return View(classes);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new SKClass());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var skClass = context.SKClasses.Find(id);
            return View("AddEdit", skClass);
        }

        [HttpPost]
        public IActionResult Edit(SKClass skClass)
        {
            if (ModelState.IsValid)
            {
                if (skClass.CourseId == 0)
                    context.SKClasses.Add(skClass);
                else
                    context.SKClasses.Update(skClass);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Action = (skClass.CourseId == 0) ? "Add" : "Edit";
                return View("AddEdit", skClass);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var skClass = context.SKClasses.Find(id);
            return View(skClass);
        }

        [HttpPost]
        public IActionResult Delete(SKClass skClass)
        {
            context.SKClasses.Remove(skClass);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
