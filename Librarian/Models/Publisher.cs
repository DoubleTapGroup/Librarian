using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Models
{
	public class Publisher
	{
		[Key]
		public int PublisherId { get; set; }

		public string Name { get; set; }
	}
}
