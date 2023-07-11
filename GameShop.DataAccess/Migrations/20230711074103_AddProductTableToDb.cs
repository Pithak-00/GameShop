using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Platforms",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Price50 = table.Column<int>(type: "int", nullable: false),
                    Price100 = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Square Enix", "これは――クリスタルの加護を断ち切るための物語。\r\n黄昏の時代を迎えつつある大地「ヴァリスゼア」――\r\n\r\n人々は唯一の加護である「マザークリスタル」の元に集い、\r\n\r\nエーテルによって魔法を生み出し、日々の暮らしを立てていた。\r\n\r\nしかし、マザークリスタルから得られるはずのエーテルは枯渇を始め、\r\n\r\nやがてそれが、世界に混乱と戦いをもたらしてゆく……\r\n\r\nこれは――クリスタルの加護を断ち切るための物語。", 9900, 9000, 8000, 8500, "Final Fantasy XVI" },
                    { 2, "Capcom", "ロゴに“VIII\"を冠した『バイオハザード ヴィレッジ』が目指すのは誰も見たことがないサバイバルホラー 悪夢のような事件から数年ー イーサン・ウィンターズは家族とのありふれた日常を取り戻していた その日常を奪ったのはクリス・レッドフィールド 暗い横顔に歴戦の勇士の面影はなかった", 4500, 4000, 3000, 3500, "BIOHAZARD VILLAGE" },
                    { 3, "Nintendo", "果てなき冒険は、大空へ広がる。『ゼルダの伝説　ブレス オブ ザ ワイルド』続編が登場。\r\nどこまでも続く広大な「大地」、そしてはるか雲の上の「大空」まで広がった世界で、どこへ行くのも、何をするのもあなた次第です。空を翔けめぐり、不思議な空島を探索するのか？リンクの手にした新たな力で、ハイラルの異変に立ち向かうのか？あなただけの果てなき冒険が、再び始まります。", 6700, 6000, 5000, 5500, "ゼルダの伝説　ティアーズ オブ ザ キングダム " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Platforms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
