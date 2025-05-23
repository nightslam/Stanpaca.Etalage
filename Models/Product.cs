namespace Stanpaca.Etalage.Models;

public class Product
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0;
    public bool IsAvailable { get; set; } = true;
    public string SpecialEvent { get; set; } = string.Empty;
} 