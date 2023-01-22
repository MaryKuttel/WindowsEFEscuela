namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Profesor_ProfesorId = c.Int(),
                    })
                .PrimaryKey(t => t.AlumnoId)
                .ForeignKey("dbo.Profesors", t => t.Profesor_ProfesorId)
                .Index(t => t.Profesor_ProfesorId);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Titulo = c.String(),
                    })
                .PrimaryKey(t => t.ProfesorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumnoes", "Profesor_ProfesorId", "dbo.Profesors");
            DropIndex("dbo.Alumnoes", new[] { "Profesor_ProfesorId" });
            DropTable("dbo.Profesors");
            DropTable("dbo.Alumnoes");
        }
    }
}
