using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ogani.Migrations
{
    public partial class add_table_blog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0651b925-1aea-47f5-9d3c-9a6068719a5e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4dad28e1-8f33-42ec-a170-780151fdca09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52c7977f-b7aa-41b4-8aa4-a70ad14e5543"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6baa3a43-a231-4728-9027-78d56739cdcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75905e32-0f69-4221-8149-5951642a5c28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1b522a0-b716-425b-8323-050e1313bdeb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b70a84d4-5b07-468b-ab9d-01f34ae68809"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db953381-d9ce-4e17-8ec9-ec993a40228e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e13a15df-9c7a-42ef-a113-ae83944d6532"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9487041-c8e4-4f66-a83a-f454a9e63808"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc04176f-8a18-4a0f-95ba-171d932e7a9a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe202495-8a1a-4abb-abfd-38dcb6567199"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7504697-ba11-44f2-93d9-736849debe95"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("99a2b12b-7840-416d-8cd3-ee56f0367815"));

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

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
                    { new Guid("fc04176f-8a18-4a0f-95ba-171d932e7a9a"), "", "Fresh Onion" },
                    { new Guid("75905e32-0f69-4221-8149-5951642a5c28"), "", "Meat" },
                    { new Guid("e13a15df-9c7a-42ef-a113-ae83944d6532"), "", "Oranges" },
                    { new Guid("f9487041-c8e4-4f66-a83a-f454a9e63808"), "", "Fastfood" },
                    { new Guid("fe202495-8a1a-4abb-abfd-38dcb6567199"), "", "Fruit & Nut Gifts" },
                    { new Guid("db953381-d9ce-4e17-8ec9-ec993a40228e"), "", "Fresh Berries" },
                    { new Guid("6baa3a43-a231-4728-9027-78d56739cdcc"), "", "Ocean Foods" },
                    { new Guid("b1b522a0-b716-425b-8323-050e1313bdeb"), "", "Butter & Eggs" },
                    { new Guid("52c7977f-b7aa-41b4-8aa4-a70ad14e5543"), "", "Sea Food" },
                    { new Guid("0651b925-1aea-47f5-9d3c-9a6068719a5e"), "", "Oatmeal" },
                    { new Guid("b70a84d4-5b07-468b-ab9d-01f34ae68809"), "", "Fresh Bananas" },
                    { new Guid("4dad28e1-8f33-42ec-a170-780151fdca09"), "", "Drink Fruits" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9"),
                column: "CreateAt",
                value: new DateTime(2022, 3, 22, 0, 54, 4, 766, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "CurrentPrice", "Description", "Image", "Name", "Rate", "ReducePrice", "SupplierId", "ToTalRemaining" },
                values: new object[] { new Guid("f7504697-ba11-44f2-93d9-736849debe95"), new DateTime(2022, 3, 22, 0, 54, 4, 770, DateTimeKind.Local).AddTicks(583), "500", "Feature", "/img/featured/feature-2.jpg", "Feature-2", 0, "200", new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"), 5 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cc88ab6f-5d66-4c30-a60e-8f5254f1e112"),
                column: "ConcurrencyStamp",
                value: "a4ba845b-2b89-453b-bb0d-89f9d88625cc");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("99a2b12b-7840-416d-8cd3-ee56f0367815"), "ca9b01cd-329f-4828-a5af-8d80064be4c2", "employee", "employee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0027068e-4c5d-4ecb-a157-b9cc063cd672"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9da6b5c-c532-4d33-9a82-1bbbda07848c", "AQAAAAEAACcQAAAAENtR8OhnSNGCRHS1AHeIgbczFebbdDj3XRP2q1hg6JrQbNKrpb/2IOwIwjYNecRgRQ==" });
        }
    }
}
