using MemoryCacheExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace MemoryCacheExample.Repositories;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Product> Product { get; set; }
}