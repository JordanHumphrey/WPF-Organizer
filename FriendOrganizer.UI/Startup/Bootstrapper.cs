using Autofac;
using FriendOrganizer.DataAccess;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.ViewModel;
using Prism.Events;

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

            // Event Aggregator for communication of events between ViewModels
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();
            // AsImplementedInterfaces() will implement all LookupDataService
            // interfaces we have created, rather than us registering every type
            // manually since we will have multiple Lookup types.
            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            // When an IFriendDataService is requested, it will make an instance
            // of the FriendDataService class.
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();

            return builder.Build();
        }
    }
}
