﻿// <auto-generated />
using System;
using DATN.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DATN.Migrations
{
    [DbContext(typeof(FastFoodContext))]
    [Migration("20220108070251_AddModelEvaCmtWishlist")]
    partial class AddModelEvaCmtWishlist
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DATN.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DATN.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Account_Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProductId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DATN.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Account_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DATN.Models.Evaluate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Account_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("EvaluationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProductId");

                    b.ToTable("Evaluates");
                });

            modelBuilder.Entity("DATN.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Account_Id")
                        .HasColumnType("int");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("Invoice_Id")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("DATN.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Account_Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ShippingCost")
                        .HasColumnType("float");

                    b.Property<string>("ShippingPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DATN.Models.InvoiceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("Invoice_Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.Property<int>("Promotion_ID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PromotionId");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("DATN.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ProductType_Id")
                        .HasColumnType("int");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.Property<int>("Promotion_Id")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("PromotionId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DATN.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("DATN.Models.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("DATN.Models.Wishlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Account_Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProductId");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("DATN.Models.Cart", b =>
                {
                    b.HasOne("DATN.Models.Account", "Account")
                        .WithMany("Carts")
                        .HasForeignKey("AccountId");

                    b.HasOne("DATN.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId");

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DATN.Models.Comment", b =>
                {
                    b.HasOne("DATN.Models.Account", "Account")
                        .WithMany("Comments")
                        .HasForeignKey("AccountId");

                    b.HasOne("DATN.Models.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId");

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DATN.Models.Evaluate", b =>
                {
                    b.HasOne("DATN.Models.Account", "Account")
                        .WithMany("Evaluates")
                        .HasForeignKey("AccountId");

                    b.HasOne("DATN.Models.Product", "Product")
                        .WithMany("Evaluates")
                        .HasForeignKey("ProductId");

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DATN.Models.History", b =>
                {
                    b.HasOne("DATN.Models.Account", "Account")
                        .WithMany("Histories")
                        .HasForeignKey("AccountId");

                    b.HasOne("DATN.Models.Invoice", "Invoice")
                        .WithMany("Histories")
                        .HasForeignKey("InvoiceId");

                    b.Navigation("Account");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("DATN.Models.Invoice", b =>
                {
                    b.HasOne("DATN.Models.Account", "Account")
                        .WithMany("Invoices")
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DATN.Models.InvoiceDetail", b =>
                {
                    b.HasOne("DATN.Models.Invoice", "Invoice")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("DATN.Models.Product", "Product")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("ProductId");

                    b.HasOne("DATN.Models.Promotion", "Promotion")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("PromotionId");

                    b.Navigation("Invoice");

                    b.Navigation("Product");

                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("DATN.Models.Product", b =>
                {
                    b.HasOne("DATN.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId");

                    b.HasOne("DATN.Models.Promotion", "Promotion")
                        .WithMany("Products")
                        .HasForeignKey("PromotionId");

                    b.Navigation("ProductType");

                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("DATN.Models.Wishlist", b =>
                {
                    b.HasOne("DATN.Models.Account", "Account")
                        .WithMany("Wishlists")
                        .HasForeignKey("AccountId");

                    b.HasOne("DATN.Models.Product", "Product")
                        .WithMany("Wishlists")
                        .HasForeignKey("ProductId");

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DATN.Models.Account", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Comments");

                    b.Navigation("Evaluates");

                    b.Navigation("Histories");

                    b.Navigation("Invoices");

                    b.Navigation("Wishlists");
                });

            modelBuilder.Entity("DATN.Models.Invoice", b =>
                {
                    b.Navigation("Histories");

                    b.Navigation("InvoiceDetails");
                });

            modelBuilder.Entity("DATN.Models.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Comments");

                    b.Navigation("Evaluates");

                    b.Navigation("InvoiceDetails");

                    b.Navigation("Wishlists");
                });

            modelBuilder.Entity("DATN.Models.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DATN.Models.Promotion", b =>
                {
                    b.Navigation("InvoiceDetails");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}