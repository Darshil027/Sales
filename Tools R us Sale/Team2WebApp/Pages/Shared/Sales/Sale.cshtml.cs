using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SalesSystem.BLL;
using SalesSystem.ViewModels;

namespace Team2WebApp.Pages.Shared.Sales
{
    public class SaleModel : PageModel
    {
        private readonly CategoryServices _categoryServices;
        private readonly StockItemServices _stockItemServices;


        public SaleModel(CategoryServices categoryServices, StockItemServices stockItemServices)
        {
            _categoryServices = categoryServices;
            _stockItemServices = stockItemServices;
        }

        [TempData]
        public string Feedback { get; set; }

        [BindProperty]
        public List<FetchCategory> Categories { get; set; }

        [BindProperty]
        public List<StockItem> StockItems { get; set; }

        [BindProperty]
        public List<SaleCart> SaleCarts { get; set; }

        [BindProperty] public int CategoryId { get; set; }

        [BindProperty] public int StockItemID { get; set; }

        [BindProperty] public bool Shopping { get; set; }
        [BindProperty] public bool ViewCart { get; set; }
        [BindProperty] public bool Checkout { get; set; }

        public void OnGet()
        {
            PopulateCategories();
            Shopping = true;
        }

        public void PopulateCategories()
        {
            Categories = _categoryServices.Category_GetList();
        }

        public IActionResult OnPostCategoryItems()
        {
            PopulateCategories();

            StockItems = _stockItemServices.Product_GetProductByCategory(CategoryId);
            
            Shopping = true;
            ViewCart = false;
            Checkout = false;

            return Page();
        }

        public IActionResult OnPostAddItems()
        {
            SaleCart saleCart = StockItems
                                    .Where(x => x.StockItemID == StockItemID)
                                    .Select(x => new SaleCart
                                    {
                                       StockItemID = x.StockItemID,
                                       Description = x.Description,
                                       price = x.price,
                                       Quantity = 1,
                                       Total = x.price
                                    })
                                    .FirstOrDefault();
            
            if (SaleCarts.Count() > 0)
            {
                bool itemExists = SaleCarts
                                    .Where(x => x.StockItemID == saleCart.StockItemID)
                                    .Any();

                if (itemExists)
                {
                    Feedback = "Item exists.";
                }
                else
                {
                    SaleCarts.Add(saleCart);
                }
            }
            else
            {
                SaleCarts.Add(saleCart);
            }
            
            PopulateCategories();

            Shopping = true;
            ViewCart = false;
            Checkout = false;

            return Page();
        }

        public IActionResult OnPostShopping()
        {
            PopulateCategories();

            Shopping = true;
            ViewCart = false;
            Checkout = false;

            return Page();
        }

        public IActionResult OnPostCart()
        {
            Shopping = false;
            ViewCart = true;
            Checkout = false;

            return Page();
        }

        public IActionResult OnPostCheckout()
        {
            Shopping = false;
            ViewCart = false;
            Checkout = true;

            return Page();
        }
    }
}
