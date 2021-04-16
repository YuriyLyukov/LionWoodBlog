using MediatR;

namespace API.CQRS.Queries
{
    public record GetCountOfAllAuthorsQuery : IRequest<int>;
}