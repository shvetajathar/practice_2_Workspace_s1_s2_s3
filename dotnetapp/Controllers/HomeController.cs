// using dotnetapp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using dotnetapp.Models;
namespace dotnetapp.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Fetch featured books
        var featuredBooks = _context.Books.Where(b => b.IsFeatured).ToList();
        var viewModel = new HomeViewModel { FeaturedBooks = featuredBooks };
        return View(viewModel);
    }

    public IActionResult Category(int categoryId)
    {
        // Fetch books for a specific category
        var category = _context.Categories.Find(categoryId);
        var books = _context.Books.Where(b => b.CategoryId == categoryId).ToList();
        var viewModel = new CategoryViewModel { Category = category, Books = books };
        return View(viewModel);
    }

    public IActionResult BookDetails(int bookId)
    {
        // Fetch book details
        var book = _context.Books.Find(bookId);
        var viewModel = new BookDetailsViewModel { Book = book };
        return View(viewModel);
    }

    public IActionResult ShoppingCart()
    {
        // Fetch shopping cart details
        var shoppingCart = _context.ShoppingCarts.Include(sc => sc.Items).FirstOrDefault();
        var viewModel = new ShoppingCartViewModel { Cart = shoppingCart };
        return View(viewModel);
    }
}

