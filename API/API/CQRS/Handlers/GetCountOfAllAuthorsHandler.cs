using System.Threading;
using System.Threading.Tasks;
using API.CQRS.Queries;
using API.Services;
using MediatR;

namespace API.CQRS.Handlers
{
    public class GetCountOfAllAuthorsHandler : IRequestHandler<GetCountOfAllAuthorsQuery, int>
    {
        private readonly IPostService _postService;

        public GetCountOfAllAuthorsHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<int> Handle(GetCountOfAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            var count = await _postService.GetCountOfAllAuthors();
            return count;
        }
    }
}