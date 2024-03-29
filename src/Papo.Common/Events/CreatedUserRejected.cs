namespace Papo.Common.Events
{
    public class CreatedUserRejected : IRejectedEvent
    {
        public string Email {get;}
        public string Reason {get;}
        public string Code {get;}

        protected CreatedUserRejected()
        {

        }

        public CreatedUserRejected(string email, string reason, string code)
        {
            Email = email;
            Code = code;
            Reason = reason;
        }
    }
}