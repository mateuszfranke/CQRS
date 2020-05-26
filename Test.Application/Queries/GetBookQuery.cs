using Convey.CQRS.Queries;
using Test.Application.Queries.DTO;

namespace Test.Application.Queries
{
    public class GetBookQuery:IQuery<BookDto>
    {
        private readonly string _name;

        public GetBookQuery(string name)
        {
            _name = name;
        }
    }
}