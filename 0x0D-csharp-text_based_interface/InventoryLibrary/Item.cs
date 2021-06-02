using System;

namespace InventoryLibrary
{
	/// <summary>
	/// Item class that inherits from BaseClass
	/// </summary>
    public static class Item : BaseClass
    {
	/// <summary>
	/// Declaring a name value
	/// </summary>
    public string name { get; set; }

	/// <summary>
	/// Declaring a description value
	/// </summary>
	public string? description { get; set; }

	/// <summary>
	/// Declaring a price value
	/// </summary>
	public float? price { get; set; }

	/// <summary>
	/// Declaring a list of strings for tags
	/// </summary>
	public List<string>? tags = new List<string>();
    }
}
