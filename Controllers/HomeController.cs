using Microsoft.AspNetCore.Mvc;
using ProjetoGAOS.Models;

namespace ProjetoGAOS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){

            return View();

          
        }
       
    }
}