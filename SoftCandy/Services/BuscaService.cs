﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoftCandy.Data;
using SoftCandy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCandy.Services
{
    public class BuscaService
    {
        private readonly SoftCandyContext _context;


        public BuscaService(SoftCandyContext context)
        {
            _context = context;

        }
        public async Task<List<Cliente>> FindByCliente(String Nome)
        {
            var result = from obj in _context.Cliente.Where(c => c.AtivoCliente) select obj;
            if (!string.IsNullOrEmpty(Nome))
            {
                byte[] tmp = Encoding.GetEncoding("ISO-8859-8").GetBytes(Nome);
                string pesquisa = System.Text.Encoding.UTF8.GetString(tmp);
                result = result.Where(x => x.NomeCliente.Contains(pesquisa));
            }
            return await result
                  .ToListAsync();
        }

        public async Task<List<Vendedor>> FindByVendedor(String Nome)
        {
            var result = from obj in _context.Vendedor.Where(c => c.AtivoVendedor) select obj;
            if (!string.IsNullOrEmpty(Nome))
            {
                byte[] tmp = Encoding.GetEncoding("ISO-8859-8").GetBytes(Nome);
                string pesquisa = Encoding.UTF8.GetString(tmp);
                result = result.Where(x => x.NomeVendedor.Contains(pesquisa));
            }
            return await result
                  .ToListAsync();
        }

        public async Task<List<Produto>> FindByProduto(String Nome)
        {
            var result = from obj in _context.Produto.Where(c => c.AtivoProduto) select obj;
            if (!string.IsNullOrEmpty(Nome))
            {
                byte[] tmp = Encoding.GetEncoding("ISO-8859-8").GetBytes(Nome);
                string pesquisa = Encoding.UTF8.GetString(tmp);
                result = result.Where(x => x.NomeProduto.Contains(pesquisa));
            }
            return await result
                  .ToListAsync();
        }

        public async Task<List<Categoria>> FindByCategoria(String Nome)
        {
            var result = from obj in _context.Categoria.Where(c => c.AtivoCategoria) select obj;
            if (!string.IsNullOrEmpty(Nome))
            {
                byte[] tmp = Encoding.GetEncoding("ISO-8859-8").GetBytes(Nome);
                string pesquisa = Encoding.UTF8.GetString(tmp);
                result = result.Where(x => x.NomeCategoria.Contains(pesquisa));
            }
            return await result
                  .ToListAsync();
        }

        public async Task<List<Pedido>> FindByPedido(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Pedido.Where(c => c.AtivoPedido) select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataPedido >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataPedido <= maxDate.Value);
            }
            return await result
                .Include(x => x.Cliente)
                .OrderByDescending(x => x.DataPedido)
                .ToListAsync();
        }
    }
}