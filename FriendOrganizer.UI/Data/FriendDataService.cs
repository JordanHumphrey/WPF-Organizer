using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        /// <summary>
        /// Load the database context for the FriendOrganizer by having Autofac
        /// create the service. 
        /// FriendOrganizerDbContext was added to the config file for type registration.
        /// </summary>
        /// <param name="contextCreator"></param>
        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        /// <summary>
        /// Loads data from the SQL Server database.
        /// Every time we call Func in constructor, a new 
        /// FriendOrganizerDbContext is created.
        /// Grab database info to laod asynchronously, and 
        /// await for it so that the ctx is not destroyed before we
        /// can load the data.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Friend>> GetAllAsync()
        {
            using (var ctx = new FriendOrganizerDbContext())
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
                //await Task.Delay(5000); Testing UI control
                //return friends;
            }
        }
    }
}
