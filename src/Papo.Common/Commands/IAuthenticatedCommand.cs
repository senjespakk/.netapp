using System;

namespace Papo.Common.Commands
{
    public interface IAuthenticated : ICommand
    {
        Guid UserId {get; set;}
    }
}