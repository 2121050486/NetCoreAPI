using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<person> person {get;set;}
    }
}