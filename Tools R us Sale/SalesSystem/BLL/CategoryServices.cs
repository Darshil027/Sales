using SalesSystem.DAL;
using SalesSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.BLL
{
    public class CategoryServices
    {
        private eTools2021Context _context;

        internal CategoryServices(eTools2021Context context)
        {
            _context = context;
        }

        public List<FetchCategory> Category_GetList()
        {
            IEnumerable<FetchCategory> data = _context.Categories
                                        .Select(x => new FetchCategory
                                        {
                                            CategoryID = x.CategoryID,
                                            Description = x.Description,
                                            Count = x.StockItems.Count()
                                        }).ToList();

            return data.ToList();
        }
    }
}
