using Microsoft.EntityFrameworkCore;
using Recpounter.Common.Model;

namespace RepCounter.DataAccess.EF.EntityConfiguration
{
	public static class ExerciseMuscleGroupConfig
	{
		public static void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ExerciseMuscleGroup>()
				.Property(emg => emg.ExerciseId)
				.IsRequired();

			modelBuilder.Entity<ExerciseMuscleGroup>()
				.Property(emg => emg.MuscleGroupId)
				.IsRequired();

			modelBuilder.Entity<ExerciseMuscleGroup>()
				.HasIndex(emg => emg.MuscleGroupId);

			modelBuilder.Entity<ExerciseMuscleGroup>()
				.HasIndex(emg => emg.ExerciseId);

			modelBuilder.Entity<ExerciseMuscleGroup>()
				.HasIndex("ExerciseId", "MuscleGroupId")
				.IsUnique();
		}
	}
}
