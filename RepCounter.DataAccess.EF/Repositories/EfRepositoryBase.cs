using Microsoft.EntityFrameworkCore;

namespace RepCounter.DataAccess.EF.Repositories
{
	public abstract class EfRepositoryBase
	{
		public EfRepositoryBase(DbContextOptions<RepCounterDbContext> dbContextOptions)
		{
			DbContextOptions = dbContextOptions;
		}

		protected DbContextOptions<RepCounterDbContext> DbContextOptions { get; }
	}
}
