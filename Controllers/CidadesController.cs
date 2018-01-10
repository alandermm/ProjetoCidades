using Microsoft.AspNetCore.Mvc;
using ProjetoCidades.Models;

namespace ProjetoCidades.Controllers
{
    public class CidadesController:Controller
    {
        Cidade cidade = new Cidade();
        public IActionResult Index(){
            var lista = cidade.ListarCidades();
            return View(lista);
        }

        public IActionResult CidadesEstados(){
            var lista = cidade.ListarCidades();
            return View(lista);
        }

        public IActionResult TodosOsDados(){
            var lista = cidade.ListarCidades();
            return View(lista);
        }


    }
}