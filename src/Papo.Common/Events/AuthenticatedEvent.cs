namespace Papo.Common.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        Guid UserId {get;}
    }
}