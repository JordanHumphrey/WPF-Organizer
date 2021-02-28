namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /// <summary>
    /// This class was auto generated from Nuget PM command 'Enable-Migrations'
    /// after creation of FriendOrganizerDbContext.
    /// With code first migrations enabled, we can add the migration to our data access
    /// project using 'Add-Migration InitialDatabase'.
    /// Whenever we change the Model, we will call this command again.
    /// Then you can apply the migration to the database by calling the 
    /// 'Update-Database' command.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// Insert data into database tables during database initialization process.
        /// Done by creating a custom Db initializer.
        /// This example populates the friends table with initial data.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Jordan", LastName = "Humphrey" },
                new Friend { FirstName = "Matthew", LastName = "Porembra" },
                new Friend { FirstName = "Mike", LastName = "Pidgeon" },
                new Friend { FirstName = "Kim", LastName = "Yeoung" }
                );

        }
    }
}
