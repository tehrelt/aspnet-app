using Amazing.Data;
using Amazing.Models;
using Amazing.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Amazing.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDataContext _context;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(UserDataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.Include(u => u.Posts).Select(u => new UserViewModel
            {
                UserName = u.UserName,
                Email = u.Email,
                Avatar = u.Avatar,
                PostsCount = u.Posts.Count()
            });
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Haha()
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