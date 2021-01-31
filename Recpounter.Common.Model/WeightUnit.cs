using System;
using System.Collections.Generic;
using System.Text;

namespace Recpounter.Common.Model
{
	/// <summary>
	/// The unit of measure used to log weight. Either Pounds or Kilograms
	/// </summary>
	public class WeightUnit
	{
		/// <summary>
		/// The primary key.
		/// </summary>
		public long WeightUnitId { get; set; }

		/// <summary>
		/// The name of the weight unit.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The short name of the weight unit.
		/// </summary>
		public string ShortName { get; set; }
	}
}
