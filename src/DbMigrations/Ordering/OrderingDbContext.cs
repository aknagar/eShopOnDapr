using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DbMigrations.Ordering
{
    public partial class OrderingDbContext : DbContext
    {
        public OrderingDbContext()
        {
        }

        public OrderingDbContext(DbContextOptions<OrderingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cardtype> Cardtypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Microsoft.eShopOnContainers.Services.OrderingDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cardtype>(entity =>
            {
                entity.ToTable("cardtypes", "ordering");

                entity.Property(e => e.Id).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders", "ordering");

                entity.HasIndex(e => e.OrderNumber, "AK_orders_OrderNumber")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddressCity).HasColumnName("Address_City");

                entity.Property(e => e.AddressCountry).HasColumnName("Address_Country");

                entity.Property(e => e.AddressState).HasColumnName("Address_State");

                entity.Property(e => e.AddressStreet).HasColumnName("Address_Street");

                entity.Property(e => e.AddressZipCode).HasColumnName("Address_ZipCode");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("orderItems", "ordering");

                entity.HasIndex(e => e.OrderId, "IX_orderItems_OrderId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.HasSequence("orderseq", "ordering").IncrementsBy(10);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
