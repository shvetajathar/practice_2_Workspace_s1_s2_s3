namespace dotnetapp.Models;
public class ShoppingCartItem
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int Quantity { get; set; }

    public Book Book { get; set; }
}
