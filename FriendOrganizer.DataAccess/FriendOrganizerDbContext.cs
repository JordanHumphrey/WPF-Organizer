using FriendOrganizer.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FriendOrganizer.DataAccess
{
    public class FriendOrganizerDbContext : DbContext
    {
        /// <summary>
        /// App.config contains the connection string and it will 
        /// create a database for us.
        /// </summary>
        public FriendOrganizerDbContext():base("FriendOrganizerDb")
        {

        }

        /// <summary>
        /// We will Load and set friends using the DB context.
        /// </summary>
        public DbSet<Friend> Friends { get; set; }

        /// <summary>
        /// Prevent Entity Framework from automatically pluralizing our
        /// table names.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
