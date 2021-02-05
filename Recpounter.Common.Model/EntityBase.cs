using System;

namespace RepCounter.Common.Model
{
	public class EntityBase
	{
		public DateTimeOffset Created { get; set; }
		public DateTimeOffset Modified { get; set; }
		public Guid RowVersion { get; set; }
	}
}
