using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ogani.Migrations
{
    public partial class add_5cot_minh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0dedf8c9-ab72-4704-8ff3-3cfcd837fe9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18cafd1d-14fb-4793-bc3a-4365d29c1c1b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2bdda6d0-e9a5-47f1-8f3a-b60a82ecd386"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b583ce3-c012-40bf-abf8-481ad6a64fc0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c37e1492-d3e9-4596-8254-1f99f48dd256"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d59851b9-72c7-4130-addf-2d814e626520"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83d8c841-06bc-445d-ac1c-c17ea5e9104e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4c6a0238-3939-4e7f-b378-2feab585c35d"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("82d738ac-29b1-400d-8faf-2a9fef0124aa"), "", "Meat" },
                    { new Guid("77b382e7-d906-4899-a348-49b334b77d84"), "", "Oranges" },
                    { new Guid("ae8fc1ae-64e5-4e7e-9cc6-14c2a2e2f447"), "", "Fastfood" },
                    { new Guid("71c2d88e-976e-47f9-bf2d-0790446af099"), "", "Fresh Bananas" },
                    { new Guid("5ca1097c-6cf0-4358-bfbb-7618ded324e4"), "", "Drink Fruits" },
                    { new Guid("cbdb92cd-6720-44ce-afa2-769540c669e9"), "", "Sea Food" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9"),
                column: "CreateAt",
                value: new DateTime(2022, 3, 31, 11, 39, 30, 570, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "CurrentPrice", "Description", "Image", "Name", "Rate", "ReducePrice", "SupplierId", "ToTalRemaining" },
                values: new object[,]
                {
                    { new Guid("16844377-d714-4495-97b2-a22ce1873492"), new DateTime(2022, 3, 31, 11, 39, 30, 573, DateTimeKind.Local).AddTicks(1549), "500", "Feature", "/img/featured/feature-2.jpg", "Feature-2", 0, "200", new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"), 5 },
                    { new Guid("c6915541-583a-41cb-8c18-2226fb8c06a4"), new DateTime(2022, 3, 31, 11, 39, 30, 573, DateTimeKind.Local).AddTicks(1720), "500", "huy", "/store-image/eada9a7f-7472-4982-8575-8243f453859b.jpg", "Feature-22fsdf", 0, "200", new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cc88ab6f-5d66-4c30-a60e-8f5254f1e112"),
                column: "ConcurrencyStamp",
                value: "e9fe1280-5719-450d-b0c0-95cd980984a4");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("3573908a-8a36-43f0-865d-04af479cea79"), "f0b2def7-2759-4380-bfee-8c893c2f41a2", "employee", "employee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0027068e-4c5d-4ecb-a157-b9cc063cd672"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3deafc67-ffef-45a4-8143-ca36d5966275", "AQAAAAEAACcQAAAAEJBtCeeLxYLoH92qU15TZTzorliD+46JHm16G4ui4E+95pXFm6D3xQwCsh9obm95qg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ca1097c-6cf0-4358-bfbb-7618ded324e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71c2d88e-976e-47f9-bf2d-0790446af099"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77b382e7-d906-4899-a348-49b334b77d84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82d738ac-29b1-400d-8faf-2a9fef0124aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae8fc1ae-64e5-4e7e-9cc6-14c2a2e2f447"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbdb92cd-6720-44ce-afa2-769540c669e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16844377-d714-4495-97b2-a22ce1873492"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6915541-583a-41cb-8c18-2226fb8c06a4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3573908a-8a36-43f0-865d-04af479cea79"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2bdda6d0-e9a5-47f1-8f3a-b60a82ecd386"), "", "Meat" },
                    { new Guid("18cafd1d-14fb-4793-bc3a-4365d29c1c1b"), "", "Oranges" },
                    { new Guid("d59851b9-72c7-4130-addf-2d814e626520"), "", "Fastfood" },
                    { new Guid("0dedf8c9-ab72-4704-8ff3-3cfcd837fe9d"), "", "Fresh Bananas" },
                    { new Guid("4b583ce3-c012-40bf-abf8-481ad6a64fc0"), "", "Drink Fruits" },
                    { new Guid("c37e1492-d3e9-4596-8254-1f99f48dd256"), "", "Sea Food" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed040235-219c-48d8-a12d-3ae4d89a2fb9"),
                column: "CreateAt",
                value: new DateTime(2022, 3, 31, 11, 28, 39, 672, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "CurrentPrice", "Description", "Image", "Name", "Rate", "ReducePrice", "SupplierId", "ToTalRemaining" },
                values: new object[] { new Guid("83d8c841-06bc-445d-ac1c-c17ea5e9104e"), new DateTime(2022, 3, 31, 11, 28, 39, 674, DateTimeKind.Local).AddTicks(1989), "500", "Feature", "/img/featured/feature-2.jpg", "Feature-2", 0, "200", new Guid("ab77aefb-5a93-4fa6-abfb-5c904d7ad5b8"), 5 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cc88ab6f-5d66-4c30-a60e-8f5254f1e112"),
                column: "ConcurrencyStamp",
                value: "fcaf0e5c-fefa-4829-9d6e-185d575239aa");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("4c6a0238-3939-4e7f-b378-2feab585c35d"), "785c0168-1c6e-4f53-9572-76de57d4a3d5", "employee", "employee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0027068e-4c5d-4ecb-a157-b9cc063cd672"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0e1eb14-9765-4f40-a984-334c011a7196", "AQAAAAEAACcQAAAAEHtgXVQ6DydK0/2yUbDYeSydPQIbpN71grCgOIV6bK5sMRc8nZXsXHcMHHNJFyjiwA==" });
        }
    }
}
