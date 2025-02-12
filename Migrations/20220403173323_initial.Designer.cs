﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ogani.Data;

namespace Ogani.Migrations
{
    [DbContext(typeof(OganiDbContext))]
    [Migration("20220403173323_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "ProviderKey");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Ogani.Data.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cc88ab6f-5d66-4c30-a60e-8f5254f1e112"),
                            ConcurrencyStamp = "e2c26aa7-f848-47df-b1f5-e78ca73084bb",
                            Name = "admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("2161eccc-e4fe-4f96-a200-ed8566084a99"),
                            ConcurrencyStamp = "ea6b833f-b1b6-439a-aa91-f0a24e8d33e6",
                            Name = "employee",
                            NormalizedName = "Employee"
                        });
                });

            modelBuilder.Entity("Ogani.Data.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0027068e-4c5d-4ecb-a157-b9cc063cd672"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c3d41948-7493-4fa3-bb02-4587f1efad10",
                            CreateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEKOyzvOjACVFmpPRwH0oGZZBGUYUjMnmom42yOcnUDyRJM2bWrKysInxjyfUExSa2A==",
                            PhoneNumber = "02002012",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("Ogani.Data.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("0027068e-4c5d-4ecb-a157-b9cc063cd672"),
                            RoleId = new Guid("cc88ab6f-5d66-4c30-a60e-8f5254f1e112")
                        });
                });

            modelBuilder.Entity("Ogani.Data.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Ogani.Data.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("695b5cdb-0992-488e-8963-e76093bb5905"),
                            Description = "",
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = new Guid("c554b60e-0cf6-449d-97b1-ccfb87e73b61"),
                            Description = "",
                            Name = "Meat"
                        },
                        new
                        {
                            Id = new Guid("0f73c4bc-be3e-4cb9-a4c7-733194fcaf4c"),
                            Description = "",
                            Name = "Oranges"
                        },
                        new
                        {
                            Id = new Guid("f7a3b03f-e3e8-4fa8-9a71-1b29bd1ddc07"),
                            Description = "",
                            Name = "Fastfood"
                        },
                        new
                        {
                            Id = new Guid("cd8fdb3b-3d1a-4cc1-b8d2-6113fccf4d24"),
                            Description = "",
                            Name = "Fresh Bananas"
                        },
                        new
                        {
                            Id = new Guid("9e65a252-71b9-4224-b7d0-1c3cc0b76c35"),
                            Description = "",
                            Name = "Drink Fruits"
                        },
                        new
                        {
                            Id = new Guid("f0dc148d-f577-4e20-bb08-d30e94ce795d"),
                            Description = "",
                            Name = "Sea Food"
                        });
                });

            modelBuilder.Entity("Ogani.Data.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Total")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ogani.Data.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("ReducePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ToTalRemaining")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9"),
                            CreateAt = new DateTime(2022, 4, 4, 0, 33, 23, 156, DateTimeKind.Local).AddTicks(5518),
                            CurrentPrice = "100",
                            Description = "Feature",
                            Image = "/img/featured/feature-1.jpg",
                            Name = "Feature-1",
                            Rate = 0,
                            ReducePrice = "200",
                            SupplierId = new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"),
                            ToTalRemaining = 5
                        },
                        new
                        {
                            Id = new Guid("a00d6584-fc5c-44ab-8e2f-b4e36e1e58a6"),
                            CreateAt = new DateTime(2022, 4, 4, 0, 33, 23, 158, DateTimeKind.Local).AddTicks(9563),
                            CurrentPrice = "500",
                            Description = "Feature",
                            Image = "/img/featured/feature-2.jpg",
                            Name = "Feature-2",
                            Rate = 0,
                            ReducePrice = "200",
                            SupplierId = new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"),
                            ToTalRemaining = 5
                        });
                });

            modelBuilder.Entity("Ogani.Data.ProductCategory", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9"),
                            CategoryId = new Guid("695b5cdb-0992-488e-8963-e76093bb5905")
                        });
                });

            modelBuilder.Entity("Ogani.Data.ProductImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3c9a6cad-25cd-4aef-9d16-3f22d6d5d717"),
                            Name = "Feature-3",
                            ProductId = new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9")
                        });
                });

            modelBuilder.Entity("Ogani.Data.ProductOrder", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("Ogani.Data.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"),
                            Address = "Ha noi",
                            Name = " Nguoi ha noi"
                        });
                });

            modelBuilder.Entity("Ogani.Data.AppUserRole", b =>
                {
                    b.HasOne("Ogani.Data.AppRole", "AppRole")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ogani.Data.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Ogani.Data.Blog", b =>
                {
                    b.HasOne("Ogani.Data.AppUser", "AppUser")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Ogani.Data.Order", b =>
                {
                    b.HasOne("Ogani.Data.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Ogani.Data.Product", b =>
                {
                    b.HasOne("Ogani.Data.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Ogani.Data.ProductCategory", b =>
                {
                    b.HasOne("Ogani.Data.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ogani.Data.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ogani.Data.ProductImage", b =>
                {
                    b.HasOne("Ogani.Data.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ogani.Data.ProductOrder", b =>
                {
                    b.HasOne("Ogani.Data.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ogani.Data.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ogani.Data.AppRole", b =>
                {
                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("Ogani.Data.AppUser", b =>
                {
                    b.Navigation("AppUserRoles");

                    b.Navigation("Blogs");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ogani.Data.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Ogani.Data.Order", b =>
                {
                    b.Navigation("ProductOrders");
                });

            modelBuilder.Entity("Ogani.Data.Product", b =>
                {
                    b.Navigation("ProductCategories");

                    b.Navigation("ProductImages");

                    b.Navigation("ProductOrders");
                });

            modelBuilder.Entity("Ogani.Data.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
