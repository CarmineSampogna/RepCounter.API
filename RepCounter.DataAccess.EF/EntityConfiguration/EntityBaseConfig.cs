using Microsoft.EntityFrameworkCore;
using RepCounter.Common.Model;

namespace RepCounter.DataAccess.EF.EntityConfiguration
{
	public static class EntityBaseConfig<TEntity> where TEntity : EntityBase
	{
		public static void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TEntity>()
				.Property(en => en.RowVersion)
				.IsRowVersion();
		}
	}
}
