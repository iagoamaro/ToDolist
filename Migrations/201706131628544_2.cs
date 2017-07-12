namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tarefas", newName: "Tarefa");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tarefa", newName: "Tarefas");
        }
    }
}
