Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class NovoBanco
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Autenticacaos",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Email = c.String(),
                        .Senha = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Usuarios",
                Function(c) New With
                    {
                        .ID = c.Int(nullable := False, identity := True),
                        .Nome = c.String(nullable := False),
                        .Email = c.String(nullable := False),
                        .Senha = c.String(nullable := False),
                        .TipoUsuario = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.ID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Usuarios")
            DropTable("dbo.Autenticacaos")
        End Sub
    End Class
End Namespace
