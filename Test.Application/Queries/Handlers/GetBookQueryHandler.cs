using System.Threading.Tasks;
using Convey.CQRS.Queries;
using Test.Application.Queries.DTO;

namespace Test.Application.Queries.Handlers
{
    public class GetBookQueryHandler:IQueryHandler<GetBookQuery,BookDto>
    {
        public async Task<BookDto> HandleAsync(GetBookQuery query)
        {
            return new BookDto("Master of art", "Arthas");
        }
    }
}