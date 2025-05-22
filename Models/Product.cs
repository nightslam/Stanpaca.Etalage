namespace Stanpaca.Etalage.Models;

public class Product
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsSold { get; set; }
    public bool IsHighlight { get; set; }
} 