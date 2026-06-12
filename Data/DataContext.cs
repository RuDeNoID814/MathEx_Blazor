using Microsoft.EntityFrameworkCore;

namespace MathEx_Blazor.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)

{
    public DbSet<Card> Cards => Set<Card>();
}