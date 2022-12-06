#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceivingPOSystem.ViewModels
{
    public class UnorderedPurchaseDetails
    {
        public int CartID { get; set; }
        public int ReturnedOrderDetailID { get; set; }
        public string ItemDescription { get; set; }
        public string VendorStockNumber { get; set; }
        public int Quantity { get; set; }
    }
}
