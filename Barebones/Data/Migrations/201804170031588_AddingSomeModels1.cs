namespace Barebones.Data.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingSomeModels1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BodyEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BodyType = c.String(),
                        Weight = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        IsSoftDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BoneEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Density = c.Int(nullable: false),
                        Color = c.String(),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        IsSoftDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BoneEntities");
            DropTable("dbo.BodyEntities");
        }
    }
}
