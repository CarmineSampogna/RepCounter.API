using Microsoft.EntityFrameworkCore;
using RepCounter.Common.Model;

namespace RepCounter.DataAccess.EF.EntityConfiguration
{
	public static class SetConfig
	{
		public static void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Set>()
				.HasOne(s => s.WorkoutExercise)
				.WithMany(we => we.Sets);

			modelBuilder.Entity<Set>()
				.HasOne(s => s.WeightUnit);

			modelBuilder.Entity<Set>()
				.HasIndex(s => s.WorkoutExerciseId);

			modelBuilder.Entity<Set>()
				.Property(s => s.WeightUnitId)
				.IsRequired();

			modelBuilder.Entity<Set>()
				.Property(s => s.WorkoutExerciseId)
				.IsRequired();
		}
	}
}
