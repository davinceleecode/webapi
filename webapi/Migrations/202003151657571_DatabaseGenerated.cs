namespace webapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class DatabaseGenerated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GameEvents", "CreatedDate", c => c.DateTime(defaultValueSql: "GETDATE()"));
            AlterColumn("dbo.Games", "CreatedDate", c => c.DateTime(defaultValueSql: "GETDATE()"));
            AlterColumn("dbo.Teams", "CreatedDate", c => c.DateTime(defaultValueSql: "GETDATE()"));
            AlterColumn("dbo.Players", "CreatedDate", c => c.DateTime(defaultValueSql: "GETDATE()"));
        }

        public override void Down()
        {
            AlterColumn("dbo.Players", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Teams", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Games", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.GameEvents", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
