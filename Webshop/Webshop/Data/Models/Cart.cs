//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Webshop.Data.Models;

//public class Cart
//{
//    public string UserId { get; set; }
//    public int CartItemId { get; set; }

//    [ForeignKey(nameof(UserId))]
//    public ApplicationUser? User { get; set; }

//    [ForeignKey(nameof(CartItemId))]
//    public CartItem CartItem { get; set; }

//}
