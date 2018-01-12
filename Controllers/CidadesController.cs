using Microsoft.AspNetCore.Mvc;
using ProjetoCidades.Models;
using ProjetoCidades.Repositorio;

namespace ProjetoCidades.Controllers
{
    public class CidadesController:Controller
    {
        Cidade cidade = new Cidade();
        CidadeRep objCidadeRep = new CidadeRep();
        public IActionResult Index(){
            var lista = objCidadeRep.Listar();
            return View(lista);
        }

        public IActionResult CidadesEstados(){
            var lista = objCidadeRep.Listar();
            return View(lista);
        }

        public IActionResult TodosOsDados(){
            var lista = objCidadeRep.Listar();
            return View(lista);
        }
        
        [HttpGet]
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([Bind] Cidade cidade){
            objCidadeRep.Cadastrar(cidade);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id){
            var cidade = objCidadeRep.Listar(id);
            return View(cidade);
        }

        [HttpPost]
        public IActionResult Editar([Bind] Cidade cidade){
            objCidadeRep.Editar(cidade);
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int id){
            objCidadeRep.Excluir(id);
            return RedirectToAction("Index");
        }

        public IActionResult Detalhes(int id){
            var cidade = objCidadeRep.Listar(id);
            return View(cidade);
        }

    }
}