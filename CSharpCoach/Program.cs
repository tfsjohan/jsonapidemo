using System;
using System.Threading.Tasks;
using CSharpCoach.Models;

namespace CSharpCoach
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var api = SharedApi.Build("https://api.ifokus.se");

            var discussion = await api.GetJson<DiscussionResponse>("/api/v1/discussion/1553786");

            if (discussion != null)
            {
                Console.WriteLine(discussion.Discussion.Title.ToUpper());
                Console.WriteLine();

                foreach (var post in discussion.Posts)
                {
                    Console.WriteLine(post.Markdown);
                    Console.WriteLine("---------------------------------------------------------");
                }
            }
        }
    }
}