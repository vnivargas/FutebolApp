
using FutebolAdmin.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FutebolAdmin.DAL
{
    public class EquipeDAO
    {
        public Equipe CosultarEquipe(int CodigoEquipe)
        {
            var db = new Contexto();
            return db.Equipe.Where(x => x.ID.Equals(CodigoEquipe)).FirstOrDefault();
        }
    }
}