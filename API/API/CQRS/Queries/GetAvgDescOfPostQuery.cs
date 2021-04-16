using MediatR;

namespace API.CQRS.Queries
{
    public record GetAvgDescOfPostQuery : IRequest<int>;
}