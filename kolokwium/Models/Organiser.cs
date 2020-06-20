using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
	public class Organiser
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdOrganiser { get; set; }

		[MaxLength(30)]
		[Required]
		public string Name { get; set; }
	}
}
