using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Diagnostics;
using System.Net.Mail;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var contributions = await GetGithubContributions();
            ViewData["GithubContributions"] = contributions;
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
        public async Task<int> GetGithubContributions()
        {
            using var client = new HttpClient();
            var url = $"https://github.com/users/Chatzo/contributions";
            var html = await client.GetStringAsync(url);

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var h2 = doc.DocumentNode.SelectSingleNode("//h2[@id='js-contribution-activity-description']");
            if (h2 != null)
            {
                // Extract just the number
                var text = h2.InnerText.Trim();
                var numberText = System.Text.RegularExpressions.Regex.Match(text, @"\d+").Value;
                if (int.TryParse(numberText, out int contributions))
                    return contributions;
            }

            return 0;
        }
    }
}
