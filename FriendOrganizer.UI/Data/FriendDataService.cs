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
        public async Task<Friend> GetByIdAsync(int friendId)
        {
            using (var ctx = new FriendOrganizerDbContext())
            {
                return await ctx.Friends.AsNoTracking().SingleAsync(f => f.Id==friendId);
                //await Task.Delay(5000); Testing UI control
                //return friends;
            }
        }

        /// <summary>
        /// Calls the Func<FriendOrganizerDbContext> to get the Db context, 
        /// and attaches the friend to the context so it is aware of this instance.
        /// </summary>
        /// <param name="friend"></param>
        /// <returns></returns>
        public async Task SaveAsync(Friend friend)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Friends.Attach(friend);
                ctx.Entry(friend).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
        }
    }
}
