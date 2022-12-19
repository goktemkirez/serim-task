using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SerimTask.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
