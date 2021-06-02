using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Inventory class that inherits from BaseClass
    /// </summary>
    public static class Inventory : BaseClass
    {
        /// <summary>
        /// User ID
        /// </summary>
        public string user_id = User.id;
        /// <summary>
        /// Item ID
        /// </summary>
        public string item_id = Item.id;
        /// <summary>
        /// Quantity value
        /// </summary>
        /// <value></value>
        public int quantity {get; set;} = 1;
    }
}