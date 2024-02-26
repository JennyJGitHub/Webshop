namespace Webshop.Client.Classes;

public class Order
{
    //public string UserName { get; set; } // Eller ska det skippas?
    public Customer Customer { get; set; }
    public List<Item> Items { get; set; }
    public double Cost { get; set; }
}
