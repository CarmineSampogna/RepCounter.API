using System;
using System.Collections.Generic;
using System.Text;

namespace Recpounter.Common.Model
{
	public class EntityBase
	{
		public DateTimeOffset Created { get; set; }
		public DateTimeOffset Modified { get; set; }
	}
}
