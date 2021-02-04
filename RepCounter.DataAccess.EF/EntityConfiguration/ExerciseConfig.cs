using Microsoft.EntityFrameworkCore;
using Recpounter.Common.Model;

namespace RepCounter.DataAccess.EF.EntityConfiguration
{
	public static class ExerciseConfig
	{
		public static void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Exercise>()
							.HasIndex(e => e.OwnerId);

			modelBuilder.Entity<Exercise>()
				.HasIndex(e => e.Name)
				.IsUnique();
		}
	}
}
