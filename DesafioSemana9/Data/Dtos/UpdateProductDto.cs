using System.ComponentModel.DataAnnotations;

namespace DesafioSemana9.Data.Dtos;

public class UpdateProductDto
{
    [Required(ErrorMessage = "Product name is required")]
    public string Name { get; set; }
    [StringLength(500)]
    public string Description { get; set; }
    [Required(ErrorMessage = "Product price is required")]
    public double Price { get; set; }
    [Required(ErrorMessage = "Product quantity must be more than 0")]
    public int Quantity { get; set; }
}
