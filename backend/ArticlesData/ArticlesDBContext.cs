using ArticlesData.Models;
using Microsoft.EntityFrameworkCore;

namespace ArticlesData
{
    public class ArticlesDBContext : DbContext
    {
        public ArticlesDBContext() { }
        public ArticlesDBContext(DbContextOptions<ArticlesDBContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
    }
}