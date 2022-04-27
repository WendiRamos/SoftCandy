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

            modelBuilder.Entity("SoftCandy.Models.Caixa", b =>
                {
                    b.Property<int>("IdCaixa")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataHoraAbertura");

                    b.Property<DateTime>("DataHoraFechamento");

                    b.Property<bool>("EstaAberto");

                    b.Property<int>("FuncionarioAberturaId");

                    b.Property<int>("FuncionarioFechamentoId");

                    b.Property<decimal>("ValorAbertura")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<decimal>("ValorFechamento")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("IdCaixa");

                    b.HasIndex("FuncionarioAberturaId");

                    b.HasIndex("FuncionarioFechamentoId");

                    b.ToTable("Caixa");
                });

            modelBuilder.Entity("SoftCandy.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AtivoCategoria");

                    b.Property<string>("NomeCategoria");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("SoftCandy.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AtivoCliente");

                    b.Property<string>("BairroCliente");

                    b.Property<string>("CelularCliente");

                    b.Property<string>("CidadeCliente");

                    b.Property<string>("EmailCliente");

                    b.Property<string>("EstadoCliente");

                    b.Property<string>("LogradouroCliente");

                    b.Property<string>("NomeCliente");

                    b.Property<string>("NumeroCliente");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SoftCandy.Models.Fornecedor", b =>
                {
                    b.Property<int>("IdFornecedor")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AtivoFornecedor");

                    b.Property<string>("BairroFornecedor");

                    b.Property<string>("CelularFornecedor");

                    b.Property<string>("CidadeFornecedor");

                    b.Property<string>("Cnpj");

                    b.Property<string>("EmailFornecedor");

                    b.Property<string>("EstadoFornecedor");

                    b.Property<string>("LogradouroFornecedor");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("NumeroFornecedor");

                    b.Property<string>("RazaoSocial");

                    b.HasKey("IdFornecedor");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("SoftCandy.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Bairro");

                    b.Property<int>("Cargo");

                    b.Property<string>("Celular");

                    b.Property<string>("Cidade");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("SoftCandy.Models.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdPedido");

                    b.Property<int>("IdProduto");

                    b.Property<decimal>("PrecoPago");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("IdPedido");

                    b.HasIndex("IdProduto");

                    b.ToTable("Item_Pedido");
                });

            modelBuilder.Entity("SoftCandy.Models.OperacaoCaixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CaixaIdCaixa");

                    b.Property<DateTime>("DataHoraFechamento");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("IdFuncionario");

                    b.Property<string>("Operacao")
                        .IsRequired();

                    b.Property<int>("Tipo");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("CaixaIdCaixa");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("OperacaoCaixa");
                });

            modelBuilder.Entity("SoftCandy.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AtivoPedido");

                    b.Property<DateTime>("DataPedido");

                    b.Property<int>("FormaPagamento");

                    b.Property<int>("IdCaixa");

                    b.Property<int?>("IdCliente");

                    b.Property<int>("IdFuncionario");

                    b.Property<bool>("Recebido");

                    b.Property<decimal>("ValorTotalPedido");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdCaixa");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("SoftCandy.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AtivoProduto");

                    b.Property<string>("DescricaoProduto");

                    b.Property<int>("IdCategoria");

                    b.Property<int>("IdFornecedor");

                    b.Property<string>("NomeProduto");

                    b.Property<decimal>("PrecoVendaProduto");

                    b.Property<int>("QuantidadeMinimaProduto");

                    b.Property<int>("QuantidadeProduto");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdFornecedor");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SoftCandy.Models.Caixa", b =>
                {
                    b.HasOne("SoftCandy.Models.Funcionario", "FuncionarioAbertura")
                        .WithMany()
                        .HasForeignKey("FuncionarioAberturaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoftCandy.Models.Funcionario", "FuncionarioFechamento")
                        .WithMany()
                        .HasForeignKey("FuncionarioFechamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoftCandy.Models.ItemPedido", b =>
                {
                    b.HasOne("SoftCandy.Models.Pedido", "Pedido")
                        .WithMany("ItensPedidos")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoftCandy.Models.Produto", "Produto")
                        .WithMany("ItensPedidos")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoftCandy.Models.OperacaoCaixa", b =>
                {
                    b.HasOne("SoftCandy.Models.Caixa")
                        .WithMany("Operacoes")
                        .HasForeignKey("CaixaIdCaixa");

                    b.HasOne("SoftCandy.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoftCandy.Models.Pedido", b =>
                {
                    b.HasOne("SoftCandy.Models.Caixa", "Caixa")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCaixa")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoftCandy.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente");

                    b.HasOne("SoftCandy.Models.Funcionario", "Funcionario")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoftCandy.Models.Produto", b =>
                {
                    b.HasOne("SoftCandy.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoftCandy.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("IdFornecedor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
