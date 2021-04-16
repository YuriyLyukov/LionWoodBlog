using System.Collections.Generic;
using System.Threading.Tasks;
using API.Contracts.V1.Responses;
using API.Domain.Entities;

namespace API.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetAllPostsAsync();
        Task<Post> GetPostByIdAsync(int postId);
        Task<Post> CreatePostAsync(string name, string description, string authorName, string tags);
        Task<bool> UpdatePostAsync(Post postToUpdate);
        Task<int> GetCountOfAllPost();
        Task<int> GetCountOfAllAuthors();
        Task<int> GetAvgDescOfPost();
        Task<Dictionary<string, int>> GetTopAuthors();
    }
}