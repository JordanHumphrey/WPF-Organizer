using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        /// <summary>
        /// Returns a bunch of friend objects with each successive call
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Friend> GetAll()
        {
            // TODO: load data from a real database
            yield return new Friend { FirstName = "Jordan", LastName = "Humphrey" };
            yield return new Friend { FirstName = "Matthew", LastName = "Porembra" };
            yield return new Friend { FirstName = "Mike", LastName = "Pidgeon" };
            yield return new Friend { FirstName = "Kim", LastName = "Yeoung" };
        }
    }
}
