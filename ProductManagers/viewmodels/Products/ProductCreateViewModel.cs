using System.ComponentModel.DataAnnotations;

namespace ProductManager.ViewModels.Products;

public class ProductCreateViewModel : IValidatableObject
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(150, MinimumLength = 3,
        ErrorMessage = "O nome deve possuir entre 3 e 150 caracteres.")]
    public string Name { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "A descrição deve possuir no máximo 500 caracteres.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "O SKU é obrigatório.")]
    [StringLength(50)]
    public string SKU { get; set; } = string.Empty;

    public decimal CostPrice { get; set; }

    public decimal SalePrice { get; set; }

    [Range(0, int.MaxValue,
        ErrorMessage = "A quantidade não pode ser negativa.")]
    public int Quantity { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (CostPrice < 0m || CostPrice > 9999999999.99m)
        {
            yield return new ValidationResult(
                "O preço de custo não pode ser negativo.",
                new[] { nameof(CostPrice) });
        }

        if (SalePrice <= 0m || SalePrice > 9999999999.99m)
        {
            yield return new ValidationResult(
                "O preço de venda deve ser maior que zero.",
                new[] { nameof(SalePrice) });
        }
    }
}