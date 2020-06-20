using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kolokwium.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium.Controllers
{
	[Route("api/artists")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private readonly ArtiscDbContext _contex;
		public ValuesController(ArtiscDbContext context)
		{
			_contex = context;
		}

		[HttpGet]
		public IActionResult GetArtist(int IdArtist)
		{
			ICollection<Artist> Artists;
			if (!_contex.Artists.Any(s => s.IdArtist == IdArtist))
			{
				return BadRequest("Artist doesnt exist");
			}
			else
			{
				Artists = _contex.Artists
					.Where(z => z.IdArtist == IdArtist)
					.ToList();
			}
			//artist event
			var artistEvent = _contex.Artist_Events
				.Where(a => a.IdArtist == IdArtist)
				.ToList();

			return Ok(Artists);
		}

		[HttpPut]
		public IActionResult UpdatePerformancedateArtist(int IdArtist, int IdEvent)
		{
			if (!_contex.Artists.Any(s => s.IdArtist == IdArtist))
			{
				return BadRequest("artist doesnt exist");
			}
			if (!_contex.Events.Any(s => s.IdEvent == IdEvent))
			{
				return BadRequest("event doesnt exist");
			}

			
			return Ok();
		}
	}
}
