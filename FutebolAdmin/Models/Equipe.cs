using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FutebolAdmin.Models
{
    [Table("Equipes")]
    public class Equipe
    {
        public int ID { get; set; }

        public DateTime DataFundacao { get; set; }

        [Required(ErrorMessage = "Nome não pode ser branco.")]
        public string Nome { get; set; }
        
        public string Cidade { get; set; }
        public string Descricao { get; set; }
    }
}