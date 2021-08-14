﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoftCandy.Data;
using SoftCandy.Models;

namespace SoftCandy.Controllers
{
    public class PedidoController : Controller
    {
        private readonly SoftCandyContext _context;

        public PedidoController(SoftCandyContext context)
        {
            _context = context;
        }

        // GET: Pedido
        public async Task<IActionResult> Index()
        {
            var softCandyContext = _context.Pedido.Include(c => c.Cliente);

            return View(await softCandyContext.ToListAsync());
           
           
        }

        // GET: Pedido/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.Num_Pedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedido/Create
        public IActionResult Create()
        {
            ViewData["ID_CLIENTE"] = new SelectList(_context.Cliente, "Id_Cliente", "Nome");
            return View();
        }

        // POST: Pedido/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Num_Pedido,Valor_Total,Desconto,Data_Pedido,ID_CLIENTE")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ID_CLIENTE"] = new SelectList(_context.Cliente, "Id_Cliente", "Celular", pedido.ID_CLIENTE);
            return View(pedido);
        }

        // GET: Pedido/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["ID_CLIENTE"] = new SelectList(_context.Cliente, "Id_Cliente", "Celular", pedido.ID_CLIENTE);
            return View(pedido);
        }

        // POST: Pedido/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Num_Pedido,Valor_Total,Desconto,Data_Pedido,ID_CLIENTE")] Pedido pedido)
        {
            if (id != pedido.Num_Pedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.Num_Pedido))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ID_CLIENTE"] = new SelectList(_context.Cliente, "Id_Cliente", "Celular", pedido.ID_CLIENTE);
            return View(pedido);
        }

        // GET: Pedido/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.Num_Pedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedido/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.Pedido.FindAsync(id);
            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedido.Any(e => e.Num_Pedido == id);
        }
    }
}
