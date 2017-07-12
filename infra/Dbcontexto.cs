using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ToDoList.Models.Abstract;

namespace ToDoList.infra
{
    public class Dbcontexto : DbContext
    {
        public Dbcontexto()
            :base("dev")
        {

        }
        public DbSet<Tarefa> Tarefa { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();



            base.OnModelCreating(modelBuilder);
        }
    }
}