﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shopping.Data;

#nullable disable

namespace Shopping.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbControllerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shopping.Models.Param", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CONT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seq_no")
                        .HasColumnType("int");

                    b.Property<int>("Tag")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Param");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CONT = "Payment completed",
                            Seq_no = 1,
                            Tag = 1
                        },
                        new
                        {
                            Id = 2,
                            CONT = "To be shipped",
                            Seq_no = 2,
                            Tag = 2
                        });
                });

            modelBuilder.Entity("Shopping.Models.Shoporder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Shoporder");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 90,
                            OrderId = "A20202026001",
                            OrderItem = "Product1",
                            Price = 100,
                            Status = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cost = 100,
                            OrderId = "A20202023001",
                            OrderItem = "Product2",
                            Price = 120,
                            Status = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Cost = 150,
                            OrderId = "A20202026002",
                            OrderItem = "Product3",
                            Price = 200,
                            Status = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Cost = 120,
                            OrderId = "A20202024003",
                            OrderItem = "Product4",
                            Price = 150,
                            Status = 1,
                            UserId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
