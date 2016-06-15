namespace FutebolAdmin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeuPrimeiroMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Equipe", newName: "Equipes");
            RenameTable(name: "dbo.Jogadors", newName: "Jogadores");
            RenameTable(name: "dbo.Usuario", newName: "Usuarios");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Usuarios", newName: "Usuario");
            RenameTable(name: "dbo.Jogadores", newName: "Jogadors");
            RenameTable(name: "dbo.Equipes", newName: "Equipe");
        }
    }
}
