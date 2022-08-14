using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages;

public class OrdersModel : PageModel
{
    public List<PizzaOrder> pizzaOrders
    {
        get; set;
    }

    public readonly ApplicateionDbContext _context;

    public OrdersModel(ApplicateionDbContext context)
    {
        pizzaOrders = new List<PizzaOrder>();
        _context = context;
    }

    public void OnGet()
    {
        pizzaOrders = _context.pizzaOrders.ToList();
    }
}
