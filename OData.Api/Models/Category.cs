﻿using System;
namespace OData.Api.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public ICollection<Product> Products { get; set; }
	}
}

