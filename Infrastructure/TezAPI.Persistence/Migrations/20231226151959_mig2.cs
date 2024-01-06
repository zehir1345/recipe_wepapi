using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("14438f9d-7598-44ab-9194-6375798edd47"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("30146674-1018-4ebd-8238-71e8d6494bfc"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("56d803fd-881c-4094-aa81-a4bdbb205028"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("6f491387-38bd-4478-aac6-00a2190e9373"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("80d064cb-6583-4175-a15d-0112adfcf63b"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("8a83dacd-60b6-4008-bccf-f11c2c67758b"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("aeaab8ec-6ea6-490c-83a6-ce51560df080"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("b197526d-79ed-43d2-862e-0c62362a0fd8"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("b76a0979-6ba8-4c12-aaa7-b28bb5226c1f"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("e0637de3-160a-4518-a12b-f737d635be24"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("f1c4ec13-7077-41ec-b476-3690708d8d08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0452adc0-9593-4cf0-8dd7-78124cd9f7f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d256c48-6e94-4e42-ac0b-2b6404f55417"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c48936a-840d-4620-a87e-61523aee04d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34c978b6-d0b0-452f-b310-6d1a85f09b0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("398b06b0-f436-430d-9c4a-c1ebca03ffe2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72546194-b5a2-49a2-aca7-ef4940ee9981"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83e1a69b-9f9e-46c8-ba07-f47520a00f11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8eba0975-6fe4-4e74-82ca-397ae073d156"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("93b10295-185b-4ba6-822f-40d6fb25d9f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98aed52e-91a2-497c-8c76-c53835529f17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ac68dca-5ab9-40dd-9ce5-61b7422e0b1b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4a019bd-c454-4533-b994-ad06d7290e23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c65f0079-5349-4b69-8bdd-e48572a5ae13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e794f138-d04a-4063-85b4-f3e3bada094a"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("14438f9d-7598-44ab-9194-6375798edd47"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8196), "Peanut" },
                    { new Guid("30146674-1018-4ebd-8238-71e8d6494bfc"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8204), "Shellfish" },
                    { new Guid("56d803fd-881c-4094-aa81-a4bdbb205028"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8209), "Wheat" },
                    { new Guid("6f491387-38bd-4478-aac6-00a2190e9373"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8199), "Soy" },
                    { new Guid("80d064cb-6583-4175-a15d-0112adfcf63b"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8198), "Dessert" },
                    { new Guid("8a83dacd-60b6-4008-bccf-f11c2c67758b"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8194), "Gluten" },
                    { new Guid("aeaab8ec-6ea6-490c-83a6-ce51560df080"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8190), "Dairy" },
                    { new Guid("b197526d-79ed-43d2-862e-0c62362a0fd8"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8207), "Pork" },
                    { new Guid("b76a0979-6ba8-4c12-aaa7-b28bb5226c1f"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8201), "Egg" },
                    { new Guid("e0637de3-160a-4518-a12b-f737d635be24"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8210), "Sesame" },
                    { new Guid("f1c4ec13-7077-41ec-b476-3690708d8d08"), new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8202), "Seafood" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate" },
                values: new object[,]
                {
                    { new Guid("0452adc0-9593-4cf0-8dd7-78124cd9f7f9"), "Breakfast", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8329) },
                    { new Guid("0d256c48-6e94-4e42-ac0b-2b6404f55417"), "Side", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8345) },
                    { new Guid("2c48936a-840d-4620-a87e-61523aee04d8"), "Starter", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8346) },
                    { new Guid("34c978b6-d0b0-452f-b310-6d1a85f09b0f"), "Beef", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8327) },
                    { new Guid("398b06b0-f436-430d-9c4a-c1ebca03ffe2"), "Vegetarian", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8351) },
                    { new Guid("72546194-b5a2-49a2-aca7-ef4940ee9981"), "Pasta", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8341) },
                    { new Guid("83e1a69b-9f9e-46c8-ba07-f47520a00f11"), "Dessert", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8333) },
                    { new Guid("8eba0975-6fe4-4e74-82ca-397ae073d156"), "Lamb", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8338) },
                    { new Guid("93b10295-185b-4ba6-822f-40d6fb25d9f0"), "Miscellaneous", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8339) },
                    { new Guid("98aed52e-91a2-497c-8c76-c53835529f17"), "Goat", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8334) },
                    { new Guid("9ac68dca-5ab9-40dd-9ce5-61b7422e0b1b"), "Seafood", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8344) },
                    { new Guid("c4a019bd-c454-4533-b994-ad06d7290e23"), "Pork", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8342) },
                    { new Guid("c65f0079-5349-4b69-8bdd-e48572a5ae13"), "Chicken", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8331) },
                    { new Guid("e794f138-d04a-4063-85b4-f3e3bada094a"), "Vegan", new DateTime(2023, 12, 26, 13, 36, 55, 93, DateTimeKind.Utc).AddTicks(8348) }
                });
        }
    }
}
