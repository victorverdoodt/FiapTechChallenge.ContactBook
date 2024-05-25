using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using Microsoft.EntityFrameworkCore;


namespace FiapTechChallenge.ContactBook.Infrastructure.Data.Contexts
{
    public partial class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<DDD> DDDs { get; set; }
        public DbSet<Region> Regions { get; set; }

        public async Task Initialize(CancellationToken cancellationToken)
        {
            var migrations = await this.Database.GetPendingMigrationsAsync();
            if (migrations.Any())
            {
                var strategy = this.Database.CreateExecutionStrategy();
                await strategy.ExecuteAsync(() => this.Database.MigrateAsync(cancellationToken));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().HasData(
                new Region { Id = 1, Name = "AC" },
                new Region { Id = 2, Name = "AL" },
                new Region { Id = 3, Name = "AM" },
                new Region { Id = 4, Name = "AP" },
                new Region { Id = 5, Name = "BA" },
                new Region { Id = 6, Name = "CE" },
                new Region { Id = 7, Name = "DF" },
                new Region { Id = 8, Name = "ES" },
                new Region { Id = 9, Name = "GO" },
                new Region { Id = 10, Name = "MA" },
                new Region { Id = 11, Name = "MG" },
                new Region { Id = 12, Name = "MS" },
                new Region { Id = 13, Name = "MT" },
                new Region { Id = 14, Name = "PA" },
                new Region { Id = 15, Name = "PB" },
                new Region { Id = 16, Name = "PE" },
                new Region { Id = 17, Name = "PI" },
                new Region { Id = 18, Name = "PR" },
                new Region { Id = 19, Name = "RJ" },
                new Region { Id = 20, Name = "RN" },
                new Region { Id = 21, Name = "RO" },
                new Region { Id = 22, Name = "RR" },
                new Region { Id = 23, Name = "RS" },
                new Region { Id = 24, Name = "SC" },
                new Region { Id = 25, Name = "SE" },
                new Region { Id = 26, Name = "SP" },
                new Region { Id = 27, Name = "TO" }
            );

            modelBuilder.Entity<DDD>().HasData(
                new DDD { Id = 1, Code = "68", RegionId = 1 },
                new DDD { Id = 2, Code = "82", RegionId = 2 },
                new DDD { Id = 3, Code = "92", RegionId = 3 },
                new DDD { Id = 4, Code = "97", RegionId = 3 },
                new DDD { Id = 5, Code = "96", RegionId = 4 },
                new DDD { Id = 6, Code = "71", RegionId = 5 },
                new DDD { Id = 7, Code = "73", RegionId = 5 },
                new DDD { Id = 8, Code = "74", RegionId = 5 },
                new DDD { Id = 9, Code = "75", RegionId = 5 },
                new DDD { Id = 10, Code = "77", RegionId = 5 },
                new DDD { Id = 11, Code = "85", RegionId = 6 },
                new DDD { Id = 12, Code = "88", RegionId = 6 },
                new DDD { Id = 13, Code = "61", RegionId = 7 },
                new DDD { Id = 14, Code = "27", RegionId = 8 },
                new DDD { Id = 15, Code = "28", RegionId = 8 },
                new DDD { Id = 16, Code = "62", RegionId = 9 },
                new DDD { Id = 17, Code = "64", RegionId = 9 },
                new DDD { Id = 18, Code = "98", RegionId = 10 },
                new DDD { Id = 19, Code = "99", RegionId = 10 },
                new DDD { Id = 20, Code = "31", RegionId = 11 },
                new DDD { Id = 21, Code = "32", RegionId = 11 },
                new DDD { Id = 22, Code = "33", RegionId = 11 },
                new DDD { Id = 23, Code = "34", RegionId = 11 },
                new DDD { Id = 24, Code = "35", RegionId = 11 },
                new DDD { Id = 25, Code = "37", RegionId = 11 },
                new DDD { Id = 26, Code = "38", RegionId = 11 },
                new DDD { Id = 27, Code = "67", RegionId = 12 },
                new DDD { Id = 28, Code = "65", RegionId = 13 },
                new DDD { Id = 29, Code = "66", RegionId = 13 },
                new DDD { Id = 30, Code = "91", RegionId = 14 },
                new DDD { Id = 31, Code = "93", RegionId = 14 },
                new DDD { Id = 32, Code = "94", RegionId = 14 },
                new DDD { Id = 33, Code = "83", RegionId = 15 },
                new DDD { Id = 34, Code = "81", RegionId = 16 },
                new DDD { Id = 35, Code = "87", RegionId = 16 },
                new DDD { Id = 36, Code = "86", RegionId = 17 },
                new DDD { Id = 37, Code = "89", RegionId = 17 },
                new DDD { Id = 38, Code = "41", RegionId = 18 },
                new DDD { Id = 39, Code = "42", RegionId = 18 },
                new DDD { Id = 40, Code = "43", RegionId = 18 },
                new DDD { Id = 41, Code = "44", RegionId = 18 },
                new DDD { Id = 42, Code = "45", RegionId = 18 },
                new DDD { Id = 43, Code = "46", RegionId = 18 },
                new DDD { Id = 44, Code = "21", RegionId = 19 },
                new DDD { Id = 45, Code = "22", RegionId = 19 },
                new DDD { Id = 46, Code = "24", RegionId = 19 },
                new DDD { Id = 47, Code = "84", RegionId = 20 },
                new DDD { Id = 48, Code = "69", RegionId = 21 },
                new DDD { Id = 49, Code = "95", RegionId = 22 },
                new DDD { Id = 50, Code = "51", RegionId = 23 },
                new DDD { Id = 51, Code = "53", RegionId = 23 },
                new DDD { Id = 52, Code = "54", RegionId = 23 },
                new DDD { Id = 53, Code = "55", RegionId = 23 },
                new DDD { Id = 54, Code = "47", RegionId = 24 },
                new DDD { Id = 55, Code = "48", RegionId = 24 },
                new DDD { Id = 56, Code = "49", RegionId = 24 },
                new DDD { Id = 57, Code = "79", RegionId = 25 },
                new DDD { Id = 58, Code = "11", RegionId = 26 },
                new DDD { Id = 59, Code = "12", RegionId = 26 },
                new DDD { Id = 60, Code = "13", RegionId = 26 },
                new DDD { Id = 61, Code = "14", RegionId = 26 },
                new DDD { Id = 62, Code = "15", RegionId = 26 },
                new DDD { Id = 63, Code = "16", RegionId = 26 },
                new DDD { Id = 64, Code = "17", RegionId = 26 },
                new DDD { Id = 65, Code = "18", RegionId = 26 },
                new DDD { Id = 66, Code = "19", RegionId = 26 },
                new DDD { Id = 67, Code = "63", RegionId = 27 }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, Name = "Lucas Silva", Email = "lucas.silva@example.com", Phone = "66912345678", DDDId = 13 },
                new Contact { Id = 2, Name = "Mateus Santos", Email = "mateus.santos@example.com", Phone = "81956781234", DDDId = 16 },
                new Contact { Id = 3, Name = "Gabriel Oliveira", Email = "gabriel.oliveira@example.com", Phone = "95934567890", DDDId = 22 },
                new Contact { Id = 4, Name = "Ana Souza", Email = "ana.souza@example.com", Phone = "99345678901", DDDId = 10 },
                new Contact { Id = 5, Name = "Julia Rodrigues", Email = "julia.rodrigues@example.com", Phone = "93345678901", DDDId = 14 },
                new Contact { Id = 6, Name = "Mariana Almeida", Email = "mariana.almeida@example.com", Phone = "71345678901", DDDId = 5 },
                new Contact { Id = 7, Name = "Rafael Costa", Email = "rafael.costa@example.com", Phone = "71345678901", DDDId = 5 },
                new Contact { Id = 8, Name = "Fernanda Gomes", Email = "fernanda.gomes@example.com", Phone = "71345678901", DDDId = 5 },
                new Contact { Id = 9, Name = "Carlos Martins", Email = "carlos.martins@example.com", Phone = "71345678901", DDDId = 5 },
                new Contact { Id = 10, Name = "Laura Lima", Email = "laura.lima@example.com", Phone = "71345678901", DDDId = 5 },
                new Contact { Id = 11, Name = "Lucas Santos", Email = "lucas.santos@example.com", Phone = "84345678901", DDDId = 20 },
                new Contact { Id = 12, Name = "Mateus Oliveira", Email = "mateus.oliveira@example.com", Phone = "84345678901", DDDId = 20 },
                new Contact { Id = 13, Name = "Gabriel Silva", Email = "gabriel.silva@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 14, Name = "Ana Almeida", Email = "ana.almeida@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 15, Name = "Julia Costa", Email = "julia.costa@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 16, Name = "Mariana Rodrigues", Email = "mariana.rodrigues@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 17, Name = "Rafael Gomes", Email = "rafael.gomes@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 18, Name = "Fernanda Martins", Email = "fernanda.martins@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 19, Name = "Carlos Lima", Email = "carlos.lima@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 20, Name = "Laura Silva", Email = "laura.silva@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 21, Name = "Lucas Costa", Email = "lucas.costa@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 22, Name = "Mateus Martins", Email = "mateus.martins@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 23, Name = "Gabriel Lima", Email = "gabriel.lima@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 24, Name = "Ana Gomes", Email = "ana.gomes@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 25, Name = "Julia Almeida", Email = "julia.almeida@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 26, Name = "Mariana Silva", Email = "mariana.silva@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 27, Name = "Rafael Santos", Email = "rafael.santos@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 28, Name = "Fernanda Oliveira", Email = "fernanda.oliveira@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 29, Name = "Carlos Silva", Email = "carlos.silva@example.com", Phone = "15345678901", DDDId = 62 },
                new Contact { Id = 30, Name = "Laura Santos", Email = "laura.santos@example.com", Phone = "15345678901", DDDId = 62 }
            );
        }
    }
}
