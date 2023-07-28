using _19_07_2023_task1.Services.Interfaces;
using _19_07_2023_task1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _19_07_2023_task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaxSubjectsApiCaller _subjectApiCaller;

        public HomeController(ITaxSubjectsApiCaller subjectsApiCaller)
        {
            _subjectApiCaller = subjectsApiCaller;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(SearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                model = _subjectApiCaller.GetTaxSubjectByTINAsync(model).Result;

                return View(model);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}