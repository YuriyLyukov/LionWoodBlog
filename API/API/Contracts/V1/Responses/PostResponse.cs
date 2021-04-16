using System;

namespace API.Contracts.V1.Responses
{
    public class PostResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string AuthorName { get; set; }
        public string Tags { get; set; }
    }
}