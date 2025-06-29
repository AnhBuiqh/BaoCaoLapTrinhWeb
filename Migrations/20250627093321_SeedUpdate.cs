using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnhBui.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsTrendingProduct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Áo thun cotton 100%, mềm mại và thoáng mát, form unisex dễ mặc cho cả nam và nữ.", "https://dosi-in.com/images/detailed/42/CDL10_1.jpg", true, "Áo Thun", 75000m },
                    { 2, "Áo khoác vải dù nhẹ, chống gió tốt, thiết kế có mũ tiện lợi cho ngày mưa.", "https://www.chapi.vn/img/product/2021/11/20/ao-khoac-nam-trung-nien-co-be-bhg-18-new.jpg", true, "Áo Khoác", 200000m },
                    { 3, "Áo len chất dệt kim mềm mại, giữ ấm tốt nhưng vẫn thoáng khí.", "https://4menshop.com/images/thumbs/2023/07/ao-len-phoi-mau-al011-mau-do-18179.jpg", true, "Áo Len", 150000m },
                    { 4, "Quần jean co giãn nhẹ, lên form đẹp, thoải mái vận động cả ngày.", "https://th.bing.com/th/id/OIP.sOahbQYxx6aZynZjlygcaAHaLH?w=640&h=960&rs=1&pid=ImgDetMain&cb=idpwebp2&o=7&rm=3", true, "Quần Jean", 125000m },
                    { 5, "Quần tây vải mềm mịn, đứng form chuẩn, phù hợp đi làm hoặc đi học.", "https://4menshop.com/images/thumbs/2022/02/quan-tay-tron-regular-mau-den-qt026-16143.jpg", true, "Quần Tây", 250000m },
                    { 6, "Bộ thể thao thun lạnh co giãn 4 chiều, thấm hút mồ hôi cực tốt.", "https://cf.shopee.vn/file/606ec435877c83e0e550e93b28bac804", true, "Bộ Quần Áo Thể Thao", 150000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
