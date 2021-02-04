using Recpounter.Common.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepCounter.DataAccess.Abstractions
{
	public interface IMuscleGroupRepository
	{
		Task<IEnumerable<MuscleGoup>> GetAllAsync();
	}
}
