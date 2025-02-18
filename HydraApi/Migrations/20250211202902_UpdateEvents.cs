using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HydraApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OccuredAt",
                table: "Event",
                newName: "Timestamp");

            migrationBuilder.AddColumn<string>(
                name: "HostAddress",
                table: "Event",
                type: "nvarchar(45)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HostAddress",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Event",
                newName: "OccuredAt");
        }
    }
}
