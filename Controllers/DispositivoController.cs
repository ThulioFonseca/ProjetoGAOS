using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoGAOS.Models;

namespace ProjetoGAOS.Controllers
{


    public class DispositivoController : Controller
    {


        private readonly AulaContext _context;

        public DispositivoController(AulaContext context)
        {

            this._context = context;
        }

        public async Task<IActionResult> ListaDispositivos()
        {
            
            return View(await _context.Dispositivos.OrderBy(x=>x.Fabricante).AsNoTracking().ToListAsync());
           
        }


        [HttpGet]
        public async Task<IActionResult> CadastroDispositivo(int? id)
        {
            var proprietarios = _context.Clientes.OrderBy(x => x.Nome).AsNoTracking().ToList();
            var proprietariosSelectList = new SelectList(proprietarios, nameof(Cliente.Cpf), nameof(Cliente.Nome));
            ViewBag.Options = proprietariosSelectList;

            if (id.HasValue)
            {

                var dispositivo = await _context.Dispositivos.FindAsync(id.ToString());
                if (dispositivo == null)
                {

                    return NotFound();
                }
                return View(dispositivo);

            }
            return View(new Dispositivo());

        }

        private bool ConsultaId(int id)
        {

            return _context.Dispositivos.Any(x => x.Identificador.Equals(id.ToString()));
        }

        [HttpPost]
        public async Task<IActionResult> CadastroDispositivo(int? id, [FromForm] Dispositivo dispositivo)
        {

            if (id.HasValue)
            {
                if (ConsultaId(id.Value))
                {

                    _context.Update(dispositivo);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ListaDispositivos");

                }

            }

            _context.Add(dispositivo);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListaDispositivos");

        }

        [HttpGet]

        public async Task<IActionResult> DeletarDispositivo(int? id)
        {

            var dispositivo = await _context.Dispositivos.FindAsync(id.ToString());

            return View(dispositivo);


        }

        [HttpPost]

        public async Task<IActionResult> DeletarDispositivo(int id)
        {

            var dispositivo = await _context.Dispositivos.FindAsync(id.ToString());
            if (dispositivo != null)
            {

                _context.Remove(dispositivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListaDispositivos));


            }

            return RedirectToAction("Index", "Home");

        }


    }



}