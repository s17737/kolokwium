using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
	public class Artist
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdArtist { get; set; }
		[MaxLength(30)]
		[Required]
		public string NickName { get; set; }

		public ICollection<Artist_Event> Artist_Events { get; set; }
	}
}
