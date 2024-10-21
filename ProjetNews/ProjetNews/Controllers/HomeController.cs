using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetNews.Models;

namespace ProjetNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private WebContext _webContext;
        public HomeController(WebContext  webContext )
        {   
            _webContext = webContext;

        }

    

        public IActionResult Index()
        {
            var list = _webContext.Categories.ToList();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveContact(Contact contact)
        {
            _webContext.Contacts.Add(contact);
            _webContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Message()
        {
            var model = _webContext.Contacts.ToList();
            return View(model);
        }
        public IActionResult News(int ID)
        {
            var news = _webContext.Newss.Where(y=> y.CategorieId == ID).ToList();
            return View(news);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}