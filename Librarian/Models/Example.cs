using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Models
{
	public class Example
	{
		[Key]
		public int ID { get; set; }

		[Display(Name = "Jeff Column")]
		public string Jeff { get; set; }

		//One to one relationship
		[ForeignKey("OtherEntity")]
		public int ForeignKey { get; set; }

		//One to many relationship
		[NotMapped]
		public virtual ICollection<int> RandomNumbers { get; set; }
	}
}
