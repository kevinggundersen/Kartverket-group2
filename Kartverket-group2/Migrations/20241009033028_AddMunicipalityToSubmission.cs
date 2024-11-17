using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class AddMunicipalityToSubmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Municipality",
                table: "Submissions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Municipality",
                table: "Submissions");
        }
    }
}
