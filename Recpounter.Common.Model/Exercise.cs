using System.Collections.Generic;

namespace RepCounter.Common.Model
{
	/// <summary>
	/// An Exercise that can be performed.
	/// </summary>
	public class Exercise : EntityBase
	{
		/// <summary>
		/// The Primary key
		/// </summary>
		public long ExerciseId { get; set; }

		/// <summary>
		/// The foreign key of the owner.
		/// </summary>
		public string OwnerId { get; set; }

		/// <summary>
		/// The exercise name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// A description of the Exercise.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// True if the exercise uses body weight.
		/// </summary>
		public bool IsBodyWeightExercise { get; set; }

		public IEnumerable<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }

		public override bool Equals(object obj)
		{
			if (!(obj is Exercise)) return false;

			Exercise that = obj as Exercise;

			return GetHashCode() == that.GetHashCode();
		}

		public override int GetHashCode()
		{
			return ExerciseId.GetHashCode();
		}
	}
}
