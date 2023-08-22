pusing Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaternidadeAPI.Migrations
{
    /// <inheritdoc />
    public partial class mae : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Mae",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Mae",
                newName: "id");
        }
    }
}
