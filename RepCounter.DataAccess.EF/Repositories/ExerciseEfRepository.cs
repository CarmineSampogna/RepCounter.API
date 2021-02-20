using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepCounter.Common.Model;
using RepCounter.DataAccess.Abstractions;

namespace RepCounter.DataAccess.EF.Repositories
{
	public class ExerciseEfRepository : EfRepositoryBase, IExerciseRepository
	{
		public ExerciseEfRepository(DbContextOptions<RepCounterDbContext> dbContextOptions) : base(dbContextOptions)
		{
		}

		public async Task DeleteAsync(Exercise exercise)
		{
			if (exercise == null) return;

			using RepCounterDbContext dbContext = new RepCounterDbContext(DbContextOptions);
			dbContext.Exercises.Remove(exercise);
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(IEnumerable<Exercise> exercises)
		{
			if (exercises == null) return;

			using RepCounterDbContext dbContext = new RepCounterDbContext(DbContextOptions);
			foreach (Exercise exercise in exercises)
			{
				if (exercise != null)
				{
					dbContext.Exercises.Remove(exercise);
				}
			}
			await dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<Exercise>> GetAllAsync()
		{
			using RepCounterDbContext dbContext = new RepCounterDbContext(DbContextOptions);
			return await dbContext.Exercises.ToListAsync();
		}

		public async Task<Exercise> GetAsync(long exerciseId)
		{
			using RepCounterDbContext dbContext = new RepCounterDbContext(DbContextOptions);
			return await dbContext.Exercises.FindAsync(exerciseId);
		}

		public Task<IEnumerable<Exercise>> GetForUserAsync(string userId)
		{
			throw new NotImplementedException();
		}

		public Task<Exercise> UpsertAsync(Exercise exercise)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Exercise>> UpsertAsync(IEnumerable<Exercise> exercises)
		{
			throw new NotImplementedException();
		}
	}
}
