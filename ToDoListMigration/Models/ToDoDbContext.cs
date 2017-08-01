using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ToDoListMigration.Models
{
	public class ToDoDbContext : DbContext
	{
		public ToDoDbContext()
		{
		}

		public DbSet<Category> Categories { get; set; }

		public DbSet<Item> Items { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDoListMigration;integrated security=True");
		}

		public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
