using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoList.infra;
using ToDoList.Models.Abstract;

namespace ToDoList.Models.EF
{
    public class EFTarefa
    {
        private Dbcontexto db;
        public EFTarefa()
        {
            db = new Dbcontexto();
        }

        public List<Tarefa> Tarefas
        {
            get
            {
                
                return db.Tarefa.OrderBy(x => x.Status).ThenBy(s => s.DataCriacao).ToList();
            }
        }

        public void Cadastrar (Tarefa param)
        {
            param.Status = param.Status.Equals(null) ? false : param.Status;
            db.Tarefa.Add(param);
            db.SaveChanges();
           
        }

        public void Remover(Tarefa param)
        {
            db.Entry(param).State = EntityState.Deleted;
            db.SaveChanges();

        }

        public void MudarStatus(int id)
        {
            var tarefa = db.Tarefa.FirstOrDefault(x => x.Id == id);
            tarefa.Status = tarefa.Status == false ? true : false;
            db.Entry(tarefa).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Tarefa Buscar(int id)
        {
            return db.Tarefa.FirstOrDefault(x => x.Id == id);
        }
    }
}