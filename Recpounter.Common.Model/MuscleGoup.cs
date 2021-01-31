namespace Recpounter.Common.Model
{
	/// <summary>
	/// Represents a groupp of muscles targeted by a workout.
	/// </summary>
	public class MuscleGoup : EntityBase
	{
		/// <summary>
		/// The primary key.
		/// </summary>
		public long MuscleGroupId { get; set; }

		/// <summary>
		/// The name of the muscle group (shoulders, calves, etc).
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// A description of the muscle group (lower legs, upper arms, etc).
		/// </summary>
		public string Description { get; set; }
	}
}
