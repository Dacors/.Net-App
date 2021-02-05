using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPersistance.Migrations
{
    public partial class InitialUnderwriting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Unw");

            migrationBuilder.CreateTable(
                name: "Policy",
                schema: "Unw",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PremiumIncome = table.Column<double>(nullable: false),
                    AgencyId = table.Column<int>(nullable: false),
                    InsuredPersonId = table.Column<int>(nullable: false),
                    InsuredCompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risk",
                schema: "Unw",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskPremium = table.Column<int>(nullable: false),
                    RiskType = table.Column<string>(nullable: true),
                    PolicyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Risk_Policy_PolicyId",
                        column: x => x.PolicyId,
                        principalSchema: "Unw",
                        principalTable: "Policy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Risk_PolicyId",
                schema: "Unw",
                table: "Risk",
                column: "PolicyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Risk",
                schema: "Unw");

            migrationBuilder.DropTable(
                name: "Policy",
                schema: "Unw");
        }
    }
}
