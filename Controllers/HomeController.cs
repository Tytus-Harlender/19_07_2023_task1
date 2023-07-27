using _19_07_2023_task1.Interfaces;
using _19_07_2023_task1.Models;
using _19_07_2023_task1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace _19_07_2023_task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITaxSubjectsApiCaller _subjectApiCaller;

        private readonly string _baseUrl = "https://wl-test.mf.gov.pl/api/search/nip/";

        private static HttpClient _httpClient = new HttpClient();

        public HomeController(ILogger<HomeController> logger, ITaxSubjectsApiCaller subjectsApiCaller)
        {
            _logger = logger;
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