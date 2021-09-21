﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftCandy.Data;

namespace SoftCandy.Migrations
{
    [DbContext(typeof(SoftCandyContext))]
    partial class SoftCandyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SoftCandy.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("SoftCandy.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CelularCliente")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("EnderecoCliente")
                        .IsRequired()
                        .HasMaxLength(254);

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SoftCandy.Models.Item_Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdProduto");

                    b.Property<int>("IdPedido");

                    b.Property<decimal>("PrecoPago");

                    b.Property<int>("QuantidadePedido");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto");

                    b.HasIndex("IdPedido");

                    b.ToTable("Item_Pedido");
                });

            modelBuilder.Entity("SoftCandy.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Pedido");

                    b.Property<int>("IdCliente");

                    b.Property<decimal>("ValorTotalPedido");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdCliente");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("SoftCandy.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(60);

                    b.Property<int>("IdCategoria");

                    b.Property<string>("Nome_Produto")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<decimal>("Preco_Venda");

                    b.Property<int>("QuantidadePedido");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SoftCandy.Models.Vendedor", b =>
                {
                    b.Property<int>("Id_Vendedor")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular_Vendedor");

                    b.Property<string>("Email_Vendedor");

                    b.Property<string>("Endereco_Vendedor");

                    b.Property<string>("Nome_Vendedor");

                    b.Property<string>("Senha_Vendedor");

                    b.HasKey("Id_Vendedor");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("SoftCandy.Models.Item_Pedido", b =>
                {
                    b.HasOne("SoftCandy.Models.Produto", "Produto")
                        .WithMany("Itens_Pedidos")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoftCandy.Models.Pedido", "Pedido")
                        .WithMany("Itens_Pedidos")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoftCandy.Models.Pedido", b =>
                {
                    b.HasOne("SoftCandy.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoftCandy.Models.Produto", b =>
                {
                    b.HasOne("SoftCandy.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
