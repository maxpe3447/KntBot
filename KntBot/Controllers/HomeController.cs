using Microsoft.AspNetCore.Mvc;

namespace KntBot.Controllers
{
    [Controller]
    public class HomeController :Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "message";

            return View();
            //Response.ContentType = "text/html;charset=utf-8";
            //await Response.SendFileAsync("testPage.html") ;
        }

        [HttpPost]
        public IActionResult Index(string name, int age)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testPage.html");
            return RedirectToAction(nameof(ShowPage));//$"{name}: {age}";
        }

        [HttpGet]
        public async Task ShowPage()
        {
            await Response.WriteAsync($"BaseDirectory: {AppDomain.CurrentDomain.BaseDirectory}\n" +
                                      $"Current dir: {Directory.GetCurrentDirectory()}");
        }

    }
}
