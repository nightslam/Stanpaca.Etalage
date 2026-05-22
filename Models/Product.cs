namespace Stanpaca.Etalage.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string LongDescription { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0;
    public bool IsAvailable { get; set; } = true;
    public string SpecialEvent { get; set; } = string.Empty;
    public List<string> ExtraImageUrls { get; set; } = new();
} 