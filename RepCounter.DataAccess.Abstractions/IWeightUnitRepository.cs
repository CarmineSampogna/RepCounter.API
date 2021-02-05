using RepCounter.Common.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepCounter.DataAccess.Abstractions
{
	public interface IWeightUnitRepository
	{
		Task<IEnumerable<WeightUnit>> GetAllAsync();
	}
}
