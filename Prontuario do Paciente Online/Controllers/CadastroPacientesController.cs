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
    public class CadastroPacientesController : Controller
    {
        private readonly Contexto _context;

        public CadastroPacientesController(Contexto context)
        {
            _context = context;
        }

        // GET: CadastroPacientes
        public async Task<IActionResult> Index()
        {
              return _context.Pacientes != null ? 
                          View(await _context.Pacientes.ToListAsync()) :
                          Problem("Entity set 'Contexto.Pacientes'  is null.");
        }

        // GET: CadastroPacientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var cadastroPaciente = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroPaciente == null)
            {
                return NotFound();
            }

            return View(cadastroPaciente);
        }

        // GET: CadastroPacientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroPacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Sexo,CPF,Endereco,Numero,Bairro,Cidade,Estado,Motivo")] CadastroPaciente cadastroPaciente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroPaciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroPaciente);
        }

        // GET: CadastroPacientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var cadastroPaciente = await _context.Pacientes.FindAsync(id);
            if (cadastroPaciente == null)
            {
                return NotFound();
            }
            return View(cadastroPaciente);
        }

        // POST: CadastroPacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sexo,CPF,Endereco,Numero,Bairro,Cidade,Estado,Motivo")] CadastroPaciente cadastroPaciente)
        {
            if (id != cadastroPaciente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroPaciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroPacienteExists(cadastroPaciente.Id))
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
            return View(cadastroPaciente);
        }

        // GET: CadastroPacientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var cadastroPaciente = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroPaciente == null)
            {
                return NotFound();
            }

            return View(cadastroPaciente);
        }

        // POST: CadastroPacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pacientes == null)
            {
                return Problem("Entity set 'Contexto.Pacientes'  is null.");
            }
            var cadastroPaciente = await _context.Pacientes.FindAsync(id);
            if (cadastroPaciente != null)
            {
                _context.Pacientes.Remove(cadastroPaciente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroPacienteExists(int id)
        {
          return (_context.Pacientes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
