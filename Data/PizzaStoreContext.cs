namespace BlazingPizza.Data;

using Microsoft.EntityFrameworkCore;
public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options):base(options)
    {

    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<PizzaSpecial> Specials { get; set; }
   
}
