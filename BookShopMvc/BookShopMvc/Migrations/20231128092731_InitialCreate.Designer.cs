﻿// <auto-generated />
using System;
using BookShopMvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShopMvc.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20231128092731_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShopMvc.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookShopMvc.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("BookShopMvc.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookShopMvc.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Grand_total")
                        .HasColumnType("decimal(14,0)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shipping_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Update_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookShopMvc.Models.Order_item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Buy_qty")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(14,0)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Order_items");
                });

            modelBuilder.Entity("BookShopMvc.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(14,0)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("SubcategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Thumb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BookShopMvc.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("BookShopMvc.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Star_rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("Update_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BookShopMvc.Models.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("BookShopMvc.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime>("Update_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookShopMvc.Models.Cart", b =>
                {
                    b.HasOne("BookShopMvc.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopMvc.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopMvc.Models.Order", b =>
                {
                    b.HasOne("BookShopMvc.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopMvc.Models.Order_item", b =>
                {
                    b.HasOne("BookShopMvc.Models.Order", "Order")
                        .WithMany("Order_items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopMvc.Models.Product", "Product")
                        .WithMany("Order_items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BookShopMvc.Models.Product", b =>
                {
                    b.HasOne("BookShopMvc.Models.Author", "Author")
                        .WithMany("Products")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopMvc.Models.Publisher", "Publisher")
                        .WithMany("Products")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopMvc.Models.Subcategory", "Subcategory")
                        .WithMany("Products")
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publisher");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("BookShopMvc.Models.Review", b =>
                {
                    b.HasOne("BookShopMvc.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopMvc.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopMvc.Models.Subcategory", b =>
                {
                    b.HasOne("BookShopMvc.Models.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookShopMvc.Models.Author", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BookShopMvc.Models.Category", b =>
                {
                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("BookShopMvc.Models.Order", b =>
                {
                    b.Navigation("Order_items");
                });

            modelBuilder.Entity("BookShopMvc.Models.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Order_items");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BookShopMvc.Models.Publisher", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BookShopMvc.Models.Subcategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BookShopMvc.Models.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
