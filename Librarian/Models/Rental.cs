using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Models
{
    public class Rental
    {
        [Key]
        public int RentalID { get; set; }

        [Display(Name = "Rental date")]
        public DateTime RentalDate { get; set; }

        [Display(Name = "Return date")]
        public DateTime ReturnDate { get; set; }
    }
}
