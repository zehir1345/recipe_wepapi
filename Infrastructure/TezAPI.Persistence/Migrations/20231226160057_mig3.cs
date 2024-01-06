using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("084fc693-c596-4870-a169-72e6ae0e433a"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("19223370-c44e-4326-bc22-0385f8cf17e5"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("19b4b29c-fc6a-4f26-ac07-7b31e9da49d3"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("3a5d84f5-20d1-4f77-88a3-110932dfc7f4"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("4a81f4a5-6d98-48ea-ad28-a525c036e91c"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("596e578d-e635-42b5-a496-0d8a19ddaee1"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("8fd33f8d-9c5b-40ab-91d5-4a032a6f8ccb"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("aa58123e-97cc-4520-84b4-12c874ac76e3"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("c5842b74-7539-4e64-adbd-6d45b0793b49"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("d3ceb332-e3a2-478b-99dc-9d78581e263f"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("e190704a-fa3c-4e98-a79d-d2bab792a5a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05e4e462-3271-4f3f-b623-6c2f306701ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("149f9953-afe1-46f8-960e-469adda123f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16be813f-b5f8-4d8f-9bde-dd5f38b43932"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ef6d1b5-f902-4217-88ae-0eed5558efc1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b9db212-cbb6-4d6a-bb7d-dedc51bb1311"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("677f7540-44a7-4046-a07a-dd125bd9c0e8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6fd19800-99f5-435e-a43a-0deb15bab283"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c5e7b14-c32f-4424-a9ab-bf8bb3769f54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acfe695e-4dd4-4d91-9ec4-607277b3e4ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b42d2b2c-f78e-4e14-8df2-e4877be9f284"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ceb65b84-edf2-4df9-b388-0c289b523006"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d34a85e0-1043-4135-9e0b-e14d2d64cf77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df03b51c-9f34-4c09-aa92-667a50567c03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3d64d51-a2f7-4c87-ad6e-39c496efdc91"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Recipes",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients");

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
                name: "UserId",
                table: "Recipes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients",
                columns: new[] { "RecipeId", "IngredientId" });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("084fc693-c596-4870-a169-72e6ae0e433a"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3156), "Dairy" },
                    { new Guid("19223370-c44e-4326-bc22-0385f8cf17e5"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3182), "Shellfish" },
                    { new Guid("19b4b29c-fc6a-4f26-ac07-7b31e9da49d3"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3185), "Wheat" },
                    { new Guid("3a5d84f5-20d1-4f77-88a3-110932dfc7f4"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3161), "Dessert" },
                    { new Guid("4a81f4a5-6d98-48ea-ad28-a525c036e91c"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3164), "Egg" },
                    { new Guid("596e578d-e635-42b5-a496-0d8a19ddaee1"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3163), "Soy" },
                    { new Guid("8fd33f8d-9c5b-40ab-91d5-4a032a6f8ccb"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3166), "Seafood" },
                    { new Guid("aa58123e-97cc-4520-84b4-12c874ac76e3"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3160), "Peanut" },
                    { new Guid("c5842b74-7539-4e64-adbd-6d45b0793b49"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3158), "Gluten" },
                    { new Guid("d3ceb332-e3a2-478b-99dc-9d78581e263f"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3184), "Pork" },
                    { new Guid("e190704a-fa3c-4e98-a79d-d2bab792a5a5"), new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3186), "Sesame" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate" },
                values: new object[,]
                {
                    { new Guid("05e4e462-3271-4f3f-b623-6c2f306701ca"), "Goat", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3319) },
                    { new Guid("149f9953-afe1-46f8-960e-469adda123f4"), "Beef", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3309) },
                    { new Guid("16be813f-b5f8-4d8f-9bde-dd5f38b43932"), "Starter", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3336) },
                    { new Guid("1ef6d1b5-f902-4217-88ae-0eed5558efc1"), "Pork", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3325) },
                    { new Guid("2b9db212-cbb6-4d6a-bb7d-dedc51bb1311"), "Side", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3334) },
                    { new Guid("677f7540-44a7-4046-a07a-dd125bd9c0e8"), "Vegan", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3339) },
                    { new Guid("6fd19800-99f5-435e-a43a-0deb15bab283"), "Chicken", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3313) },
                    { new Guid("8c5e7b14-c32f-4424-a9ab-bf8bb3769f54"), "Breakfast", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3311) },
                    { new Guid("acfe695e-4dd4-4d91-9ec4-607277b3e4ed"), "Seafood", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3333) },
                    { new Guid("b42d2b2c-f78e-4e14-8df2-e4877be9f284"), "Vegetarian", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3341) },
                    { new Guid("ceb65b84-edf2-4df9-b388-0c289b523006"), "Dessert", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3315) },
                    { new Guid("d34a85e0-1043-4135-9e0b-e14d2d64cf77"), "Miscellaneous", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3322) },
                    { new Guid("df03b51c-9f34-4c09-aa92-667a50567c03"), "Lamb", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3321) },
                    { new Guid("f3d64d51-a2f7-4c87-ad6e-39c496efdc91"), "Pasta", new DateTime(2023, 12, 26, 15, 19, 59, 303, DateTimeKind.Utc).AddTicks(3324) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
