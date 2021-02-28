using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendOrganizer.UI.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function to raise event where selected item happens or changes,
        /// and pass the name of the property and update it in the View. 
        /// CallerMemberName grabs the name of the property so we dont have to 
        /// pass it manually.
        /// Since we want to use this method from subclasses, its protected,
        /// and we may want to override it so we make it virtual.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
