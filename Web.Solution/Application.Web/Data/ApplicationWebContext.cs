using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Entities.Models;

namespace Application.Web.Models
{
    public class ApplicationWebContext : DbContext
    {
        public ApplicationWebContext (DbContextOptions<ApplicationWebContext> options)
            : base(options)
        {
        }

        public DbSet<Application.Entities.Models.Customer> Customer { get; set; }
    }
}
