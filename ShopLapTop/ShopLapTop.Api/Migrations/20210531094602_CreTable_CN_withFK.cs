using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopLapTop.Api.Migrations
{
    public partial class CreTable_CN_withFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiNhanhs",
                columns: table => new
                {
                    MaCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KhoMaKho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiNhanhs", x => x.MaCN);
                    table.ForeignKey(
                        name: "FK_ChiNhanhs_Khos_KhoMaKho",
                        column: x => x.KhoMaKho,
                        principalTable: "Khos",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiNhanhs_KhoMaKho",
                table: "ChiNhanhs",
                column: "KhoMaKho");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiNhanhs");
        }
    }
}
