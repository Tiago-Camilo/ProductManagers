using ProductManager.Models;

namespace ProductManager.Services.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAllAsync(string? search = null);

    Task<Product?> GetByIdAsync(int id);

    Task<bool> CreateAsync(Product product);

    Task<bool> UpdateAsync(Product product);

    Task<bool> DeleteAsync(int id);
}