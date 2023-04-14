using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestaoProdutos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dbContexting : Migration
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
                    Quantidade = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "Id", "Codigo", "DataFabricacao", "DataValidade", "Descricao", "FornecedorCnpj", "FornecedorCodigo", "FornecedorDescricao", "Quantidade", "Situacao" },
                values: new object[,]
                {
                    { 1, "993555727645154", new DateTime(2022, 10, 7, 1, 27, 4, 569, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 10, 30, 23, 17, 17, 731, DateTimeKind.Local).AddTicks(179), "Unbranded Wooden Shoes", "723125300001", 281, "Runolfsson, Lesch and Casper", 36, "Inativo" },
                    { 2, "330743658172774", new DateTime(2023, 2, 20, 4, 36, 4, 566, DateTimeKind.Local).AddTicks(6373), new DateTime(2023, 8, 22, 14, 8, 20, 245, DateTimeKind.Local).AddTicks(402), "Generic Metal Table", "420250670001", 872, "Dickinson - Walter", 1, "Ativo" },
                    { 3, "698712379330985", new DateTime(2023, 3, 24, 2, 29, 6, 949, DateTimeKind.Local).AddTicks(6242), new DateTime(2024, 2, 21, 5, 54, 41, 453, DateTimeKind.Local).AddTicks(4694), "Awesome Granite Keyboard", "104033480001", 336, "Barton - Stark", 4, "Inativo" },
                    { 4, "129645006738731", new DateTime(2023, 3, 26, 10, 9, 21, 511, DateTimeKind.Local).AddTicks(7035), new DateTime(2024, 3, 4, 2, 42, 3, 850, DateTimeKind.Local).AddTicks(1541), "Incredible Steel Shoes", "057655130001", 1744, "Carroll - Halvorson", 27, "Inativo" },
                    { 5, "737647225524408", new DateTime(2022, 4, 28, 16, 45, 25, 224, DateTimeKind.Local).AddTicks(1128), new DateTime(2023, 6, 26, 10, 32, 41, 763, DateTimeKind.Local).AddTicks(9734), "Tasty Steel Pants", "598018510001", 1269, "Will, Nitzsche and Simonis", 70, "Inativo" },
                    { 6, "287218365031513", new DateTime(2022, 12, 16, 13, 53, 31, 708, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 12, 28, 20, 15, 40, 711, DateTimeKind.Local).AddTicks(2036), "Handmade Metal Cheese", "588777890001", 396, "Ondricka - Becker", 22, "Inativo" },
                    { 7, "512549930500787", new DateTime(2022, 12, 21, 17, 53, 17, 310, DateTimeKind.Local).AddTicks(9686), new DateTime(2024, 3, 8, 13, 37, 40, 789, DateTimeKind.Local).AddTicks(5246), "Practical Frozen Shirt", "851455670001", 182, "Kuvalis Group", 38, "Inativo" },
                    { 8, "681863830936189", new DateTime(2022, 11, 14, 10, 24, 46, 524, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 2, 15, 13, 2, 25, 735, DateTimeKind.Local).AddTicks(1290), "Fantastic Plastic Chips", "363930250001", 597, "Little, Quitzon and Zulauf", 75, "Ativo" },
                    { 9, "592466729748171", new DateTime(2022, 11, 7, 17, 6, 41, 577, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 8, 17, 8, 42, 34, 650, DateTimeKind.Local).AddTicks(390), "Small Metal Bacon", "929308270001", 1709, "Weber, Hyatt and Jones", 38, "Inativo" },
                    { 10, "648612223784112", new DateTime(2022, 11, 6, 10, 38, 49, 524, DateTimeKind.Local).AddTicks(1886), new DateTime(2023, 6, 30, 14, 39, 39, 9, DateTimeKind.Local).AddTicks(8360), "Licensed Wooden Table", "292107550001", 1611, "Bergstrom, Ortiz and Kovacek", 74, "Inativo" },
                    { 11, "279007141252489", new DateTime(2022, 8, 28, 1, 47, 44, 611, DateTimeKind.Local).AddTicks(9606), new DateTime(2023, 4, 30, 17, 34, 28, 52, DateTimeKind.Local).AddTicks(8665), "Generic Cotton Pizza", "763267250001", 521, "Walsh, Hessel and Schimmel", 87, "Inativo" },
                    { 12, "553655281459604", new DateTime(2022, 7, 29, 2, 1, 0, 323, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 12, 21, 22, 2, 33, 355, DateTimeKind.Local).AddTicks(2737), "Generic Wooden Fish", "910713840001", 653, "Ritchie, Homenick and Howell", 14, "Ativo" },
                    { 13, "082082568730459", new DateTime(2022, 9, 1, 21, 27, 33, 956, DateTimeKind.Local).AddTicks(9204), new DateTime(2023, 7, 30, 2, 51, 45, 492, DateTimeKind.Local).AddTicks(9956), "Refined Cotton Computer", "409646620001", 1136, "Morar, Hilll and Huels", 32, "Ativo" },
                    { 14, "399244193795951", new DateTime(2023, 3, 3, 1, 14, 38, 74, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 6, 16, 6, 18, 55, 460, DateTimeKind.Local).AddTicks(3581), "Intelligent Cotton Gloves", "265132730001", 1605, "Huels - Simonis", 6, "Inativo" },
                    { 15, "943897652297639", new DateTime(2022, 9, 30, 19, 2, 23, 140, DateTimeKind.Local).AddTicks(1447), new DateTime(2023, 12, 18, 2, 26, 47, 168, DateTimeKind.Local).AddTicks(1493), "Practical Frozen Table", "738978090001", 1865, "Hayes LLC", 47, "Inativo" },
                    { 16, "990470761456761", new DateTime(2023, 2, 14, 4, 46, 4, 221, DateTimeKind.Local).AddTicks(9137), new DateTime(2023, 10, 11, 2, 34, 26, 796, DateTimeKind.Local).AddTicks(6552), "Fantastic Granite Pants", "055631550001", 986, "Doyle, Harber and Kovacek", 33, "Ativo" },
                    { 17, "123366926675384", new DateTime(2022, 6, 8, 13, 22, 41, 250, DateTimeKind.Local).AddTicks(7267), new DateTime(2023, 10, 3, 20, 3, 2, 376, DateTimeKind.Local).AddTicks(8174), "Intelligent Soft Computer", "164810780001", 942, "Schiller LLC", 71, "Inativo" },
                    { 18, "152453120063282", new DateTime(2022, 11, 17, 4, 25, 0, 2, DateTimeKind.Local).AddTicks(1400), new DateTime(2023, 7, 20, 9, 57, 56, 516, DateTimeKind.Local).AddTicks(6514), "Awesome Plastic Soap", "134043070001", 88, "Jacobson - Hintz", 74, "Ativo" },
                    { 19, "158340505449817", new DateTime(2022, 7, 25, 4, 53, 41, 384, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 9, 24, 13, 47, 20, 286, DateTimeKind.Local).AddTicks(1322), "Handmade Concrete Chair", "692354980001", 417, "Kovacek, Homenick and Connelly", 44, "Ativo" },
                    { 20, "095512257076044", new DateTime(2022, 5, 1, 14, 32, 41, 768, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 2, 22, 17, 10, 35, 339, DateTimeKind.Local).AddTicks(9152), "Refined Metal Salad", "854064970001", 728, "Hegmann - Shanahan", 23, "Inativo" },
                    { 21, "551461840072022", new DateTime(2023, 2, 1, 21, 19, 32, 250, DateTimeKind.Local).AddTicks(7545), new DateTime(2023, 5, 19, 6, 2, 16, 372, DateTimeKind.Local).AddTicks(3734), "Awesome Concrete Chicken", "199881950001", 794, "Nicolas, Leffler and Fisher", 94, "Inativo" },
                    { 22, "827326580391060", new DateTime(2022, 10, 5, 12, 59, 9, 510, DateTimeKind.Local).AddTicks(714), new DateTime(2023, 12, 7, 16, 3, 10, 762, DateTimeKind.Local).AddTicks(7674), "Sleek Plastic Pants", "389258230001", 1102, "Mosciski Inc", 73, "Ativo" },
                    { 23, "177188313166446", new DateTime(2022, 7, 26, 3, 43, 9, 156, DateTimeKind.Local).AddTicks(5769), new DateTime(2023, 12, 31, 14, 58, 59, 958, DateTimeKind.Local).AddTicks(96), "Awesome Fresh Chair", "501164740001", 634, "Parisian, Strosin and Smith", 56, "Inativo" },
                    { 24, "716504950322807", new DateTime(2022, 11, 19, 18, 46, 27, 673, DateTimeKind.Local).AddTicks(7214), new DateTime(2024, 3, 17, 12, 44, 13, 385, DateTimeKind.Local).AddTicks(5382), "Ergonomic Cotton Cheese", "532665660001", 839, "Homenick LLC", 87, "Inativo" },
                    { 25, "807655248463906", new DateTime(2022, 7, 29, 3, 20, 23, 647, DateTimeKind.Local).AddTicks(677), new DateTime(2023, 10, 21, 14, 48, 33, 67, DateTimeKind.Local).AddTicks(1794), "Rustic Metal Bacon", "676320970001", 95, "Schaden - Feil", 68, "Ativo" },
                    { 26, "137113688747715", new DateTime(2022, 4, 27, 5, 22, 19, 537, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 5, 27, 4, 10, 59, 322, DateTimeKind.Local).AddTicks(2261), "Gorgeous Plastic Hat", "141749930001", 381, "Klocko Inc", 17, "Ativo" },
                    { 27, "034169802256391", new DateTime(2023, 2, 20, 11, 11, 58, 991, DateTimeKind.Local).AddTicks(5794), new DateTime(2024, 2, 20, 1, 49, 53, 744, DateTimeKind.Local).AddTicks(8370), "Practical Granite Pizza", "437528100001", 638, "Lehner - Davis", 25, "Ativo" },
                    { 28, "116368652642978", new DateTime(2023, 2, 4, 18, 42, 49, 664, DateTimeKind.Local).AddTicks(1659), new DateTime(2023, 6, 2, 17, 51, 32, 713, DateTimeKind.Local).AddTicks(1749), "Handcrafted Fresh Gloves", "052116570001", 1310, "Toy - Armstrong", 61, "Ativo" },
                    { 29, "354007764326816", new DateTime(2022, 11, 25, 10, 43, 11, 724, DateTimeKind.Local).AddTicks(7587), new DateTime(2023, 11, 6, 21, 18, 5, 378, DateTimeKind.Local).AddTicks(2381), "Sleek Soft Pants", "942194160001", 1346, "Aufderhar LLC", 72, "Ativo" },
                    { 30, "042319924302634", new DateTime(2022, 8, 9, 3, 40, 50, 654, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 2, 20, 8, 41, 45, 749, DateTimeKind.Local).AddTicks(4598), "Licensed Cotton Cheese", "443382120001", 1064, "Feil Group", 25, "Ativo" },
                    { 31, "378045293182570", new DateTime(2023, 2, 28, 3, 19, 14, 412, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 9, 8, 2, 19, 27, 781, DateTimeKind.Local).AddTicks(8719), "Rustic Wooden Chips", "578616920001", 1278, "Hudson, Hammes and Mraz", 49, "Ativo" },
                    { 32, "259986346512308", new DateTime(2023, 2, 15, 1, 28, 48, 556, DateTimeKind.Local).AddTicks(576), new DateTime(2023, 7, 30, 19, 20, 14, 421, DateTimeKind.Local).AddTicks(7018), "Handcrafted Soft Towels", "053806810001", 1081, "Hessel - Toy", 59, "Inativo" },
                    { 33, "329292738685831", new DateTime(2023, 2, 18, 2, 24, 45, 787, DateTimeKind.Local).AddTicks(9859), new DateTime(2023, 9, 22, 21, 49, 14, 216, DateTimeKind.Local).AddTicks(6043), "Awesome Metal Mouse", "988919590001", 393, "Rowe, Lubowitz and Hackett", 67, "Inativo" },
                    { 34, "375422138035402", new DateTime(2022, 10, 24, 15, 40, 39, 873, DateTimeKind.Local).AddTicks(7489), new DateTime(2023, 5, 30, 3, 2, 0, 353, DateTimeKind.Local).AddTicks(3872), "Generic Frozen Mouse", "232702620001", 749, "Ryan, Grady and Sporer", 30, "Ativo" },
                    { 35, "624937287554812", new DateTime(2022, 8, 5, 23, 30, 16, 807, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 2, 4, 1, 32, 55, 379, DateTimeKind.Local).AddTicks(7586), "Gorgeous Wooden Chicken", "491721870001", 598, "Aufderhar - Schiller", 10, "Inativo" },
                    { 36, "590181778388351", new DateTime(2022, 7, 11, 18, 47, 29, 61, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 8, 18, 9, 9, 38, 552, DateTimeKind.Local).AddTicks(9213), "Fantastic Frozen Chips", "324990210001", 468, "Feest - Bauch", 16, "Ativo" },
                    { 37, "698134962701406", new DateTime(2023, 2, 20, 11, 58, 57, 831, DateTimeKind.Local).AddTicks(3803), new DateTime(2023, 10, 3, 13, 35, 27, 752, DateTimeKind.Local).AddTicks(4686), "Refined Cotton Soap", "179079480001", 1583, "Ebert - Wolff", 45, "Inativo" },
                    { 38, "674644887010882", new DateTime(2023, 4, 3, 8, 21, 57, 947, DateTimeKind.Local).AddTicks(2138), new DateTime(2023, 11, 4, 22, 25, 50, 885, DateTimeKind.Local).AddTicks(1632), "Fantastic Concrete Salad", "949471510001", 201, "Parisian LLC", 22, "Inativo" },
                    { 39, "477405473646258", new DateTime(2022, 12, 14, 2, 50, 17, 287, DateTimeKind.Local).AddTicks(45), new DateTime(2024, 1, 24, 2, 58, 8, 767, DateTimeKind.Local).AddTicks(3137), "Awesome Soft Pants", "884206120001", 1841, "Borer Group", 30, "Inativo" },
                    { 40, "748491822068104", new DateTime(2022, 5, 18, 6, 36, 20, 316, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 1, 18, 14, 4, 51, 292, DateTimeKind.Local).AddTicks(9513), "Handcrafted Frozen Towels", "079848830001", 254, "Blanda, Nitzsche and Reichert", 94, "Inativo" },
                    { 41, "034080033987564", new DateTime(2022, 6, 29, 15, 29, 16, 101, DateTimeKind.Local).AddTicks(5528), new DateTime(2023, 10, 1, 11, 29, 53, 478, DateTimeKind.Local).AddTicks(8701), "Tasty Fresh Salad", "267213020001", 1621, "Wuckert, Abbott and Wintheiser", 7, "Ativo" },
                    { 42, "429316086576195", new DateTime(2022, 6, 29, 22, 59, 14, 658, DateTimeKind.Local).AddTicks(7142), new DateTime(2023, 9, 15, 4, 56, 57, 80, DateTimeKind.Local).AddTicks(1538), "Sleek Frozen Computer", "877218030001", 1341, "Emard Group", 94, "Ativo" },
                    { 43, "066651777729280", new DateTime(2022, 5, 14, 23, 59, 18, 771, DateTimeKind.Local).AddTicks(4519), new DateTime(2024, 1, 2, 9, 4, 18, 884, DateTimeKind.Local).AddTicks(8545), "Tasty Metal Fish", "942220250001", 1328, "Morissette Group", 48, "Inativo" },
                    { 44, "914633283564975", new DateTime(2022, 10, 2, 22, 21, 16, 875, DateTimeKind.Local).AddTicks(8573), new DateTime(2024, 4, 8, 18, 3, 19, 669, DateTimeKind.Local).AddTicks(8256), "Small Cotton Hat", "198433650001", 348, "Murray, Goldner and Breitenberg", 70, "Inativo" },
                    { 45, "463397556152027", new DateTime(2022, 6, 7, 13, 7, 48, 696, DateTimeKind.Local).AddTicks(3873), new DateTime(2023, 8, 20, 5, 37, 10, 780, DateTimeKind.Local).AddTicks(6552), "Handcrafted Steel Shirt", "113723100001", 1488, "Yundt - Keeling", 87, "Inativo" },
                    { 46, "681125193278798", new DateTime(2023, 1, 22, 12, 32, 2, 230, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 3, 31, 15, 53, 10, 603, DateTimeKind.Local).AddTicks(8471), "Handcrafted Plastic Chair", "677568460001", 1015, "Hoppe, Zulauf and Lind", 96, "Ativo" },
                    { 47, "765538624248520", new DateTime(2022, 10, 24, 4, 0, 14, 506, DateTimeKind.Local).AddTicks(4310), new DateTime(2023, 11, 6, 20, 8, 37, 763, DateTimeKind.Local).AddTicks(5018), "Small Concrete Chips", "954807740001", 853, "Beier - Hegmann", 84, "Ativo" },
                    { 48, "993094619721575", new DateTime(2022, 8, 24, 4, 47, 7, 940, DateTimeKind.Local).AddTicks(3006), new DateTime(2024, 2, 18, 11, 9, 18, 574, DateTimeKind.Local).AddTicks(7739), "Small Plastic Towels", "956716470001", 240, "DuBuque - Schimmel", 67, "Inativo" },
                    { 49, "492571765965468", new DateTime(2023, 2, 3, 21, 51, 39, 675, DateTimeKind.Local).AddTicks(4691), new DateTime(2023, 9, 25, 22, 44, 43, 996, DateTimeKind.Local).AddTicks(3944), "Incredible Cotton Keyboard", "966851980001", 1228, "Prohaska, Nienow and Marquardt", 89, "Ativo" },
                    { 50, "488994852973323", new DateTime(2022, 11, 6, 22, 48, 19, 677, DateTimeKind.Local).AddTicks(5982), new DateTime(2023, 11, 27, 21, 17, 58, 166, DateTimeKind.Local).AddTicks(893), "Incredible Rubber Sausages", "617458560001", 486, "Blick Inc", 34, "Inativo" }
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
