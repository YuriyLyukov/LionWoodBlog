using System.Threading;
using System.Threading.Tasks;
using API.CQRS.Queries;
using API.Services;
using MediatR;

namespace API.CQRS.Handlers
{
    public class GetAvgDescOfPostHandler : IRequestHandler<GetAvgDescOfPostQuery, int>
    {
        private readonly IPostService _postService;

        public GetAvgDescOfPostHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<int> Handle(GetAvgDescOfPostQuery request, CancellationToken cancellationToken)
        {
            var count = await _postService.GetAvgDescOfPost();
            return count;
        }
    }
}