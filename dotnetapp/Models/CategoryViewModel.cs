using System.Collections.Generic;
namespace dotnetapp.Models;
public class CategoryViewModel
{
    public Category Category { get; set; }

    public List<Book> Books { get; set; }
}
