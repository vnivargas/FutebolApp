using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FutebolAdmin.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Login não pode ser branco.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha não pode ser branco.")]
        public string Senha { get; set; }
        public int EquipeID { get; set; }
        [ForeignKey("EquipeID")]
        public virtual Equipe Equipe { get; set; }
    }
}