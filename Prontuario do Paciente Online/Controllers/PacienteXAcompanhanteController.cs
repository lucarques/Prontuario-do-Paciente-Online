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
    public class PacienteXAcompanhanteController : Controller
    {
        private readonly Contexto _context;

        public PacienteXAcompanhanteController(Contexto context)
        {
            _context = context;
        }

        // GET: PacienteXAcompanhante
        public async Task<IActionResult> Index()
        {
              return _context.Pacientes != null ? 
                          View(await _context.Pacientes.ToListAsync()) :
                          Problem("Entity set 'Contexto.Pacientes'  is null.");
        }

        // GET: PacienteXAcompanhante/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var pacienteXAcompanhante = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pacienteXAcompanhante == null)
            {
                return NotFound();
            }

            return View(pacienteXAcompanhante);
        }

        // GET: PacienteXAcompanhante/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PacienteXAcompanhante/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Sexo,CPF,Endereco,Numero,Bairro,Cidade,Estado,Motivo,NomeAcompanhante,CPFAcompanhante,Email,Celular,GrauParentesco")] PacienteXAcompanhante pacienteXAcompanhante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pacienteXAcompanhante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pacienteXAcompanhante);
        }

        // GET: PacienteXAcompanhante/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var pacienteXAcompanhante = await _context.Pacientes.FindAsync(id);
            if (pacienteXAcompanhante == null)
            {
                return NotFound();
            }
            return View(pacienteXAcompanhante);
        }

        // POST: PacienteXAcompanhante/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sexo,CPF,Endereco,Numero,Bairro,Cidade,Estado,Motivo,NomeAcompanhante,CPFAcompanhante,Email,Celular,GrauParentesco")] PacienteXAcompanhante pacienteXAcompanhante)
        {
            if (id != pacienteXAcompanhante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pacienteXAcompanhante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteXAcompanhanteExists(pacienteXAcompanhante.Id))
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
            return View(pacienteXAcompanhante);
        }

        // GET: PacienteXAcompanhante/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var pacienteXAcompanhante = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pacienteXAcompanhante == null)
            {
                return NotFound();
            }

            return View(pacienteXAcompanhante);
        }

        // POST: PacienteXAcompanhante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pacientes == null)
            {
                return Problem("Entity set 'Contexto.Pacientes'  is null.");
            }
            var pacienteXAcompanhante = await _context.Pacientes.FindAsync(id);
            if (pacienteXAcompanhante != null)
            {
                _context.Pacientes.Remove(pacienteXAcompanhante);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteXAcompanhanteExists(int id)
        {
          return (_context.Pacientes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
