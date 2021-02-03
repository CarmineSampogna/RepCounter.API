namespace Recpounter.Common.Model
{
	/// <summary>
	/// A record of a muscle group being targeted by a specific exercise.
	/// </summary>
	public class ExerciseMuscleGroup
	{
		/// <summary>
		/// The primary key.
		/// </summary>
		public long ExerciseMuscleGroupId { get; set; }

		/// <summary>
		/// The foreign key of the Exercise.
		/// </summary>
		public long ExerciseId { get; set; }

		/// <summary>
		/// The foreign key of the MuscleGroup.
		/// </summary>
		public long MuscleGroupId { get; set; }
	}
}
