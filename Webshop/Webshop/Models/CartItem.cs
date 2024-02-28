using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Webshop.Data;

namespace Webshop.Models;

public class CartItem
{
    public int Id { get; set; }
    public ApplicationUser User { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }

}
