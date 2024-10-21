using Microsoft.EntityFrameworkCore;
using ProjetNews.Data;

namespace ProjetNews.Models
{
    public class WebContext : DbContext
    
    {
        public WebContext(DbContextOptions<WebContext> options)
            : base(options)
    {
    }
        public DbSet<News> Newss { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Teame> Teames { get; set; }
    }
}
