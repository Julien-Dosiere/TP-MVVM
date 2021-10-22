namespace IHM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class numero : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Adresses", "Numero", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Adresses", "Numero", c => c.Int(nullable: false));
        }
    }
}
