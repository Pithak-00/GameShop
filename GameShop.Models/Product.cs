﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace GameShop.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Brand { get; set; }
		[Required]
		[Display(Name = "List Price")]
		[Range(1,10000)]
		public int ListPrice { get; set; }

		[Required]
		[Display(Name = "Price for 1-50")]
		[Range(1, 10000)]
		public int Price { get; set; }
		[Required]
		[Display(Name = "Price for 50+")]
		[Range(1, 10000)]
		public int Price50 { get; set; }
		[Required]
		[Display(Name = "Price for 100+")]
		[Range(1, 10000)]
		public int Price100 { get; set; }
		public string Description { get; set; }
		public int PlatformId { get; set; }
		[ForeignKey("PlatformId")]
		[ValidateNever]
		public Platform Platform { get; set; }
		[ValidateNever]
		public string ImageUrl { get; set; }
	}
}
