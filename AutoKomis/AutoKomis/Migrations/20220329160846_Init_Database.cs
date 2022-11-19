using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoKomis.Migrations
{
    public partial class Init_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auta",
                columns: table => new
                {
                    IdSamochodu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdKomisu = table.Column<int>(type: "INTEGER", nullable: false),
                    IdSprzedazy = table.Column<int>(type: "INTEGER", nullable: false),
                    Marka = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    RokProdukcji = table.Column<string>(type: "TEXT", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false),
                    Przebieg = table.Column<string>(type: "TEXT", nullable: false),
                    Cena = table.Column<string>(type: "TEXT", nullable: false),
                    Kolor = table.Column<string>(type: "TEXT", nullable: false),
                    PojemnoscSilnika = table.Column<double>(type: "REAL", nullable: false),
                    TypNadwozia = table.Column<string>(type: "TEXT", nullable: false),
                    RodzajPaliwa = table.Column<string>(type: "TEXT", nullable: false),
                    Segment = table.Column<char>(type: "TEXT", nullable: false),
                    IloscDrzwi = table.Column<int>(type: "INTEGER", nullable: false),
                    CzyDostepny = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auta", x => x.IdSamochodu);
                });

            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    IdKlienta = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(type: "TEXT", nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    NrDowodu = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.IdKlienta);
                });

            migrationBuilder.CreateTable(
                name: "Komis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Miasto = table.Column<string>(type: "TEXT", nullable: false),
                    Ulica = table.Column<string>(type: "TEXT", nullable: false),
                    KodPocztowy = table.Column<string>(type: "TEXT", nullable: false),
                    KRS = table.Column<string>(type: "TEXT", nullable: false),
                    NIP = table.Column<string>(type: "TEXT", nullable: false),
                    ImieWlasciciela = table.Column<string>(type: "TEXT", nullable: false),
                    NazwiskoWlasciciela = table.Column<string>(type: "TEXT", nullable: false),
                    KosztyUtrzymanieMiesieczne = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pracownicy",
                columns: table => new
                {
                    IdPracownika = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdKomisu = table.Column<int>(type: "INTEGER", nullable: false),
                    Imie = table.Column<string>(type: "TEXT", nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    Stanowisko = table.Column<string>(type: "TEXT", nullable: false),
                    NrDowodu = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownicy", x => x.IdPracownika);
                });

            migrationBuilder.CreateTable(
                name: "Sprzedaze",
                columns: table => new
                {
                    IdSprzedazy = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdSamochodu = table.Column<int>(type: "INTEGER", nullable: false),
                    IdPracownika = table.Column<int>(type: "INTEGER", nullable: false),
                    IdKlienta = table.Column<int>(type: "INTEGER", nullable: false),
                    DataZawarciaUmowy = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Kwota = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprzedaze", x => x.IdSprzedazy);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auta");

            migrationBuilder.DropTable(
                name: "Klienci");

            migrationBuilder.DropTable(
                name: "Komis");

            migrationBuilder.DropTable(
                name: "Pracownicy");

            migrationBuilder.DropTable(
                name: "Sprzedaze");
        }
    }
}
