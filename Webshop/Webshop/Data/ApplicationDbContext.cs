using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Webshop.Models;

namespace Webshop.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Product> Products {  get; set; }
    //public DbSet<CartItem> CartItems { get; set; }
    //public DbSet<Cart> Carts { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var product1 = new Product
        {
            Id = 1,
            Name = "Donut",
            ShortDescription = "Donut with sprinkles.",
            FullDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim blandit volutpat maecenas volutpat.",
            Price = 2.99,
            Image = "https://images.pexels.com/photos/3253735/pexels-photo-3253735.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            Quantity = 100,
            OnSale = false
        };
        var product2 = new Product
        {
            Id = 2,
            Name = "Chocolate Cupcake",
            ShortDescription = "Chocolate cupcake with chocolate frosting.",
            FullDescription = "Diam vulputate ut pharetra sit amet aliquam id. Adipiscing elit duis tristique sollicitudin nibh sit amet commodo nulla. Tempus egestas sed sed risus pretium quam vulputate.",
            Price = 1.99,
            Image = "https://images.pexels.com/photos/10899790/pexels-photo-10899790.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            Quantity = 100,
            OnSale = true
        };
        var product3 = new Product
        {
            Id = 3,
            Name = "Chocolate Chip Cookie",
            ShortDescription = "Cookie with chocolate and hazelnuts.",
            FullDescription = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            Price = 1.49,
            Image = "https://images.pexels.com/photos/7243524/pexels-photo-7243524.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            Quantity = 300,
            OnSale = false
        };
        var product4 = new Product
        {
            Id = 4,
            Name = "Lemon Cupcake",
            ShortDescription = "Lemon cupcake with vanilla frosting and sprinkles.",
            FullDescription = "Viverra mauris in aliquam sem. Ac auctor augue mauris augue. Ullamcorper sit amet risus nullam eget felis eget nunc. Egestas diam in arcu cursus euismod.",
            Price = 2.49,
            Image = "https://images.pexels.com/photos/6210740/pexels-photo-6210740.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            Quantity = 100,
            OnSale = false
        };
        var product5 = new Product
        {
            Id = 5,
            Name = "Chocolate Cake",
            ShortDescription = "Chocolate cake with berries.",
            FullDescription = "Velit euismod in pellentesque massa placerat. Libero nunc consequat interdum varius sit amet mattis vulputate enim. Nisl rhoncus mattis rhoncus urna neque.",
            Price = 49.99,
            Image = "https://images.pexels.com/photos/10975256/pexels-photo-10975256.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            Quantity = 50,
            OnSale = false
        };

        modelBuilder.Entity<Product>().HasData(product1, product2, product3, product4, product5);

        base.OnModelCreating(modelBuilder);
    }
}
