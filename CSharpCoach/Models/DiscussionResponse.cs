using System.Collections.Generic;

namespace CSharpCoach.Models
{
    public class DiscussionResponse
    {
        public int Id { get; set; }

        public int AccessRight { get; set; }

        public Discussion Discussion { get; set; }

        public IList<Post> Posts { get; set; }
    }
}