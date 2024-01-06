using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Allergies_AllergyId",
                table: "Recipes");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("21f643f8-e5b7-40be-a9a1-82431d3f5b03"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("27e4cf9f-4ba1-419c-9f9c-08e18d303e9c"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("41205175-cb20-43dc-baaa-b996504417dc"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("5888d76b-e24b-4c3d-b5bd-39255a2b9bbe"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("6ac05c38-78ae-429c-bdae-846e6dc54fcb"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("7682a866-ca12-4432-9e9f-901c873d364f"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("a1d13c30-1b83-4710-a818-e687c036f777"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("b92417aa-26e1-4444-95f2-5ae7c77db34c"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("cee7aded-f890-477a-9985-e99ecf9b3442"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("df1e56ee-71f9-4f6d-b728-9d596e99a501"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("ff8fa7c7-035f-40c7-9394-31ec357b8a84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19ee09a2-f8eb-4bd9-9ab4-b08b698ac53b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ac40351-c38e-4d08-9b45-b1c9741ca870"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a86aceb-7ae2-48d7-afbb-63b09ca525e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5854d083-5a64-4220-9b55-6a9cdfc09383"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d0da6bb-f484-4355-b1ea-dd8fb5b2929d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8bc1df3f-be0e-4893-a72b-c252c63d7310"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9521c076-57f1-447e-9680-84a88851269d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ca4b590-082b-44b8-b01d-8fb1f09913c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1a9e786-3d0b-42e6-b504-6532b282b01f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfd67674-6a45-4984-8a9b-3c29ebac1944"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2e34c9c-bc1e-4380-89d0-1b615b17269c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db547e56-9d52-45b7-a66e-8ec9b34ee482"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e15a6796-6c60-456f-9871-c3175cf39949"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec9bb0bd-873d-4987-b51a-6a05c4cadc2f"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AllergyId",
                table: "Recipes",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Files",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("11342a05-431d-402e-8b95-945e7a8b54d8"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5164), "Egg" },
                    { new Guid("14f28f66-2023-4c59-b0bc-ef2ac58b9b80"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5167), "Shellfish" },
                    { new Guid("1da2cc27-d215-41f5-ba1f-f1a2a6ec4e9e"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5148), "Dessert" },
                    { new Guid("21c47d34-5341-4049-b306-011e8cd4c541"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5172), "Sesame" },
                    { new Guid("3b966ab8-9124-40e7-9ae8-924c98bfe9d6"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5166), "Seafood" },
                    { new Guid("52bae312-31fe-40d4-9890-9b39fc44046a"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5142), "Dairy" },
                    { new Guid("6eb07e38-2851-4350-b6a4-448522960961"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5147), "Peanut" },
                    { new Guid("7d898e27-256b-454e-bc11-945816ee79f9"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5170), "Wheat" },
                    { new Guid("c6e52986-53e8-4461-819d-44836a9269ef"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5145), "Gluten" },
                    { new Guid("e52508d6-f5bd-403b-84bc-0648cdca0a49"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5169), "Pork" },
                    { new Guid("fada1ca5-fd49-44ca-8158-a3199611a331"), new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5163), "Soy" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate" },
                values: new object[,]
                {
                    { new Guid("18252d66-634b-4e54-9b6f-76fd76b73714"), "Pork", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5328) },
                    { new Guid("294a27c6-44ba-47a6-b257-65fc1a45c162"), "Chicken", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5319) },
                    { new Guid("32ab1d88-6f9f-447a-80db-88c23c88bc90"), "Miscellaneous", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5325) },
                    { new Guid("333c31c0-390e-4f55-90fa-3fad68cd31b8"), "Vegan", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5336) },
                    { new Guid("3ef5b401-3a9a-4f68-aabd-05896386763a"), "Pasta", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5327) },
                    { new Guid("54e9ba34-dec4-4ac3-a31c-6bf0f6709219"), "Dessert", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5321) },
                    { new Guid("70554f0d-35fc-454d-a941-28c97694eeed"), "Starter", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5335) },
                    { new Guid("75c3f772-ec4f-4ecc-8ffa-5c8d33f109f3"), "Goat", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5322) },
                    { new Guid("79f18845-924e-4e81-a09d-d4e5e32ef9ae"), "Seafood", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5332) },
                    { new Guid("87c6f14e-2e06-46fd-baff-5892ba5d57c8"), "Vegetarian", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5337) },
                    { new Guid("b5419e65-2ce3-4ead-bb00-05b1c729e571"), "Side", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5333) },
                    { new Guid("b6ba3d23-01d9-4ce8-909a-45befb2fdc2c"), "Lamb", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5324) },
                    { new Guid("da16be06-0d9a-41b9-9442-aee38a9c9f3c"), "Beef", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5312) },
                    { new Guid("fde2dc31-76cc-4577-936f-8db5e688c8d6"), "Breakfast", new DateTime(2024, 1, 6, 12, 18, 57, 519, DateTimeKind.Utc).AddTicks(5317) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Files_UserId",
                table: "Files",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Users_UserId",
                table: "Files",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Allergies_AllergyId",
                table: "Recipes",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Users_UserId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Allergies_AllergyId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Files_UserId",
                table: "Files");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("11342a05-431d-402e-8b95-945e7a8b54d8"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("14f28f66-2023-4c59-b0bc-ef2ac58b9b80"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("1da2cc27-d215-41f5-ba1f-f1a2a6ec4e9e"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("21c47d34-5341-4049-b306-011e8cd4c541"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("3b966ab8-9124-40e7-9ae8-924c98bfe9d6"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("52bae312-31fe-40d4-9890-9b39fc44046a"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("6eb07e38-2851-4350-b6a4-448522960961"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("7d898e27-256b-454e-bc11-945816ee79f9"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("c6e52986-53e8-4461-819d-44836a9269ef"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("e52508d6-f5bd-403b-84bc-0648cdca0a49"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("fada1ca5-fd49-44ca-8158-a3199611a331"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18252d66-634b-4e54-9b6f-76fd76b73714"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("294a27c6-44ba-47a6-b257-65fc1a45c162"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32ab1d88-6f9f-447a-80db-88c23c88bc90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("333c31c0-390e-4f55-90fa-3fad68cd31b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ef5b401-3a9a-4f68-aabd-05896386763a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54e9ba34-dec4-4ac3-a31c-6bf0f6709219"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70554f0d-35fc-454d-a941-28c97694eeed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75c3f772-ec4f-4ecc-8ffa-5c8d33f109f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f18845-924e-4e81-a09d-d4e5e32ef9ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87c6f14e-2e06-46fd-baff-5892ba5d57c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5419e65-2ce3-4ead-bb00-05b1c729e571"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6ba3d23-01d9-4ce8-909a-45befb2fdc2c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da16be06-0d9a-41b9-9442-aee38a9c9f3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fde2dc31-76cc-4577-936f-8db5e688c8d6"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Files");

            migrationBuilder.AlterColumn<Guid>(
                name: "AllergyId",
                table: "Recipes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("21f643f8-e5b7-40be-a9a1-82431d3f5b03"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8697), "Sesame" },
                    { new Guid("27e4cf9f-4ba1-419c-9f9c-08e18d303e9c"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8665), "Dairy" },
                    { new Guid("41205175-cb20-43dc-baaa-b996504417dc"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8670), "Gluten" },
                    { new Guid("5888d76b-e24b-4c3d-b5bd-39255a2b9bbe"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8686), "Shellfish" },
                    { new Guid("6ac05c38-78ae-429c-bdae-846e6dc54fcb"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8675), "Dessert" },
                    { new Guid("7682a866-ca12-4432-9e9f-901c873d364f"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8677), "Soy" },
                    { new Guid("a1d13c30-1b83-4710-a818-e687c036f777"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8678), "Egg" },
                    { new Guid("b92417aa-26e1-4444-95f2-5ae7c77db34c"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8684), "Seafood" },
                    { new Guid("cee7aded-f890-477a-9985-e99ecf9b3442"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8691), "Pork" },
                    { new Guid("df1e56ee-71f9-4f6d-b728-9d596e99a501"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8673), "Peanut" },
                    { new Guid("ff8fa7c7-035f-40c7-9394-31ec357b8a84"), new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8695), "Wheat" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate" },
                values: new object[,]
                {
                    { new Guid("19ee09a2-f8eb-4bd9-9ab4-b08b698ac53b"), "Vegetarian", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8917) },
                    { new Guid("3ac40351-c38e-4d08-9b45-b1c9741ca870"), "Seafood", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8907) },
                    { new Guid("4a86aceb-7ae2-48d7-afbb-63b09ca525e3"), "Pork", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8905) },
                    { new Guid("5854d083-5a64-4220-9b55-6a9cdfc09383"), "Beef", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8885) },
                    { new Guid("6d0da6bb-f484-4355-b1ea-dd8fb5b2929d"), "Goat", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8894) },
                    { new Guid("8bc1df3f-be0e-4893-a72b-c252c63d7310"), "Lamb", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8899) },
                    { new Guid("9521c076-57f1-447e-9680-84a88851269d"), "Chicken", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8890) },
                    { new Guid("9ca4b590-082b-44b8-b01d-8fb1f09913c8"), "Starter", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8911) },
                    { new Guid("b1a9e786-3d0b-42e6-b504-6532b282b01f"), "Breakfast", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8888) },
                    { new Guid("cfd67674-6a45-4984-8a9b-3c29ebac1944"), "Side", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8909) },
                    { new Guid("d2e34c9c-bc1e-4380-89d0-1b615b17269c"), "Pasta", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8903) },
                    { new Guid("db547e56-9d52-45b7-a66e-8ec9b34ee482"), "Dessert", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8892) },
                    { new Guid("e15a6796-6c60-456f-9871-c3175cf39949"), "Miscellaneous", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8901) },
                    { new Guid("ec9bb0bd-873d-4987-b51a-6a05c4cadc2f"), "Vegan", new DateTime(2023, 12, 26, 16, 0, 57, 714, DateTimeKind.Utc).AddTicks(8913) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Allergies_AllergyId",
                table: "Recipes",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
