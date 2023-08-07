using dBConnectorApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dBConnectorApp.Services;

namespace dBConnectorApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product>? Products;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();

        }
    }
}