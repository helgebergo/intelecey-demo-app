using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddTagUpdatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "tags",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "tags");
        }
    }
}
