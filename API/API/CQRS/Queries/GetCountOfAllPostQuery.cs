using MediatR;

namespace API.CQRS.Queries
{
    public record GetCountOfAllPostQuery : IRequest<int>;
}