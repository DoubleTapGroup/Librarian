using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Models
{
    public class Book
    {
        [Key]
		public int BookId { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

		public int AuthorId { get; set; }
		public Author Author { get; set; }

		public int PublisherId { get; set; }
		public Publisher Publisher { get; set; }
    }
}
