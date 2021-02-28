using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Startup;
using FriendOrganizer.UI.ViewModel;
using System.Windows;

namespace FriendOrganizer.UI
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
    {
        /// <summary>
        /// A custom startup function is needed since we create
        /// it based on a ViewModel being passed with a FriendDataService.
        /// We use AutoFac to allow for automatic dependency injection
        /// and enable unit testing and scalability.
        /// Bootstrapper will resolve a MainWindow, and look at its constructor,
        /// and see it has to create a MainViewModel, go to the MainViewModel's
        /// constructor and see it has create an IFriendDataService.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootStrapper = new Bootstrapper();
            var container = bootStrapper.Boostrap();
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
