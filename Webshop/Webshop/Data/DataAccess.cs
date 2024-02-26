using Microsoft.EntityFrameworkCore;
using Webshop.Data.Models;

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

    public async Task<List<Product>> GetCart(ApplicationUser user)
    {
        var currentUser = await _context.Users.Include(u => u.Cart).FirstOrDefaultAsync(u => u.Id == user.Id);
        return currentUser.Cart;
    }

    public async Task UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUser(ApplicationUser user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }
}
