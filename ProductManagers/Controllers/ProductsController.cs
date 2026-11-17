using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;
using ProductManager.Services.Interfaces;
using ProductManager.ViewModels.Products;

namespace ProductManager.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    // GET: Products
    public async Task<IActionResult> Index(string? search)
    {
        var products = await _productService.GetAllAsync(search);

        var viewModel = new ProductListViewModel
        {
            Search = search,
            Products = products
        };

        return View(viewModel);
    }

    // GET: Products/Details/5
    public async Task<IActionResult> Details(int id)
    {
        var product = await _productService.GetByIdAsync(id);

        if (product is null)
            return NotFound();

        return View(product);
    }

    // GET: Products/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Products/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ProductCreateViewModel viewModel)
    {
        if (!ModelState.IsValid)
            return View(viewModel);

        var product = new Product
        {
            Name = viewModel.Name.Trim(),
            Description = viewModel.Description?.Trim(),
            SKU = viewModel.SKU.Trim(),
            CostPrice = viewModel.CostPrice,
            SalePrice = viewModel.SalePrice,
            Quantity = viewModel.Quantity
        };

        try
        {
            var created = await _productService.CreateAsync(product);

            if (!created)
            {
                ModelState.AddModelError(
                    nameof(viewModel.SKU),
                    "Não foi possível cadastrar. Verifique se o SKU já existe ou se os dados são válidos.");

                return View(viewModel);
            }

            TempData["Success"] = "Produto cadastrado com sucesso!";

            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            ModelState.AddModelError(
                string.Empty,
                "Ocorreu um erro ao cadastrar o produto.");

            return View(viewModel);
        }
    }

    // GET: Products/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var product = await _productService.GetByIdAsync(id);

        if (product is null)
            return NotFound();

        var viewModel = new ProductEditViewModel
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            SKU = product.SKU,
            CostPrice = product.CostPrice,
            SalePrice = product.SalePrice,
            Quantity = product.Quantity
        };

        return View(viewModel);
    }

    // POST: Products/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(
        int id,
        ProductEditViewModel viewModel)
    {
        if (id != viewModel.Id)
            return BadRequest();

        if (!ModelState.IsValid)
            return View(viewModel);

        var product = new Product
        {
            Id = viewModel.Id,
            Name = viewModel.Name.Trim(),
            Description = viewModel.Description?.Trim(),
            SKU = viewModel.SKU.Trim(),
            CostPrice = viewModel.CostPrice,
            SalePrice = viewModel.SalePrice,
            Quantity = viewModel.Quantity
        };

        try
        {
            var updated = await _productService.UpdateAsync(product);

            if (!updated)
            {
                ModelState.AddModelError(
                    nameof(viewModel.SKU),
                    "Não foi possível atualizar. Verifique o SKU e os dados informados.");

                return View(viewModel);
            }

            TempData["Success"] = "Produto atualizado com sucesso!";

            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            ModelState.AddModelError(
                string.Empty,
                "Ocorreu um erro ao atualizar o produto.");

            return View(viewModel);
        }
    }

    // GET: Products/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var product = await _productService.GetByIdAsync(id);

        if (product is null)
            return NotFound();

        return View(product);
    }

    // POST: Products/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        try
        {
            var deleted = await _productService.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            TempData["Success"] = "Produto excluído com sucesso!";

            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            TempData["Error"] = "Não foi possível excluir o produto.";

            return RedirectToAction(nameof(Index));
        }
    }
}