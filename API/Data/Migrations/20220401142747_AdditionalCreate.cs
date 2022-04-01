using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class AdditionalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountsTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientName = table.Column<string>(type: "TEXT", nullable: true),
                    Balance = table.Column<float>(type: "REAL", nullable: false),
                    CreDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypesTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DocumentName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypesTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationsTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OperationType = table.Column<int>(type: "INTEGER", nullable: false),
                    OperationSum = table.Column<float>(type: "REAL", nullable: false),
                    Commissions = table.Column<float>(type: "REAL", nullable: false),
                    CreDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    DocumentType = table.Column<int>(type: "INTEGER", nullable: false),
                    DocumentRef = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationTypesTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OperationName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTypesTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardsTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardType = table.Column<int>(type: "INTEGER", nullable: false),
                    CardNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PIN = table.Column<int>(type: "INTEGER", nullable: false),
                    CreDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardsTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardsTbl_AccountsTbl_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountsTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardsTbl_AccountId",
                table: "CardsTbl",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardsTbl");

            migrationBuilder.DropTable(
                name: "DocumentTypesTbl");

            migrationBuilder.DropTable(
                name: "OperationsTbl");

            migrationBuilder.DropTable(
                name: "OperationTypesTbl");

            migrationBuilder.DropTable(
                name: "AccountsTbl");
        }
    }
}
