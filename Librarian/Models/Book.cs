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
        public int ID { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "AuthorID")]
        public string AuthorID { get; set; }

        [Display(Name = "PublisherID")]
        public string PublisherID { get; set; }
    }
}
