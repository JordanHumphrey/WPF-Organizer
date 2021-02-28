using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    /// <summary>
    /// Interface for the ViewModel to interact with the DataService
    /// </summary>
    public interface IFriendDataService
    {
        Task<List<Friend>> GetAllAsync();
    }
}