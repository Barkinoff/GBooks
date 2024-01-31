

using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Addresses;
using GBooks.Domain.Entites.Attachments;
using GBooks.Domain.Entites.Books;
using GBooks.Domain.Entites.Carts;
using GBooks.Domain.Entites.Categories;
using GBooks.Domain.Entites.Discounts;
using GBooks.Domain.Entites.Order;
using GBooks.Domain.Entites.Payments;
using GBooks.Domain.Entites.Supliers;
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
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Suplier> Supliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

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

            modelBuilder.Entity<Book>().
                HasOne(u => u.Discount).
                WithOne().
                HasForeignKey<Book>(u => u.DiscountId);

            modelBuilder.Entity<Book>().
                HasOne(u => u.Author).
                WithOne().
                HasForeignKey<Book>(u => u.AuthorId);

            modelBuilder.Entity<Book>().
                HasOne(u => u.Language).
                WithOne().
                HasForeignKey<Book>(u => u.LanguageId);

            modelBuilder.Entity<Book>().
                HasOne(u => u.Attachment).
                WithOne().
                HasForeignKey<Book>(u => u.AttachmentId);

            modelBuilder.Entity<Book>().
                HasOne(u => u.SubCategory).
                WithOne().
                HasForeignKey<Book>(u => u.SubCategoryId);

            modelBuilder.Entity<Category>().
                HasOne(u => u.SubCategory).
                WithOne().
                HasForeignKey<Category>(u => u.SubCategoryId);

            modelBuilder.Entity<Category>().
                HasOne(u => u.ParentCategory).
                WithOne().
                HasForeignKey<Category>(u => u.ParentId);

            modelBuilder.Entity<SubCategory>().
                HasMany(r => r.Books).
                WithOne(r => r.SubCategory).
                HasForeignKey(r => r.SubCategoryId);

            modelBuilder.Entity<Author>().
                HasMany(r => r.AuthorBooks).
                WithOne(r => r.Author).
                HasForeignKey(r => r.AuthorId);

            modelBuilder.Entity<Author>().
                HasOne(u => u.Attachment).
                WithOne().
                HasForeignKey<Author>(u => u.AttachmentId);

            modelBuilder.Entity<Discount>().
                HasOne(u => u.Attachment).
                WithOne().
                HasForeignKey<Discount>(u => u.AttachmentId);

            modelBuilder.Entity<Cart>().
                HasOne(u => u.User).
                WithOne().
                HasForeignKey<Cart>(u => u.UserId);

            modelBuilder.Entity<CartItem>().
                HasOne(u => u.Book).
                WithOne().
                HasForeignKey<CartItem>(u => u.BookId);

            modelBuilder.Entity<CartItem>().
                HasOne(u => u.Cart).
                WithOne().
                HasForeignKey<CartItem>(u => u.CartId);

            modelBuilder.Entity<Suplier>().
                HasOne(u => u.Attachment).
                WithOne().
                HasForeignKey<Suplier>(u => u.AttachmentId);

            modelBuilder.Entity<Order>().
                HasOne(u => u.User).
                WithOne().
                HasForeignKey<Order>(u => u.UserId);

            modelBuilder.Entity<Order>().
                HasOne(u => u.Suplier).
                WithOne().
                HasForeignKey<Order>(u => u.SuplierId);

            modelBuilder.Entity<Order>().
                HasOne(u => u.Address).
                WithOne().
                HasForeignKey<Order>(u => u.AddressId);

            modelBuilder.Entity<Order>().
                HasOne(u => u.Payment).
                WithOne().
                HasForeignKey<Order>(u => u.PaymentId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
