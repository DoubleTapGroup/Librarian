using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Librarian.Middleware;
using Librarian.Models;
using Microsoft.AspNetCore.Mvc;

namespace Librarian.Controllers
{
    public class HomeController : Controller
    {
		private readonly LibrarianContext _context;

		public HomeController(LibrarianContext context)
		{
			_context = context;
		}

		[HttpPost]
		[Route("/signin")]
		public IActionResult Signin([Bind("Email, Password")] User user)
		{
			var auth = new Auth(HttpContext);

			var model = _context.User
				.Where(x => x.Email == user.Email && x.Password == user.Password && x.Rank == "admin")
				.SingleOrDefault();

			if(model != null)
			{
				auth.SetUser(model.UserId);
			}

			return Redirect("/");
		}

		[HttpGet]
		[Route("/login")]
		public IActionResult Login()
		{
			return View();
		}

		public IActionResult Index()
        {
            return View();
        }
    }
}