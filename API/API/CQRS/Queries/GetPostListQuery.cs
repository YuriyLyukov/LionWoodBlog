using System.Collections.Generic;
using API.Contracts.V1.Responses;
using API.Domain.Entities;
using MediatR;

namespace API.CQRS.Queries
{
    public record GetPostListQuery() : IRequest<List<PostResponse>>;
}