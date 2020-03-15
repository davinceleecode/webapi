namespace webapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameEvents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PointValue = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        Game_ID = c.Int(),
                        Player_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Games", t => t.Game_ID)
                .ForeignKey("dbo.Players", t => t.Player_ID)
                .Index(t => t.Game_ID)
                .Index(t => t.Player_ID);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        AwayTeam_ID = c.Int(),
                        HomeTeam_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teams", t => t.AwayTeam_ID)
                .ForeignKey("dbo.Teams", t => t.HomeTeam_ID)
                .Index(t => t.AwayTeam_ID)
                .Index(t => t.HomeTeam_ID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        Team_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teams", t => t.Team_ID)
                .Index(t => t.Team_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameEvents", "Player_ID", "dbo.Players");
            DropForeignKey("dbo.GameEvents", "Game_ID", "dbo.Games");
            DropForeignKey("dbo.Games", "HomeTeam_ID", "dbo.Teams");
            DropForeignKey("dbo.Games", "AwayTeam_ID", "dbo.Teams");
            DropForeignKey("dbo.Players", "Team_ID", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_ID" });
            DropIndex("dbo.Games", new[] { "HomeTeam_ID" });
            DropIndex("dbo.Games", new[] { "AwayTeam_ID" });
            DropIndex("dbo.GameEvents", new[] { "Player_ID" });
            DropIndex("dbo.GameEvents", new[] { "Game_ID" });
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
            DropTable("dbo.GameEvents");
        }
    }
}
