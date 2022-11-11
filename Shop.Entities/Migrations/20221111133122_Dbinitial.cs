﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Entities.Migrations
{
    public partial class Dbinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(2048)", maxLength: 2048, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProducts",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryProducts_Accounts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDAcount = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Accounts_IDAcount",
                        column: x => x.IDAcount,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDAccount = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Accounts_IDAccount",
                        column: x => x.IDAccount,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDCategoryProduct = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Accounts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_CategoryProducts_IDCategoryProduct",
                        column: x => x.IDCategoryProduct,
                        principalTable: "CategoryProducts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDAccount = table.Column<long>(type: "bigint", nullable: true),
                    IDOrder = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payments_Accounts_IDAccount",
                        column: x => x.IDAccount,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_IDOrder",
                        column: x => x.IDOrder,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDAccount = table.Column<long>(type: "bigint", nullable: true),
                    IDProduct = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_Accounts_IDAccount",
                        column: x => x.IDAccount,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Products_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileContent = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    small = table.Column<int>(type: "int", nullable: false),
                    datetime2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDProduct = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Files_Accounts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Products_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Total = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDOrder = table.Column<long>(type: "bigint", nullable: true),
                    IDProduct = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_IDOrder",
                        column: x => x.IDOrder,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "ID", "AccountType", "Address", "BirthDay", "CreatedDate", "Email", "IsActive", "IsDelete", "Name", "Password", "Phone", "Sex", "Status", "Username" },
                values: new object[] { 1L, 1, "a", new DateTime(2022, 11, 11, 20, 31, 21, 126, DateTimeKind.Local).AddTicks(2872), new DateTime(2022, 11, 11, 20, 31, 21, 124, DateTimeKind.Local).AddTicks(7366), "abc", true, false, "Dương", "1", "123", 1, true, "admin" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "ID", "AccountType", "Address", "BirthDay", "CreatedDate", "Email", "IsActive", "IsDelete", "Name", "Password", "Phone", "Sex", "Status", "Username" },
                values: new object[] { 2L, 2, "a", new DateTime(2022, 11, 11, 20, 31, 21, 126, DateTimeKind.Local).AddTicks(5613), new DateTime(2022, 11, 11, 20, 31, 21, 126, DateTimeKind.Local).AddTicks(5587), "zxxz", true, false, "Dương", "1", "123", 2, true, "user" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProducts_CreatedBy",
                table: "CategoryProducts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_IDAccount",
                table: "Comments",
                column: "IDAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_IDProduct",
                table: "Comments",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_IDAcount",
                table: "Feedbacks",
                column: "IDAcount");

            migrationBuilder.CreateIndex(
                name: "IX_Files_CreatedBy",
                table: "Files",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Files_IDProduct",
                table: "Files",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IDOrder",
                table: "OrderDetails",
                column: "IDOrder");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IDProduct",
                table: "OrderDetails",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IDAccount",
                table: "Orders",
                column: "IDAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_IDAccount",
                table: "Payments",
                column: "IDAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_IDOrder",
                table: "Payments",
                column: "IDOrder");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatedBy",
                table: "Products",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IDCategoryProduct",
                table: "Products",
                column: "IDCategoryProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "CategoryProducts");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
