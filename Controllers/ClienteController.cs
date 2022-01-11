using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoGAOS.Models;

namespace ProjetoGAOS.Controllers
{


    public class ClienteController : Controller
    {
        private readonly AulaContext _context;

        public ClienteController(AulaContext context)
        {

            this._context = context;
        }
        public async Task<IActionResult> ListaClientes()
        {

            return View(await _context.Clientes.OrderBy(x => x.Nome).AsNoTracking().ToListAsync());

        }

        [HttpGet]
        public async Task<IActionResult> CadastroCliente(int? id)
        {

            if (id.HasValue)
            {

                var cliente = await _context.Clientes.FindAsync(id.ToString());
                if (cliente == null)
                {

                    return NotFound();
                }
                return View(cliente);

            }
            return View(new Cliente());

        }

        private bool ConsultaCpf(int id)
        {

            return _context.Clientes.Any(x => x.Cpf.Equals(id.ToString()));
        }

        [HttpPost]
        public async Task<IActionResult> CadastroCliente(int? id, [FromForm] Cliente cliente)
        {

            if (id.HasValue)
            {
                if (ConsultaCpf(id.Value))
                {

                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ListaClientes");

                }

            }

            _context.Add(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListaClientes");

        }

        [HttpGet]

        public async Task<IActionResult> DeletarCliente(int? id)
        {

            var cliente = await _context.Clientes.FindAsync(id.ToString());

            return View(cliente);


        }

        [HttpPost]

        public async Task<IActionResult> DeletarCliente(int id)
        {

            var cliente = await _context.Clientes.FindAsync(id.ToString());
            if (cliente != null)
            {

                _context.Remove(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListaClientes));


            }

            return RedirectToAction("Index", "Home");

        }


    }



}