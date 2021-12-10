using BooksAdministration.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksAdministration.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }   
}
