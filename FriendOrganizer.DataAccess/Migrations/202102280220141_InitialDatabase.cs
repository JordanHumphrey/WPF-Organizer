namespace FriendOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    /// <summary>
    /// When wanting to add constraints to the entity framework tables,
    /// do so via the Model objects, and re-scaffold the migration
    /// with 'Add-Migration InitialDatabase -Force' in Nuget PM.
    /// When ready to build the database, run Update-Database in PM,
    /// while also adding the connection string config to the UI config file.
    /// </summary>
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friend",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Friend");
        }
    }
}
