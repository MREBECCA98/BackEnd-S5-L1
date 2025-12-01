using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd_S5_L1.Migrations
{
    /// <inheritdoc />
    public partial class addedbooksummary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bookSummary",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookSummary",
                table: "Products");
        }
    }
}
