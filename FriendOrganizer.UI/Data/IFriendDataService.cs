using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    /// <summary>
    /// Interface for the ViewModel to interact with the DataService
    /// </summary>
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}