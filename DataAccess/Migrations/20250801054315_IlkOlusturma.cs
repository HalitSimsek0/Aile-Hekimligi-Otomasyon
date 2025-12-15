using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class IlkOlusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinsiyet",
                columns: table => new
                {
                    CinsiyetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinsiyetAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinsiyet", x => x.CinsiyetId);
                });

            migrationBuilder.CreateTable(
                name: "TamamlanmaDurumu",
                columns: table => new
                {
                    TamamlanmaDurumuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TamamlanmaDurumu", x => x.TamamlanmaDurumuId);
                });

            migrationBuilder.CreateTable(
                name: "DoktorKayit",
                columns: table => new
                {
                    HekimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dogumtarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CinsiyetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoktorKayit", x => x.HekimId);
                    table.ForeignKey(
                        name: "FK_DoktorKayit_Cinsiyet_CinsiyetId",
                        column: x => x.CinsiyetId,
                        principalTable: "Cinsiyet",
                        principalColumn: "CinsiyetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoktorKabulDurumu",
                columns: table => new
                {
                    DoktorKabulDurumuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HekimId = table.Column<int>(type: "int", nullable: false),
                    AlinanKabulSayisi = table.Column<int>(type: "int", nullable: false),
                    MisafirKabulSayisi = table.Column<int>(type: "int", nullable: false),
                    ToplamKayitliHastaSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoktorKabulDurumu", x => x.DoktorKabulDurumuId);
                    table.ForeignKey(
                        name: "FK_DoktorKabulDurumu_DoktorKayit_HekimId",
                        column: x => x.HekimId,
                        principalTable: "DoktorKayit",
                        principalColumn: "HekimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KabulListe",
                columns: table => new
                {
                    KabulId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dogumtarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    TamamlanmaDurumuId = table.Column<int>(type: "int", nullable: false),
                    HekimId = table.Column<int>(type: "int", nullable: false),
                    OncelikliMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KabulListe", x => x.KabulId);
                    table.ForeignKey(
                        name: "FK_KabulListe_DoktorKayit_HekimId",
                        column: x => x.HekimId,
                        principalTable: "DoktorKayit",
                        principalColumn: "HekimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KabulListe_TamamlanmaDurumu_TamamlanmaDurumuId",
                        column: x => x.TamamlanmaDurumuId,
                        principalTable: "TamamlanmaDurumu",
                        principalColumn: "TamamlanmaDurumuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KayitliKisiListesi",
                columns: table => new
                {
                    KayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dogumtarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnneAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    BabaAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HekimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KayitliKisiListesi", x => x.KayId);
                    table.ForeignKey(
                        name: "FK_KayitliKisiListesi_DoktorKayit_HekimId",
                        column: x => x.HekimId,
                        principalTable: "DoktorKayit",
                        principalColumn: "HekimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MhrsKayit",
                columns: table => new
                {
                    MhrsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saat = table.Column<TimeSpan>(type: "time", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HekimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MhrsKayit", x => x.MhrsId);
                    table.ForeignKey(
                        name: "FK_MhrsKayit_DoktorKayit_HekimId",
                        column: x => x.HekimId,
                        principalTable: "DoktorKayit",
                        principalColumn: "HekimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Misafir",
                columns: table => new
                {
                    MisafirId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HekimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Misafir", x => x.MisafirId);
                    table.ForeignKey(
                        name: "FK_Misafir_DoktorKayit_HekimId",
                        column: x => x.HekimId,
                        principalTable: "DoktorKayit",
                        principalColumn: "HekimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoktorKabulDurumu_HekimId",
                table: "DoktorKabulDurumu",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_DoktorKayit_CinsiyetId",
                table: "DoktorKayit",
                column: "CinsiyetId");

            migrationBuilder.CreateIndex(
                name: "IX_KabulListe_HekimId",
                table: "KabulListe",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_KabulListe_TamamlanmaDurumuId",
                table: "KabulListe",
                column: "TamamlanmaDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_KayitliKisiListesi_HekimId",
                table: "KayitliKisiListesi",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_MhrsKayit_HekimId",
                table: "MhrsKayit",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_Misafir_HekimId",
                table: "Misafir",
                column: "HekimId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoktorKabulDurumu");

            migrationBuilder.DropTable(
                name: "KabulListe");

            migrationBuilder.DropTable(
                name: "KayitliKisiListesi");

            migrationBuilder.DropTable(
                name: "MhrsKayit");

            migrationBuilder.DropTable(
                name: "Misafir");

            migrationBuilder.DropTable(
                name: "TamamlanmaDurumu");

            migrationBuilder.DropTable(
                name: "DoktorKayit");

            migrationBuilder.DropTable(
                name: "Cinsiyet");
        }
    }
}
