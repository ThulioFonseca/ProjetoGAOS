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

            return View(await _context.OrdemDeServicos.OrderBy(x => x.Id).AsNoTracking().ToListAsync());


        }

        public Task<EmptyResult> BuscaDados(){

            ViewBag.Teste = "Funciona!!!";
            return null;

        }


        private void Querys (int? id){

            if(id == null){


                var ModeloSelectList = new SelectList(from Dispositivo in _context.Dispositivos.OrderBy(x=>x.Fabricante) join Cliente in _context.Clientes on Dispositivo.Proprietario equals Cliente.Cpf 
 
                                        select new
                                        {   
                                            id = Dispositivo.Identificador,
                                            FabricanteModelo = Dispositivo.Fabricante + " - " + Dispositivo.Modelo + " ------- " + Cliente.Nome},                                                           
                                            
                                            "id",
                                            "FabricanteModelo"

                                            );

                ViewBag.AllDispositivos = ModeloSelectList;

                
            var AllClientes = new List<Cliente>(

                                    from Cliente in _context.Clientes
                                    select Cliente);                  

                    var AllClienteSelectList = new SelectList(AllClientes, nameof(Cliente.Cpf), nameof(Cliente.Nome));

            ViewBag.AllClientes = AllClienteSelectList;

            }          


         var ListaDispositivo = new List<Dispositivo>(

                                    from Ordem in _context.OrdemDeServicos
                                    where Ordem.Id == id
                                    join Dispositivo in _context.Dispositivos on Ordem.Identificador
                                    equals Dispositivo.Identificador
                                    select Dispositivo);                  

                    var DispositivoSelectList = new SelectList(ListaDispositivo, nameof(Dispositivo.Identificador), nameof(Dispositivo.Modelo));

            ViewBag.Dispositivo = DispositivoSelectList ;

            var ListaNome = new List<Cliente>(

                                    from Ordem in _context.OrdemDeServicos
                                    where Ordem.Id == id
                                    join Cliente in _context.Clientes on Ordem.Cliente
                                    equals Cliente.Cpf
                                    select Cliente);                  

                    var ClienteSelectList = new SelectList(ListaNome, nameof(Cliente.Cpf), nameof(Cliente.Nome));

            ViewBag.Cliente = ClienteSelectList;


        }

        [HttpGet]
        public async Task<IActionResult> CriaOrdem(int? id)
        {
                
            Querys(id);

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