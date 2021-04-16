namespace API.Controllers.V1
{
    public class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;
        
        public static class Posts
        {
            public const string GetAll = Base + "/posts";
            public const string Update = Base + "/post";
            public const string Get = Base + "/post/{postId}";
            public const string Create = Base + "/post";
            public const string CountPosts = Base + "/countpost";
            public const string CountAuthors = Base + "/countauthor";
            public const string CountAvgDesc = Base + "/countavgdesc";
            public const string GetTopAuthors = Base + "/topauthors";
        }
    }
}