using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Models
{
    public class Rental
    {
        [Key]
		public int RentalId { get; set; }

        [Display(Name = "Rental date")]
        public DateTime RentalDate { get; set; }

        [Display(Name = "Return date")]
        public DateTime? ReturnDate { get; set; }

		public int BookId { get; set; }
		public Book Book { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
    }
}
