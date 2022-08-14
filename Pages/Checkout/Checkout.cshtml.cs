using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout;

[BindProperties(SupportsGet = true)]
public class CheckoutModel : PageModel
{
    public string PizzaName
    {
        get; set;
    }
    public float PizzaPrice
    {
        get; set;
    }
    public string ImageTitle
    {
        get; set;
    }

    private readonly ApplicateionDbContext _context;

    public CheckoutModel(ApplicateionDbContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        if (string.IsNullOrEmpty(ImageTitle))
        {
            ImageTitle = "Create";
        }
        if (string.IsNullOrEmpty(PizzaName))
        {
            PizzaName = "Create";
        }
        if (PizzaPrice <= 0)
        {
            PizzaPrice = 8;
        }

        var order = new PizzaOrder
        {
            PizzaName = PizzaName,
            BasePrice = PizzaPrice
        };

        _context.pizzaOrders.Add(order);
        _context.SaveChanges();
    }
}
