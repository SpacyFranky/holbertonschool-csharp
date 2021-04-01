using System;

namespace InventoryLibrary
{
	/// <summary>
	/// BaseClass that all other classes will inherit from
	/// </summary>
    public static class BaseClass
    {
		/// <summary>
		/// Declaring an id value
		/// </summary>
        public string id { get; set; }

		/// <summary>
		/// Declaring a created date value
		/// </summary>
		public DateTime date_created { get; set; }

		/// <summary>
		/// Declaring an updated date value
		/// </summary>
		public DateTime date_updated { get; set; }
    }
}
