using Microsoft.EntityFrameworkCore;
using ProductManager.Data;
using ProductManager.Models;
using ProductManager.Services.Interfaces;

namespace ProductManager.Services;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync(string? search = null)
    {
        var query = _context.Products.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(p =>
                p.Name.Contains(search) ||
                p.SKU.Contains(search));
        }

        return await query
            .OrderBy(p => p.Name)
            .ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _context.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<bool> CreateAsync(Product product)
    {
        if (product.CostPrice < 0 ||
            product.SalePrice <= 0 ||
            product.Quantity < 0)
        {
            return false;
        }

        var skuExists = await _context.Products
            .AnyAsync(p => p.SKU.ToLower() == product.SKU.ToLower());

        if (skuExists)
            return false;

        product.CreatedAt = DateTime.UtcNow;

        _context.Products.Add(product);

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> UpdateAsync(Product product)
    {
        var existingProduct = await _context.Products
            .FirstOrDefaultAsync(p => p.Id == product.Id);

        if (existingProduct is null)
            return false;

        if (product.CostPrice < 0 ||
            product.SalePrice <= 0 ||
            product.Quantity < 0)
        {
            return false;
        }

        var skuExists = await _context.Products
            .AnyAsync(p =>
                p.SKU.ToLower() == product.SKU.ToLower() &&
                p.Id != product.Id);

        if (skuExists)
            return false;

        existingProduct.Name = product.Name;
        existingProduct.Description = product.Description;
        existingProduct.SKU = product.SKU;
        existingProduct.CostPrice = product.CostPrice;
        existingProduct.SalePrice = product.SalePrice;
        existingProduct.Quantity = product.Quantity;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var product = await _context.Products
            .FirstOrDefaultAsync(p => p.Id == id);

        if (product is null)
            return false;

        _context.Products.Remove(product);

        await _context.SaveChangesAsync();

        return true;
    }
}