using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorPizzeria.Models;

namespace RazorPizzeria.Pages;

public class PizzaModel : PageModel
{
    public List<Pizza> PizzasDB = new()
    {
        new Pizza() { ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 4 },
        new Pizza() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 2, TomatoSauce=true, Cheese = true, Beef = true, FinalPrice = 5 },
        new Pizza() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 15 },
        new Pizza() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Mushrooms = true, FinalPrice = 6 },
        new Pizza() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 6 },
        new Pizza() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, TomatoSauce = true, Cheese = true, Mushrooms = true, FinalPrice = 5 },
        new Pizza() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 2, TomatoSauce = true, Cheese = true, Pepperoni = true, FinalPrice = 5 },
        new Pizza() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 2, TomatoSauce = true, Cheese = true, Tuna = true, FinalPrice = 5 },
        new Pizza() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 2, TomatoSauce = true, Cheese = true, Mushrooms = true, Pineapple = true, FinalPrice = 12 },
    };

    public void OnGet()
    {
    }
}
