namespace IHM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initcomptes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Rue = c.String(),
                        CodePostal = c.String(),
                        Ville = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Comptes", "Login", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comptes", "Login", c => c.Int(nullable: false));
            DropTable("dbo.Adresses");
        }
    }
}
