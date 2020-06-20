using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
	public class ArtiscDbContext : DbContext
	{
		public DbSet<Artist> Artists { get; set; }
		public DbSet<Artist_Event> Artist_Events { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Event_Organizer> Event_Organizers { get; set; }
		public DbSet<Organiser> Organiser { get; set; }
		public ArtiscDbContext(DbContextOptions options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Artist_Event>()
				.HasKey(z => new { z.IdArtist, z.IdEvent});

			modelBuilder.Entity<Event_Organizer>()
				.HasKey(z => new { z.IdEvent, z.IdOrganiser });
		}


	}
}
