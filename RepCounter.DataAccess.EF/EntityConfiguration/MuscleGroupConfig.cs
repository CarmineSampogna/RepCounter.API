﻿using Microsoft.EntityFrameworkCore;
using RepCounter.Common.Model;
using System;

namespace RepCounter.DataAccess.EF.EntityConfiguration
{
	public static class MuscleGroupConfig
	{
		public static void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MuscleGroup>()
				.HasIndex(mg => mg.Name)
				.IsUnique();
		}
	}
}
