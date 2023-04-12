using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EstoqueGeral.Data;
using EstoqueGeral.Models;

namespace EstoqueGeral.Controllers
{
    public class TestesController : Controller
    {
        private readonly EstoqueGeralContext _context;

        public TestesController(EstoqueGeralContext context)
        {
            _context = context;
        }

        // GET: Testes
        public async Task<IActionResult> Index()
        {
              return _context.Teste != null ? 
                          View(await _context.Teste.ToListAsync()) :
                          Problem("Entity set 'EstoqueGeralContext.Teste'  is null.");
        }

        // GET: Testes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Teste == null)
            {
                return NotFound();
            }

            var teste = await _context.Teste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teste == null)
            {
                return NotFound();
            }

            return View(teste);
        }

        // GET: Testes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Testes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Teste teste)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teste);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teste);
        }

        // GET: Testes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Teste == null)
            {
                return NotFound();
            }

            var teste = await _context.Teste.FindAsync(id);
            if (teste == null)
            {
                return NotFound();
            }
            return View(teste);
        }

        // POST: Testes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id")] Teste teste)
        {
            if (id != teste.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teste);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TesteExists(teste.Id))
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
            return View(teste);
        }

        // GET: Testes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Teste == null)
            {
                return NotFound();
            }

            var teste = await _context.Teste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teste == null)
            {
                return NotFound();
            }

            return View(teste);
        }

        // POST: Testes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Teste == null)
            {
                return Problem("Entity set 'EstoqueGeralContext.Teste'  is null.");
            }
            var teste = await _context.Teste.FindAsync(id);
            if (teste != null)
            {
                _context.Teste.Remove(teste);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TesteExists(string id)
        {
          return (_context.Teste?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
