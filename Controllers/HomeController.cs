using _19_07_2023_task1.Models;
using _19_07_2023_task1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace _19_07_2023_task1.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly string _baseUrl = "https://wl-api.mf.gov.pl/api/search/nip/";

		private static HttpClient _httpClient = new HttpClient();

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
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
		public async Task<IActionResult> Search(SearchViewModel model)
		{
			if (ModelState.IsValid)
			{
				var currentDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
                _httpClient.BaseAddress = new Uri(_baseUrl);
				_httpClient.DefaultRequestHeaders.Clear();
				//var res = await _httpClient.GetAsync("https://catfact.ninja/fact");
				var sth = await _httpClient.GetAsync("https://wl-api.mf.gov.pl/api/search/nip/8971829834?date=2023-07-19");
                var response1 = await _httpClient.GetAsync($"{_baseUrl}{model.Nip}?date={currentDate}");
				var response2 = await _httpClient.GetFromJsonAsync<Root>($"{_baseUrl}{model.Nip}?date={currentDate}");
				return View(response2);
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