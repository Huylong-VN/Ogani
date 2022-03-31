using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ogani.Migrations
{
    public partial class add_table_blog_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11f22df0-3e1f-480d-a3e4-6faadeee1481"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12bde58e-c2a8-45ec-ae3d-3decd85a559b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2689622e-30a4-4469-98dc-b569d82f5f5f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("869412c0-fa39-463b-8730-0f656e3052fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce8c5c73-f4c0-486b-90fa-c635cd760ba8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fff2a7f2-79e2-4183-b3f1-29f0f4f4940c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b90526a0-ea41-4ff5-b454-adb81af88a1f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("153f90f2-fd69-4000-81ae-374d9e07c421"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("ce8c5c73-f4c0-486b-90fa-c635cd760ba8"), "", "Meat" },
                    { new Guid("fff2a7f2-79e2-4183-b3f1-29f0f4f4940c"), "", "Oranges" },
                    { new Guid("12bde58e-c2a8-45ec-ae3d-3decd85a559b"), "", "Fastfood" },
                    { new Guid("2689622e-30a4-4469-98dc-b569d82f5f5f"), "", "Fresh Bananas" },
                    { new Guid("11f22df0-3e1f-480d-a3e4-6faadeee1481"), "", "Drink Fruits" },
                    { new Guid("869412c0-fa39-463b-8730-0f656e3052fa"), "", "Sea Food" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9"),
                column: "CreateAt",
                value: new DateTime(2022, 3, 28, 14, 6, 46, 716, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "CurrentPrice", "Description", "Image", "Name", "Rate", "ReducePrice", "SupplierId", "ToTalRemaining" },
                values: new object[] { new Guid("b90526a0-ea41-4ff5-b454-adb81af88a1f"), new DateTime(2022, 3, 28, 14, 6, 46, 718, DateTimeKind.Local).AddTicks(6684), "500", "Feature", "/img/featured/feature-2.jpg", "Feature-2", 0, "200", new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"), 5 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cc88ab6f-5d66-4c30-a60e-8f5254f1e112"),
                column: "ConcurrencyStamp",
                value: "941d6592-1e9d-4a8d-8e5e-a95fc2976090");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("153f90f2-fd69-4000-81ae-374d9e07c421"), "79d976bf-fa21-41df-aea4-a1169c989756", "employee", "employee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0027068e-4c5d-4ecb-a157-b9cc063cd672"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4544542b-3c71-45a5-81ca-917ecdb5d4b9", "AQAAAAEAACcQAAAAEDm9f81iHOOvEmcPDSJMxPn+0K5SW6+0EJ0E80k/KokD+JtfKF6OaQQqk6NJ5YqG8A==" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");
        }
    }
}
