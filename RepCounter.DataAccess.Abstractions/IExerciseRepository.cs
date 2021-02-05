using RepCounter.Common.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepCounter.DataAccess.Abstractions
{
	interface IExerciseRepository : IGetAll<Exercise>
	{
		Task GetAsync(long exerciseId);
		Task UpsertAsync(Exercise exercise);
		Task UpsertAsync(IEnumerable<Exercise> exercises);
		Task DeleteAsync(Exercise exercise);
		Task DeleteAsync(IEnumerable<Exercise> exercises);
	}
}
