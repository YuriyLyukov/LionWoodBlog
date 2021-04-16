using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using API.Contracts.V1.Responses;
using API.CQRS.Queries;
using API.Services;
using AutoMapper;
using MediatR;

namespace API.CQRS.Handlers
{
    public class GetTopAuthorsHandler : IRequestHandler<GetTopAuthorsQuery,List<TopPostAuthorsResponse>>
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public GetTopAuthorsHandler(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        public async Task<List<TopPostAuthorsResponse>> Handle(GetTopAuthorsQuery request, CancellationToken cancellationToken)
        {
            var topAuthors = await _postService.GetTopAuthors();
            List<TopPostAuthorsResponse> result = _mapper.Map<List<TopPostAuthorsResponse>>(topAuthors);
            return result;
        }
    }
}