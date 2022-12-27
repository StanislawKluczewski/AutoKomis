using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoKomis.Migrations
{
    public partial class UpdateAllMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SprzedazIdSprzedazy",
                table: "Klienci",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sprzedaze_IdKlienta",
                table: "Sprzedaze",
                column: "IdKlienta");

            migrationBuilder.CreateIndex(
                name: "IX_Pracownicy_IdKomisu",
                table: "Pracownicy",
                column: "IdKomisu");

            migrationBuilder.CreateIndex(
                name: "IX_Klienci_SprzedazIdSprzedazy",
                table: "Klienci",
                column: "SprzedazIdSprzedazy");

            migrationBuilder.CreateIndex(
                name: "IX_Auta_IdKomisu",
                table: "Auta",
                column: "IdKomisu");

            migrationBuilder.CreateIndex(
                name: "IX_Auta_IdSprzedazy",
                table: "Auta",
                column: "IdSprzedazy");

            migrationBuilder.AddForeignKey(
                name: "FK_Auta_Komis_IdKomisu",
                table: "Auta",
                column: "IdKomisu",
                principalTable: "Komis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Auta_Sprzedaze_IdSprzedazy",
                table: "Auta",
                column: "IdSprzedazy",
                principalTable: "Sprzedaze",
                principalColumn: "IdSprzedazy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Klienci_Sprzedaze_SprzedazIdSprzedazy",
                table: "Klienci",
                column: "SprzedazIdSprzedazy",
                principalTable: "Sprzedaze",
                principalColumn: "IdSprzedazy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pracownicy_Komis_IdKomisu",
                table: "Pracownicy",
                column: "IdKomisu",
                principalTable: "Komis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprzedaze_Klienci_IdKlienta",
                table: "Sprzedaze",
                column: "IdKlienta",
                principalTable: "Klienci",
                principalColumn: "IdKlienta",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auta_Komis_IdKomisu",
                table: "Auta");

            migrationBuilder.DropForeignKey(
                name: "FK_Auta_Sprzedaze_IdSprzedazy",
                table: "Auta");

            migrationBuilder.DropForeignKey(
                name: "FK_Klienci_Sprzedaze_SprzedazIdSprzedazy",
                table: "Klienci");

            migrationBuilder.DropForeignKey(
                name: "FK_Pracownicy_Komis_IdKomisu",
                table: "Pracownicy");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprzedaze_Klienci_IdKlienta",
                table: "Sprzedaze");

            migrationBuilder.DropIndex(
                name: "IX_Sprzedaze_IdKlienta",
                table: "Sprzedaze");

            migrationBuilder.DropIndex(
                name: "IX_Pracownicy_IdKomisu",
                table: "Pracownicy");

            migrationBuilder.DropIndex(
                name: "IX_Klienci_SprzedazIdSprzedazy",
                table: "Klienci");

            migrationBuilder.DropIndex(
                name: "IX_Auta_IdKomisu",
                table: "Auta");

            migrationBuilder.DropIndex(
                name: "IX_Auta_IdSprzedazy",
                table: "Auta");

            migrationBuilder.DropColumn(
                name: "SprzedazIdSprzedazy",
                table: "Klienci");
        }
    }
}
