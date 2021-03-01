using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    /// <summary>
    /// Interface for the ViewModels to interact with the DataService
    /// </summary>
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(int friendId);
        Task SaveAsync(Friend friend);
    }
}