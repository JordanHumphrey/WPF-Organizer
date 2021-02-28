using Prism.Events;

namespace FriendOrganizer.UI.Event
{
    /// <summary>
    /// Parameter is of type int for PubSubEvent, which is 
    /// the Friend.Id
    /// 
    /// </summary>
    public class OpenFriendDetailViewEvent :PubSubEvent<int>
    {
    }
}
