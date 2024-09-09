using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eSurvey.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedSurveysTable_SurveyTemplatesTable_Id",
                table: "CompletedSurveysTable");

            migrationBuilder.AlterColumn<string>(
                name: "Template_Id",
                table: "CompletedSurveysTable",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedSurveysTable_Template_Id",
                table: "CompletedSurveysTable",
                column: "Template_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedSurveysTable_SurveyTemplatesTable_Template_Id",
                table: "CompletedSurveysTable",
                column: "Template_Id",
                principalTable: "SurveyTemplatesTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedSurveysTable_SurveyTemplatesTable_Template_Id",
                table: "CompletedSurveysTable");

            migrationBuilder.DropIndex(
                name: "IX_CompletedSurveysTable_Template_Id",
                table: "CompletedSurveysTable");

            migrationBuilder.AlterColumn<string>(
                name: "Template_Id",
                table: "CompletedSurveysTable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedSurveysTable_SurveyTemplatesTable_Id",
                table: "CompletedSurveysTable",
                column: "Id",
                principalTable: "SurveyTemplatesTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
