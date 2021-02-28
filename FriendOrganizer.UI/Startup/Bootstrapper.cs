using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI.Startup
{
    /// <summary>
    /// Creates the autofac container for auto dependency injection,
    /// knows about all the types, and creates instances.
    /// </summary>
    public class Bootstrapper
    {
        public IContainer Boostrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            // When an IFriendDataService is requested, it will make an instance
            // of the FriendDataService class.
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();

            return builder.Build();
        }
    }
}
