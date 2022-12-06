using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.ViewModels
{
    public class SaleCart
    {
        public int StockItemID { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
