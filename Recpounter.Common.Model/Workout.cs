using System;
using System.Collections.Generic;

namespace RepCounter.Common.Model
{
	/// <summary>
	/// Represents a workout.
	/// </summary>
	public class Workout : EntityBase
	{
		/// <summary>
		/// The primary key.
		/// </summary>
		public long WorkoutId { get; set; }

		/// <summary>
		/// The foreign key of the user.
		/// </summary>
		public string UserId { get; set; }

		/// <summary>
		/// The name of the workout.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The time the workout was started, in UTC
		/// </summary>
		public DateTimeOffset? StartUTC { get; set; }

		/// <summary>
		/// The time the workout was ended, in UTC.
		/// </summary>
		public DateTimeOffset? EndUTC { get; set; }

		/// <summary>
		/// Flag for whether the Workout has started or not.
		/// </summary>
		public bool IsStarted { get; set; }

		/// <summary>
		/// Flag for whether the Workout is complete or not.
		/// </summary>
		public bool IsComplete { get; set; }

		public IEnumerable<WorkoutExercise> WorkoutExercises { get; set; }
	}
}
