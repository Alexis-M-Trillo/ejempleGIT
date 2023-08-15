using Microsoft.EntityFrameworkCore;
using BlazingSushi.Shared;

namespace BlazingSushi.Server.Models
{
    public class SushiStoreContext : DbContext
    {
        public DbSet<SushiSpecial> Sushi { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;database=PizzaStore");
        }
    }
}
