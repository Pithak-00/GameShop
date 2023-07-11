﻿// <auto-generated />
using GameShop.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameShop.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230711085625_AddForeignKeyForPlatformProductRelation")]
    partial class AddForeignKeyForPlatformProductRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameShop.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "PS5"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "PS4"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Switch"
                        });
                });

            modelBuilder.Entity("GameShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ListPrice")
                        .HasColumnType("int");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Price100")
                        .HasColumnType("int");

                    b.Property<int>("Price50")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlatformId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Square Enix",
                            Description = "これは――クリスタルの加護を断ち切るための物語。\r\n黄昏の時代を迎えつつある大地「ヴァリスゼア」――\r\n\r\n人々は唯一の加護である「マザークリスタル」の元に集い、\r\n\r\nエーテルによって魔法を生み出し、日々の暮らしを立てていた。\r\n\r\nしかし、マザークリスタルから得られるはずのエーテルは枯渇を始め、\r\n\r\nやがてそれが、世界に混乱と戦いをもたらしてゆく……\r\n\r\nこれは――クリスタルの加護を断ち切るための物語。",
                            ListPrice = 9900,
                            PlatformId = 1,
                            Price = 9000,
                            Price100 = 8000,
                            Price50 = 8500,
                            Title = "Final Fantasy XVI"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Capcom",
                            Description = "ロゴに“VIII\"を冠した『バイオハザード ヴィレッジ』が目指すのは誰も見たことがないサバイバルホラー 悪夢のような事件から数年ー イーサン・ウィンターズは家族とのありふれた日常を取り戻していた その日常を奪ったのはクリス・レッドフィールド 暗い横顔に歴戦の勇士の面影はなかった",
                            ListPrice = 4500,
                            PlatformId = 2,
                            Price = 4000,
                            Price100 = 3000,
                            Price50 = 3500,
                            Title = "BIOHAZARD VILLAGE"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Nintendo",
                            Description = "果てなき冒険は、大空へ広がる。『ゼルダの伝説　ブレス オブ ザ ワイルド』続編が登場。\r\nどこまでも続く広大な「大地」、そしてはるか雲の上の「大空」まで広がった世界で、どこへ行くのも、何をするのもあなた次第です。空を翔けめぐり、不思議な空島を探索するのか？リンクの手にした新たな力で、ハイラルの異変に立ち向かうのか？あなただけの果てなき冒険が、再び始まります。",
                            ListPrice = 6700,
                            PlatformId = 3,
                            Price = 6000,
                            Price100 = 5000,
                            Price50 = 5500,
                            Title = "ゼルダの伝説　ティアーズ オブ ザ キングダム "
                        });
                });

            modelBuilder.Entity("GameShop.Models.Product", b =>
                {
                    b.HasOne("GameShop.Models.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Platform");
                });
#pragma warning restore 612, 618
        }
    }
}
