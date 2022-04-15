using Microsoft.EntityFrameworkCore;
using RestAPI_Project_BookWeb.Models;

namespace RestAPI_Project_BookWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
