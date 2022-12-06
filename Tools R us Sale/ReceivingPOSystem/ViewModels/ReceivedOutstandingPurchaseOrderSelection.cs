#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceivingPOSystem.ViewModels
{
    public class ReceivedOutstandingPurchaseOrderSelection
    {
        public int PurchaseOrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string VendorName { get; set; }
        public string VendorPhoneInfo { get; set; }
    }
}
