using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepCounter.DataAccess.Abstractions
{
	public interface IGetAll<T>
	{
		Task<IEnumerable<T>> GetAllAsync();
	}
}
