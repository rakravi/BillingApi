using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessModel;

namespace BusinessLayer.BusinessHelper
{
    public class ServiceCharges : AdditionalCharges
    {
        private List<PurchasedItems> _purchasedItems;

        public ServiceCharges(List<PurchasedItems> items)
        {
            _purchasedItems = items;
        }
        public override float GetCharge()
        {
            //Checking purchased item type to calculate the service charge.
            var type = HasPurchasedItemType() ? Constants.Food :
                        Constants.Drink;

            var srvPercent = GetChargePercent(type);

            //Calculating bill amount before additional charges
            var serviceCharge = _purchasedItems.Sum(item => item.TotalPrice) * srvPercent / 100;

            return (float)Math.Round(serviceCharge, 2);
        }


        //Method to check if the list of items has any food items.
        private bool HasPurchasedItemType()
        {
            return (_purchasedItems != null) ?
                _purchasedItems.Where(items => items.ItemType == Constants.Food).Count() > 0 :
                false;
        }

        private int GetChargePercent(string type)
        {
            var percent = 0;
            if(type != "")
            {
                switch (type)
                {
                    case "FD":
                        percent = Constants.FoodSrvCharge;
                        break;
                    case "BVG":
                        percent = Constants.DrinkSrvCharge;
                        break;
                    default:
                        percent = Constants.DrinkSrvCharge;
                        break;
                }
            }
            return percent;
        }
    }
}
