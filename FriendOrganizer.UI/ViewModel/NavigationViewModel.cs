using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Event;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private IFriendLookupDataService _friendLookupService { get; set; }

        private IEventAggregator _eventAggregator;

        /// <summary>
        /// Constructor takes an IFriendDataLookupService that corresponds
        /// to the requirements of this ViewModel, lookup of friends.
        /// </summary>
        /// <param name="friendLookupDataService"></param>
        public NavigationViewModel(IFriendLookupDataService friendLookupDataService,
            IEventAggregator eventAggregator)
        {
            _friendLookupService = friendLookupDataService;
            _eventAggregator = eventAggregator;
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

        public ObservableCollection<LookupItem> Friends { get; }

        private LookupItem _selectedFriend;

        public LookupItem SelectedFriend
        {
            get { return _selectedFriend; }
            set 
            {
                _selectedFriend = value;
                OnPropertyChanged();
                // Once the property has been updated, send out
                // an event that the property has been changed for
                // the other viewmodels to pickup.
                if (_selectedFriend != null)
                {
                    _eventAggregator.GetEvent<OpenFriendDetailViewEvent>()
                        .Publish(_selectedFriend.Id);
                }
            }
        }

    }
}
