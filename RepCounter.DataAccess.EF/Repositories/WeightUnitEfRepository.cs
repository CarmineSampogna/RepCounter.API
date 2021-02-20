using Microsoft.EntityFrameworkCore;
using RepCounter.Common.Model;
using RepCounter.DataAccess.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepCounter.DataAccess.EF.Repositories
{
	public class WeightUnitEfRepository : EfRepositoryBase, IWeightUnitRepository
	{
		public WeightUnitEfRepository(DbContextOptions<RepCounterDbContext> dbContextOptions) : base(dbContextOptions)
		{
		}

		public async Task<IEnumerable<WeightUnit>> GetAllAsync()
		{
			using RepCounterDbContext dbContext = new RepCounterDbContext(DbContextOptions);
			return await dbContext.WeightUnits.ToListAsync();
		}
	}
}
