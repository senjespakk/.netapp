using System.Threading.Tasks;

namespace Papo.Common.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T Command);
        
    }
}