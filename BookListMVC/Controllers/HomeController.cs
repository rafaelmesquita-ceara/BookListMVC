using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookListMVC.Models;

namespace BookListMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public User User { get; set; }
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? id)
        {
            return View();
        }

        #region API CALLS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index()
        {
            var query = _db.Users
                       .Where(s => s.CH_Login == User.CH_Login && s.CH_Password == User.CH_Password)
                       .FirstOrDefault();

            if (query != null)
            {
                ViewBag.Msg = "success";
                return RedirectToAction("Index", "Books", new { area = "" });
            }
            else
            {
                ViewBag.Msg = "fail";
                return View("Index");

            }
        }
        #endregion


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
