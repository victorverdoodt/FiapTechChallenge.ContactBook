using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FiapTechChallenge.ContactBook.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DDDs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    RegionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DDDs_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    DDDId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_DDDs_DDDId",
                        column: x => x.DDDId,
                        principalTable: "DDDs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "AC" },
                    { 2L, "AL" },
                    { 3L, "AM" },
                    { 4L, "AP" },
                    { 5L, "BA" },
                    { 6L, "CE" },
                    { 7L, "DF" },
                    { 8L, "ES" },
                    { 9L, "GO" },
                    { 10L, "MA" },
                    { 11L, "MG" },
                    { 12L, "MS" },
                    { 13L, "MT" },
                    { 14L, "PA" },
                    { 15L, "PB" },
                    { 16L, "PE" },
                    { 17L, "PI" },
                    { 18L, "PR" },
                    { 19L, "RJ" },
                    { 20L, "RN" },
                    { 21L, "RO" },
                    { 22L, "RR" },
                    { 23L, "RS" },
                    { 24L, "SC" },
                    { 25L, "SE" },
                    { 26L, "SP" },
                    { 27L, "TO" }
                });

            migrationBuilder.InsertData(
                table: "DDDs",
                columns: new[] { "Id", "Code", "RegionId" },
                values: new object[,]
                {
                    { 1L, "68", 1L },
                    { 2L, "82", 2L },
                    { 3L, "92", 3L },
                    { 4L, "97", 3L },
                    { 5L, "96", 4L },
                    { 6L, "71", 5L },
                    { 7L, "73", 5L },
                    { 8L, "74", 5L },
                    { 9L, "75", 5L },
                    { 10L, "77", 5L },
                    { 11L, "85", 6L },
                    { 12L, "88", 6L },
                    { 13L, "61", 7L },
                    { 14L, "27", 8L },
                    { 15L, "28", 8L },
                    { 16L, "62", 9L },
                    { 17L, "64", 9L },
                    { 18L, "98", 10L },
                    { 19L, "99", 10L },
                    { 20L, "31", 11L },
                    { 21L, "32", 11L },
                    { 22L, "33", 11L },
                    { 23L, "34", 11L },
                    { 24L, "35", 11L },
                    { 25L, "37", 11L },
                    { 26L, "38", 11L },
                    { 27L, "67", 12L },
                    { 28L, "65", 13L },
                    { 29L, "66", 13L },
                    { 30L, "91", 14L },
                    { 31L, "93", 14L },
                    { 32L, "94", 14L },
                    { 33L, "83", 15L },
                    { 34L, "81", 16L },
                    { 35L, "87", 16L },
                    { 36L, "86", 17L },
                    { 37L, "89", 17L },
                    { 38L, "41", 18L },
                    { 39L, "42", 18L },
                    { 40L, "43", 18L },
                    { 41L, "44", 18L },
                    { 42L, "45", 18L },
                    { 43L, "46", 18L },
                    { 44L, "21", 19L },
                    { 45L, "22", 19L },
                    { 46L, "24", 19L },
                    { 47L, "84", 20L },
                    { 48L, "69", 21L },
                    { 49L, "95", 22L },
                    { 50L, "51", 23L },
                    { 51L, "53", 23L },
                    { 52L, "54", 23L },
                    { 53L, "55", 23L },
                    { 54L, "47", 24L },
                    { 55L, "48", 24L },
                    { 56L, "49", 24L },
                    { 57L, "79", 25L },
                    { 58L, "11", 26L },
                    { 59L, "12", 26L },
                    { 60L, "13", 26L },
                    { 61L, "14", 26L },
                    { 62L, "15", 26L },
                    { 63L, "16", 26L },
                    { 64L, "17", 26L },
                    { 65L, "18", 26L },
                    { 66L, "19", 26L },
                    { 67L, "63", 27L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_DDDId",
                table: "Contacts",
                column: "DDDId");

            migrationBuilder.CreateIndex(
                name: "IX_DDDs_RegionId",
                table: "DDDs",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "DDDs");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
