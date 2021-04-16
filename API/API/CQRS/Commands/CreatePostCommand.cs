using API.Contracts.V1.Responses;
using MediatR;

namespace API.CQRS.Commands
{
    public record CreatePostCommand(string Name, string Description, string AuthorName, string Tags) : IRequest<PostResponse>;
}