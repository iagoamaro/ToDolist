using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models.Abstract
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Descrição deve ser informada.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Data da Criação")]
        public DateTime DataCriacao { get; set; }
       
        [Display(Name = "Concluída")]
        public bool Status { get; set; }

    }
}