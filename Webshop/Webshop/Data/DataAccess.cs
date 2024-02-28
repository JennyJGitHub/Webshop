using Microsoft.EntityFrameworkCore;
using Webshop.Models;

namespace Webshop.Data;

public class DataAccess
{
    private readonly ApplicationDbContext _context;

    public DataAccess(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllProducts()
    {
        var products = await _context.Products.ToListAsync();
        return products;
    }

    public async Task<Product> GetProductById(int id)
    {
        var product = await _context.Products.FindAsync(id);
        return product;
    }

    public async Task<List<Product>> GetCartItems(ApplicationUser user)
    {
        List<Product> cartItems = new();
        var userCart = await _context.CartItems.Include(c => c.Product).Where(c => c.User.Id == user.Id).ToListAsync();
        foreach (var item in userCart)
        {
            if (item.Quantity > 1)
            {
                for (int i = 0; i < item.Quantity; i++)
                {
                    cartItems.Add(item.Product);
                }
            }
            else
            {
                cartItems.Add(item.Product);
            }
        }
        return cartItems;
    }

    public async Task AddCartItem(ApplicationUser user, Product product)
    {
        var cartItem = _context.CartItems.Include(c => c.Product).SingleOrDefault(c => c.User.Id == user.Id && c.Product.Id == product.Id);
        if (cartItem == null)
        {
            CartItem newCartItem = new() { User = user, Product = product, Quantity = 1 };
            _context.CartItems.Add(newCartItem);
        }
        else
        {
            cartItem.Quantity += 1;
            _context.CartItems.Update(cartItem);
        }
        await _context.SaveChangesAsync();
    }

    public async Task RemoveCartItem(ApplicationUser user, Product product)
    {
        var cartItem = _context.CartItems.Single(c => c.User.Id == user.Id && c.Product.Id == product.Id);
        if (cartItem.Quantity == 1)
        {
            _context.CartItems.Remove(cartItem);
        }
        else
        {
            cartItem.Quantity -= 1;
            _context.CartItems.Update(cartItem);
        }
        await _context.SaveChangesAsync();
    }

    public async Task EmptyCart(ApplicationUser user)
    {
        var cart = _context.CartItems.Where(c => c.User.Id == user.Id);
        _context.CartItems.RemoveRange(cart);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }
}
