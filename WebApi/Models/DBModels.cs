namespace WebApi.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class DBModels : DbContext
	{
		public DBModels()
			: base("name=DBModels")
		{
		}

		public virtual DbSet<Product> Product { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.Property(e => e.StandardCost)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.ListPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.Weight)
				.HasPrecision(8, 2);
		}
	}
}
