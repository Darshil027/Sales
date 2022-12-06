#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceivingPOSystem.ViewModels
{
    public class AddPODetailsTRXInput
    {
        public int StockItemID { get; set; }
        public int QuantityReceived { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }
    }
}
