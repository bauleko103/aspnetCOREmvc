﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Entities.Enities;

namespace Shop.Entities.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Entities.Enities.Account", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(2048)
                        .HasColumnType("varchar(2048)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            AccountType = 1,
                            Address = "a",
                            BirthDay = new DateTime(2022, 11, 11, 20, 31, 21, 126, DateTimeKind.Local).AddTicks(2872),
                            CreatedDate = new DateTime(2022, 11, 11, 20, 31, 21, 124, DateTimeKind.Local).AddTicks(7366),
                            Email = "abc",
                            IsActive = true,
                            IsDelete = false,
                            Name = "Dương",
                            Password = "1",
                            Phone = "123",
                            Sex = 1,
                            Status = true,
                            Username = "admin"
                        },
                        new
                        {
                            ID = 2L,
                            AccountType = 2,
                            Address = "a",
                            BirthDay = new DateTime(2022, 11, 11, 20, 31, 21, 126, DateTimeKind.Local).AddTicks(5613),
                            CreatedDate = new DateTime(2022, 11, 11, 20, 31, 21, 126, DateTimeKind.Local).AddTicks(5587),
                            Email = "zxxz",
                            IsActive = true,
                            IsDelete = false,
                            Name = "Dương",
                            Password = "1",
                            Phone = "123",
                            Sex = 2,
                            Status = true,
                            Username = "user"
                        });
                });

            modelBuilder.Entity("Shop.Entities.Enities.CategoryProduct", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.ToTable("CategoryProducts");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Comment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("IDAccount")
                        .HasColumnType("bigint");

                    b.Property<long?>("IDProduct")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("IDAccount");

                    b.HasIndex("IDProduct");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Feedback", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("IDAcount")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("IDAcount");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Shop.Entities.Enities.File", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("datetime2")
                        .HasColumnName("datetime2");

                    b.Property<string>("FileContent")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<long?>("IDProduct")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnName("small");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("datetime2")
                        .HasColumnName("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("IDProduct");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Order", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("IDAccount")
                        .HasColumnType("bigint");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<long>("Total")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("IDAccount");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Shop.Entities.Enities.OrderDetail", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("IDOrder")
                        .HasColumnType("bigint");

                    b.Property<long?>("IDProduct")
                        .HasColumnType("bigint");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<long>("Total")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("IDOrder");

                    b.HasIndex("IDProduct");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Payment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<long?>("IDAccount")
                        .HasColumnType("bigint");

                    b.Property<long?>("IDOrder")
                        .HasColumnType("bigint");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("IDAccount");

                    b.HasIndex("IDOrder");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Product", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<long?>("IDCategoryProduct")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("IDCategoryProduct");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shop.Entities.Enities.CategoryProduct", b =>
                {
                    b.HasOne("Shop.Entities.Enities.Account", "Account")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Comment", b =>
                {
                    b.HasOne("Shop.Entities.Enities.Account", "Account")
                        .WithMany("Comments")
                        .HasForeignKey("IDAccount")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Shop.Entities.Enities.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Feedback", b =>
                {
                    b.HasOne("Shop.Entities.Enities.Account", "Account")
                        .WithMany("Feedbacks")
                        .HasForeignKey("IDAcount")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Shop.Entities.Enities.File", b =>
                {
                    b.HasOne("Shop.Entities.Enities.Account", "Account")
                        .WithMany("Files")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Shop.Entities.Enities.Product", "Product")
                        .WithMany("Files")
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Order", b =>
                {
                    b.HasOne("Shop.Entities.Enities.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("IDAccount")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Shop.Entities.Enities.OrderDetail", b =>
                {
                    b.HasOne("Shop.Entities.Enities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("IDOrder")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Shop.Entities.Enities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Payment", b =>
                {
                    b.HasOne("Shop.Entities.Enities.Account", "Account")
                        .WithMany("Payments")
                        .HasForeignKey("IDAccount")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Shop.Entities.Enities.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("IDOrder")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Account");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Product", b =>
                {
                    b.HasOne("Shop.Entities.Enities.Account", "Account")
                        .WithMany("Products")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Shop.Entities.Enities.CategoryProduct", "CategoryProduct")
                        .WithMany("Products")
                        .HasForeignKey("IDCategoryProduct")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Account");

                    b.Navigation("CategoryProduct");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Account", b =>
                {
                    b.Navigation("CategoryProducts");

                    b.Navigation("Comments");

                    b.Navigation("Feedbacks");

                    b.Navigation("Files");

                    b.Navigation("Orders");

                    b.Navigation("Payments");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Shop.Entities.Enities.CategoryProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Shop.Entities.Enities.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Files");

                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
