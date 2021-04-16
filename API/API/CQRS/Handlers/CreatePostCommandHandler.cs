using System.Threading;
using System.Threading.Tasks;
using API.Contracts.V1.Responses;
using API.CQRS.Commands;
using API.Domain.Entities;
using API.Services;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace API.CQRS.Handlers
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, PostResponse>
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }
        public async Task<PostResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postService.CreatePostAsync(request.Name, request.Description, request.AuthorName, request.Tags);
            return _mapper.Map<Post, PostResponse>(post);
        }
    }
}