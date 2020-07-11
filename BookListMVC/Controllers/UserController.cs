using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookListMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public User User{ get; set; }
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(int? id)
        {
            var count = _db.Users.Count();
            ViewBag.Msg = count.ToString();
            return View();
        }


        #region API CALLS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            //create
            _db.Users.Add(User);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

    }
}