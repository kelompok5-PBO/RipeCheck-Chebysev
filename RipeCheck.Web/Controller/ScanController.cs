using Microsoft.AspNetCore.Mvc;
using RipeCheck.Web.Models;

namespace RipeCheck.Web.Controllers
{
    public class ScanController : Controller
    {
        public IActionResult Index()
        {
            // Polymorphism: tipe interface, objek konkret
            IClassifier classifier = new MobileNetClassifier();

            var repo = new ResultRepository<Fruit>();
            repo.Add(classifier.Classify("pisang1.jpg"));
            repo.Add(new Tomato("mentah", 0.81));
            repo.Add(new Banana("busuk", 0.95));
            repo.Add(new Banana("matang", 0.88));

            ViewBag.Results = repo.GetAll();
            ViewBag.Counts = repo.CountByRipeness();
            ViewBag.MatangCount = repo.Filter(f => f.Ripeness == "matang").Count;

            return View();
        }
    }
}