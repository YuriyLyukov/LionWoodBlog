using System.Collections.Generic;
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
    public class GetPostListHandler : IRequestHandler<GetPostListQuery, List<PostResponse>>
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;
        
        public GetPostListHandler(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }
        public async Task<List<PostResponse>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postService.GetAllPostsAsync();
            return _mapper.Map<List<Post>, List<PostResponse>>(posts);
        }
    }
}