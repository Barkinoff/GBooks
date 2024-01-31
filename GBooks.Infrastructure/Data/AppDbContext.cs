

using GBooks.Domain.Entites.Addresses;
using GBooks.Domain.Entites.Users;
using GBooks.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace GBooks.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes()) 
            {
                entity.SetTableName(entity.GetTableName().ToSnakeCase());
                foreach (var property in entity.GetProperties()) 
                {
                    property.SetColumnName(property.GetColumnName().ToSnakeCase());
                }
            }

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Entity<User>().
                HasOne(u => u.Role).
                WithOne().
                HasForeignKey<User>(u => u.RoleId);

            modelBuilder.Entity<User>().
               HasOne(u => u.Address).
               WithOne().
               HasForeignKey<User>(u => u.AddressId);

            modelBuilder.Entity<RolePermission>().
               HasOne(u => u.Role).
               WithOne().
               HasForeignKey<RolePermission>(u => u.RoleId);

            modelBuilder.Entity<Role>().
                HasMany(r => r.Permissions).
                WithOne(r => r.Role).
                HasForeignKey(r => r.RoleId);


            base.OnModelCreating(modelBuilder);
        }

    }
}
