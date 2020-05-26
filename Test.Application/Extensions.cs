using Convey;
using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using Microsoft.AspNetCore.Builder;

namespace Test.Application
{
    public static class Extensions
    {
        public static IConveyBuilder AddApplication(this IConveyBuilder builder)
        {
            builder
                .AddCommandHandlers()
                .AddInMemoryCommandDispatcher()
                .AddQueryHandlers()
                .AddInMemoryQueryDispatcher();

            return builder;

        }
    }
}