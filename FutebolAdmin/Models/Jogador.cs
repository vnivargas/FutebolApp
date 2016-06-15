using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FutebolAdmin.Models
{
    [Table("Jogadores")]
    public class Jogador
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Nome não pode ser branco.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Nome não pode ser branco.")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "RG não pode ser branco.")]
        public string Documento { get; set; }
        public string Posicao { get; set; }
        public int EquipeID { get; set; }
        public int Votos { get; set; }
        public int Gols { get; set; }
        public bool Suspenso { get; set; }

        [ForeignKey("EquipeID")]
        public virtual Equipe Equipe { get; set; }
    }
}