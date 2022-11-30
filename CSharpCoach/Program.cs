using System;
using System.Threading.Tasks;

namespace CSharpCoach
{
    public class DiscussionResponse
    {
        public int Id { get; set; }

        public int AccessRight { get; set; }

        public Discussion Discussion { get; set; }
    }

    public class Discussion
    {
        public string Title { get; set; }
    }
    
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var api = new ApiClient.ApiClient("https://api.ifokus.se");

            var discussion = await api.GetJson<DiscussionResponse>("/api/v1/discussion/1553786");

            if (discussion != null)
            {
                Console.WriteLine(discussion.Discussion.Title);
            }

        }
    }
}