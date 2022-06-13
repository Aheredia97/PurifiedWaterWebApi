using Microsoft.EntityFrameworkCore;
using PurifiedWaterWebApi.Context.Entities;
using System.Linq;

namespace PurifiedWaterWebApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region OnModelCreating
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }
            #endregion
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
    }
}
