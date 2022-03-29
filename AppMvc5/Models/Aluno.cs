using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AppMvc5.Models
{
    public class Aluno
    {


        public Aluno(DateTime matricula)
        {      
            DataMatricula = DateTime.Now;
        }
        public Aluno()
        {

        }

        [Key]
        public int Id { get; set; }

        [DisplayName("Nome Completo:")]
        [Required(ErrorMessage = " O campo {0} é obrigatório!")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres!")]
        public string Nome { get; set; }

        [DisplayName("E-mail:")]
        [Required(ErrorMessage =" O campo {0} é obrigatório!")]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(300,ErrorMessage ="Escreva no máximo até 300 caracteres!")]
        [MinLength(30,ErrorMessage ="Escreva no mínimo 30 caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório!")]
        public string CPF { get; set; }


        public DateTime DataMatricula { get; set; }

        public bool Ativo { get; set; }


    }
}