using System.Threading;
using System.Threading.Tasks;
using API.CQRS.Queries;
using API.Services;
using MediatR;

namespace API.CQRS.Handlers
{
    public class GetCountOfAllPostHandler : IRequestHandler<GetCountOfAllPostQuery, int>
    {
        private readonly IPostService _postService;

        public GetCountOfAllPostHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<int> Handle(GetCountOfAllPostQuery request, CancellationToken cancellationToken)
        {
            var count = await _postService.GetCountOfAllPost();
            return count;
        }
    }
}