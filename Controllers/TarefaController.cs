using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models.Abstract;
using ToDoList.Models.EF;

namespace ToDoList.Controllers
{
    public class TarefaController : Controller
    {

        EFTarefa tarefa;
        public TarefaController()
        {
            EFTarefa _tarefa = new EFTarefa();
            tarefa = _tarefa;
        }
        // GET: Tarefa
        public ActionResult Index()
        {
            return View(tarefa.Tarefas);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Tarefa param)
        {
            tarefa.Cadastrar(param);
            return RedirectToAction("Index");
        }

        public ActionResult Deletar(int id)
        {            
            return View(tarefa.Buscar(id));
        }

        [HttpPost]
        public ActionResult Deletar(Tarefa param)
        {
            tarefa.Remover(param);
            return RedirectToAction("Index");
        }

        
        public ActionResult AlterarStatus(int id)
        {
            tarefa.MudarStatus(id);
            return RedirectToAction("Index");
        }
    }
}