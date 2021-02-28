using FriendOrganizer.UI.ViewModel;
using System.Windows;

namespace FriendOrganizer.UI
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        /// <summary>
        /// Assign the DataContext of the View to the 
        /// main ViewModel
        /// </summary>
        /// <param name="viewModel"></param>
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
            Loaded += MainWindow_Loaded;
        }

        /// <summary>
        /// Separation of Concerns
        /// View should not be calling any functions that deal with data,
        /// so assign View DataContext to the ViewModel and Load data into 
        /// the View with a ViewModel object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }
    }
}
