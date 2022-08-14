﻿namespace RazorPizzeria.Models;

public class Pizza
{
    public string ImageTitle { get; set; } = string.Empty;
    public string PizzaName { get; set; } = string.Empty;
    public float BasePrice { get; set; } = 2f;
    public bool TomatoSauce
    {
        get; set;
    }
    public bool Cheese
    {
        get; set;
    }
    public bool Pepperoni
    {
        get; set;
    }
    public bool Mushrooms
    {
        get; set;
    }
    public bool Tuna
    {
        get; set;
    }
    public bool Pineapple
    {
        get; set;
    }
    public bool Ham
    {
        get; set;
    }
    public bool Beef
    {
        get; set;
    }
    public float FinalPrice
    {
        get; set;
    }
}