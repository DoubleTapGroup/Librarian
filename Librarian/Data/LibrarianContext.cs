using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Models
{
    public class LibrarianContext : DbContext
    {
        public LibrarianContext (DbContextOptions<LibrarianContext> options)
            : base(options)
        {
        }

        public DbSet<Librarian.Models.Book> Book { get; set; }
		public DbSet<Librarian.Models.Rental> Rental { get; set; }
		public DbSet<Librarian.Models.User> User { get; set; }
	}
}
