using Convey.CQRS.Commands;

namespace Test.Application.Commands
{
    public class AddBookCommand :ICommand
    {
        private readonly string _name;
        private readonly string _author;

        public AddBookCommand(string name, string author)
        {
            _name = name;
            _author = author;
        }
    }
}