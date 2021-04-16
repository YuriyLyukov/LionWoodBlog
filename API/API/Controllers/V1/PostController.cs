using System.Collections.Generic;
using System.Threading.Tasks;
using API.Contracts.V1.Responses;
using API.CQRS.Commands;
using API.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.V1
{
    public class PostController : Controller
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public async Task<IActionResult> GetAllPost()
        {
            var query = new GetPostListQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        
        [HttpGet(ApiRoutes.Posts.Get)]
        public async Task<IActionResult> GetPost([FromRoute] int postId)
        {
            var query = new GetPostByIdQuery(postId);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost(ApiRoutes.Posts.Create)]
        public async Task<IActionResult> Create([FromBody] CreatePostCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet(ApiRoutes.Posts.CountPosts)]
        public async Task<int> GetCountPosts()
        {
            var query = new GetCountOfAllPostQuery();
            var result = await _mediator.Send(query);
            return result;
        }
        [HttpGet(ApiRoutes.Posts.CountAuthors)]
        public async Task<int> GetCountAuthors()
        {
            var query = new GetCountOfAllAuthorsQuery();
            var result = await _mediator.Send(query);
            return result;
        }
        [HttpGet(ApiRoutes.Posts.CountAvgDesc)]
        public async Task<int> GetCountAvgDesc()
        {
            var query = new GetAvgDescOfPostQuery();
            var result = await _mediator.Send(query);
            return result;
        }
        [HttpGet(ApiRoutes.Posts.GetTopAuthors)]
        public async Task<List<TopPostAuthorsResponse>> GetTopAuthors()
        {
            var query = new GetTopAuthorsQuery();
            var result = await _mediator.Send(query);
            return result;
        }
    }
}