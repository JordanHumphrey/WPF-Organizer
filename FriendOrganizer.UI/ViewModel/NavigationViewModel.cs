using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class NavigationViewModel : INavigationViewModel
    {
        private IFriendLookupDataService _friendLookupService { get; set; }
        public ObservableCollection<LookupItem> Friends { get; }

        /// <summary>
        /// Constructor takes an IFriendDataLookupService that corresponds
        /// to the requirements of this ViewModel, lookup of friends.
        /// </summary>
        /// <param name="friendLookupDataService"></param>
        public NavigationViewModel(IFriendLookupDataService friendLookupDataService)
        {
            _friendLookupService = friendLookupDataService;
            Friends = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _friendLookupService.GetFriendLookupAsync();
            Friends.Clear();
            foreach (var item in lookup)
            {
                Friends.Add(item);
            }
        }
    }
}
