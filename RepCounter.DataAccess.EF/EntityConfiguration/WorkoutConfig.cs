using Microsoft.EntityFrameworkCore;
using RepCounter.Common.Model;

namespace RepCounter.DataAccess.EF.EntityConfiguration
{
	public static class WorkoutConfig
	{
		public static void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Workout>()
				.HasIndex(w => w.UserId);

			modelBuilder.Entity<Workout>()
				.HasIndex(w => w.Name);

			modelBuilder.Entity<Workout>()
				.Property(w => w.UserId)
				.IsRequired();

			modelBuilder.Entity<Workout>()
				.Property(w => w.Name)
				.IsRequired();
		}
	}
}
