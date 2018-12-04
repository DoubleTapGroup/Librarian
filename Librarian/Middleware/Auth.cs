using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Middleware
{
	public class Auth
	{
		public HttpContext Context { get; set; }

		public Auth(HttpContext context) => Context = context;

		public bool IsAuthenticated() => Context.Session?.GetInt32("auth:user") != null;

		public void SetUser(int userId) => Context.Session?.SetInt32("auth:user", userId);
	}
}
