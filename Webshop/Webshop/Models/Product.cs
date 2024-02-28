using Webshop.Data;

namespace Webshop.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string FullDescription { get; set; }
    public double Price { get; set; }
    public string Image { get; set; }
    public int Quantity { get; set; }
    public bool OnSale { get; set; }
}
