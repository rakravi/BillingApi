using BusinessLayer.BusinessModel;
using BusinessLayer.BusinessHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BillingBl : IBillingBlContract
    {
        //Business layer method to caculate the final bill amount.
        public BillDetails CalculateFinalCheck(List<PurchasedItems> purchasedItems)
        {
            float totalAmount = 0;
            float additionalCharge = 0;

            if (purchasedItems != null && purchasedItems.Count > 0) {
                //Calculating bill amount before additional charges
                totalAmount = (float)Math.Round(purchasedItems.Sum(item => item.TotalPrice), 2);

                //Calculate the service charge.
                additionalCharge = new ServiceCharges(purchasedItems).GetCharge();
            }

            return new BillDetails { Total = totalAmount, ServiceCharge = additionalCharge };
        }

       


    }
}
