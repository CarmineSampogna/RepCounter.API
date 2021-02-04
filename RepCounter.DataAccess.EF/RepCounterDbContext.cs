using Microsoft.EntityFrameworkCore;
using Recpounter.Common.Model;
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
		public DbSet<MuscleGoup> MuscleGroups { get; set; }
		public DbSet<Set> Sets { get; set; }
		public DbSet<WeightUnit> WeightUnits { get; set; }
		public DbSet<Workout> Workouts { get; set; }
		public DbSet<WorkoutExercise> WorkoutExercises { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			List<Action<ModelBuilder>> entityConfigs = new List<Action<ModelBuilder>>
			{
				ExerciseConfig.Configure,
				ExerciseMuscleGroupConfig.Configure
			};

			foreach(var entityConfig in entityConfigs)
			{
				entityConfig.Invoke(modelBuilder);
			}
		}
	}
}
