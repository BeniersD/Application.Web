using Microsoft.EntityFrameworkCore;
using Application.Entities.Models;

namespace Application.Data.Data
{
    public class ApplicationWebContext : DbContext
    {
        public ApplicationWebContext (DbContextOptions<ApplicationWebContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}
