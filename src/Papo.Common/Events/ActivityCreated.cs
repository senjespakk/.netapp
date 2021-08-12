namespace Papo.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid Id {get;}
        public Guid UserId {get;}
        public string Category {get;}
        public string Name {get;}
        public string Description {get;}
        public DateTime CreatedAt {get;}

        protected ActivityCreated()
        {

        }

        public CreateActivity(Guid id, Guid userid,
        string category, )
        {
            Id = id;
            UserId = userid;
            ...
        }
    }
}