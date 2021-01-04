using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public partial class MySqlContext : DbContext
    {
        public MySqlContext()
        {
        }

        public MySqlContext(DbContextOptions<MySqlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;User=root;password=senha;port=3306;database=jetecommerce;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Users
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasColumnName("salt")
                    .HasColumnType("varchar(36)")
                    .HasDefaultValueSql("'0'");
            });


            // Products
            modelBuilder.Entity<Product>(entity =>
            {

                entity.ToTable("products");
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category_id)
                    .IsRequired()
                    .HasColumnName("category_id")
                     .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasColumnName("discount")
                    .HasColumnType("decimal(5,2)");

                 entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasColumnName("stock")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                 entity.Property(e => e.Url_image)
                    .IsRequired()
                    .HasColumnName("url_image")
                    .HasColumnType("varchar(36)")
                    .HasDefaultValueSql("'0'");

                 entity.Property(e => e.Is_promotion)
                    .IsRequired()
                    .HasColumnName("is_promotion")
                    .HasColumnType("boolean")
                    .HasDefaultValueSql("'0'");

                 entity.Property(e => e.Is_activate)
                    .IsRequired()
                    .HasColumnName("is_activate")
                    .HasColumnType("boolean")
                    .HasDefaultValueSql("'0'");
            });


             // Categorys
            modelBuilder.Entity<Category>(entity =>
            {

                entity.ToTable("categorys");
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasColumnName("discount")
                    .HasColumnType("decimal(5,2)");

                 entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasColumnName("stock")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                 entity.Property(e => e.Url_image)
                    .IsRequired()
                    .HasColumnName("url_image")
                    .HasColumnType("varchar(36)")
                    .HasDefaultValueSql("'0'");

                 entity.Property(e => e.Is_promotion)
                    .IsRequired()
                    .HasColumnName("is_promotion")
                    .HasColumnType("boolean")
                    .HasDefaultValueSql("'0'");

                 entity.Property(e => e.Is_activate)
                    .IsRequired()
                    .HasColumnName("is_activate")
                    .HasColumnType("boolean")
                    .HasDefaultValueSql("'0'");
            });

        }
    }
}