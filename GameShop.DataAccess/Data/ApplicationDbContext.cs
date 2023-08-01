using GameShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameShop.DataAccess.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<Platform> Platforms { get; set; }
		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Platform>().HasData(
				new Platform { Id = 1, Name = "PS5", DisplayOrder = 1 },
				new Platform { Id = 2, Name = "PS4", DisplayOrder = 2 },
				new Platform { Id = 3, Name = "Switch", DisplayOrder = 3 }
				);

			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Final Fantasy XVI",
					Brand = "Square Enix",
					ListPrice = 9900,
					Price = 9000,
					Price50 = 8500,
					Price100 = 8000,
					Description = "これは――クリスタルの加護を断ち切るための物語。\r\n黄昏の時代を迎えつつある大地「ヴァリスゼア」――\r\n\r\n人々は唯一の加護である「マザークリスタル」の元に集い、\r\n\r\nエーテルによって魔法を生み出し、日々の暮らしを立てていた。\r\n\r\nしかし、マザークリスタルから得られるはずのエーテルは枯渇を始め、\r\n\r\nやがてそれが、世界に混乱と戦いをもたらしてゆく……\r\n\r\nこれは――クリスタルの加護を断ち切るための物語。",
					PlatformId = 1,
					ImageUrl = ""
				},
				new Product
				{
					Id = 2,
					Title = "BIOHAZARD VILLAGE",
					Brand = "Capcom",
					ListPrice = 4500,
					Price = 4000,
					Price50 = 3500,
					Price100 = 3000,
					Description = "ロゴに“VIII\"を冠した『バイオハザード ヴィレッジ』が目指すのは誰も見たことがないサバイバルホラー 悪夢のような事件から数年ー イーサン・ウィンターズは家族とのありふれた日常を取り戻していた その日常を奪ったのはクリス・レッドフィールド 暗い横顔に歴戦の勇士の面影はなかった",
					PlatformId = 2,
					ImageUrl = ""
				},
				new Product
				{
					Id = 3,
					Title = "ゼルダの伝説　ティアーズ オブ ザ キングダム ",
					Brand = "Nintendo",
					ListPrice = 6700,
					Price = 6000,
					Price50 = 5500,
					Price100 = 5000,
					Description = "果てなき冒険は、大空へ広がる。『ゼルダの伝説　ブレス オブ ザ ワイルド』続編が登場。\r\nどこまでも続く広大な「大地」、そしてはるか雲の上の「大空」まで広がった世界で、どこへ行くのも、何をするのもあなた次第です。空を翔けめぐり、不思議な空島を探索するのか？リンクの手にした新たな力で、ハイラルの異変に立ち向かうのか？あなただけの果てなき冒険が、再び始まります。",
					PlatformId = 3,
					ImageUrl = ""
				}
			);
		}
	}
}
