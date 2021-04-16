using API.Contracts.V1.Responses;
using MediatR;

namespace API.CQRS.Queries
{
    public record GetPostByIdQuery(int Id) : IRequest<PostResponse>;
}