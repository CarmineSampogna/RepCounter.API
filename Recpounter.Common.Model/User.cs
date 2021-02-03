using System;
using System.Collections.Generic;
using System.Text;

namespace Recpounter.Common.Model
{
	/// <summary>
	/// Represents an app user.
	/// </summary>
	public class User 
	{
		/// <summary>
		/// The primary key
		/// </summary>
		public string Uid { get; set; }

		/// <summary>
		/// The user's display name.
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// The user's image url.
		/// </summary>
		public string ImageUrl { get; set; }
	}
}
