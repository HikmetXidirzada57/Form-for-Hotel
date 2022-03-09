using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Hotelform.Models
{
    public partial class HotelDBContext : DbContext
    {
        public HotelDBContext()
        {
        }

        public HotelDBContext(DbContextOptions<HotelDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserToRol> UserToRols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =LAPTOP-UQ4T15K6;initial catalog=HotelDB;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Floor>(entity =>
            {
                entity.Property(e => e.FloorId).HasColumnName("floorId");

                entity.Property(e => e.FloorNumber).HasColumnName("floorNumber");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.Checkin).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.RoomId).HasColumnName("roomId");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__customer__36B12243");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK__Orders__roomId__35BCFE0A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__userId__37A5467C");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.RolName)
                    .HasMaxLength(50)
                    .HasColumnName("rolName");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomId).HasColumnName("roomId");

                entity.Property(e => e.FloorId).HasColumnName("floorId");

                entity.Property(e => e.RoomtypeId).HasColumnName("roomtypeId");

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.FloorId)
                    .HasConstraintName("FK__Rooms__floorId__29572725");

                entity.HasOne(d => d.Roomtype)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.RoomtypeId)
                    .HasConstraintName("FK__Rooms__roomtypeI__286302EC");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.Property(e => e.RoomTypeId).HasColumnName("roomTypeId");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(300);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserToRol>(entity =>
            {
                entity.HasKey(e => e.UserToRolsId)
                    .HasName("PK__UserToRo__F66673C68E13AB9A");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserToRols)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__UserToRol__RoleI__300424B4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserToRols)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserToRol__userI__30F848ED");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
