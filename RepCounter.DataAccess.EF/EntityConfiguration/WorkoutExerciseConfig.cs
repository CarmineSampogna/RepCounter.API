using Microsoft.EntityFrameworkCore;
using RepCounter.Common.Model;

namespace RepCounter.DataAccess.EF.EntityConfiguration
{
	public static class WorkoutExerciseConfig
	{
		public static void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WorkoutExercise>()
				.HasOne(we => we.Workout)
				.WithMany(w => w.WorkoutExercises);

			modelBuilder.Entity<WorkoutExercise>()
				.HasOne(we => we.Exercise)
				.WithMany();

			modelBuilder.Entity<WorkoutExercise>()
				.Property(we => we.WorkoutId)
				.IsRequired();

			modelBuilder.Entity<WorkoutExercise>()
				.Property(we => we.ExerciseId)
				.IsRequired();

			modelBuilder.Entity<WorkoutExercise>()
				.HasIndex(we => we.WorkoutId);

			modelBuilder.Entity<WorkoutExercise>()
				.HasIndex(we => we.ExerciseId);
		}
	}
}
