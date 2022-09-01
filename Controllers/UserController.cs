using MarvelMVC.DatabaseContext;
using MarvelMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var user = _context.UserDataTable.ToList();
            return View(user);
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(UserData user)
        {
            if (ModelState.IsValid)
            {
                await _context.UserDataTable.AddAsync(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
