using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data;

public class PizzaContext : DbContext
{
// This allows external code to pass in the configuration, so the same DbContext can be shared between test and production code and even used with different providers.
    public PizzaContext (DbContextOptions<PizzaContext> options)
        : base(options)
    {
    }

    // The DbSet<T> properties correspond to tables to be created in the database.
    public DbSet<Pizza> Pizzas => Set<Pizza>();
    public DbSet<Topping> Toppings => Set<Topping>();
    public DbSet<Sauce> Sauces => Set<Sauce>();

}