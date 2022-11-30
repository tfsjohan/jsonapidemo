using System;

namespace CSharpCoach.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Markdown { get; set; }

        public int UserId { get; set; }

        public string[] Images { get; set; }
        
    }
}