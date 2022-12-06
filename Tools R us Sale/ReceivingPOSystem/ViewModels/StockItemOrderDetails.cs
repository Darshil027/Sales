#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceivingPOSystem.ViewModels
{
    public class StockItemOrderDetails
    {
        public int StockItemID { get; set; }
        public string Description { get; set; }
        public int QuantityOnOrder { get; set; }
        public int QuantityOutstanding { get; set; }
    }
}
