using SalesSystem.DAL;
using SalesSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.BLL
{
    public class StockItemServices
    {
        private eTools2021Context _context;

        internal StockItemServices(eTools2021Context context)
        {
            _context = context;
        }

		public List<StockItem> Product_GetProductByCategory(int categoryID)
		{
			IEnumerable<StockItem> Item = _context.StockItems
							.Where(x => x.CategoryID == categoryID)
							.Select(x => new StockItem
							{
								StockItemID = x.StockItemID,
								Description = x.Description,
								QuantityOnHand = x.QuantityOnHand,
								price = x.SellingPrice
							}).ToList();

			return Item.ToList();
		}

	}
}
