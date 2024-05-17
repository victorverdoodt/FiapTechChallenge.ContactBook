using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using Microsoft.EntityFrameworkCore;

namespace FiapTechChallenge.ContactBook.Infrastructure.Data.Contexts
{
    public partial class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<DDD> DDDs { get; set; }
        public virtual DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
