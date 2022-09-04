using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModLoader.Migrations
{
    public partial class NewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GamesId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModCollections_Games_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModCollectionId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packs_ModCollections_ModCollectionId",
                        column: x => x.ModCollectionId,
                        principalTable: "ModCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PackId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mods_Packs_PackId",
                        column: x => x.PackId,
                        principalTable: "Packs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebResources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModId = table.Column<int>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebResources_Mods_ModId",
                        column: x => x.ModId,
                        principalTable: "Mods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SynthiraRu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false),
                    SourseDownload = table.Column<string>(type: "TEXT", nullable: false),
                    LinkDownload = table.Column<string>(type: "TEXT", nullable: false),
                    AboutMod = table.Column<string>(type: "TEXT", nullable: false),
                    WebResourceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SynthiraRu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SynthiraRu_WebResources_WebResourceId",
                        column: x => x.WebResourceId,
                        principalTable: "WebResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_Name",
                table: "Games",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModCollections_GamesId",
                table: "ModCollections",
                column: "GamesId");

            migrationBuilder.CreateIndex(
                name: "IX_ModCollections_Name",
                table: "ModCollections",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mods_Name",
                table: "Mods",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mods_PackId",
                table: "Mods",
                column: "PackId");

            migrationBuilder.CreateIndex(
                name: "IX_Packs_ModCollectionId",
                table: "Packs",
                column: "ModCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Packs_Name",
                table: "Packs",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SynthiraRu_Name",
                table: "SynthiraRu",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SynthiraRu_WebResourceId",
                table: "SynthiraRu",
                column: "WebResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_WebResources_ModId",
                table: "WebResources",
                column: "ModId");

            migrationBuilder.CreateIndex(
                name: "IX_WebResources_Name",
                table: "WebResources",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SynthiraRu");

            migrationBuilder.DropTable(
                name: "WebResources");

            migrationBuilder.DropTable(
                name: "Mods");

            migrationBuilder.DropTable(
                name: "Packs");

            migrationBuilder.DropTable(
                name: "ModCollections");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
