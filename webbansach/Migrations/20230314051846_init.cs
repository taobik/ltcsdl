using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webbansach.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NXB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNXB = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TacGia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTG = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaNhap = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    NhaXuatBanId = table.Column<int>(type: "int", nullable: false),
                    TacGiaId = table.Column<int>(type: "int", nullable: false),
                    TheLoaiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sach_NXB_NhaXuatBanId",
                        column: x => x.NhaXuatBanId,
                        principalTable: "NXB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_TacGia_TacGiaId",
                        column: x => x.TacGiaId,
                        principalTable: "TacGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_TheLoai_TheLoaiId",
                        column: x => x.TheLoaiId,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sach_NhaXuatBanId",
                table: "Sach",
                column: "NhaXuatBanId");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TacGiaId",
                table: "Sach",
                column: "TacGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TheLoaiId",
                table: "Sach",
                column: "TheLoaiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "NXB");

            migrationBuilder.DropTable(
                name: "TacGia");

            migrationBuilder.DropTable(
                name: "TheLoai");
        }
    }
}
