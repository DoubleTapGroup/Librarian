using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Models
{
   public class UsersModel
   {
      public UsersModel()
      {

      }

      [Key]
      public int UserID { get; set; }

      [Display(Name = "First Name")]
      public string FisrtName { get; set; }

      [Display(Name = "Last Name")]
      public string LastName { get; set; }

      [Display(Name = "Phone Number")]
      public string PhoneNumber { get; set; }

      [Display(Name = "Email")]
      public string Email { get; set; }

      [Display(Name = "Adress")]
      public string Adress { get; set; }


      //[NotMapped]
      //public virtual ICollection<RentalEvidence> RentalEvidences { get; set; }
   }
}
