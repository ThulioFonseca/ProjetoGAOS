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

            List<String> Nomes = new List<string>();
            var DispositivoIds = _context.Dispositivos.OrderBy(x => x.Modelo).AsNoTracking().ToList();
            foreach (var Dispositivo in DispositivoIds){

                Nomes.Add(Dispositivo.Fabricante.ToString());

            }

            var listaNomes = new SelectList(Nomes);

            var DispositivoSelectList = new SelectList((from Dispositivo in _context.Dispositivos.OrderBy(x => x.Modelo).AsNoTracking().ToList()

                                                       select new
                                                       {

                                                           id = Dispositivo.Identificador,
                                                           ModeloNome = Dispositivo.Fabricante + " " + Dispositivo.Modelo }),
                                                           "id", 
                                                           "ModeloNome"
                                                           
                                                           );




            ViewBag.AllDispositivos = DispositivoSelectList;
            ViewBag.AllClientes = listaNomes;
            //DispositivoIds[0].Proprietario.ToString()

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