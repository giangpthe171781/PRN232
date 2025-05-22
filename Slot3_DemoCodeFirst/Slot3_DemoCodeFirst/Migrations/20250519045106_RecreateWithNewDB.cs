using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Slot3_DemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class RecreateWithNewDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PlayerInstruments_InstrumentTypeId",
                table: "PlayerInstruments",
                column: "InstrumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerInstruments_InstrumentTypes_InstrumentTypeId",
                table: "PlayerInstruments",
                column: "InstrumentTypeId",
                principalTable: "InstrumentTypes",
                principalColumn: "InstrumentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerInstruments_InstrumentTypes_InstrumentTypeId",
                table: "PlayerInstruments");

            migrationBuilder.DropIndex(
                name: "IX_PlayerInstruments_InstrumentTypeId",
                table: "PlayerInstruments");
        }
    }
}
