using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }

		[Display(Name = "Email")]
		public string Email { get; set; }

		[Display(Name = "Address")]
		public string Address { get; set; }

		[NotMapped]
		public string Name { get => FirstName + " " + LastName; set => Name = value; }
	}
}
