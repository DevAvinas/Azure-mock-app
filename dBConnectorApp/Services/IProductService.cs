using dBConnectorApp.Models;

namespace dBConnectorApp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}