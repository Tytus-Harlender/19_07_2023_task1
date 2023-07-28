using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _19_07_2023_task1.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaxSubjects",
                columns: table => new
                {
                    TaxSubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusVat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Krs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidenceAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationLegalDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDenialBasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDenialDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestorationBasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestorationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemovalBasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemovalDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasVirtualAccounts = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxSubjects", x => x.TaxSubjectId);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    WorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkerRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.WorkerId);
                });

            migrationBuilder.CreateTable(
                name: "Accunts",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxSubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accunts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Accunts_TaxSubjects_TaxSubjectId",
                        column: x => x.TaxSubjectId,
                        principalTable: "TaxSubjects",
                        principalColumn: "TaxSubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxSubjectWorker",
                columns: table => new
                {
                    TaxSubjectsTaxSubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkersWorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxSubjectWorker", x => new { x.TaxSubjectsTaxSubjectId, x.WorkersWorkerId });
                    table.ForeignKey(
                        name: "FK_TaxSubjectWorker_TaxSubjects_TaxSubjectsTaxSubjectId",
                        column: x => x.TaxSubjectsTaxSubjectId,
                        principalTable: "TaxSubjects",
                        principalColumn: "TaxSubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxSubjectWorker_Workers_WorkersWorkerId",
                        column: x => x.WorkersWorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accunts_TaxSubjectId",
                table: "Accunts",
                column: "TaxSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxSubjectWorker_WorkersWorkerId",
                table: "TaxSubjectWorker",
                column: "WorkersWorkerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accunts");

            migrationBuilder.DropTable(
                name: "TaxSubjectWorker");

            migrationBuilder.DropTable(
                name: "TaxSubjects");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
