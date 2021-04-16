using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Contracts.V1.Responses;
using API.CQRS.Commands;
using API.Data;
using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class PostService : IPostService
    {
        private readonly DataContext _dataContext;

        public PostService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Post>> GetAllPostsAsync()
        {
            return await _dataContext.Posts.ToListAsync();
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await _dataContext.Posts.SingleOrDefaultAsync(x => x.Id == postId);
        }

        public async Task<Post> CreatePostAsync(string name, string description, string authorName, string tags)
        {
            var post = new Post()
            {
                Id = new int(),
                Name = name,
                Description = description,
                Date = DateTime.UtcNow,
                AuthorName = authorName,
                Tags = tags,
            };
            await _dataContext.Posts.AddAsync(post);
            await _dataContext.SaveChangesAsync();
            return post;
        }

        public async Task<bool> UpdatePostAsync(Post postToUpdate)
        {
            _dataContext.Posts.Update(postToUpdate);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<int> GetCountOfAllPost()
        {
            var count = await _dataContext.Posts.CountAsync();
            return count;
        }
        public async Task<int> GetCountOfAllAuthors()
        {
            var count = await _dataContext.Posts.Select(p => p.AuthorName).Distinct().CountAsync();
            return count;
        }

        public async Task<int> GetAvgDescOfPost()
        {
            var count = await _dataContext.Posts.Where(p => p.Description != null).AverageAsync(c => c.Description.Length);
            var result = (int) count;
            return result;
        }

        public async Task<Dictionary<string, int>> GetTopAuthors()
        {
            /*var list = (await _dataContext.Posts
                    .Select(p => new {p.AuthorName})
                    .ToListAsync())
                .GroupBy(i => i.AuthorName)
                .ToDictionary(g => g.Key, g => g.Count());*/
            var query = await _dataContext.Posts
                .GroupBy(p => p.AuthorName)
                .Select(g => new {authorName = g.Key, count = g.Count()})
                .OrderByDescending(k => k.count)
                .ToDictionaryAsync(k => k.authorName, v => v.count);
            return query;
        }
    }
}