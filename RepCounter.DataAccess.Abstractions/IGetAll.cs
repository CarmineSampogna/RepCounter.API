using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepCounter.DataAccess.Abstractions
{
	interface IGetAll<T>
	{
		Task<IEnumerable<T>> GetAllAsync();
	}
}
