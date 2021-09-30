using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

public partial class ShopDbContext : DbContext
{
    public ShopDbContext()
        : base("name=ShopDbContext")
    {
    }
    public virtual DbSet<News> News { get; set; }
}
