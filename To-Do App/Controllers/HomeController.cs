using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using To_Do_App.Data;
using To_Do_App.Models;

namespace To_Do_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        TodoDbContext _todoDbContext;

        public HomeController(ILogger<HomeController> logger, TodoDbContext todoDbContext)
        {
            _todoDbContext = todoDbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Todo> list = _todoDbContext.Todo.Where(c => c.IsCompleted == false).ToList();
            ViewBag.TodoList = list;
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