using System;

namespace Recpounter.Common.Model
{
    /// <summary>
    /// An Exercise that is performed as part of a Workout.
    /// </summary>
	public class WorkoutExercise : EntityBase
	{
        /// <summary>
        /// The primary key.
        /// </summary>
        public long WorkoutExerciseId { get; set; }

        /// <summary>
        /// The foreign key of the Workout this Exercise is being performed in.
        /// </summary>
        public long WorkoutId { get; set; }

        /// <summary>
        /// The Exercise being performed.
        /// </summary>
        public long ExerciseId { get; set; }

        /// <summary>
        /// The time this exercise was started, in UTC.
        /// </summary>
        public DateTimeOffset StartUTC { get; set; }

        /// <summary>
        /// The time this Exercise was finished, in UTC.
        /// </summary>
        public DateTimeOffset EndUTC { get; set; }

        /// <summary>
        /// Flag for is the Exercise has been started.
        /// </summary>
        public bool IsStarted { get; set; }

        /// <summary>
        /// Flag for if the Exercise has been completed.
        /// </summary>
        public bool IsComplete { get; set; }
    }
}
