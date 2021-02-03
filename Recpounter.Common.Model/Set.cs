namespace Recpounter.Common.Model
{
    /// <summary>
    /// Represents a set of repititions of an Exercise performed in a Workout.
    /// </summary>
	public class Set : EntityBase
	{
        /// <summary>
        /// The primary key.
        /// </summary>
        public long SetId { get; set; }

        /// <summary>
        /// The foreign key of the WorkoutExercise.
        /// </summary>
        public long WorkoutExerciseId { get; set; }

        /// <summary>
        /// The id of the Wight Unit the user selected for this set.
        /// </summary>
        public long WeightUnitId { get; set; }

        /// <summary>
        /// The number of this set.
        /// </summary>
        public int SetNumber { get; set; }

        /// <summary>
        /// The number of repititions performed in this Set.
        /// </summary>
        public int Reps { get; set; }

        /// <summary>
        /// The amount of weight used for this Set.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// The number of seconds rested after this Set.
        /// </summary>
        public int? RestSeconds { get; set; }

        /// <summary>
        /// The total amount of mass moved during this set. Weight * repititions.
        /// </summary>
        public double Volume { get; set; }
    }
}
