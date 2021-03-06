﻿using System;
using System.ComponentModel.DataAnnotations;
using KombniyApp.Core;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KombniyApp.Core
{
	public class User

	{
		
		public int UserId { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[Required]
		[StringLength(50)]
		public string Surname { get; set; }
		[Required]
		[StringLength(50)]
		public string Username { get; set; }
		[Required]
		[EmailAddress]
		[StringLength(50)]
		public string Email { get; set; }
		[Required]
		[StringLength(20)]
		public string Password { get; set; }

		public string photoPath { get; set; }

		[StringLength(1000)]
		public string About { get; set; } = "Bir bilgi girilmedi";
		
		public int WardrobeId { get; set; }

		public Wardrobe Wardrobe { get; set; }

		public IEnumerable<Wardrobe> Wardrobes { get; set; }
		
		
	}
}
