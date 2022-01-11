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


    public class OrdensController : Controller
    {


        private readonly aulaContext _context;

        public OrdensController(aulaContext context)
        {

            this._context = context;
        }

        public async Task<IActionResult> ListaOrdens()
        {

            return View(await _context.OrdemDeServicos.OrderBy(x => x.Id).AsNoTracking().ToListAsync());


        }

        [HttpGet]
        public async Task<IActionResult> CriaOrdem(int? id)
        {


            var DispositivoSelectList = new SelectList(from Dispositivo in _context.Dispositivos.OrderBy(x=>x.Fabricante) join Cliente in _context.Clientes on Dispositivo.Proprietario equals Cliente.Cpf 
 
                                        select new
                                        {
                                            id = Dispositivo.Identificador,
                                            FabricanteModelo = Dispositivo.Fabricante + " - " + Dispositivo.Modelo + " ------- " + Cliente.Nome},                                                           

                                            "id",
                                            "FabricanteModelo"

                                            );

             var ClienteSelectList = new SelectList(from Cliente in _context.Clientes.OrderBy(x => x.Nome).AsNoTracking().ToList()

                                        select new
                                        {
                                            cpf = Cliente.Cpf,
                                            nome = Cliente.Nome},                                                           

                                            "cpf",
                                            "nome"

                                            );

            ViewBag.AllDispositivos = DispositivoSelectList;
            ViewBag.AllClientes = ClienteSelectList;
            

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

      }



}