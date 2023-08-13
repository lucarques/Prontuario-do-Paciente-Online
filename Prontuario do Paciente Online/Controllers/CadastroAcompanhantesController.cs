using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;

namespace Prontuario_do_Paciente_Online.Controllers
{
    public class CadastroAcompanhantesController : Controller
    {
        private readonly Contexto _context;

        public CadastroAcompanhantesController(Contexto context)
        {
            _context = context;
        }

        // GET: CadastroAcompanhantes
        public async Task<IActionResult> Index()
        {
              return _context.CadastroAcompanhante != null ? 
                          View(await _context.CadastroAcompanhante.ToListAsync()) :
                          Problem("Entity set 'Contexto.CadastroAcompanhante'  is null.");
        }

        // GET: CadastroAcompanhantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadastroAcompanhante == null)
            {
                return NotFound();
            }

            var cadastroAcompanhante = await _context.CadastroAcompanhante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroAcompanhante == null)
            {
                return NotFound();
            }

            return View(cadastroAcompanhante);
        }

        // GET: CadastroAcompanhantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroAcompanhantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Sexo,CPF,Email,Celular,UtilizarApp")] CadastroAcompanhante cadastroAcompanhante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroAcompanhante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroAcompanhante);
        }

        // GET: CadastroAcompanhantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadastroAcompanhante == null)
            {
                return NotFound();
            }

            var cadastroAcompanhante = await _context.CadastroAcompanhante.FindAsync(id);
            if (cadastroAcompanhante == null)
            {
                return NotFound();
            }
            return View(cadastroAcompanhante);
        }

        // POST: CadastroAcompanhantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sexo,CPF,Email,Celular,UtilizarApp")] CadastroAcompanhante cadastroAcompanhante)
        {
            if (id != cadastroAcompanhante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroAcompanhante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroAcompanhanteExists(cadastroAcompanhante.Id))
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
            return View(cadastroAcompanhante);
        }

        // GET: CadastroAcompanhantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadastroAcompanhante == null)
            {
                return NotFound();
            }

            var cadastroAcompanhante = await _context.CadastroAcompanhante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroAcompanhante == null)
            {
                return NotFound();
            }

            return View(cadastroAcompanhante);
        }

        // POST: CadastroAcompanhantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadastroAcompanhante == null)
            {
                return Problem("Entity set 'Contexto.CadastroAcompanhante'  is null.");
            }
            var cadastroAcompanhante = await _context.CadastroAcompanhante.FindAsync(id);
            if (cadastroAcompanhante != null)
            {
                _context.CadastroAcompanhante.Remove(cadastroAcompanhante);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroAcompanhanteExists(int id)
        {
          return (_context.CadastroAcompanhante?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
