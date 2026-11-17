using ProductManager.Models;

namespace ProductManager.ViewModels.Products;

public class ProductListViewModel
{
    public string? Search { get; set; }

    public List<Product> Products { get; set; } = [];
}