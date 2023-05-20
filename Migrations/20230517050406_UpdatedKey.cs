using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bt.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ApplicationType",
                table: "mApplicationType",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Applicant_Id",
                table: "Applicants_GNM",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Session_Code",
                table: "AgeEligibilityCriteria",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mApplicationType",
                table: "mApplicationType",
                column: "ApplicationType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applicants_GNM",
                table: "Applicants_GNM",
                column: "Applicant_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgeEligibilityCriteria",
                table: "AgeEligibilityCriteria",
                column: "Session_Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_mApplicationType",
                table: "mApplicationType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applicants_GNM",
                table: "Applicants_GNM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgeEligibilityCriteria",
                table: "AgeEligibilityCriteria");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationType",
                table: "mApplicationType",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Applicant_Id",
                table: "Applicants_GNM",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Session_Code",
                table: "AgeEligibilityCriteria",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
