using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestaoProdutos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Produtos1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FornecedorCodigo = table.Column<int>(type: "int", nullable: false),
                    FornecedorDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FornecedorCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "DataFabricacao", "DataValidade", "Descricao", "FornecedorCnpj", "FornecedorCodigo", "FornecedorDescricao", "Situacao" },
                values: new object[,]
                {
                    { 1, "525814128898576", new DateTime(2022, 9, 30, 12, 54, 13, 489, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 9, 27, 2, 40, 4, 358, DateTimeKind.Local).AddTicks(7980), "Handcrafted Cotton Salad", "447272390001", 819, "Hahn Inc", "Inativo" },
                    { 2, "411914198066469", new DateTime(2022, 10, 15, 18, 2, 13, 172, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 11, 5, 22, 39, 2, 730, DateTimeKind.Local).AddTicks(774), "Rustic Plastic Computer", "297432500001", 289, "Schultz, Pollich and Moen", "Inativo" },
                    { 3, "634532717114483", new DateTime(2023, 3, 8, 6, 18, 46, 940, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 5, 3, 22, 37, 23, 734, DateTimeKind.Local).AddTicks(5333), "Awesome Rubber Chair", "224392140001", 1017, "Frami - Hoppe", "Inativo" },
                    { 4, "812064437132669", new DateTime(2022, 9, 30, 22, 42, 37, 778, DateTimeKind.Local).AddTicks(951), new DateTime(2023, 8, 22, 17, 11, 58, 729, DateTimeKind.Local).AddTicks(5898), "Unbranded Soft Tuna", "253099040001", 1025, "Kulas and Sons", "Inativo" },
                    { 5, "630955820030493", new DateTime(2022, 12, 15, 0, 28, 55, 211, DateTimeKind.Local).AddTicks(2953), new DateTime(2023, 11, 25, 21, 40, 4, 625, DateTimeKind.Local).AddTicks(491), "Practical Soft Table", "666439230001", 968, "Sawayn - Lemke", "Ativo" },
                    { 6, "213804402607931", new DateTime(2022, 7, 3, 14, 35, 58, 229, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 1, 22, 9, 19, 17, 398, DateTimeKind.Local).AddTicks(2852), "Refined Frozen Chips", "933523320001", 1223, "Brakus and Sons", "Ativo" },
                    { 7, "039227370969951", new DateTime(2022, 6, 13, 14, 0, 31, 472, DateTimeKind.Local).AddTicks(6157), new DateTime(2023, 12, 26, 12, 13, 10, 483, DateTimeKind.Local).AddTicks(8529), "Intelligent Plastic Shirt", "598502640001", 102, "Prohaska, Kovacek and Kirlin", "Inativo" },
                    { 8, "001737894175458", new DateTime(2022, 11, 26, 8, 17, 17, 974, DateTimeKind.Local).AddTicks(9598), new DateTime(2024, 3, 26, 14, 28, 48, 402, DateTimeKind.Local).AddTicks(9080), "Sleek Metal Fish", "658014480001", 1214, "Rutherford - Schoen", "Ativo" },
                    { 9, "381451100032066", new DateTime(2022, 11, 24, 10, 45, 27, 279, DateTimeKind.Local).AddTicks(2477), new DateTime(2024, 2, 19, 13, 54, 45, 600, DateTimeKind.Local).AddTicks(2179), "Practical Cotton Mouse", "948653180001", 219, "Thompson, VonRueden and Glover", "Inativo" },
                    { 10, "055897409836047", new DateTime(2023, 1, 5, 13, 10, 29, 386, DateTimeKind.Local).AddTicks(3566), new DateTime(2023, 12, 19, 2, 13, 59, 249, DateTimeKind.Local).AddTicks(4253), "Licensed Cotton Mouse", "554849620001", 1946, "Greenholt, Kiehn and Kassulke", "Inativo" },
                    { 11, "985171456412922", new DateTime(2022, 11, 10, 22, 30, 43, 35, DateTimeKind.Local).AddTicks(9509), new DateTime(2023, 6, 4, 13, 58, 19, 610, DateTimeKind.Local).AddTicks(8624), "Gorgeous Plastic Tuna", "379374760001", 1991, "Wyman - Leuschke", "Ativo" },
                    { 12, "696715446860857", new DateTime(2022, 10, 28, 13, 12, 31, 253, DateTimeKind.Local).AddTicks(6448), new DateTime(2023, 5, 20, 11, 22, 51, 554, DateTimeKind.Local).AddTicks(4707), "Gorgeous Concrete Soap", "945186620001", 853, "Gottlieb - Jerde", "Inativo" },
                    { 13, "375049938376276", new DateTime(2022, 9, 24, 20, 25, 14, 260, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 2, 28, 20, 39, 25, 94, DateTimeKind.Local).AddTicks(5942), "Gorgeous Metal Gloves", "503575450001", 1619, "Wolff, Dach and Mueller", "Inativo" },
                    { 14, "805232256046961", new DateTime(2022, 12, 2, 8, 0, 39, 69, DateTimeKind.Local).AddTicks(5618), new DateTime(2023, 12, 23, 16, 55, 13, 984, DateTimeKind.Local).AddTicks(1442), "Small Soft Shirt", "644447810001", 1959, "Ondricka LLC", "Inativo" },
                    { 15, "983243423975842", new DateTime(2022, 10, 11, 2, 4, 57, 391, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 10, 26, 14, 48, 39, 116, DateTimeKind.Local).AddTicks(759), "Rustic Metal Ball", "528908660001", 775, "Tillman Inc", "Ativo" },
                    { 16, "446136549049741", new DateTime(2022, 9, 21, 2, 19, 13, 148, DateTimeKind.Local).AddTicks(9116), new DateTime(2023, 8, 17, 2, 32, 58, 208, DateTimeKind.Local).AddTicks(117), "Incredible Steel Pants", "183942750001", 1602, "Ruecker - Prosacco", "Inativo" },
                    { 17, "922903134313251", new DateTime(2022, 9, 3, 21, 21, 8, 230, DateTimeKind.Local).AddTicks(7916), new DateTime(2024, 2, 15, 6, 7, 15, 537, DateTimeKind.Local).AddTicks(4925), "Intelligent Rubber Shoes", "043523910001", 1632, "Lowe and Sons", "Ativo" },
                    { 18, "148485161118768", new DateTime(2023, 1, 29, 19, 18, 23, 945, DateTimeKind.Local).AddTicks(6189), new DateTime(2024, 3, 9, 17, 13, 19, 459, DateTimeKind.Local).AddTicks(811), "Tasty Cotton Cheese", "360498440001", 1368, "Considine, Lockman and Blanda", "Ativo" },
                    { 19, "628165242687026", new DateTime(2023, 3, 31, 11, 12, 29, 178, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 4, 25, 17, 4, 13, 829, DateTimeKind.Local).AddTicks(2244), "Intelligent Plastic Salad", "913057710001", 1259, "Larkin, Ferry and O'Conner", "Ativo" },
                    { 20, "221559411559584", new DateTime(2023, 2, 25, 19, 39, 20, 178, DateTimeKind.Local).AddTicks(1049), new DateTime(2023, 6, 7, 13, 19, 55, 811, DateTimeKind.Local).AddTicks(9428), "Tasty Wooden Car", "472762290001", 414, "Langosh LLC", "Ativo" },
                    { 21, "645597448016264", new DateTime(2023, 3, 22, 11, 6, 43, 458, DateTimeKind.Local).AddTicks(3890), new DateTime(2023, 12, 9, 13, 57, 51, 236, DateTimeKind.Local).AddTicks(6247), "Handmade Plastic Keyboard", "367138110001", 157, "Homenick - Hane", "Inativo" },
                    { 22, "653436144215443", new DateTime(2022, 10, 21, 20, 3, 30, 592, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 12, 24, 15, 44, 43, 702, DateTimeKind.Local).AddTicks(5), "Ergonomic Plastic Table", "992400800001", 280, "Cronin, Gusikowski and Corkery", "Ativo" },
                    { 23, "132129809681918", new DateTime(2022, 12, 28, 8, 47, 38, 112, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 11, 27, 9, 20, 36, 535, DateTimeKind.Local).AddTicks(843), "Fantastic Steel Shoes", "699196190001", 1583, "Rohan - Kling", "Inativo" },
                    { 24, "091851133518442", new DateTime(2022, 12, 3, 2, 2, 47, 384, DateTimeKind.Local).AddTicks(7617), new DateTime(2023, 4, 19, 23, 39, 33, 293, DateTimeKind.Local).AddTicks(6053), "Practical Fresh Gloves", "622048370001", 1557, "Bechtelar - Pollich", "Ativo" },
                    { 25, "207620778305909", new DateTime(2023, 2, 18, 14, 38, 6, 597, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 9, 8, 0, 19, 51, 396, DateTimeKind.Local).AddTicks(7305), "Handcrafted Plastic Salad", "302741550001", 781, "Raynor - Brekke", "Inativo" },
                    { 26, "550948906292759", new DateTime(2023, 4, 2, 16, 1, 32, 649, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 10, 22, 8, 31, 15, 106, DateTimeKind.Local).AddTicks(853), "Fantastic Soft Keyboard", "334385280001", 420, "Robel and Sons", "Inativo" },
                    { 27, "998220673127968", new DateTime(2023, 3, 21, 14, 15, 49, 11, DateTimeKind.Local).AddTicks(7492), new DateTime(2024, 1, 1, 15, 42, 47, 319, DateTimeKind.Local).AddTicks(5649), "Ergonomic Frozen Ball", "106478280001", 290, "Graham and Sons", "Inativo" },
                    { 28, "805339656882165", new DateTime(2023, 1, 27, 22, 50, 3, 429, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 9, 23, 21, 24, 30, 976, DateTimeKind.Local).AddTicks(7250), "Licensed Wooden Mouse", "136489610001", 1297, "Moore, Gusikowski and Reilly", "Ativo" },
                    { 29, "155968346029034", new DateTime(2022, 4, 23, 1, 16, 12, 416, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 8, 20, 13, 32, 54, 359, DateTimeKind.Local).AddTicks(122), "Gorgeous Rubber Tuna", "824026720001", 158, "McDermott - Cruickshank", "Ativo" },
                    { 30, "473210163901562", new DateTime(2023, 4, 7, 14, 46, 17, 508, DateTimeKind.Local).AddTicks(1294), new DateTime(2024, 1, 22, 1, 7, 14, 418, DateTimeKind.Local).AddTicks(7582), "Tasty Granite Pizza", "996150640001", 221, "Kassulke LLC", "Ativo" },
                    { 31, "977490930012971", new DateTime(2022, 9, 25, 9, 26, 37, 781, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 12, 19, 17, 9, 34, 105, DateTimeKind.Local).AddTicks(3467), "Fantastic Rubber Shirt", "029312350001", 1915, "Homenick, Bernier and Bartoletti", "Ativo" },
                    { 32, "581381521825612", new DateTime(2022, 5, 1, 13, 29, 24, 316, DateTimeKind.Local).AddTicks(1022), new DateTime(2023, 12, 19, 0, 13, 21, 560, DateTimeKind.Local).AddTicks(1131), "Rustic Steel Ball", "802865890001", 1210, "Armstrong, Cremin and Beer", "Inativo" },
                    { 33, "694472358108958", new DateTime(2022, 8, 6, 16, 12, 29, 863, DateTimeKind.Local).AddTicks(965), new DateTime(2023, 10, 21, 18, 8, 31, 916, DateTimeKind.Local).AddTicks(7042), "Incredible Plastic Fish", "489868780001", 406, "Stamm LLC", "Ativo" },
                    { 34, "272887419990022", new DateTime(2022, 5, 9, 12, 24, 6, 584, DateTimeKind.Local).AddTicks(9777), new DateTime(2023, 6, 19, 23, 39, 6, 872, DateTimeKind.Local).AddTicks(4002), "Licensed Concrete Hat", "422636640001", 987, "Pacocha, Prosacco and Larson", "Inativo" },
                    { 35, "482994298331710", new DateTime(2022, 7, 15, 0, 58, 14, 168, DateTimeKind.Local).AddTicks(5945), new DateTime(2023, 9, 14, 21, 52, 38, 342, DateTimeKind.Local).AddTicks(6482), "Unbranded Wooden Chips", "701364470001", 1, "Bailey - Borer", "Inativo" },
                    { 36, "314183846840490", new DateTime(2022, 5, 7, 18, 4, 11, 956, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 1, 27, 19, 48, 29, 797, DateTimeKind.Local).AddTicks(3509), "Handcrafted Frozen Chair", "678292030001", 588, "Huel Group", "Inativo" },
                    { 37, "271133154842485", new DateTime(2022, 9, 1, 2, 11, 39, 344, DateTimeKind.Local).AddTicks(1743), new DateTime(2023, 12, 11, 2, 12, 41, 429, DateTimeKind.Local).AddTicks(1897), "Rustic Plastic Bike", "514759940001", 593, "Abshire, Gorczany and Torp", "Ativo" },
                    { 38, "700672106108231", new DateTime(2022, 5, 16, 11, 54, 41, 579, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 5, 22, 5, 36, 34, 386, DateTimeKind.Local).AddTicks(2298), "Intelligent Wooden Car", "224343820001", 1280, "Waelchi - Quitzon", "Ativo" },
                    { 39, "104949442042635", new DateTime(2022, 10, 11, 23, 31, 38, 930, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 1, 1, 21, 24, 20, 320, DateTimeKind.Local).AddTicks(223), "Practical Fresh Table", "366389770001", 534, "Heathcote - Abshire", "Ativo" },
                    { 40, "818361095892948", new DateTime(2022, 9, 3, 22, 36, 39, 296, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 9, 13, 22, 41, 45, 834, DateTimeKind.Local).AddTicks(5689), "Fantastic Cotton Towels", "991607580001", 53, "Fritsch - Osinski", "Ativo" },
                    { 41, "184252861060826", new DateTime(2023, 3, 16, 2, 33, 20, 949, DateTimeKind.Local).AddTicks(4513), new DateTime(2023, 10, 22, 6, 18, 17, 225, DateTimeKind.Local).AddTicks(7042), "Handmade Steel Tuna", "959964430001", 501, "Hartmann Group", "Inativo" },
                    { 42, "386410882193536", new DateTime(2022, 11, 11, 11, 51, 4, 504, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 8, 26, 18, 55, 0, 324, DateTimeKind.Local).AddTicks(4802), "Licensed Cotton Gloves", "864618160001", 151, "Walter Group", "Ativo" },
                    { 43, "676906365516643", new DateTime(2022, 5, 17, 12, 21, 46, 772, DateTimeKind.Local).AddTicks(4202), new DateTime(2023, 9, 1, 21, 28, 0, 811, DateTimeKind.Local).AddTicks(479), "Gorgeous Granite Towels", "748578490001", 25, "Donnelly, Herman and Rogahn", "Ativo" },
                    { 44, "063047019565214", new DateTime(2023, 2, 11, 14, 42, 55, 33, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 11, 20, 20, 16, 1, 976, DateTimeKind.Local).AddTicks(2213), "Handcrafted Concrete Mouse", "382242630001", 1223, "Jones - Thompson", "Ativo" },
                    { 45, "196621333910438", new DateTime(2022, 7, 6, 8, 46, 25, 736, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 4, 2, 16, 17, 30, 695, DateTimeKind.Local).AddTicks(1866), "Fantastic Soft Gloves", "743193290001", 1163, "Nader - Bernhard", "Inativo" },
                    { 46, "552225673869501", new DateTime(2023, 3, 10, 5, 9, 56, 71, DateTimeKind.Local).AddTicks(364), new DateTime(2023, 11, 20, 1, 8, 37, 703, DateTimeKind.Local).AddTicks(2469), "Rustic Wooden Towels", "977010390001", 497, "Moen, Cronin and Kassulke", "Inativo" },
                    { 47, "733736356042640", new DateTime(2023, 1, 14, 15, 9, 12, 22, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 6, 28, 19, 47, 17, 692, DateTimeKind.Local).AddTicks(7118), "Ergonomic Granite Chair", "842981190001", 402, "Powlowski, Howe and Bailey", "Ativo" },
                    { 48, "171533029412267", new DateTime(2023, 2, 19, 12, 39, 32, 420, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 2, 3, 17, 8, 58, 36, DateTimeKind.Local).AddTicks(9), "Tasty Soft Mouse", "896488470001", 11, "Klein, Mills and Corwin", "Inativo" },
                    { 49, "598980603967494", new DateTime(2022, 12, 22, 9, 57, 53, 673, DateTimeKind.Local).AddTicks(3091), new DateTime(2024, 2, 4, 2, 18, 16, 867, DateTimeKind.Local).AddTicks(2171), "Sleek Wooden Cheese", "364369610001", 976, "Steuber, O'Hara and VonRueden", "Inativo" },
                    { 50, "709852972847087", new DateTime(2023, 1, 10, 12, 3, 14, 295, DateTimeKind.Local).AddTicks(9736), new DateTime(2023, 11, 24, 9, 9, 35, 517, DateTimeKind.Local).AddTicks(9796), "Incredible Soft Soap", "763762020001", 1579, "Mraz LLC", "Ativo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
