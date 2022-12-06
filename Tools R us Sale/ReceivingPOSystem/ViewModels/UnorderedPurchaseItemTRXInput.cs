#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceivingPOSystem.ViewModels
{
    public class UnorderedPurchaseItemTRXInput
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public string ItemDescription { get; set; }
        public string VendorStockNumber { get; set; }
    }
}
