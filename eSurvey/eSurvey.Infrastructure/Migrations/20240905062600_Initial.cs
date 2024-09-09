using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eSurvey.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyTemplatesTable",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Survey_JsonFormat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SurveyTemplate_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompletedSurveysTable",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Template_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_IDNP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Survey_JsonFormat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CompletedSurvey_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletedSurveysTable_SurveyTemplatesTable_Id",
                        column: x => x.Id,
                        principalTable: "SurveyTemplatesTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedSurveysTable");

            migrationBuilder.DropTable(
                name: "SurveyTemplatesTable");
        }
    }
}
