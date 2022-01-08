using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoGAOS.Models;


namespace ProjetoGAOS.Controllers
{


    public class OrdensController : Controller
    {


        private readonly AulaContext _context;

        public OrdensController(AulaContext context)
        {

            this._context = context;
        }

        public async Task<IActionResult> ListaOrdens()
        {

            return View(await _context.OrdemDeServicos .AsNoTracking().ToListAsync());


        }

        [HttpGet]
        public async Task<IActionResult> CriaOrdem(int? id)
        {

            if (id.HasValue)
            {

                var ordem = await _context.OrdemDeServicos.FindAsync(id);
                if (ordem == null)
                {

                    return RedirectToAction("Index", "Home");
                }
                return View(ordem);

            }
            return View(new OrdemDeServico());

        }

        private bool ConsultaChave(int id)
        {

            return _context.OrdemDeServicos .Any(x => x.Id.Equals(id));
        }

        [HttpPost]
        public async Task<IActionResult> CriaOrdem(int? id, [FromForm] OrdemDeServico ordem)
        {

            if (id.HasValue)
            {
                if (ConsultaChave(id.Value))
                {

                    _context.Update(ordem);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ListaOrdens");

                }

            }

            _context.Add(ordem);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListaOrdens");

        }

      /*  [HttpGet]

        public async Task<IActionResult> DeletarCliente(int? id)
        {

            var cliente = await _context.OrdemDeServicos.FindAsync(id.ToString());

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

        }*/


    }



}