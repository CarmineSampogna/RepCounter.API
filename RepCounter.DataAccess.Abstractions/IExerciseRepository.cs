using RepCounter.Common.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepCounter.DataAccess.Abstractions
{
	public interface IExerciseRepository : IGetAll<Exercise>
	{
		Task<Exercise> GetAsync(long exerciseId);
		Task<IEnumerable<Exercise>> GetForUserAsync(string userId);
		Task<Exercise> UpsertAsync(Exercise exercise);
		Task<IEnumerable<Exercise>> UpsertAsync(IEnumerable<Exercise> exercises);
		Task DeleteAsync(Exercise exercise);
		Task DeleteAsync(IEnumerable<Exercise> exercises);
	}
}
