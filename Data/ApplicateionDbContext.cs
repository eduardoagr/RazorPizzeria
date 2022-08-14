using Microsoft.EntityFrameworkCore;

using RazorPizzeria.Models;

namespace RazorPizzeria.Data;

public class ApplicateionDbContext : DbContext
{
    public DbSet<PizzaOrder> pizzaOrders
    {
        get; set;
    }

    public ApplicateionDbContext(DbContextOptions<ApplicateionDbContext> options)
        : base(options)
    {

    }
}
