﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoinApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220627164340_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Models.Coins", b =>
                {
                    b.Property<int>("MonedaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("MonedaId");

                    b.ToTable("Coins");

                    b.HasData(
                        new
                        {
                            MonedaId = 1,
                            Descripcion = "Bitcoin",
                            ImagenUrl = "https://png.monster/bitcoin-icon-3/ ",
                            Valor = 10000.0
                        },
                        new
                        {
                            MonedaId = 2,
                            Descripcion = "Ethereum",
                            ImagenUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png",
                            Valor = 9000.0
                        },
                        new
                        {
                            MonedaId = 3,
                            Descripcion = "Cardano",
                            ImagenUrl = "https://www.pngall.com/wp-content/uploads/10/Cardano-Crypto-Logo-PNG-Free-Image.png",
                            Valor = 8000.0
                        },
                        new
                        {
                            MonedaId = 4,
                            Descripcion = "Tether",
                            ImagenUrl = "https://iconape.com/wp-content/files/ac/209643/png/tether-usdt-logo.png",
                            Valor = 7000.0
                        },
                        new
                        {
                            MonedaId = 5,
                            Descripcion = "Binance Coin",
                            ImagenUrl = "https://www.pngwing.com/es/free-png-masau",
                            Valor = 6000.0
                        },
                        new
                        {
                            MonedaId = 6,
                            Descripcion = "Repple",
                            ImagenUrl = "https://www.pngwing.com/en/free-png-afkuk",
                            Valor = 5000.0
                        },
                        new
                        {
                            MonedaId = 7,
                            Descripcion = "Dogecoin",
                            ImagenUrl = "https://www.pngwing.com/en/free-png-kgbjx",
                            Valor = 4000.0
                        },
                        new
                        {
                            MonedaId = 8,
                            Descripcion = "USDCoin",
                            ImagenUrl = "https://www.pngall.com/wp-content/uploads/10/USD-Coin-Logo-PNG-Pic.png",
                            Valor = 3000.0
                        },
                        new
                        {
                            MonedaId = 9,
                            Descripcion = "Terra",
                            ImagenUrl = "https://png.pngtree.com/png-clipart/20220131/original/pngtree-d-front-rendering-cryptocurrency-luna-or-terra-blue-coin-with-cartoon-png-image_7261248.png",
                            Valor = 2000.0
                        },
                        new
                        {
                            MonedaId = 10,
                            Descripcion = "Solana",
                            ImagenUrl = "https://www.pngall.com/wp-content/uploads/10/Solana-Crypto-Logo-PNG-File.png",
                            Valor = 1000.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
