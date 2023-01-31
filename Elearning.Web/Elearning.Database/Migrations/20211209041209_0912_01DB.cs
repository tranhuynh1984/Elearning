using Microsoft.EntityFrameworkCore.Migrations;

namespace Elearning.Database.Migrations
{
    public partial class _0912_01DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RevenuePlanType",
                table: "ProfitPlan",
                newName: "ProfitPlanType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfitPlanType",
                table: "ProfitPlan",
                newName: "RevenuePlanType");
        }
    }
}
