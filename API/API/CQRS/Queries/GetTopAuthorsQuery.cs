using System.Collections.Generic;
using API.Contracts.V1.Responses;
using MediatR;

namespace API.CQRS.Queries
{
    public record GetTopAuthorsQuery : IRequest<List<TopPostAuthorsResponse>>;
}