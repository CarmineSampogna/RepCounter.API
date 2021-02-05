using Microsoft.EntityFrameworkCore;
using RepCounter.Common.Model;
using RepCounter.DataAccess.EF.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace RepCounter.DataAccess.EF
{
	public class RepCounterDbContext : DbContext
	{
		public RepCounterDbContext([NotNull] DbContextOptions options) : base(options)
		{
		}

		public DbSet<Exercise> Exercises { get; set; }
		public DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }
		public DbSet<MuscleGroup> MuscleGroups { get; set; }
		public DbSet<Set> Sets { get; set; }
		public DbSet<WeightUnit> WeightUnits { get; set; }
		public DbSet<Workout> Workouts { get; set; }
		public DbSet<WorkoutExercise> WorkoutExercises { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			List<Action<ModelBuilder>> entityConfigs = new List<Action<ModelBuilder>>
			{
				EntityBaseConfig<Exercise>.Configure,
				ExerciseConfig.Configure,

				EntityBaseConfig<ExerciseMuscleGroup>.Configure,
				ExerciseMuscleGroupConfig.Configure,

				EntityBaseConfig<MuscleGroup>.Configure,
				MuscleGroupConfig.Configure,

				EntityBaseConfig<Set>.Configure,
				SetConfig.Configure,

				EntityBaseConfig<Workout>.Configure,
				WorkoutConfig.Configure,

				EntityBaseConfig<WorkoutExercise>.Configure,
				WorkoutExerciseConfig.Configure
			};

			entityConfigs.ForEach(config => config.Invoke(modelBuilder));
		}
	}
}
