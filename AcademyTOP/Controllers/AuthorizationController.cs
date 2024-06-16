using AcademyTOP.DataAccessLayer;
using AcademyTOP.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;
using System.Text;

namespace AcademyTOP.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AuthorizationController(ApplicationDbContext contex)
        {
             _context = contex;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Authorization(Admin admin)
        {
            var request = _context.Database.
            var hashPassword = HashPassword(admin.Password);

            return View();
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
