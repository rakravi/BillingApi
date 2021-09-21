using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.BusinessModel
{
    public class PurchasedItems
    {
        //Code of the item purchased
        [Required]
        public string ItemCd { get; set; }
        //Name of the item purchased
        [Required]
        public string ItemName { get; set; }
        //Type of the item purchased
        [Required]
        public string ItemType { get; set; }
        //Price for a one unit of the item
        [Required]
        public float Price { get; set; }
        //Total price for entire quantity purchased
        [Required]
        public float TotalPrice { get; set; }
        //Number of item purchased.
        [DefaultValue(1)]
        public int Quantity  { get; set; }
    }
}
