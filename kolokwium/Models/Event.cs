using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
	public class Event
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdEvent { get; set; }

		[MaxLength(100)]
		[Required]
		public string Name { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public ICollection<Artist_Event> Artist_Events { get; set; }
		public ICollection<Event_Organizer> Event_Organizer { get; set; }

	}
}
