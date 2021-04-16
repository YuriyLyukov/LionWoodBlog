using System.Threading;
using System.Threading.Tasks;
using API.Contracts.V1.Responses;
using API.CQRS.Queries;
using API.Domain.Entities;
using API.Services;
using AutoMapper;
using MediatR;

namespace API.CQRS.Handlers
{
    public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery, PostResponse>
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public GetPostByIdHandler(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }
        
        public async Task<PostResponse> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var post = await _postService.GetPostByIdAsync(request.Id);
            if (post == null)
            {
                return null;
            }
            return _mapper.Map<Post, PostResponse>(post);
        }
    }
}