using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group30_Final_Project.Models
{
    public class Order
    {

        public Int32 OrderID { get; set; }

        public Decimal Subtotal { get; set; }

        public Decimal Total { get; set; }

        public Decimal TaxRate { get; set; }

        // True if order is completed
        // False if order is not complete (will be shopping cart)
        public bool OrderCompleted { get; set; }

        // True if order is a gift to another customer 
        // False if items in order belong to customer
        public bool boolGift { get; set; }


/********************************************************************************************************************/
/***********      Navigation properties below                ********************************************************/
/********************************************************************************************************************/


        // Order must belong to 1 and only 1 user
        // consider renaming
        public User CustPlacingOrder { get; set; }






    }
}