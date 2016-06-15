namespace FutebolAdmin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipe",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataFundacao = c.DateTime(nullable: false),
                        Nome = c.String(nullable: false),
                        Cidade = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Sobrenome = c.String(nullable: false),
                        Documento = c.String(nullable: false),
                        Posicao = c.String(),
                        EquipeID = c.Int(nullable: false),
                        Votos = c.Int(nullable: false),
                        Gols = c.Int(nullable: false),
                        Suspenso = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Equipe", t => t.EquipeID, cascadeDelete: true)
                .Index(t => t.EquipeID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        EquipeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Equipe", t => t.EquipeID, cascadeDelete: true)
                .Index(t => t.EquipeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "EquipeID", "dbo.Equipe");
            DropForeignKey("dbo.Jogadors", "EquipeID", "dbo.Equipe");
            DropIndex("dbo.Usuario", new[] { "EquipeID" });
            DropIndex("dbo.Jogadors", new[] { "EquipeID" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Jogadors");
            DropTable("dbo.Equipe");
        }
    }
}
