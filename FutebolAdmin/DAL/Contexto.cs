using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FutebolAdmin.Models;

namespace FutebolAdmin.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Equipe> Equipe { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Jogador> Jogador { get; set; }

    }
}