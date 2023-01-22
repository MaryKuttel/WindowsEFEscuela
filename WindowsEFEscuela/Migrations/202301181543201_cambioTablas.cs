namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumno");
            AlterColumn("dbo.Alumno", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumno", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesors", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesors", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesors", "Titulo", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profesors", "Titulo", c => c.String());
            AlterColumn("dbo.Profesors", "Apellido", c => c.String());
            AlterColumn("dbo.Profesors", "Nombre", c => c.String());
            AlterColumn("dbo.Alumno", "Apellido", c => c.String());
            AlterColumn("dbo.Alumno", "Nombre", c => c.String());
            RenameTable(name: "dbo.Alumno", newName: "Alumnoes");
        }
    }
}
