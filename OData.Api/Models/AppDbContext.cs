using System;
using Microsoft.EntityFrameworkCore;

namespace OData.Api.Models
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}

