using Recpounter.Common.Model;
using System.Threading.Tasks;

namespace RepCounter.DataAccess.Abstractions
{
	public interface IExerciseMuscleGroupRepository
	{
		Task<ExerciseMuscleGroup> GetAsync(long exerciseMuscleGroupId);
		Task DeleteAsyn(ExerciseMuscleGroup exerciseMuscleGroup);
	}
}
