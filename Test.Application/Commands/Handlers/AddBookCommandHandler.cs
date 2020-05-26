using System.Threading.Tasks;
using Convey.CQRS.Commands;

namespace Test.Application.Commands.Handlers
{
    public class AddBookCommandHandler :ICommandHandler<AddBookCommand>
    {
        public Task HandleAsync(AddBookCommand command)
        {
            return Task.CompletedTask;
        }
    }
}