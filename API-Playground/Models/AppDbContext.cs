using API_Playground.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Playground.Models;

{
    public sealed class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
}
}
