﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
	public class Event_Organizer
	{
		public int IdEvent { get; set; }
		public int IdOrganiser { get; set; }
		public Event Event { get; set; }
		public Organiser Organiser { get; set; }
	}
}
