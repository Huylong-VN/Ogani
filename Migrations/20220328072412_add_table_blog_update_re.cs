using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ogani.Migrations
{
    public partial class add_table_blog_update_re : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12180db9-f0cd-4f49-942b-e7a209fb5762"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3bddb6eb-4649-482e-b047-6c7355707baa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5eda00c0-61ee-4feb-b69e-964a36a08887"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d42442e-1380-4718-8f1b-168188dfff2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97914234-c15e-4b46-8a79-86a6fd079028"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b028f39d-2bea-4f72-bee3-6cb6cb27aba9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7916e0a-3cf0-4b3c-b373-70e6bc5bcf81"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("af280dc0-c93e-4b64-a390-2c92dd700f02"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("be8857a5-ab33-4648-b7c1-de003c513af0"), "", "Meat" },
                    { new Guid("76e0a243-65e7-4be3-b54a-d3332e91f2b4"), "", "Oranges" },
                    { new Guid("8f9231a1-7d56-467e-9ac6-0e9e675bc939"), "", "Fastfood" },
                    { new Guid("63bfd0cd-aebc-4048-bcd8-9aecd471a206"), "", "Fresh Bananas" },
                    { new Guid("ae606eb9-fdb7-4ff7-b9a5-d27643262dd0"), "", "Drink Fruits" },
                    { new Guid("0dac5d43-0f94-4b2e-917a-88dc36884515"), "", "Sea Food" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9"),
                column: "CreateAt",
                value: new DateTime(2022, 3, 28, 14, 24, 11, 284, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "CurrentPrice", "Description", "Image", "Name", "Rate", "ReducePrice", "SupplierId", "ToTalRemaining" },
                values: new object[] { new Guid("4978a2c5-90be-4b31-8c4c-3bbf27f8fd41"), new DateTime(2022, 3, 28, 14, 24, 11, 286, DateTimeKind.Local).AddTicks(7126), "500", "Feature", "/img/featured/feature-2.jpg", "Feature-2", 0, "200", new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"), 5 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cc88ab6f-5d66-4c30-a60e-8f5254f1e112"),
                column: "ConcurrencyStamp",
                value: "97dadfdf-5229-41c5-a9f0-404915371cec");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("1c10e13b-0497-4336-ab07-ac041201b518"), "9f902b4f-5aa5-42b7-9df5-1995b06ffd21", "employee", "employee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0027068e-4c5d-4ecb-a157-b9cc063cd672"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9fb5782-7da4-4ffe-83e6-304834ce33fa", "AQAAAAEAACcQAAAAEAWooYwesTEBGJkR84fGD75CU853iaAbezkhbaIeRMwmEu/3L6+g7opz6phl5pZYhg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0dac5d43-0f94-4b2e-917a-88dc36884515"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63bfd0cd-aebc-4048-bcd8-9aecd471a206"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76e0a243-65e7-4be3-b54a-d3332e91f2b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f9231a1-7d56-467e-9ac6-0e9e675bc939"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae606eb9-fdb7-4ff7-b9a5-d27643262dd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8857a5-ab33-4648-b7c1-de003c513af0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4978a2c5-90be-4b31-8c4c-3bbf27f8fd41"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c10e13b-0497-4336-ab07-ac041201b518"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3bddb6eb-4649-482e-b047-6c7355707baa"), "", "Meat" },
                    { new Guid("97914234-c15e-4b46-8a79-86a6fd079028"), "", "Oranges" },
                    { new Guid("8d42442e-1380-4718-8f1b-168188dfff2d"), "", "Fastfood" },
                    { new Guid("b028f39d-2bea-4f72-bee3-6cb6cb27aba9"), "", "Fresh Bananas" },
                    { new Guid("12180db9-f0cd-4f49-942b-e7a209fb5762"), "", "Drink Fruits" },
                    { new Guid("5eda00c0-61ee-4feb-b69e-964a36a08887"), "", "Sea Food" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9"),
                column: "CreateAt",
                value: new DateTime(2022, 3, 28, 14, 20, 4, 403, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "CurrentPrice", "Description", "Image", "Name", "Rate", "ReducePrice", "SupplierId", "ToTalRemaining" },
                values: new object[] { new Guid("b7916e0a-3cf0-4b3c-b373-70e6bc5bcf81"), new DateTime(2022, 3, 28, 14, 20, 4, 405, DateTimeKind.Local).AddTicks(4293), "500", "Feature", "/img/featured/feature-2.jpg", "Feature-2", 0, "200", new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"), 5 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cc88ab6f-5d66-4c30-a60e-8f5254f1e112"),
                column: "ConcurrencyStamp",
                value: "b0aa40e8-845d-41d5-bd35-a68ba6ca1a1b");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("af280dc0-c93e-4b64-a390-2c92dd700f02"), "9954b7b5-8229-4d98-b13c-c9259956891d", "employee", "employee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0027068e-4c5d-4ecb-a157-b9cc063cd672"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7d80b29-f3fa-4de5-88f4-d912b41f05ca", "AQAAAAEAACcQAAAAEJhNV86+iftbJ3LZP1QEe1wVGxWZc+RmvoNoaIk5hF/Bu8SGy/e5bp2oO9QgDLVAkA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId",
                unique: true);
        }
    }
}
