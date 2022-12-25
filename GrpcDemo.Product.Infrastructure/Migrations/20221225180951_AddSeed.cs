using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrpcDemo.Product.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("3d889ad4-cdee-42c8-adf2-0419892b30ba"), "Çöküş", 76m },
                    { new Guid("9d8abdec-67f7-481f-8eab-e3df947a9c01"), "Donnie Darko", 46.4m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d889ad4-cdee-42c8-adf2-0419892b30ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d8abdec-67f7-481f-8eab-e3df947a9c01"));
        }
    }
}
